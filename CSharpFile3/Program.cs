using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


namespace CSharpFile3
{
    public class Employees{
        //members
        int id;
        string name;
        int salary;
        //Constructor
        public Employees(int id, string name, int salary){
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        //Destructor

        ~Employees(){}


        //Properties
        public int Id{
            get{return id;}
            set{id = value;}
        }

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public int Salary{
            get{return salary;}
            set{salary = value;}
        }

        public string Insert(){
            return("id: "+ Id + " nimi: "+ Name + " palkka: " + Salary);
           
        }

    }

    //Driver class
    class Program
    {

        static void Main(string[] args)
        {
            Employees [] employees = new Employees[3];
            const int arrLen = 3;
            string []identification = new string [arrLen];
            int [] identification_ = new int [arrLen];
            string [] Name_ = new string [arrLen];

            string [] Salary_ = new string [arrLen];
            int [] Salaries_ = new int [arrLen];

            Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka):");

            for(int C = 0; C < arrLen; C++){
                Console.WriteLine("Anna id:");
                    identification [C] = Console.ReadLine();
                    Int32.TryParse(identification[C], out identification_[C]);

                    Console.WriteLine("Anna nimi:");
                    Name_ [C]  = Console.ReadLine();

                    Console.WriteLine("Anna palkka:");
                    Salary_ [C] = Console.ReadLine();
                    Int32.TryParse(Salary_[C], out Salaries_[C]);}

           
            employees[0] = new Employees(identification_[0], Name_[0], Salaries_[0]);
            employees[1] = new Employees(identification_[1], Name_[1], Salaries_[1]);
            employees[2] = new Employees (identification_[2], Name_[2], Salaries_[2]);


            Hashtable hastable = new Hashtable();

            hastable.Add(identification_[0], Name_[0] +" " + Salary_[0]);
            hastable.Add(identification_[1], Name_[1] + " "  + Salary_[1] );
            hastable.Add(identification_[2], Name_[2] + " " + Salary_[2] );



        
            var dir = System.Environment.CurrentDirectory;
            string fullPathToTargetFile = dir + "/rekisteri3.txt";
            
            using(FileStream create = File.Create(fullPathToTargetFile)){
            using(StreamWriter writer = new StreamWriter(create)){
                for(int i = 0; i< employees.Length; ++i){
                    writer.WriteLine(employees[i].Insert());}}}
    
            
           


            string idNum;
            //Reading contents of the file
            using(StreamReader reader = new StreamReader(fullPathToTargetFile)){
                string contents = reader.ReadToEnd();
                do{
                    Console.WriteLine("Anna työntekijän id:");
                    idNum = Console.ReadLine();
                    if(contents.Contains(idNum)){
                        if(idNum == "1"){
                            Console.WriteLine(employees[0].Insert());
                        }else if(idNum == "2"){
                            Console.WriteLine(employees[1].Insert());
                        }else if(idNum == "3"){
                            Console.WriteLine(employees[2].Insert());
                        }else{
                            Console.WriteLine("Työntekijää ei löytynyt id-numerolla {0}", idNum);
                            Environment.Exit(0);
                        }
            }else{
                Console.WriteLine("Työntekijää ei löytynyt id-numerolla {0}", idNum);
                Environment.Exit(0);}

            }while(idNum == "1" || idNum == "2" || idNum == "3");
            Console.WriteLine("Työntekijää ei löytynyt id-numerolla {0}", idNum);
            Environment.Exit(0);
            

}}}} 