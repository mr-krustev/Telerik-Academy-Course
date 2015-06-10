using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape()
        {
        }

        public Shape(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateSurface();

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

    }
}
