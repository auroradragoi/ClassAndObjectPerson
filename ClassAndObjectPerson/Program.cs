using System;

namespace ClassAndObjectPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana pers = new Persoana();
            pers.nume = "Dragoi";
            pers.prenume = "Aurora";
            pers.varsta = 28;
            Console.WriteLine(pers.afiseazaDetaliiPersoana());

            /*Console.WriteLine();
            Console.WriteLine("Nume: " + pers.nume + "\nPrenume: " + pers.prenume + "\nVarsta: " + pers.varsta);*/

            Console.WriteLine();
            Console.WriteLine("Nume: " + pers.nume);

            Persoana pers1 = new Persoana("Ionescu");
            pers1.prenume = "Marian";
            pers1.varsta = 30;

            Console.WriteLine();
            Console.WriteLine("Nume: " + pers1.nume + "\nPrenume: " + pers1.prenume + "\nVarsta: " + pers1.varsta);

            Persoana pers2 = new Persoana("Popescu", "Ioana", 18);
            Console.WriteLine();
            Console.WriteLine("Nume: " + pers2.nume + "\nPrenume: " + pers2.prenume + "\nVarsta: " + pers2.varsta);

            Console.ReadLine();
        }
    }
}
