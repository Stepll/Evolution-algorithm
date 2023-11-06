using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Classes
{
    static class Extentions
    {

        static public Point ToSizeCoordinate(this Point point, int size) 
        { 
            return new Point(point.X * size, point.Y * size);
        }

        static public Point FromSizeCoordinate(this Point point, int size)
        {
            return new Point(point.X / size, point.Y / size);
        }
    }
}
