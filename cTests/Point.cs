using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTests
{
    enum PointType
    {
        a,
        b,
        c
    }
    internal class Point
    {
        protected int x, y;
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (x == p.x) && (y == p.y);
            }
        }
        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override int GetHashCode()
        {
            return (this.x << 2) ^ this.y;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1})", x, y);
        }
    }
}
