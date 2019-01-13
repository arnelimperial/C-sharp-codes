using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFile4
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

            //string path = @"C:\Users\9page\Documents\C#\rekisteri";
            var dir = System.Environment.CurrentDirectory;
            string fullPathToTargetFile = dir + "/rekisteri.txt";
            
            using(FileStream create = File.Create(fullPathToTargetFile))//Create file
            using(StreamWriter writer = new StreamWriter(create))//create file object
            for(int i = 0; i< employees.Length; ++i){
                writer.WriteLine(employees[i].Insert()); //write something to the file

            }
    
            const int arrLen = 3;
            string []identification = new string [arrLen];
            string [] Name_ = new string [arrLen];
            string [] Salary_ = new string [arrLen];
            Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka):");

            for(int C = 0; C < arrLen; C++){
                Console.WriteLine("Anna id:");
                identification [C] = Console.ReadLine();
                Console.WriteLine("Anna nimi");
                 Name_ [C]  = Console.ReadLine();
                 Console.WriteLine("Anna palka:");
                 Salary_ [C] = Console.ReadLine();

            }



           
        }
    }
}


//Recommended for creating files in ProgramData hidden file from OS
// var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
// var complete = Path.Combine(systemPath, fileName);