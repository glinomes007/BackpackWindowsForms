using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWindowsForms
{
    [Serializable]
    public abstract class Backpack
    {
        public Backpack(string tag, Shape shape, Material material, string color)
        {
            Tag = tag;
            Shape = shape.Name;
            Material = material.Name;
            Color = color;
            Price = shape.Price + material.Price;
        }
        public string Tag { get; set; }
        public string Shape { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
