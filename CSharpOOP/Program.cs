using System;

namespace CSharpOOP
{
    public class Kirja{

        //Members variables
        string bookName;
        string bookAuthor;
        int bookCode;
        double bookPrice;

        //Constructor declaration
        public Kirja(string bookName, string bookAuthor, int bookCode, double bookPrice){
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

        public double BookPrice(){
            return bookPrice;
        }

        public override string ToString(){
            return(bookName + ", " + bookAuthor + ", " + bookCode.ToString() + ", " + bookPrice.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create object

            Kirja books = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.5);

            string book = books.BookName(), author = books.BookAuthor();
            int code = books.BookCode();
            double price = books.BookPrice();


            //Console.WriteLine(book + ", " + author + ", " + code + ", " + price);
            Console.WriteLine(books.ToString());

        }
    }
}
