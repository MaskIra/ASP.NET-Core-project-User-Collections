using System.Collections.Generic;

namespace CourseWork.Models
{
    public class Topic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Collection> Collections { get; set; }
    }
}
