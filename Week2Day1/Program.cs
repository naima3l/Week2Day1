using System;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1; //creo solo il riferimento all'oggetto senza crearlo, quindi punto a null

            Person p2 = new Person();

            p2.FirstName = "Mario";
            p2.LastName = "Rossi";

            Person p3 = new Person();

            p3.FirstName = "Sara";
            p3.LastName = "Bianchi";

            p1 = p2; //2 riferimenti alla stessa istanza

            Console.WriteLine(p1.FirstName + " " + p1.LastName);

            Person p4 = new Person("Ciccio", "Pasticcio");

            Person p5 = new Person("Samuele", "Verdi", 25);
            //p5.Age = 28; ERRORE

            //Address
            p5.Address = new HomeAddress();
            p5.Address.Street = "via Roma";
            //accesso alle proprietà di Address...

            //Classe annidata
            Person.SecondAddress secondAddress = new Person.SecondAddress();
            secondAddress.Street = "via Milano";

            //Metodi
            p5.PrintBioData();

            Person p6 = new Person("Anna", "Bianchi", 37);
            Console.WriteLine(Person.Count);

            //accedere ai metodi della classe statica
            StaticClass.MyMethod();
            //StaticClass = new StaticClass(); ERRORE! classe statica non si istanzia
        }
    }
}
