using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ZwierzakDomowy
    {
        private string nazwa;
        private string gatunek;
        private DateTime data_urodzenia;

        public ZwierzakDomowy(string nazwa, string gatunek, DateTime data_urodzenia)
        {
            this.nazwa = nazwa;
            this.gatunek = gatunek;
            this.data_urodzenia = data_urodzenia;
        }

        public int ObliczWiek()
        {
            DateTime dzisiaj = DateTime.Now;
            int wiek = dzisiaj.Year - data_urodzenia.Year;

            if (data_urodzenia > dzisiaj)
            {
                throw new Exception("Data urodzenia wkracza w przyszłość");
            }
            else if (wiek > 25)
            {
                throw new Exception("Zwierze nie może żyć dłużej niz 25 lat");
            }
            return wiek;

        }

        public override string ToString()
        {
            int wiek;

            try
            {
                wiek = ObliczWiek();
            }
            catch (Exception e)
            {
                return $"{nazwa} ({gatunek}) - Błąd: {e.Message}";
            }
            return $"{nazwa} ({gatunek}) - Wiek: {wiek} lat";

        }

    }
}
