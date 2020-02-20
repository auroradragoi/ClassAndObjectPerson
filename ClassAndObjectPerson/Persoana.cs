using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjectPerson
{
    class Persoana
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int varsta { get; set; }

        // constructor implicit
        public Persoana()
        {
            nume = "";
            prenume = "";
            varsta = 0;
        }

        //constructor cu 1 parametru

        public Persoana(string nume)
        {
            this.nume = nume;
            this.prenume = "";
            this.varsta = 0;
        }

        public Persoana(string name, string firstName, int age)
        {
            this.nume = name;
            this.prenume = firstName;
            this.varsta = age;
        }

        public string afiseazaDetaliiPersoana()
        {
            return "Nume: " + nume + "\nPrenume: " + prenume + "\nVarsta: " + varsta;
        }
    }
}
