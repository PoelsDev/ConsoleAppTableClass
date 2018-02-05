using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTableClass
{
    
    class Table
    {
        private int height;
        private int width;
        public Table(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public void ShowData()
        {
            Console.WriteLine("Width: " + width + " cm");
            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine();
        }
    }



}
