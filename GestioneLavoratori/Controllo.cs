using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Controllo
    {
        public static bool controlloLavoratore(string nom,string cognome,int stipendio,Lavoratore [] lav)
        {
            bool ris = false;
            foreach (var k in lav)
            {
                if (k!=null&&k.Nome!=nom && k.Cognome!=cognome && k.StipendioAnn!=stipendio)
                {
                    ris= true;
                    break;
                }
            }
            return ris;
        }
    }
}
