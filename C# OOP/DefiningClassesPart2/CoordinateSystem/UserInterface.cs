using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            Point3D pointX = new Point3D(3, 2, 3);
            Point3D pointY = new Point3D(2, 2, 2);

            Console.WriteLine(Calculate.Distance(pointX,pointY));

            PathStorage.FileSave();
         
        }
    }
}
