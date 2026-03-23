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
            Point[] directions = new Point[]
            {
                Point.North,
                Point.East,
                Point.South,
                Point.West

            };

            int index = Array.IndexOf(directions, point);
            if(direction == Direction.Right)
            {
                // add +1 to follow the order, for example if point =Point.East index will be 1 
                //since we are moving to the right we want the index of the next item in the array
                // Use moduluo to wrap around
                index = (index + 1) % directions.Length;
            }
            return directions[index];
        }

    }
}
