using System;

namespace Week2Day1.esercizio1
{
    internal class Menu
    {
        internal static void Start()
        {
            char choice;
            do
            {
                Console.WriteLine("Benvenuto!");

                Console.WriteLine("Premi 1 per aggiungere un libro \nPremi 2 per eliminare un libro \nPremi 3 per visualizzare tutti i libri in magazzino \nPremi 4 per visualizzare i libri per genere \nPremi Q per uscire");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        //aggiungi libro
                        AddNewBook();
                        break;
                    case '2':
                        //elimina libro
                        RemoveBookByISBN();
                        break;
                    case '3':
                        //visualizzare tutti i libri
                        BookManager.ShowBooks();
                        break;
                    case '4':
                        //visualizzare tutti i libri per genere
                        ShowBookByGenre();
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("\nScelta non valida!");
                        break;
                }
            } while (choice != 'Q');
        }

        

        private static void AddNewBook()
        {
            string isbn, title, author;
            decimal price;
            do
            {
                Console.WriteLine("\nInserisci il codice ISBN (10 cifre)");
                isbn = Console.ReadLine();
            }
            while (isbn.Length != 10);

            //se esiste già un libro con lo stesso codice, lo segnala, se no si procede all'inserimento
            if(BookManager.GetByIsbn(isbn) == null)
            {
                //inserire titolo
                do
                {
                    Console.WriteLine("\nInserire il titolo del libro");
                    title = Console.ReadLine();
                } while (title.Length == 0);

                //inserire autore
                do
                {
                    Console.WriteLine("\nInserire l'autore del libro");
                    author = Console.ReadLine();
                } while (author.Length == 0);

                //inserire prezzo
                Console.WriteLine("\nInserire il prezzo del libro");
                while(!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
                {
                    Console.WriteLine("Devi inserire un prezzo valido!");
                }
                //inserire genere
                GenreEnum genre = GetGenre();

                Book newBook = BookManager.addBook(isbn,title,author,price,genre);
            }
            else
            {
                Console.WriteLine("Esiste già un libro con questo codice isbn");
            }

        }

        private static void RemoveBookByISBN()
        {
            string isbn;
            do
            {
                Console.WriteLine("\nInserisci il codice ISBN (10 cifre) del libro che vuoi rimuovere.");
                isbn = Console.ReadLine();
            }
            while (isbn.Length != 10);

            Book book = BookManager.GetByIsbn(isbn);
            if (book == null)
            {
                Console.WriteLine("\nIl libro che stai cercando di rimuovere non esiste.");
            }
            else
            {
                BookManager.RemoveBook(book);
            }

        }

        private static void ShowBookByGenre()
        {
            Console.WriteLine("Di che genere vuoi visualizzare la lista?");
            GenreEnum genre = GetGenre();
            BookManager.ShowBookByGenre(genre);
        }

        private static GenreEnum GetGenre()
        {
            Console.WriteLine($"Premi {(int)GenreEnum.Fantasy} per scegliere {GenreEnum.Fantasy}");
            Console.WriteLine($"Premi {(int)GenreEnum.Horror} per scegliere {GenreEnum.Horror}");
            Console.WriteLine($"Premi {(int)GenreEnum.Thriller} per scegliere {GenreEnum.Thriller}");
            Console.WriteLine($"Premi {(int)GenreEnum.Romance} per scegliere {GenreEnum.Romance}");
            Console.WriteLine($"Premi {(int)GenreEnum.Comedy} per scegliere {GenreEnum.Comedy}");

            int g;
            while(!int.TryParse(Console.ReadLine(),out g) || g < 0 || g > 4)
            {
                Console.WriteLine("Scelta non valida. Riprova!");
            }

            return (GenreEnum)g;
        }
    }
}