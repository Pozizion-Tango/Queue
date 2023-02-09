using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue
{
    internal class GUI
    {
        private Queue<string> queue = new Queue<string>();

        public Queue<string> Queue
        {
            get { return queue; }
            set { queue = value; }
        }
        public void MenuTitle()//title
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("======================================="); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\r\n        H1 Queue Operations Menu        \r\n"); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("=======================================\r\n\r\n"); Console.ResetColor();
            Console.WriteLine("1. Add Items\r\n\r\n2. Delete Items\r\n\r\n3. Show the number of items\r\n\r\n4. Show min and max items\r\n\r\n");
        }
        public void Menu()//first menu to help guide. This program relies heavily on methods 
        {
            MenuTitle();
            string choice = Console.ReadLine();
            if (choice == "1")
                AddItems();//Adds a new item to the Queue
            else if (choice == "2")
                DeleteItems();//removes the last item in the Queue
            else if (choice == "3")
                NumberOfItems();//Shows all the items in the Queue
            else if (choice == "4")
                MinAndMax();//shows the first, and last item.
            Console.Clear();
        }
        public void AddItems()
        {
            Console.Clear();
            Console.Write("Inset An Item: ");
            this.Queue.Enqueue(Console.ReadLine());
            Menu();
        }
        public void DeleteItems()
        {
            Console.Clear();
            Console.WriteLine("Last Item Removed");
            this.Queue.Dequeue();
            Menu();
        }
        public void NumberOfItems()
        {
            Console.Clear();
            foreach (string item in this.Queue)
                Console.WriteLine(item + " ");
            Menu();
        }
        public void MinAndMax()
        {
            Console.Clear();
            string item = this.Queue.First();
            Console.WriteLine(this.Queue.Peek() + " Is Peek , " + this.Queue.Last() + " Is Last");
            Console.ReadKey();
        }
    }

}
