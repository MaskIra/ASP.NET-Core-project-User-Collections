using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CourseWork.Models;
using Microsoft.AspNetCore.Http;

namespace CourseWork.ViewModels
{
    public class CollectionFieldsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int TopicId { get; set; }

        public List<Field> Fields { get; set; }

        public IFormFile Image { get; set; }
    }
}
