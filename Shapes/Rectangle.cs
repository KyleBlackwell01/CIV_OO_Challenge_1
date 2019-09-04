using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string pColour, int Length, int Width) : base(Length, Width, Length, Width, pColour)
        {

        }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
