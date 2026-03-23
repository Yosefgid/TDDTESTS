using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDDTests.Core;

namespace TDDTests.Test
{
    public class CompassTests
    {
        //Return x when passed y
        //Ensure that when the rotate method is passed a point
        //Facing North and a Right direction it should return Point.East

        [Test]
        public void Rotate_East_When_Rotating_North_Right()
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
