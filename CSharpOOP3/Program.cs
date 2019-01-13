using System;

 public class Kirja{

        //Members variables
        string bookName; 
        string bookAuthor;
        public float hinta;//BookPrice public modifier for accessibility
        string bookPublisher;
        string bookTheme;
        float discount;
        float discountResult;
        

        //Constructor declaration
        public Kirja(string bookName, string bookAuthor, string bookPublisher, float hinta, string bookTheme){
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.hinta = hinta;
            this.bookPublisher = bookPublisher;
            this.bookTheme = bookTheme;
        }

        //Destructor
        ~Kirja(){}

        //Methods
        public string BookName(){
            return bookName;
        }

        public string BookAuthor(){
            return bookAuthor;
        }

        public string BookTheme(){
            return bookTheme;
        }

        public float BookPrice(){
            return hinta;
        }

        public string BookPublisher(){
            return bookPublisher;
        }

        //Method to calculate 10% discount
        public float Discount(float number){
            discount = number - (number * 0.1F);
            return discount;
        }

        //Hinta property of type float
        
        public float Hinta{

            get{
                discountResult = Discount(hinta);//Invoke function Discount()...

                 return this.hinta = discountResult;
                }
            //set function
            set{
                hinta = value;
            }
        }

      
 }


    class Program{
        
        static void Main(string[] args)
        {

            Kirja k = new Kirja("Kirja", "K. Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
            Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");

            Console.WriteLine(k.hinta);
            Console.WriteLine(k2.Hinta);
            
        }
    }

