using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string pColour, float s1, float s2) : base(pColour, s1, s2, 0)
        {
            Side3Length = (float)Math.Sqrt(s1 * s1 + s2 * s2);
        }

        public float GetArea()
        {
            return 0.5f * (Side1Length * Side2Length);
        }
    }
}
