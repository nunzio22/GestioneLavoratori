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
            Inserimento.Prova(lav);
            Inserimento.insert(lav);
            Ricerca.Lettura(lav);
            Console.ReadLine();

        }
    }
}
