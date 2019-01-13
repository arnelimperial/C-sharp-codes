using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


namespace CSharpException2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Anna tiedoston nimi:");
            string fileName_ = Console.ReadLine();
            var dir = System.Environment.CurrentDirectory;
            //add the user input to the path that match to the created file full path
            string fullPathToTargetFile = System.Environment.CurrentDirectory + "/" + fileName_;
           
            
            try{
                //Try to read the file if the full path is true it will start to read 
                using(StreamReader objectReader = new StreamReader(fullPathToTargetFile)){
                    Console.WriteLine(objectReader.ReadToEnd());
                    }
            }catch(FileNotFoundException){
                Console.WriteLine("Tiedostoa ei löytynyt nimellä {0}", fileName_);
            }

        }
    }
}
