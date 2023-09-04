using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    internal class rectangle
    {
        private int width {  get; set; }
        private int height { get; set; }
        private Color color { get; set; }
        private bool isTransparent { get; set; }


        public rectangle(int width)
        {
            this.width = width;
        }

        public rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public rectangle(int width, int height, Color color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public rectangle(int width, int height, Color color, bool isTransparent)
        {
            this.width = width;
            this.height = height;
            this.color = color;
            this.isTransparent=isTransparent;
        }

        public void WriteProperties()
        {
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("height: {0}", height);
            Console.WriteLine("color: {0}", color);
            Console.WriteLine("is Transparent: {0} \n", isTransparent);
        }
    }
}
