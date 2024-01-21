using System.Diagnostics;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public abstract class Product
    {
        private decimal price;
        private int count;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ім'я не може бути порожнім або містити лише пробіли.");
                }
                name = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна не може бути від'ємною.");
                }
                price = value;
            }
        }
        public int Count 
        {
            get { return count; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Кількість не може бути від'ємною.");
                }
                count = value;
            }
        }
        public abstract void Display();
    }
}