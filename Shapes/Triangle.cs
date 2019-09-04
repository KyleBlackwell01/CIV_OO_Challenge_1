using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shapes
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }

        public Triangle(string pColour, float s1, float s2, float s3) : base(pColour)
        {
            this.Side1Length = s1;
            this.Side2Length = s2;
            this.Side3Length = s3;
        }

        public float GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}
