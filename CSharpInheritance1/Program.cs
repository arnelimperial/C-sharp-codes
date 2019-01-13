using System;

public class KulkuValine{
    protected string type;
    protected string brand;
    protected int makeYear;
    protected float price;

    public KulkuValine(string type, string brand, int makeYear, float price){
        this.type = type;
        this.brand = brand;
        this.makeYear = makeYear;
        this.price = price;
    }

    ~KulkuValine(){}
    //virtual function to print member variables defined in base class
    public virtual void TulostaTiedot(){
        Console.WriteLine(this.type + ", " + this.brand + ", " + this.makeYear + ", " + this.price);
    }
}


class Auto : KulkuValine{
    protected int machineSize;
    protected string model;
    protected int doorNumber;
    //Constructor in derived class with members assigned
    public Auto(string type, string brand, int makeYear, float price, int machineSize, string model, int doorNumber): base(type, brand, makeYear, price){
        this.machineSize = machineSize;
        this.model = model;
        this.doorNumber = doorNumber;
   }

    ~Auto(){}
    //override virtual function in derived class
    public override void TulostaTiedot(){
        Console.WriteLine(this.type + ", " + this.brand + ", " + this.makeYear + ", " + this.price + ", " + this.machineSize + ", " + this.model + ", "+ this.doorNumber);
    }
}




    class Program
    {
        static void Main(string[] args)
        {
            KulkuValine kv = new KulkuValine("auto", "Honda", 2014, 18190f);
            kv.TulostaTiedot();

            Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
           a.TulostaTiedot();

        }
    }

