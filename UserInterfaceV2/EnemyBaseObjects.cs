using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UserInterfaceV2
{
    public class EnemyBaseObjects
    {
        private int iD;
        private string name;
        private int points;
        private Image pictures;

        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }
        public Image Pictures { get => pictures; set => pictures = value; }
        public int ID { get => iD; set => iD = value; }

        public EnemyBaseObjects(int iD,string name, int points, Image pictures)
        {
            this.iD = iD;
            this.name = name;
            this.points = points;
            this.pictures = pictures;
        }

    }
}
