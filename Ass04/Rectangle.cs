using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Parameterless constructor
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        // Constructor with width and height
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Constructor with single integer
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
    }

}
