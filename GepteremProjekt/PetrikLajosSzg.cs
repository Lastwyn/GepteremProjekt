using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class PetrikLajosSzg
    {
        List<Gepterem> termek;

        public PetrikLajosSzg(List<Gepterem> termek)
        {
            this.termek = termek;
        }

        internal List<Gepterem> terem { get => termek; set => termek = value; }
    }
}
