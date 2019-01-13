using System;

namespace CSharpOpen1
{
    public interface Comparison{
        string TulostaTiedot();
        string VertailePalkka(double salary, Tyontekija tyontekijat);
    }
    public class Tyontekija: Comparison{
        protected string name;
        protected int id;
        protected double salary;

        public Tyontekija(int id, string name, double salary ){
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public int Id{
            get{return id;}
            set{id = value;}
        }

        public double Salary{
            get{return salary;}
            set{salary = value;}
        }

        
        public string VertailePalkka(double salary, Tyontekija tyontekijat){
            double compare1 = 4500.23, compare2 = 5890.44, compare3 = 39493.29;
            if(tyontekijat.Salary != compare3){
                return("Toissijainen työntekijä:");
            }else{
                return("\nEnsisijainen työntekijä:");
            }
        }

        public string TulostaTiedot(){
            return("ID: #" + Id + "\nNimi: " + Name + "\nPalkka: "+ Salary+ " Euro\n");
        }


        ~Tyontekija(){}
    } 
    class Program
    {
        static void Main(string[] args)
        {
            const int arrLen = 3;
            Tyontekija [] tyontekijat = new Tyontekija[arrLen];
            tyontekijat [0] = new Tyontekija(4006, "John Doe", 4500.23);
            tyontekijat [1] = new Tyontekija(2367, "Arnska Antilla", 5890.44);
            tyontekijat [2] = new Tyontekija(7834,"Juan Dela Cruz", 39493.29);

            for(int C = 0; C < tyontekijat.Length; C++){
                Console.WriteLine(tyontekijat[C].VertailePalkka(39493.29, tyontekijat[C]));
                Console.WriteLine(tyontekijat[C].TulostaTiedot());
                
            }
            
        }
    }
}
