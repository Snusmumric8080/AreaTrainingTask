using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Figures;
using ClassLibrary1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaTriangle()
        {
            var expected = 6;
            Triangle triangle = new Triangle(5, 4, 3);


            var actual = triangle.AreaCalc();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsRight()
        {
            var expected = true;
            Triangle triangle = new Triangle(5, 3, 4);


            var actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCircle()
        {
            var expected = 78.53981633974483;
            Circle circle = new Circle(5);


            var actual = circle.AreaCalc();

            Assert.AreEqual(expected, actual);
        }



    }
}
