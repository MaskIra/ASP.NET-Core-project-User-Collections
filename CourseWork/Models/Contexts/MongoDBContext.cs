using CourseWork.Infrastructures;
using CourseWork.Interface;
using CourseWork.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Models.Contexts
{
    public class MongoDBContext : IMongoDBContext
    {
        public readonly IMongoDatabase db;
        private readonly IMongoCollection<Item> _context;

        public MongoDBContext(IMongoClient client)
        {
            db = client.GetDatabase(MongoDBData.DataBaseName);
            _context = db.GetCollection<Item>(nameof(Item));
        }

        public async Task<ObjectId> Create(Item item)
        {
            await _context.InsertOneAsync(item);
            return item.Id;
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _context.Find(_ => true).ToListAsync();
        }
        public async Task<IEnumerable<Item>> GetCollectionItems(int CollectionId)
        {
            return await _context.Find(i => i.CollectionId == CollectionId).ToListAsync();
        }

        public Task<Item> Get(ObjectId objectId)
        {
            return _context.Find(Builders<Item>.Filter.Eq(i => i.Id, objectId)).FirstOrDefaultAsync();
        }
        
        public async Task<bool> Update(ObjectId objectId, Item item)
        {
            var filter = Builders<Item>.Filter.Eq(c => c.Id, objectId);
            var update = Builders<Item>.Update
                .Set(c => c.CollectionId, item.CollectionId)
                .Set(c => c.Name, item.Name);

            var result = await _context.UpdateOneAsync(filter, update);

            if (item.Fileds != null)
                foreach (var field in item.Fileds)
                {
                    update = Builders<Item>.Update.Set(field.Key, item.Fileds[field.Key]);
                    result = await _context.UpdateOneAsync(filter, update);
                }

            return result.ModifiedCount == 1;
        }

        public async Task<bool> Delete(ObjectId objectId)
        {
            var filter = Builders<Item>.Filter.Eq(c => c.Id, objectId);
            var result = await _context.DeleteOneAsync(filter);

            return result.DeletedCount == 1;
        }
    }
}
