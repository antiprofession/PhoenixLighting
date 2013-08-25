using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixLighting.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int LightEffciency { get; set; }
        public int Color { get; set; }
        public string Function { get; set; }
        public float Length { get; set; }
        public float Diameter { get; set; }
        public bool CE { get; set; }
        public bool ROHS { get; set; }

        public string Advantages { get; set; }
        public string Specifications { get; set; }
    }
}
