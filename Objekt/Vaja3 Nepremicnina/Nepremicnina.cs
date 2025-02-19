using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vaja3_Nepremicnina
{
    public class Nepremicnina
    {
        public string Ulica;
        public string HisnaStevilka;
        public string Naziv;

        public Nepremicnina(string ulica, string hisnaStevilka, string naziv)
        {
            Ulica = ulica;
            HisnaStevilka = hisnaStevilka;
            Naziv = naziv;
        }
    }
}