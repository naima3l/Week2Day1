using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1.esercizio1
{
    class BookManager
    {
        static List<Book> books = new List<Book>();
        //Dictionary<string, Book> bookss = new Dictionary<string, Book>();

        internal static Book GetByIsbn(string isbn)
        {
            //scorrere la lista
            foreach(Book book in books)
            {
                if(book.ISBN == isbn)
                {
                    return book;
                }
                
            }
            return null;
        }

        internal static Book addBook(string isbn, string title, string author, decimal price, GenreEnum genre)
        {
            Book book = new Book(isbn, title, author, price, genre);
            books.Add(book); //lo aggiungo alla mia lista di libri creata sopra
            return book;
        }

        internal static void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"Il libro {book.Title} è stato rimosso!");
        }

        internal static void ShowBooks()
        {
            Console.WriteLine("\n");
            foreach(Book book in books)
            {
                Console.WriteLine($"Titolo : {book.Title} , Autore : {book.Author} , Prezzo : {book.Price}, Genere : {book.Genre}");
            }
            
        }

        internal static void ShowBookByGenre(GenreEnum genre)
        {
            Console.WriteLine("\n");
            int count=0;
            foreach (Book book in books)
            {
                if(book.Genre == genre)
                {
                    Console.WriteLine($"Titolo : {book.Title} , Autore : {book.Author} , Prezzo : {book.Price}, Genere : {book.Genre}");
                    count++;
                }
                
            }
            if(count==0)
            {
                Console.WriteLine($"Non c'è nessun libro del genere {genre}");
            }
        }
    }
}
