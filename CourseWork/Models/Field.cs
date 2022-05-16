using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class Field
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field name error")]
        [Display(Name = "Field name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field type error")]
        [Display(Name = "Field type")]
        public string Type { get; set; }

        [Required]
        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
