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
            bool fine=true;
            string nome, cognome;
            int stipendioAnn;
            string insert;
            do
            {
                //creazione utnete si chiede di che tipologia deve essere l'utente per poterlo creare di quel tipo
                Console.WriteLine("Che tipo di Lavoratore si vuole inserire ?"
                    + Environment.NewLine
                    + "1 Lavoratore dipendente " + Environment.NewLine
                    + "2 Lavoratore autonomo");
                //si salva il valore in una variabile temporalle
                tem = Console.ReadLine();
                //si inseriscono i dati personali su varibile provissorie
                Console.WriteLine("Nome lavoratore : ");
                nome = Console.ReadLine();
                i = Libero(lav);
                Console.WriteLine("Cognome lavoratore : ");
                cognome = Console.ReadLine();
                //controllo che lo stipendio annuale sia un intero
                //volendo si potebebe crare un metodo della classe controllo che effetua il controllo ma 
                //essendo che comunque per coretteza di codice dovra stampare qui non ha senso imprementarre un
                // un metodo per due righe di codice
                do
                {
                    Console.WriteLine("Inserisci lo stipendio annnuale");
                    insert = Console.ReadLine();
                    if (!Int32.TryParse(insert, out a))
                    {
                        Console.WriteLine("Il valore inserito non è corretto quindi rinserisci");
                    }
                } while (!Int32.TryParse(insert, out a));
                stipendioAnn = a;
                //dentro if lacia un metodo che ritorna un buleano di tipo false se allinterno del utente essiste già il lavoratore
                if(Controllo.controlloLavoratore(nome, cognome, stipendioAnn,lav))
                {
                    //crea l'oggeto del tipo inserito e gli da i parametri inseriti in precedenza
                    tem = tem.ToUpper();
                    if (tem == "1" || tem == "LAVORATORE DIPENDENTE")
                    { 
                        lav[i] = new LavoratoreDipendete();
                        //solo per aggiungere lo spazio alla fine della crazione
                        Console.WriteLine("");
                    }
                    else if (tem == "2" || tem == "LAVORATORE AUTONOMO")
                    {
                        lav[i] = new LavoratoreAutonomo();
                        Console.WriteLine("");
                    }

                    lav[i].Nome = nome;
                    lav[i].Cognome = cognome;
                    lav[i].StipendioAnn = stipendioAnn;
                }
                else
                {
                    //se l'utete è si manda il messaggio nel quale si specifaca che il lavoratore non può essere inserito
                    Console.WriteLine("Utente già allinterno del 'DB' imposibile rinserirlo");
                }
                //si chiede al utente se desidera fare altre operazioni 
                Console.WriteLine("Vuoi inserire altri utenti?");
                tem = Console.ReadLine().ToUpper();
                //se risponde di si il codice continua se risponde in altro modo tramite il brek esce dal do whille ponendo fine al esecuzione
                if ((tem == "SI"))
                    ;
                else fine=false;

            } while (fine);
        }
        //gira gli elementi finche non ne trova uno libero in questo caso visto che si dubita che lutente inserisca
        //più di 27 lavorotori non è neccessaro controllorare se si esce della grandezza del arrey
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

            a[2] = new LavoratoreAutonomo()
            {
                Nome = "Alberto",
                Cognome = "Gambino",
                DataDiNasciata = new DateTime(1979, 12, 29),
                StipendioAnn = 70000
                
            };
        }
    }
}
