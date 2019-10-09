using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreDipendete : Lavoratore
    {
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
        //public Tipo livel { get; set; }

   
        public override string ToString()
        {
            return base.ToString() +
                "Stipendio Mensile percepito : " + StipendioNet + "$" + Environment.NewLine +
                "Data di assunzione : " + DataAssunzione + Environment.NewLine;
        }
        public override string GetDettaglioStipendio()
        {
            return base.GetDettaglioStipendio()+ 
                StipendioNet+"$" + Environment.NewLine;
        }

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
