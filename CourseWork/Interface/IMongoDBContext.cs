using CourseWork.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Interface
{
    public interface IMongoDBContext
    {
        Task<IEnumerable<Item>> GetAllItems();

        Task<IEnumerable<Item>> GetCollectionItems(int CollectionId);

        Task<Item> Get(ObjectId objectId);

        Task<ObjectId> Create(Item item);

        Task<bool> Update(ObjectId id, Item item);
        //Task<bool> Update(string id, Item item);

        Task<bool> Delete(string name);
    }
}
