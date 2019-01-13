using System;

namespace CSharpOpen2
{
    public class Firma{

        protected string companyName;
        protected string companyAddress;
        protected string phoneNumber;
        public double revenue;
        public double expenditure;
        double calculation_;
        


        public Firma(){
            this.companyName = "IFF Limited";
            this.companyAddress = "57th Street Manhattan, NY";
            this.phoneNumber = "231-7190368";
            this.revenue = 3400000000;
            this.expenditure = 1000000000;
        }
        ~Firma(){}

        public string CompanyName{
            get{return companyName;}
            set{companyName = value;}
        }

        public string CompanyAddress{
            get{return companyAddress;}
            set{companyAddress = value;}
        }

        public double Revenue{
            get{return revenue;}
            set{revenue = value;}
        }

        public double Expenditure{
            get{return expenditure;}
            set{expenditure = value;}
        }

        public string PhoneNumber{
            get{return phoneNumber;}
            set{phoneNumber = value;}
        }


        public double profitCalculation(double revenue_, double expenditure_){
            revenue = revenue_;
            expenditure = expenditure_;
            calculation_ = ((revenue - expenditure) /expenditure) *100;

            return (calculation_);
        }


        public override string ToString(){

            return("Firman nimi: " + companyName + "\nFirman osoite: " + companyAddress + "\nPuhelin: " + phoneNumber + "\nTulot: " + revenue.ToString() + " (Billion Euro)"+ "\nMenot: " + expenditure.ToString() + " (Billion Euro)");

        }

        public void evaluation (double num){
            if(num >= 300){
                Console.WriteLine("Yhtiön tulosarviointi: Prosentuaalinen voitto on erinomainen.");
            }else if(num < 300 && num >= 200){
                Console.WriteLine("Yhtiön tulosarviointi: Prosentuaalinen voitto on tyydyttävä.");
            }else{
                Console.WriteLine("Yhtiön tulosarviointi: Prosenttiosuus ei ole hyvä.");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Firma firma = new Firma();
            string display = firma.ToString();
            Console.WriteLine(display);
            double res = firma.profitCalculation(firma.revenue, firma.expenditure);
           
           Console.WriteLine("\nVoitto: " + string.Format("{0:0.00}", res) + " %");
           firma.evaluation(res);
        }
    }
}
