using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreDipendete : Lavoratore
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
                return StipendioLord - ris;
            }
        }
        public DateTime DataAssunzione { get; set; }


        public override int Tasse()
        {
            if (StipendioAnn < 6000)
                return 0;
            else if (StipendioAnn < 15000)
                return 15;
            else if (StipendioAnn < 25000)
                return 30;
            else if (StipendioAnn < 35000)
                return 40;
            else return 50;
        }
    }
}
