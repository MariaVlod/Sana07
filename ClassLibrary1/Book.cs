using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Book : Product
    {
        public string Author { get; set; }
        public override void Display()
        {
            Console.WriteLine($"Book: {Name}, Price: {Price:C}, Count: {Count}, Author: {Author}");
        }

    }
}
