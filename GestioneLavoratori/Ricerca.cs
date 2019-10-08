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
            for (int i = 0; i < lav.Length; i++)
            {
                for (int j = 0; j < lav.Length; j++)
                {
                    if(lav[i].StipendioAnn>lav[j].StipendioAnn)
                    {

                    }
                }
            }
        }
        public static void OrdinamentoAnn(Lavoratore[] lav)
        {

        }

        internal static void RicercaNome(string ric, Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    if (lav[i].Nome.ToUpper() == ric)
                    {
                        Console.WriteLine(lav[i].GetDettaglioStipendio());
                    }
                }
            }
        }
        internal static void RicercaNum(int n, Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    Console.WriteLine(lav[i].GetDettaglioStipendio());
                    if (i+1 == n)
                        break;
                }
            }

        }

    }
}
