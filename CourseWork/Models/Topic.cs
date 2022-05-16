using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class Topic
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "TopicName")]
        public string Name { get; set; }
    }
}
