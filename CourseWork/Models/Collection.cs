using System.ComponentModel.DataAnnotations;
using CourseWork.Resources;

namespace CourseWork.Models
{
    public class Collection
    {
        public int Id { get; set; }

        //[Display(Name = ResourceKeys.CollectionName, ResourceType = typeof(Resources.DisplayForAttribute))]
        //[Required(ErrorMessageResourceName = "Error collection name", ErrorMessageResourceType = typeof(LangResource))]

        [Required(ErrorMessage = "Collection name is requade")]
        public string Name { get; set; }

        [Display(Name = "Collection description")]
        public string Description { get; set; }

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
