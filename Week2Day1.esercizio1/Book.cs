using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1.esercizio1
{
    //    Scrivere un programma per la gestione del magazzino di una libreria.



    //Un libro è un'entità che ha

    //•Codice ISBN

    //•Titolo

    //•Autore

    //•Genere

    //•Prezzo

    //•

    //Per il genere usare un enum.



    //L’utente utilizzatore(magazziniere) può:

    //•inserire un nuovo libro(verificando, tramite il codice ISBN, che non ci sia già)

    //•eliminare un libro

    //•visualizzare tutti i libri

    //•visualizzare i libri per genere
    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public GenreEnum Genre  {get; set;}

        //public Book()
        //{
        //    //costruttore
        //}

        public Book(string isbn, string title, string author, decimal price, GenreEnum genre)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
            Genre = genre;
        }

        //methods
       

        public void ShowBooks()
        {

        }

       
}
    enum GenreEnum
    {
        Fantasy, //0
        Horror, //1
        Thriller, //2
        Romance, //3
        Comedy
    }
}
