using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Smartphone : Product
    {
        public string OS { get; set; }
        public override void Display()
        {
            Console.WriteLine($"Smartphone: {Name}, Price: {Price:C}, Count: {Count}, OS: {OS}");
        }

    }
}
