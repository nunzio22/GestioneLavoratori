using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreAutonomo : Lavoratore
    {

        public int StipendioAnn { get; set; }
        public int StipendioLord
        {
            get
            {
                return StipendioAnn/12;
            }
        }
        public int StipendioNet
        {
            get
            {
                int tass = Tasse();
                int ris = StipendioLord / 100;
                ris *= tass;
                return StipendioLord-ris;
            }
        }
        public DateTime DataAssunzione { get; set; }

        public override int Tasse()
        {
           if(StipendioAnn<50000)
            {
                return 15;
            }
            return 30;
        }
    }
}
