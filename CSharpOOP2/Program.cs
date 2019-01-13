using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public class Kirja{

        //Members variables
        public string Nimi; //declared public for accessibility
        string bookAuthor;
        float bookPrice;
        string bookPublisher;
        public string bookTheme;
       
        

        //Constructor declaration
        public Kirja(string Nimi, string bookAuthor, string bookPublisher, float bookPrice, string bookTheme){
            this.Nimi = Nimi;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
            this.bookPublisher = bookPublisher;
            this.bookTheme = bookTheme;
        }

        //Methods
        public string BookName(){
            return Nimi;
        }

        public string BookAuthor(){
            return bookAuthor;
        }

        public string BookTheme(){
            return bookTheme;
        }

        public float BookPrice(){
            return bookPrice;
        }

        public string BookPublisher(){
            return bookPublisher;
        }

       public void HaeKirja(string Nimi){

            Console.WriteLine(BookName() + ", " + BookAuthor() + ", " + BookPublisher() + ", " + BookPrice() + ", " + BookTheme());
        }

 }

 //To access the nonstatic object from static function in Program class
 //provide static variable and set local var into the static var
 //then set into the dot operator object with non-static member of the other class
    class Program{
        public static string newTheme;
        //objects as parameter and replacement string
        public static void VaidaTeema(Kirja k2, string theme){
        newTheme = theme;// "Jännitys" string theme
        k2.bookTheme = newTheme;
       
    }

        static void Main(string[] args)
        {
            //Create object
            Kirja k = new Kirja("Kirja", "K. Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
            Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");

            k.HaeKirja(k.Nimi);
            VaidaTeema(k2, "Jännitys");//invoke static function without refrence to other class as it belongs to Program class
            k2.HaeKirja(k2.Nimi);

        }
    }
 

