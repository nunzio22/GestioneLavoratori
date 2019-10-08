using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreAutonomo : Lavoratore
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
                return StipendioLord-ris;
            }
        }
        public int DipendentiAssunti { get; set; }
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore() +
                "Stipendio Mensile percepito : " + StipendioNet +"$"+ Environment.NewLine+
                "Dipendenti assunti : "+ DipendentiAssunti + Environment.NewLine;
        }
        public override string GetDettaglioStipendio()
        {
            return StipendioNet + "$" + Environment.NewLine;
        }
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
