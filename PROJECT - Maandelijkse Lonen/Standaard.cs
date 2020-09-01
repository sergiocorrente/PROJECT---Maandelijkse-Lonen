using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PROJECT___Maandelijkse_Lonen
{
    public class Standaard : Werknemer
    {
        private decimal AantalUren;
        private decimal Loon;

        public Standaard(string voornaam, string achternaam, string geslacht, DateTime indiensttreding, string iban, decimal uren) : base(voornaam, achternaam, geslacht, indiensttreding, iban)
        {

            AantalUren = uren;

        }

        //public decimal AantalUren
        //{  

        //    get 
        //    { 
        //      return  uren
        //    }
        //    set
        //    {
        //        return uren;
        //    }


    }

        






}

