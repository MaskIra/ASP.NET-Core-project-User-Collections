using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseWork.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [Required]
        [BsonElement("CollectionId")]
        public int CollectionId { get; set; }

        [Required]
        [BsonElement("Name")]
        [Display(Name = "Item name")]
        public string Name { get; set; }

        [BsonExtraElements]
        public Dictionary<string, object> Fileds { get; set; }
    }
}
