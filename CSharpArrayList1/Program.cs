using System;
using System.Collections.Generic;

class Jumppa : IComparable{
    public string nimi;
    public string[] ajat;
    public string[] paikat;

    public Jumppa(string nimi, string[] ajat, string[] paikat)
    {
        this.nimi = nimi;
        this.ajat = ajat;
        this.paikat = paikat;
    }

    public override string ToString()
    {
        string jumppa = nimi+"\najat:\n";
        for (int i = 0; i < ajat.Length; i++)
        {
            jumppa += ajat[i] + "\n";
        }

        jumppa += "\npaikat:\n";

        for (int i = 0; i < paikat.Length; i++)
        {
            jumppa += paikat[i] + "\n";
        }
        return jumppa;
    }

    //Define class Properties
    public string Nimi{
        get{return nimi;}
        set{nimi = value;}
    }

    public string [] Ajat{
        get{return ajat;}
        set{ajat = value;}
    }

    public string [] Paikat{
        get{return paikat;}
        set{paikat = value;}
    }

    //Implement ICompare Interface using String Object to sort objects
    public int CompareTo(Object obj){

        if(obj is Jumppa){
            Jumppa list_Object = (Jumppa) obj;
            return nimi.CompareTo(list_Object.Nimi);
        }else{
            throw new ArgumentException("Objects is not created from Jumppa class.");
        }
    }



}
    class Program
    {
        static void Main(string[] args)
        {
            List<Jumppa> list_Object = new List<Jumppa>();
            list_Object.Add(new Jumppa("juniori", new string[]{"Keskiviikko 9:30", "Perjantai 9:30"}, new string[]{"Liikuntasali"}));
            list_Object.Add(new Jumppa("seniori", new string[]{"Maanantai 8:00", "Tiistai 8:30"}, new string[]{"Liikuntasali"}));
            list_Object.Add(new Jumppa("perhe", new string[]{"Lauantai 12:30", "Sunnuntai 13:00"}, new string[]{"Puisto", "Liikuntasali"}));
            list_Object.Add(new Jumppa("naisten", new string[]{"Tiistai 8:00", "Perjantai 8:00"}, new string[]{"Puisto"}));
            list_Object.Add(new Jumppa("miesten", new string[]{"Maanantai 8:00", "Torstai 8:00"}, new string[]{"Liikuntasali", "Puisto"}));

            list_Object.Sort();

            foreach (var jumppa in list_Object){
               Console.WriteLine(jumppa.ToString());
            }
        } 

    
    }   
