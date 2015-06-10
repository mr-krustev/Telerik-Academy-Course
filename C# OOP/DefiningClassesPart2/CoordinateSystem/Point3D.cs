namespace CoordinateSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Point3D
    {
        public static readonly Point3D pointO = new Point3D(0, 0, 0);

        int x;
        int y;
        int z;


        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D PointO
        {
            get { return pointO; }
        }

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public int Z
        {
            get { return this.z; }
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", x, y, z);
        }
    }

    static class Calculate
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                                      (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                                      (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
            return result;
            //d = Math.Sqrt((x2-x1)(x2-x1) + (y2-y1)(y2-y1) + (z2-z1)(z2-z1)
        }



    }

}
