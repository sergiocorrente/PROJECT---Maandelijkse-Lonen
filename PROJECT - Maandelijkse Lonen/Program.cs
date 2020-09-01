using System;
using System.Reflection.PortableExecutable;

namespace PROJECT___Maandelijkse_Lonen
{
    class Program
    {
        static void Main(string[] args)
        {
            Werknemer werknemer1 = new Werknemer("sergio", "corrente", "Man", new DateTime(2013, 1, 23), "BE3100656012");
            
            Console.WriteLine(werknemer1);
            Console.ReadLine();
        
        }
    }
}
