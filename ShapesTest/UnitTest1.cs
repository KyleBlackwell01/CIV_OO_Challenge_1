using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTest
{
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
        RightAngleTriangle ra1 { get; set; }
        EquilateralTriangle eq1 { get; set; }

        //Square sq2 { get; set; }
        //Rectangle rec2 { get; set; }
        //RightAngleTriangle ra2 { get; set; }
        //EquilateralTriangle eq2 { get; set; }


        [SetUp]
        public void Init()
        {

            
            //sq1 = new Square("Blue", 4);
            //rec1 = new Rectangle("Red", 4, 3);
            //ra1 = new RightAngleTriangle("White", 3, 4);
            //eq1 = new EquilateralTriangle("black", 6);

            //sq2 = new Square("Blue", 6);
            //rec2 = new Rectangle("Red", 5, 4);
            //ra2 = new RightAngleTriangle("White", 7, 4);
            //eq2 = new EquilateralTriangle("black", 8);
        }

        [Test]
        [TestCase ("Blue",5,25,20)]
        [TestCase("Blue", 15, 225, 60)]
        [TestCase("Blue", 7, 49, 28)]
        public void SquareTests(string color, int s1, int expArea, int expPer)
        {
            sq1 = new Square(color, s1);


            Assert.AreEqual(expArea, sq1.GetArea());
            Assert.AreEqual(expPer, sq1.GetPerimeter());

        }

        [Test]
        [TestCase ("Blue",5,10,50,30)]
        [TestCase("Blue", 4, 6, 24, 20)]
        [TestCase("Blue", 9, 7, 63, 32)]
        public void RectangleTests(string color, int s1, int s2, int expArea, int expPer)
        {

            rec1 = new Rectangle(color, s1, s2);
            //int area = 12;
            //int perimeter = 14;

            Assert.AreEqual(expArea, rec1.GetArea());
            Assert.AreEqual(expPer, rec1.GetPerimeter());

            //area = 20;
            //perimeter = 18;

            //Assert.AreEqual(area, rec2.GetArea());
            //Assert.AreEqual(perimeter, rec2.GetPerimeter());

        }

        [Test]
        [TestCase ("Blue",3,4,6,12)]
        public void RightAngleTriangleTests(string color, float s1, float s2, float expArea, float expPer)
        {
            ra1 = new RightAngleTriangle(color, s1, s2);

            //float area = 6;
            //float perimeter = 12;

            Assert.AreEqual(Math.Round(expArea, 2), Math.Round(ra1.GetArea(), 2));
            Assert.AreEqual(Math.Round(expPer, 2), Math.Round(ra1.GetPerimeter(), 2));
            //area = 14;
            //perimeter = 19.06f;

            //Assert.AreEqual(Math.Round(area, 2), Math.Round(ra2.GetArea(), 2));
            //Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(ra2.GetPerimeter(), 2));

        }

        [Test]
        [TestCase ("Blue",6,15.59f,18)]
        public void EquilateralTriangleTests(string color, float s1, float expArea, float expPer)
        {
            eq1 = new EquilateralTriangle(color, s1);
            //float area = 15.59f;
            //float perimeter = 18;

            Assert.AreEqual(Math.Round(expArea, 2), Math.Round(eq1.GetArea(), 2));
            Assert.AreEqual(Math.Round(expPer, 2), Math.Round(eq1.GetPerimeter(), 2));

            //area = 27.71f;
            //perimeter = 24;

            //Assert.AreEqual(Math.Round(area, 2), Math.Round(eq2.GetArea(), 2));
            //Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(eq2.GetPerimeter(), 2));
        }
    }
}
