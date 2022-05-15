using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CourseWork.Models;
using CourseWork.ViewModels;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Http;
using CourseWork.Infrastructures;

namespace CourseWork.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly ApplicationContext _context;
        public static List<DataType> types = new List<DataType>()
            {
                new DataType("text","text"),
                new DataType("number", "number"),
                new DataType("checkbox","checkbox"),
                new DataType("date","date")
            };

        public CollectionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Collections
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Collections.Include(c => c.Topic).Include(c => c.User);
            return View(await applicationContext.ToListAsync());
        }

        // GET: Collections/Create
        public IActionResult Create()
        {
            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["DataTypes"] = new SelectList(types, "Value", "Name");
            return View();
        }

        // POST: Collections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,UserId,TopicId,Fields,Image")] CollectionFieldsModel collection)
        {
            if (ModelState.IsValid)
            {
                var newCollection = ExtractCollection(collection);
                _context.Add(newCollection);
                await _context.SaveChangesAsync();
                collection.Id = newCollection.Id;

                var fields = ExtractFields(collection);
                foreach (var field in fields)
                {
                    _context.Add(field);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public Collection ExtractCollection(CollectionFieldsModel CollectionField)
        {
            string PublicId;
            return new Collection()
            {
                Name = CollectionField.Name,
                Description = CollectionField.Description,
                UserId = CollectionField.UserId,
                User = _context.Users.Find(CollectionField.UserId),
                TopicId = CollectionField.TopicId,
                Topic = _context.Topics.Find(CollectionField.TopicId),
                ImageURL = UploadImage(CollectionField.Image, out PublicId),
                ImagePublicId = PublicId
            };
        }
        public void UpdateCollection(CollectionFieldsModel CollectionField, ref Collection collection)
        {
            collection.Name = CollectionField.Name;
            collection.Description = CollectionField.Description;
            collection.UserId = CollectionField.UserId;
            collection.User = _context.Users.Find(CollectionField.UserId);
            collection.TopicId = CollectionField.TopicId;
            collection.Topic = _context.Topics.Find(CollectionField.TopicId);
        }
        public List<Field> ExtractFields(CollectionFieldsModel CollectionField)
        {
            List<Field> fields = new List<Field>();
            if (CollectionField.Fields != null)
            {
                foreach (Field field in CollectionField.Fields)
                {
                    fields.Add(new Field()
                    {
                        Name = field.Name,
                        Type = field.Type,
                        CollectionId = CollectionField.Id,
                        Collection = _context.Collections.Find(CollectionField.Id)
                    });
                }
            }
            return fields;
        }
        public string UploadImage(IFormFile image, out string PublicID)
        {
            if (image == null)
            {
                PublicID = null;
                return null;
            }
            try
            {
                var cloudinary = new Cloudinary(CloudinaryImageUpload.Account);
                cloudinary.Api.Secure = true;

                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    image.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }
                string base64 = Convert.ToBase64String(bytes);


                var prefix = @"data:image/png;base64,";
                var imagePath = prefix + base64;

                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imagePath),
                    Folder = CloudinaryImageUpload.Path
                };

                var uploadResult = cloudinary.Upload(@uploadParams);
                PublicID = uploadResult.PublicId;
                return uploadResult.SecureUrl.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteImage(string PublicID)
        {
            if (PublicID == null)
                return;

            try
            {
                var cloudinary = new Cloudinary(CloudinaryImageUpload.Account);
                cloudinary.Destroy(new DeletionParams(PublicID));
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Collections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var collection = await _context.Collections.FindAsync(id);
            if (collection == null)
                return NotFound();
            var fields = _context.Fields.Where(f => f.CollectionId == id).ToList();

            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["DataTypes"] = new SelectList(types, "Value", "Name");
            ViewData["PreviousImage"] = collection.ImageURL;
            return View(ToCollectionFieldsModel(collection, fields));
        }

        private CollectionFieldsModel ToCollectionFieldsModel(Collection collection, List<Field> fields)
        {
            return new CollectionFieldsModel()
            {
                Id = collection.Id,
                Name = collection.Name,
                Description = collection.Description,
                Image = null,
                TopicId = collection.TopicId,
                UserId = collection.UserId,
                Fields = fields
            };
        }

        // POST: Collections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,UserId,TopicId,Fields,Image")] CollectionFieldsModel collection)
        {
            if (id != collection.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    var newCollection = await _context.Collections.FindAsync(id);
                    UpdateCollection(collection, ref newCollection);

                    if (collection.Image == null && string.IsNullOrWhiteSpace(HttpContext.Request.Form["deleteimage"]))
                    {
                        DeleteImage(newCollection.ImagePublicId);
                    }
                    if (collection.Image != null)
                    {
                        string PublicId;
                        newCollection.ImageURL = UploadImage(collection.Image, out PublicId);
                        newCollection.ImagePublicId = PublicId;
                    }

                    _context.Update(newCollection);
                    await _context.SaveChangesAsync();
                    collection.Id = newCollection.Id;

                    var fields1 = _context.Fields.Where(f => f.CollectionId == collection.Id);
                    foreach (var field in fields1)
                    {
                        _context.Fields.Remove(field);
                        await _context.SaveChangesAsync();
                    }

                    var fields = ExtractFields(collection);
                    foreach (var field in fields)
                    {
                        _context.Add(field);
                        await _context.SaveChangesAsync();
                    }

                    //_context.Update(collection);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CollectionExists(collection.Id))
                        return NotFound();
                    else
                        throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        //// GET: Collections/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var collection = await _context.Collections
        //        .Include(c => c.Topic)
        //        .Include(c => c.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (collection == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(collection);
        //}

        //// POST: Collections/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var collection = await _context.Collections.FindAsync(id);
            _context.Collections.Remove(collection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectionExists(int id)
        {
            return _context.Collections.Any(e => e.Id == id);
        }
    }
}
