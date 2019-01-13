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
    public virtual string ToString(){
        return (this.type + ", " + this.brand + ", " + this.makeYear + ", " + this.price);
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
    public override string ToString(){
        return (this.type + ", " + this.brand + ", " + this.makeYear + ", " + this.price + ", " + this.machineSize + ", " + this.model + ", "+ this.doorNumber);
    }
}



    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
            Auto a2 = new Auto("farmari", "Skoda", 2014, 22990f, 151, "Octavia", 4);

            Console.WriteLine(a.ToString() + "\n" + a2.ToString());
            Console.WriteLine(a.Equals(a2));
        }
    }

