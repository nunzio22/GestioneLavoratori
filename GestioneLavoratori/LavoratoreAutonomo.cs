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
        /// <summary>
        /// ovveride del metodo dettagli stipendio del oggeto lavoratore autonomo
        /// </summary>
        /// <returns>ritorna una stringa con i dettagli stipendio del oggeto</returns>
        public override string GetDettaglioStipendio()
        {
            return base.GetDettaglioStipendio()+
                StipendioNet + "$" + Environment.NewLine;
        }
        /// <summary>
        /// ovveride del metodo to string del oggeto lavoratore autonomo
        /// </summary>
        /// <returns>ritorna una stringa con i dettagli lavoratore autonomo</returns>
        public override string ToString()
        {
            return base.ToString() +
                "Stipendio Mensile percepito : " + StipendioNet + "$" + Environment.NewLine +
                "Dipendenti assunti : " + DipendentiAssunti + Environment.NewLine;
        }
        /// <summary>
        /// calcolo tasse in base allo stipendio
        /// </summary>
        /// <returns>percentuale delle tasse</returns>
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
