using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndGen = new Random();
            // Table t = new Table(rndGen.Next(50, 200), rndGen.Next(50, 200));
            //t.ShowData();

            List<Table> Tables = new List<Table>();

            for (int i = 0; i < 10; i++)
            {
                int w = rndGen.Next(50, 200);
                int h = rndGen.Next(50, 200);
                Tables.Add(new Table(w, h));
            }

            foreach (var t in Tables)
            {
                t.ShowData();
            }
        }
    }
}
