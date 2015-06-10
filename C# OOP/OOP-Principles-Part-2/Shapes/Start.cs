namespace Shapes
{
    using System;
    using System.Linq;

    using Models;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            List<Shape> fewShapes = new List<Shape>()
            {
                new Triangle(5,8),
                new Rectangle(7,9),
                new Square(6)
            };

            foreach (var sh in fewShapes)
            {
                Console.WriteLine(sh.CalculateSurface());
            }
        }
    }
}
