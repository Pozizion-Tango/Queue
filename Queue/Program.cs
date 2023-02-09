using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUI menu = new GUI();
            while (true)
            {
                menu.Menu();//using a simple method to call in the GUI-Menu
            }
        }
    }
}
