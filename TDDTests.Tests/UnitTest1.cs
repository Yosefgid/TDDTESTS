

using TDDTests.Core;

namespace TDDTests.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            //Arrange
            Compass compass = new Compass(Point.North);

            //Act
            Point result = compass.Rotate(Point.North, Direction.Right);
            //Assert
            Assert.That(result, Is.EqualTo(Point.East));
        }
    }
}