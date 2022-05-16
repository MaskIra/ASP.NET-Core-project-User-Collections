using CourseWork.Interface;
using CourseWork.Models;
using CourseWork.Models.Contexts;
using CourseWork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Controllers
{
    [ApiController]
    [Route("{controller}/{action}/")]
    public class ItemsController : Controller
    {
        private readonly IMongoDBContext itemrepos;
        private readonly ApplicationContext _context;

        public ItemsController(IMongoDBContext itemrepos, ApplicationContext context)
        {
            this.itemrepos = itemrepos;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await itemrepos.GetAllItems();

            return new JsonResult(items);
        }

        [HttpGet("{id}")] // collection id
        public async Task<IActionResult> Index(int id)
        {
            IEnumerable<Item> items = await itemrepos.GetCollectionItems(id);
            ViewData["FieldsCollection"] = _context.Fields.Where(f => f.CollectionId == id);
            ViewData["Id"] = id;

            return View(items);
        }

        [HttpGet("{id}")] // collection id
        public async Task<IActionResult> Create(int id)
        {
            var item = new ItemViewModel()
            {
                CollectionId = id,
                Fields = ToFieldsType(_context.Fields.Where(f => f.CollectionId == id).ToList())
            };
            return View(item);
        }
        private List<ViewField> ToFieldsType(List<Field> values)
        {
            List<ViewField> newViewFields = new List<ViewField>();
            foreach (var value in values)
            {
                newViewFields.Add(new ViewField(value.Name, value.Type, null));
            }

            return newViewFields;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ItemViewModel item)
        {
            var id = await itemrepos.Create(ToItem(item));

            return RedirectToAction("Index", new { id = item.CollectionId });
        }

        private Item ToItem(ItemViewModel item)
        {
            Item newItem = new Item()
            {
                Name = item.Name,
                CollectionId = item.CollectionId,
                Fileds = ToFieldsType(item.Fields)
            };
            if (item.Id != null)
                newItem.Id = ObjectId.Parse(item.Id);
            return newItem;
        }

        private Dictionary<string, object> ToFieldsType(List<ViewField> values)
        {
            Dictionary<string, object> newValues = new Dictionary<string, object>();
            if (values != null)
            {
                foreach (var value in values)
                {
                    object res = null;
                    if (value.Type == "date")
                    {
                        res = DateTime.Parse(value.Value);
                    }
                    if (value.Type == "checkbox")
                    {
                        res = bool.Parse(value.Value);
                    }
                    if (value.Type == "number")
                    {
                        res = int.Parse(value.Value);
                    }
                    if (value.Type == "text")
                    {
                        res = value.Value;
                    }
                    newValues.Add(value.Name, res);
                }
            }

            return newValues;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var item = await itemrepos.Get(ObjectId.Parse(id));
            var viewitem = new ItemViewModel()
            {
                Id = item.Id.ToString(),
                CollectionId = item.CollectionId,
                Name = item.Name,
                Fields = ToFieldsType(_context.Fields.Where(f => f.CollectionId == item.CollectionId).ToList(), item.Fileds)
            };

            return View(viewitem);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] ItemViewModel viewitem)
        {
            Item item = ToItem(viewitem);
            var result = await itemrepos.Update(item.Id, item);

            return RedirectToAction("Index", new { id = item.CollectionId });
        }

        private List<ViewField> ToFieldsType(List<Field> fields, Dictionary<string, object> values)
        {
            List<ViewField> newViewFields = new List<ViewField>();
            foreach (var field in fields)
            {
                var value = values[field.Name];
                if (field.Type == "date")
                {
                    value = Convert.ToDateTime(value).Date.ToString("yyyy-MM-dd");
                }
                newViewFields.Add(new ViewField(field.Name, field.Type, value.ToString()));
            }

            return newViewFields;
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] string id)
        {
            int collectionId = (await itemrepos.Get(ObjectId.Parse(id))).CollectionId;
            var result = await itemrepos.Delete(ObjectId.Parse(id));

            return RedirectToAction("Index", new { id = collectionId });
        }
    }
}
