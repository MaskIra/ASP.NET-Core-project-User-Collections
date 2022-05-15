using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class DataType
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public DataType(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
}
