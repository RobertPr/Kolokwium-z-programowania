using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Lekarz : Osoba
    {
        private string specialnosc;

        public Lekarz(string imienazwisko, string specialnosc)
        {
            base.imieNazwisko = imienazwisko;
            this.specialnosc = specialnosc;
        }

        public override string ToString()
        {
            return "Lekarz, imie i nazwisko: " + imieNazwisko + " specialnosc: " + specialnosc;
        }
    }
}
