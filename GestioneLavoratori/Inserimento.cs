using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Inserimento
    {
        /// <summary>
        /// insserimento di nuovi lavoratori 
        /// </summary>
        /// <param name="lav">arrey dove vengono inseriti i lavoratori</param>
        public static void insert(Lavoratore [] lav)
        {
            string tem;
            int i=0;
            bool fine;
            string nome, cognome;
            int stipendioAnn;
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
                Console.WriteLine("Cognome lavoratore : ");
                cognome = Console.ReadLine();
                stipendioAnn = insertN("lo stipendio annuale");
                //dentro if lacia un metodo che ritorna un buleano di tipo false se allinterno del utente essiste già il lavoratore
                i = Libero(lav);
                if (i != 0)
                {
                    if (Controllo.controlloLavoratore(nome, cognome, stipendioAnn, lav))
                    {
                        //controllo la posizione liberea del arrey

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
                }
                else
                {
                    Console.WriteLine("Inseriti i numeri massimo di lavoratori impossibile aggiungere altri lavorator");
                    break;
                }
              fine = Controllo.altreOprezioni("inserire altri utenti");
            } while (fine);
        }
        //gira gli elementi finche non ne trova uno libero in questo caso visto che si dubita che lutente inserisca
        /// <summary>
        /// gira l'arrey dei lavoratori e trova lo spazio libero
        /// </summary>
        /// <param name="lav">l'arrey di tipo lavoratore</param>
        /// <returns>Il numero della cella llibera del arrey lavoratore</returns>
        public static int Libero(Lavoratore[] lav)
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
        /// <summary>
        /// l'inserimenento del numero dentro una varibile da stringa gestendo le varie eccezioni
        /// </summary>
        /// <param name="pr">stringa che distingue la richiesta che si vuole fare</param>
        /// <exception cref="NumeroException"></exception>
        /// <returns>ritorna un intero scritto dal utente</returns>
        ///    
        public static int insertN(string pr)
        {
            //creazioni delle variabili necessarie per l'inserimento
            string temp;
            int num1=0;
            bool fine = true;
            do
            {
                Console.WriteLine("Inserisci {0} e premi invio",pr);
                temp = Console.ReadLine();
                try
                {
                    num1 = Eccezione(temp);
                    fine = false;
                }
                catch (NumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } while (fine);
            return num1;
        }
        /// <summary>
        /// distingue le varie eccezioni del inserimento di una stringa al interno di un inti
        /// </summary>
        /// <param name="temp">la stringa contente il valore scritto dal utente</param>
        /// <returns>intero con il contenuto della stringra o ritorna il tipo di eccezione</returns>

        private static int Eccezione(string temp)
        {
            int n;
            try
            {
                n = Int32.Parse(temp);
                return n;
            }
            catch (ArgumentNullException)
            {
                throw new NumeroException("Il varore è null");
            }
            catch (FormatException)
            {
                throw new NumeroException("Il varore inserito non è un intero");
            }
            catch (OverflowException)
            {
                throw new NumeroException("Il varore inserito è troppo grande");
            }
            catch (Exception)
            {
                throw new NumeroException("Il varore inserito non va bene");
            }

        }

        //creazione dei lavoratori base che ci saranno sempre
        /// <summary>
        /// inserimento automatico di lavoratori
        /// </summary>
        /// <param name="a">arrey lavoratore</param>
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
