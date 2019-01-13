/*
*Working with C# Interface and Array of Objects 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public interface ITProducts
{
    string HaeTuote(string productName, Tuote tuotteet);
    string LaskeYhteisArvo();
}
public class Tuote: ITProducts{
    string productName;
    float unitCost;
    double unitCount;
   
    
    

    
     public Tuote(string name, float cost, double count){
        productName = name;
        unitCost = cost;
        unitCount = count;
    }

    


    ~Tuote(){}

    

    public string HaeTuote(string productName, Tuote tuotteet){
        string compare = "vihko"; // Compare productName with compare variable 
        if(tuotteet.productName != compare){
            return ("");
        }else{
            return ("Tuote");
            }
        }
    public string LaskeYhteisArvo(){

        double product = unitCost * unitCount;
        double roundOf = Math.Round(product, 1, MidpointRounding.AwayFromZero);
        string data_result = Convert.ToString(roundOf);
        return(data_result);
            
    }    
}


    class Program
    {
        static void Main(string[] args)
        {
            Tuote [] tuotteet = new Tuote[3];
            tuotteet[0] = new Tuote("kyna", 1.4f, 300);
            tuotteet[1] = new Tuote("vihko", 2.3f, 425);
            tuotteet[2] = new Tuote("tabletti", 349f, 251);

            for(int i = 0; i< tuotteet.Length; i++){
                 Console.WriteLine(tuotteet[i].HaeTuote("vihko", tuotteet[i]));
                 Console.WriteLine(tuotteet[i].LaskeYhteisArvo());

                

            }

             
           
        }
    }

