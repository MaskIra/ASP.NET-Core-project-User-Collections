using System;
using System.Collections.Generic;

namespace CourseWork.Models
{
    public class Collection
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        public string ImageURL { get; set; }

        public string ImagePublicId { get; set; }

        //public ICollection<Field> Fields { get; set; }
    }
}
