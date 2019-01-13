using System;

namespace CSharpException1
{
    public class Exceptions_{


        protected int num1_;
        protected int num2_;
        protected double dataResult_;

        public Exceptions_(int num1_, int num2_){
            this.num1_ = num1_;
            this.num2_ = num2_;
        }

        public int Num1_{
            get{return num1_;}
            set{num1_ = value;}
        }

        public int Num2_{
            get{return num2_;}
            set{num2_ = value;}
        }

        ~Exceptions_(){}


        public double Division(int num1_, int num2_){
            
            try{
                dataResult_ = num1_ / num2_;
            }catch(DivideByZeroException err){
                Console.WriteLine(err);
                Environment.Exit(0);
            }

            return dataResult_;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            const int arrLen = 3;
            string [] num1 = new string [arrLen];
            string [] num2 = new string [arrLen];
            int [] num1_ = new int [arrLen];
            int [] num2_ = new int [arrLen];

            for(int i = 0; i < arrLen; ++i){
                Console.WriteLine("Anna kaksi kokonaislukua:");
                num1[i] = Console.ReadLine();
               
                try{
                    num1_[i] = Int32.Parse(num1[i]);
                

                }catch(FormatException error){
                    Console.WriteLine(error);
                    Environment.Exit(0);
                }


                num2 [i] = Console.ReadLine();
                try{
                    num2_[i] = Int32.Parse(num2[i]);
                }

                catch(FormatException error){
                    Console.WriteLine(error);
                    Environment.Exit(0);
                }
               
            }


            Exceptions_ [] exception_ = new Exceptions_[arrLen];
            exception_[0] = new Exceptions_(num1_[0], num2_[0]);
            exception_[1] = new Exceptions_(num1_[1], num2_[2]);
            exception_[2] = new Exceptions_(num1_[2], num2_[2]);


            double [] res = new double [arrLen];
            for(int i = 0; i< arrLen; i++){
                res [i] = exception_[i].Division(num1_[i], num2_[i]);
                Console.WriteLine("Division: {0}", res[i]);
            }

        
        }
    }
}
