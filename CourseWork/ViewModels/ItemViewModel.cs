using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    public class ItemViewModel
    {
        public string Id { get; set; }

        public int CollectionId { get; set; }

        [Display(Name = "Item name")]
        public string Name { get; set; }

        public List<ViewField> Fields { get; set; }
    }

    public class ViewField
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public ViewField() { }

        public ViewField(string Name, string Type, string Value)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
        }
    }
}
