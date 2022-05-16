using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class Collection
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Error collection name")]
        public string Name { get; set; }

        [Display(Name = "Collection description")]
        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        [Display(Name = "Collection ImageURL")]
        public string ImageURL { get; set; }

        public string ImagePublicId { get; set; }
    }
}
