using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Infrastructures
{
    public static class CloudinaryImageUpload
    {
        public static string ApiKey { get; set; }
        public static string ApiSecret { get; set; }
        public static string Cloud { get; set; }
        public static Account Account { get; set; }
        public static string Path { get; set; }
    }
}
