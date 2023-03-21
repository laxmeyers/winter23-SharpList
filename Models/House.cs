using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpList.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Floors { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int Year { get; set; } = 2025;
        public double Price { get; set; } = 1.00;
        public String Description { get; set; }
        public String ImgUrl { get; set; }
    }

}