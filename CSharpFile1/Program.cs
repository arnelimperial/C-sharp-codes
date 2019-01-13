using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpFile1
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

        //Display & Insert function
        public string Insert(){
            return("id: " + Id + "\nnimi: " + Name + "\npalka: " + Salary);
            
        }

    }

    //Driver class
    class Program
    {
        static void Main(string[] args)
        {
            Employees [] employees = new Employees[3];

            employees[0] = new Employees(1, "Jari", 3500);
            employees[1] = new Employees(2, "Matti", 4800);
            employees[2] = new Employees(3, "Tuomas", 2100);

        
            var dir = System.Environment.CurrentDirectory;
            string fullPathToTargetFile = dir + "/rekisteri1.txt";
            
            using(FileStream create = File.Create(fullPathToTargetFile)){
            using(StreamWriter writer = new StreamWriter(create)){
            for(int i = 0; i< employees.Length; ++i){
                writer.WriteLine(employees[i].Insert());}
            }}
            
            string idNum;
            Console.WriteLine("Anna työntekijän id:");
            idNum = Console.ReadLine();

            //Reading contents of the file
            using(StreamReader reader = new StreamReader(fullPathToTargetFile)){
                string contents = reader.ReadToEnd();
                if(contents.Contains(idNum)){
                    if(idNum == "1"){
                        Console.WriteLine(employees[0].Insert());
                        }else if(idNum == "2"){
                            Console.WriteLine(employees[1].Insert());
                            }else if(idNum == "3"){
                                Console.WriteLine(employees[2].Insert());
                            }else{
                                Console.WriteLine("Työntekijää ei löydy id-numerolla {0}", idNum);
                            }
            }else{
                Console.WriteLine("Työntekijää ei löydy id-numerolla {0}", idNum);
            

}}}}}