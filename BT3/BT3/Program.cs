using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            var hinh1 = new Product(7, 4, 3);
            var hinh2 = new Product(3, 4, 5);
            var hinh3 = new Product(3, 3, 3);
            var hinh4 = new Product(4, 4, 5);
            var hinh5 = new Product(2, 4, 5);

            Product.printtitle();
            hinh1.ToString();
            hinh2.ToString();
            hinh3.ToString();
            hinh4.ToString();
            hinh5.ToString();
            Console.WriteLine("------------------------------");
        }
    }
}
