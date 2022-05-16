using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CourseWork.Models;
using Microsoft.AspNetCore.Http;

namespace CourseWork.ViewModels
{
    public class CollectionFieldsViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Error collection name")]
        [Display(Name = "Collection name")]
        public string Name { get; set; }

        [Display(Name = "Collection description")]
        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Topic name")]
        public int TopicId { get; set; }

        public List<Field> Fields { get; set; }

        public IFormFile Image { get; set; }
    }
}
