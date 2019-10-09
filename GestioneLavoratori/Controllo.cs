using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Controllo
    {
        //controllo se il lavoratore è gia presnsete controllo lo stipendio e non la data perchè nella media 
        //l'utente sbaglia ad inserire la data quindi non gliela faccio inserire si potra inserire in seguito con un
        //metodo che controlla bene che l'inserimeto della data sia coretto nel controolo non cabierbbe molto 
        //invece di k.StipendioAnn==stipendio ci sara k.DataDiNasciata==data e si passera al metodo un tipo data invece di un int
        public static bool controlloLavoratore(string nom,string cognome,int stipendio,Lavoratore [] lav)
        {
            bool ris = true;
            foreach (var k in lav)
            {
                if (k!=null&&k.Nome==nom && k.Cognome==cognome && k.StipendioAnn==stipendio)
                {
                    ris= false;
                    break;
                }
            }
            return ris;
        }
        public static bool altreOprezioni()
        {
            bool fine=true;
            string tem;
            //si chiede al utente se desidera fare altre operazioni 
            Console.WriteLine("Vuoi inserire altri utenti?");
            tem = Console.ReadLine().ToUpper();
            if ((tem == "SI"))
                ;
            else fine=false;
        }
    }
}
