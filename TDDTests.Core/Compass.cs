using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTests.Core
{
    public class Compass
    {
        public Point CurrentPoint { get; set; }


        //This is needed as it sets the compass to have an intial direction, forcing it to have a valid value
        public Compass(Point startingPoint)
        {

            CurrentPoint = startingPoint;
        }

        public Point Rotate(Point point, Direction direction)
        {
            if (point == Point.North && direction == Direction.Right)
            {
                return Point.East;
            }
            return point;
        }

    }
}
