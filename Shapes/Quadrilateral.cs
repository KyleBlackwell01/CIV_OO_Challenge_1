using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Quadrilateral : Shapes
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(int s1, int s2, int s3, int s4, string pColour) : base(pColour)
        {
            this.Side1Length = s1;
            this.Side2Length = s2;
            this.Side3Length = s3;
            this.Side4Length = s4;
        }

        public int GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }
}
