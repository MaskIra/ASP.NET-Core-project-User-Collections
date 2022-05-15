using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseWork.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("CollectionId")]
        public int CollectionId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonExtraElements]
        public Dictionary<string, object> Fileds { get; set; }
    }
}
