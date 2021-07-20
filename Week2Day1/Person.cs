using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class Person
    {
        //string FirstName; //campi , default: private 
        //string LastName;

        //public string FirstName;
        //public string LastName;


        //Proprietà
        public string FirstName
        {
            get //recuperrare valore
            {
                return _firstName;
            }
            set//settare il valore
            {
                _firstName = value;
            }
        }

        private string _firstName; //campo privato

        public string LastName { get; set; }

        //public int Age { get; } //=20 se non metto il set vuol dire che non posso mai modificarne il valore
        
        //neanche qui dentro, nella classe stessa, posso assegnare il valore ad Age
        
        public int Age { get; private set; }

        //public void MetodoACaso()
        //{
        //    int a = 25;
        //    Age = a; //all'interno della classe lo posso settare, grazie al private
        //}

        public string BioData //proprietà mascherata da metodo
        {
            get
            {
                return FirstName + " " + LastName + " " + Age;
            }
        }

        //costruttore -> è un metodo particolare che deve avere lo stesso nome della classe e nella sua firma avrà solo il nome della classe, i parametri e non un tipo di ritorno
        //serve ad inizializzare l'oggetto in modo corretto
        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        

        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        if(value == string.Empty) //se utente "inserisce" stringa vuota
        //        {
        //            _firstName = "Nessun nome";
        //        }
        //        else
        //        {
        //            _firstName = value;
        //        }
        //    }
        //}

        public Person()
        {
            //imposta le variabili con valori di default
        }


        public static int Count { get; set; } //con static la proprietà diventa un membro di classe, e quindi ogni volta che istanzio una persona con il costruttore, mi viene incrementato count
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Count++;
        }

        //keyword this
        //public Person(string FirstName, string lastName, int age)
        //{
        //    this.FirstName = FirstName; //proprio a questa(this) istaza di persona assegno
        //    LastName = lastName;        //il valore passato al costruttore FirstName
        //    Age = age;
        //}

        public string FullName
        {
            get
            {
                return this.FirstName +" " + this.LastName;
            }
        }
        
        //Proprietà di tipo di un'altra classe
        public HomeAddress Address { get; set; } //= new HomeAddress() in questo modo la istanzio già qui e quindi non devo farlo nel main

        //Classe annidata -> meglio non farle 
        public class SecondAddress
        {
            public string Street { get; set; }
            //..
        }

        //Metodi -> per descrivere azioni, comportamenti della classe
        public void PrintBioData()
        {
            Console.WriteLine(FirstName + " " +LastName + " " +Age +" "+ Address.Street);
        }

        //internal -> visibile nel progetto
        //private-> visibile solo nell'ambito del tipo (es. nell'ambito della classe)
        //public-> visibile 'dappertutto', nel progetto e anche fuori
        //protected-> visibile nell'ambito delle classi che ereditano dalla classe
    }
}
