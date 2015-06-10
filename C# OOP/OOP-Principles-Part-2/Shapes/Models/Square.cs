using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square()
            :base()
        {
        }

        public Square(double size)
            :base(size,size)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height*this.Width;
        }
    }
}
