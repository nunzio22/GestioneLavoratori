using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Inserimento
    {
        public static void insert(Lavoratore [] lav)
        {
            string tem;
            int i=0;
            int a=0;
            string insert;
            do
            {
                Console.WriteLine("Che tipo di Lavoratore si vuole inserire ?"
                    + Environment.NewLine
                    + "1 Lavoratore dipendente " + Environment.NewLine
                    + "2 Lavoratore autonomo");
                tem = Console.ReadLine();
                tem = tem.ToUpper();
                if (tem == "1" || tem == "LAVORATORE DIPENDENTE")
                {
                    i = Libero(lav);
                    lav[i] = new LavoratoreDipendete();
                    Console.WriteLine("Hai selezionato lavoratore autonomo");
                }
                else if (tem == "2" || tem == "LAVORATORE AUTONOMO")
                {
                    i = Libero(lav);
                    lav[i] = new LavoratoreAutonomo();
                    Console.WriteLine("Hai selezionato lavoratore autonomo");
                }
                Console.WriteLine("Nome lavoratore : ");
                insert = Console.ReadLine();
                lav[i].Nome = insert;
                Console.WriteLine("Cognome lavoratore : ");
                insert = Console.ReadLine();
                lav[i].Cognome = insert;
                do
                {
                    Console.WriteLine("Inserisci lo stipendio annnuale");
                    insert = Console.ReadLine();
                    if (!Int32.TryParse(insert, out a))
                    {
                        Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
                    }
                } while (!Int32.TryParse(insert, out a));
                lav[i].StipendioAnn = a;
                //si chiede al utente se desidera fare altre operazioni 
                Console.WriteLine("Vuoi inserire altri utenti?");
                tem = Console.ReadLine().ToUpper();
                //se risponde di si il codice continua se risponde in altro modo tramite il brek esce dal do whille ponendo fine al esecuzione
                if ((tem == "SI"))
                    ;
                else break;

            } while (true);
        }

        private static int Libero(Lavoratore[] lav)
        {
            for (int i = 0; i < lav.Length; i++)
            {
                if ((lav[i] == null))
                {
                    return i;
                }

            }
            return 0;
        }
        public static int insertN()
        {
            //creazioni delle variabili necessarie per l'inserimento
            string temp;
            int num1;
            do
            {
                Console.WriteLine("Inserisci il numero e premi invio");
                temp = Console.ReadLine();
                if (!Int32.TryParse(temp, out num1))
                {
                    Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
                }
            } while (!Int32.TryParse(temp, out num1));
            return num1;
        }

        public static void Prova(Lavoratore [] a)
        {
            a[0] = new LavoratoreDipendete()
            {
                Nome = "Federica",
                Cognome = "Pellegrini",
                DataDiNasciata = new DateTime(1988, 05, 25),
                StipendioAnn = 50000,
                DataAssunzione = new DateTime(1983, 7, 3)
        };
            a[1] = new LavoratoreDipendete()
            {
                Nome = "Nunzio",
                Cognome = "prova",
                DataDiNasciata = new DateTime(2000, 05, 22),
                StipendioAnn = 25000,
                DataAssunzione = new DateTime(1998, 5, 22)
            };

            a[2] = new LavoratoreDipendete()
            {
                Nome = "Alberto",
                Cognome = "Gambino",
                DataDiNasciata = new DateTime(1996, 12, 29),
                StipendioAnn = 70000,
                DataAssunzione = DateTime.Now
            };
        }
    }
}
