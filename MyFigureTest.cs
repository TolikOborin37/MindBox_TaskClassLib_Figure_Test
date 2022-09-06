using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox_Task_ClassLib_Figure;
using SemanticComparison;

namespace MindBox_TaskClassLib_Figure_Test
{
    [TestClass]
    public class MyFigureTest
    {
        //тест на правильность ввода
        [TestMethod]
        public void Test_Circle()
        {
            //arrange
            double radius_test = 5;
            string name_test = "Круг";
            Circle circle_test = new Circle(name_test, radius_test);

            //act
            Circle circle = new Circle("Круг", 5);
            var expexted = new Likeness<Circle, Circle>(circle_test);

            //assert
            Assert.AreEqual(expexted, circle);
        }
        [TestMethod]
        public void Test_Circle_radius_8()
        {
            //arrange
            string expexted = "201,062";

            //act
            Circle circle = new Circle("Круг", 8);
            string circle_test = $"{circle.square():0.000}";

            //assert
            Assert.AreEqual(expexted, circle_test);
        }

        [TestMethod]
        public void Test_Triangle_a5_b6_c8()
        {
            //arrange
            string expected = "14,981";
            //act
            Triangle triangle = new Triangle("Треугольник", 5, 6, 8);
            string triangle_test = $"{triangle.square():0.000}";
            //assert
            Assert.AreEqual(expected, triangle_test);
        }
    }
}
