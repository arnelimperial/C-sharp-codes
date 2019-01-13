using System;

namespace CSharp5
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int fib0 = 1, fib1 = 2, fib2 = 4, fibonacci;
           
            for(int i = 1;i <= 21; ++i){

                if(i == 1){
                    Console.WriteLine(fib0);
                    continue;
                }

                if(i == 2){
                    Console.WriteLine(fib0);
                    continue;
                }

                if(i == 3){
                     Console.WriteLine(fib1);
                     continue;
                }

                if(i == 4){
                     Console.WriteLine(fib2);
                     continue;
                }



                fibonacci = fib2 * 2;
                fib2 = fibonacci;
               Console.WriteLine(fibonacci);
            }
        }
    }
}
