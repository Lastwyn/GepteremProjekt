using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {
        string nev;
        int[,] ertekeles;
        int helyDb;
        int sorDb;

        public Gepterem(string nev, int[,] ertekeles, int helyDb, int sorDb)
        {
            this.nev = nev;
            this.ertekeles = ertekeles;
            this.helyDb = helyDb;
            this.sorDb = sorDb;
        }

        public string Nev { get => nev; set => nev = value; }
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }
    }
}
