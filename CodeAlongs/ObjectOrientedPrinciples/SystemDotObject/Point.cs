using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SystemDotObject
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        // only constructor for this object
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // anytime we give the object to print it will use this method
        public override string ToString()
        {
            return $"Point as ({x}, {y})";
        }

        // allows us to determine the comparison
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Point otherPoint = (Point) obj;

            return (this.x == otherPoint.x) && (this.y == otherPoint.y);
        }

        // we can do member-wise copy
        // create a new object and copy only hte values
        public Point Copy()
        {
            return (Point)this.MemberwiseClone();
        }
    }
}
