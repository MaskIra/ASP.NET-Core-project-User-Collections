using CourseWork.Interface;
using CourseWork.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class MongoDBContext : IMongoDBContext
    {
        public readonly IMongoDatabase db;
        private readonly IMongoCollection<Item> items;

        public MongoDBContext(IMongoClient client)
        {
            db = client.GetDatabase("maskcourse"); // TODO
            items = db.GetCollection<Item>(nameof(Item));
        }

        public async Task<ObjectId> Create(Item item)
        {
            await items.InsertOneAsync(item);
            return item.Id;
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
           return await items.Find(_ => true).ToListAsync();
        }
        public async Task<IEnumerable<Item>> GetCollectionItems(int CollectionId)
        {
            return await items.Find(i => i.CollectionId == CollectionId).ToListAsync();
        }

        public Task<Item> Get(ObjectId objectId)
        {
            var filter = Builders<Item>.Filter.Eq(i => i.Id, objectId);
            return items.Find(filter).FirstOrDefaultAsync();
        }

        // string Id
        public Task<bool> Update(ObjectId Id, Item item)
        {
            //var filter = Builders<Car>.Filter.Eq(c => c.Id, objectId);
            //var update = Builders<Car>.Update
            //    .Set(c => c.Make, car.Make)
            //    .Set(c => c.Model, car.Model)
            //    .Set(c => c.TopSpeed, car.TopSpeed);
            //var result = await _cars.UpdateOneAsync(filter, update);

            //return result.ModifiedCount == 1;
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string Name)
        {
            //var filter = Builders<Car>.Filter.Eq(c => c.Id, objectId);
            //var result = await _cars.DeleteOneAsync(filter);

            //return result.DeletedCount == 1;
            throw new NotImplementedException();
        }
    }
}
