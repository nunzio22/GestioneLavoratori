using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Ricerca
    {
        public static void Lettura(Lavoratore [] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    Console.WriteLine(lav[i].GetDettaglioLavoratore());
                }
            }
        }

        public static void OrdinamentoSti(Lavoratore [] lav)
        {

        }
        public static void OrdinamentoAnn(Lavoratore[] lav)
        {

        }
    }
}
