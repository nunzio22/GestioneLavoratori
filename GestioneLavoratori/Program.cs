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
            int n;
            // creazione stringa richiesta
            string ric;
            do
            {
                // selezione ciò che si vuole fare
                Console.WriteLine(
                    "1 Stipendio mensile del lavoratore : "+ Environment.NewLine
                    +"2 Lista dei lavoratori inseriti"+ Environment.NewLine
                    +"3 Ordinamento dei Lavoratori per stipendio percepito"+ Environment.NewLine
                    +"4 Ordinamento dei lavoratori per anzianita"+Environment.NewLine
                    +"5 Inserimernto nuovo lavoratore : "+ Environment.NewLine);
                ric=Console.ReadLine();
                // serie di if di controllo su ciò che si è scelto
                if (ric=="1")
                {
                    //altra richiesta di 
                    Console.WriteLine("1 Stipendio tramite nome(Nome)" + Environment.NewLine
                                       +"2 Un numero di persone del quale si vuole vedere lo stipendio(Numero)" + Environment.NewLine
                                       +"3 Stipendio di tutti i lavoratori (Tutti) ");
                    //altro contorllo di richiesta
                    ric = Console.ReadLine().ToUpper();
                    if(ric=="1"||ric=="NOME")
                    {
                        Console.WriteLine("Inserire il nome del quale si vuole vedere lo stipendio : ");
                        ric = Console.ReadLine().ToUpper();
                        //metodo che stampa il nome e stipendio della persona cercata dal utente
                        Ricerca.RicercaNome(ric, lav);
                    }
                    else if (ric == "2"||ric=="NUMERO")
                    {
                        Console.WriteLine("Inserire il numero delle persone sulle quali si vuole controllare lo stipendio ");
                        n = Inserimento.insertN("Il numero");
                        Ricerca.RicercaNum(n, lav);

                    }
                    else if (ric == "3"||ric=="TUTTI")
                    {
                        Ricerca.RicercaNum(lav.Length, lav);
                    }
                }
                else if (ric=="2")
                {
                    Ricerca.Lettura(lav);
                }
                else if (ric == "3")
                {
                    Ricerca.OrdinamentoSti(lav);
                }
                else if (ric == "4")
                {
                    Ricerca.OrdinamentoAnn(lav);
                }
                else if (ric == "5")
                {
                    Inserimento.insert(lav);
                }

                Console.WriteLine("Vuoi vare altre operazioni?");
                ric = Console.ReadLine().ToUpper();
                //se risponde di si il codice continua se risponde in altro modo tramite il brek esce dal do whille ponendo fine al esecuzione
                if ((ric == "SI"))
                    ;
                else break;
            } while (true);
            Console.ReadLine();

        }
    }
}
