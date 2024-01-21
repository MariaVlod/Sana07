using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Laptop : Product
    {
        public string Processor { get; set; }
        public override void Display()
        {
            Console.WriteLine($"Laptop: {Name}, Price: {Price:C}, Count: {Count}, Processor: {Processor}");
        }
    }
}
