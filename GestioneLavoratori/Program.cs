using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavoratore[] lav = new Lavoratore[30];
            Lavoratore l1 = new LavoratoreDipendete();
            bool insert = false;
            Console.WriteLine("Vuoi inserire lavoratori ?");
            while(insert)
            Console.WriteLine("Che tipo di Lavoratore si vuole inserire ?" + Environment.NewLine
                + "1 Lavoratore dipendente "+ Environment.NewLine
                +"2 Lavoratore autonomo");
            lav[0] = l1; 
        }
    }
}
