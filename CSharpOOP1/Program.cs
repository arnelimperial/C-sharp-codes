using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOOP1
{
    public class Kirja{

        //Members variables
        string bookName;
        string bookAuthor;
        int bookCode;
        float bookPrice;

        //Constructor declaration
        public Kirja(string bookName, string bookAuthor, int bookCode, float bookPrice){
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookCode = bookCode;
            this.bookPrice = bookPrice;
        }

        //Methods
        public string BookName(){
            return bookName;
        }

        public string BookAuthor(){
            return bookAuthor;
        }

        public int BookCode(){
            return bookCode;
        }

        public float BookPrice(){
            return bookPrice;
        }

        public void VertaileKirja(Kirja k2){
            if(this.bookPrice > k2.bookPrice){
                Console.WriteLine(this.bookName + " on kalliimpi kuin " + k2.bookName);
            }else{
                Console.WriteLine(this.bookName + " on halvempi kuin " + k2.bookName);
            }
        }
}
    


    class Program
    {
        static void Main(string[] args)
        {
            //Create object

            Kirja k = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.50f);
            Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", 347, 36.90f);


            //string book = books.BookName(), author = books.BookAuthor();
            //int code = books.BookCode();
            //double price = books.BookPrice();

            k.VertaileKirja(k2);


           // Console.WriteLine(book + ", " + author + ", " + code + ", " + price);
        }
    }
}
