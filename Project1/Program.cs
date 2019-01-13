using System;

namespace C__Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double product2 = 72.0, product1 = 7.96, product3 = 99.90;

            string result1 = string.Format("Tuote 1: {0:0.00}", product1);
            string result2 = string.Format("Tuote 2: {0:0.0}", product2);
            string result3 = string.Format("Tuote 2: {0:0.00}", product3);

            
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);



        }
    }
}
