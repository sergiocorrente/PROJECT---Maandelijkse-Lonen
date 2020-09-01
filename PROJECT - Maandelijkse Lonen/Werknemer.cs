using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT___Maandelijkse_Lonen
{
    public  enum Geslacht { Man, Vrouw }
    public class Werknemer
    {

        public string Voornaam { get; private set; }
        
        public string Achternaam { get; private set; }
        public String Geslacht { get; private set; }

        public DateTime Indiensttreding { get; private set; }
        public string IbanNummer { get; private set; }

        public Werknemer (string voornaam,string achternaam,string geslacht,DateTime indiensttreding,string iban)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geslacht = geslacht;
            Indiensttreding = indiensttreding;
            IbanNummer = iban;

        }

        public override string ToString()
        {
            return string.Format("{0} {1} geslacht: {2} in dienst sinds {3} Rekening nummer {4} ", Voornaam,Achternaam,Geslacht,Indiensttreding.ToShortDateString(), IbanNummer);
        }
        
    }
}
