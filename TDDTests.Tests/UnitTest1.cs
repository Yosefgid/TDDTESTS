
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

        [Test]
        public void Test2()
        {
            //Arrange
            Compass compass = new Compass(Point.North);


            //Act

            Assert.Multiple(() =>
            {
                Point resultN = compass.Rotate(Point.North, Direction.Right);
                Assert.That(resultN, Is.EqualTo(Point.East));

                Point resultE = compass.Rotate(Point.East, Direction.Right);
                Assert.That(resultE, Is.EqualTo(Point.South));

                Point resultS = compass.Rotate(Point.South, Direction.Right);
                Assert.That(resultS, Is.EqualTo(Point.West));

                Point resultW = compass.Rotate(Point.West, Direction.Right);
                Assert.That(resultW, Is.EqualTo(Point.North));

                }

            );
        }
    }
}