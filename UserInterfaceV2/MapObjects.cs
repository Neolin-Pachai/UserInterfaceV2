using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
   public class MapObjects
    {
        private string name;
        private Point coordinates;
        private double length;
        private double height;
        private string type;
        private Image images;

        public Point Coordinates { get => coordinates; set => coordinates = value; }
        public double Length { get => length; set => length = value; }
        public double Height { get => height; set => height = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public Image Images { get => images; set => images = value; }

        public MapObjects(string name, Point coordinates, double length, double height,string type,Image images)
        {
            this.name = name;
            this.coordinates = coordinates;
            this.length = length;
            this.height = height;
            this.type = type;
            this.images = images; 
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}",name, coordinates, length, height,type);
        }
    }
}
