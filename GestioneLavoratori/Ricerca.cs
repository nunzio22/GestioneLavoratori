using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Ricerca
    {
        //semplice lettura del dettaglio lavoratore
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
        //trova il numero di oggetti dentro arrey
        public static int NumeroElementi(Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                    ;
                else
                {
                    return i;
                }
            }
            return 0;
        }
        //stampa tutti i dettagli stipendio in ordine di stipendio annuoale piu alto 
        public static void OrdinamentoSti(Lavoratore [] lav)
        {
            //chiama la funzio che mi restituisce un arrey con lo stipendio annuale in ordine
            int[] ord = OrdiStip(lav);
            for (int i = 0; i < ord.Length; i++)
            {
                    for (int y = 0; y < lav.Length; y++)
                    {
                        if (!(lav[y] == null))
                        {
                                //stampo in ordiene di ord i vari dettagli stipendio
                            if(ord[i]==lav[y].StipendioAnn)
                            Console.WriteLine(lav[y].GetDettaglioStipendio());
                    }
              }
            }
        }

        private static int[] OrdiStip(Lavoratore [] lav)
        {
            //mi salva il numero di oggetti al intetno del arrey e creo un arrey iìdi int di quella lunghezza
            int indi = NumeroElementi(lav);

            int[] ord=new int [indi];
            //do come valore dei elemenri ord il vallore dello stipendio annuaole
            for (int y  = 0; y < ord.Length; y++)
            {
                    ord[y] = lav[y].StipendioAnn;
            }
            //faccio una sorte di distint sul arrey
            ord = ord.Distinct().ToArray();
            Array.Sort(ord);
            return ord;
        }

        public static void OrdinamentoAnn(Lavoratore[] lav)
        {
            // arrey oggetto lavoratore dipendente
            LavoratoreDipendete[] ord = new LavoratoreDipendete[30];
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    if(lav[i] is LavoratoreDipendete)
                        ord[i] = (LavoratoreDipendete)lav[i];
                }
            }
            int indi = NumeroElementi(ord);
            DateTime[] v = new DateTime[indi];
            for (int y = 0; y < v.Length; y++)
            {
                v[y] = ord[y].DataAssunzione;
            }
            Array.Sort(v);
            v = v.Distinct().ToArray();

            for (int i = 0; i < v.Length; i++)
            {
                for (int y = 0; y < ord.Length; y++)
                {
                    if (!(ord[y] == null))
                    {
                        //stampo in ordiene di ord i vari dettagli stipendio
                        if (v[i] == ord[y].DataAssunzione)
                            Console.WriteLine(ord[y].GetDettaglioLavoratore());
                    }
                }
            }
        }
        //cerca il nome dentro il campo nome dei vari oggetti del arrey e lo stapa a scermo
        internal static void RicercaNome(string ric, Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    if (lav[i].Nome.ToUpper() == ric)
                    {
                        //chiama il metodo che stampa i dettaglio stipendio
                        Console.WriteLine(lav[i].GetDettaglioStipendio());
                    }
                }
            }
        }
        //stampa un numero di dettegli lavoratori in base a quanti ne chiede lutente se sono piu dei lavoratori esistenti gli stampa tutti
        internal static void RicercaNum(int n, Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if (!(lav[i] == null))
                {
                    //chiama il metodo che stampa i dettaglio stipendio
                    Console.WriteLine(lav[i].GetDettaglioStipendio());
                    if (i+1 == n)
                        break;
                }
            }

        }

    }
}
