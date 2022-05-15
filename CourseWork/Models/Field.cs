using System;
using System.Collections.Generic;

namespace CourseWork.Models
{
    public class Field
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
