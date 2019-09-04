using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string pColour, float SideLength) : base(pColour, SideLength, SideLength, SideLength)
        {

        }

        public float GetArea()
        {
            return (float)Math.Sqrt(3) / 4 * Side1Length * Side2Length;
        }
    }
}
