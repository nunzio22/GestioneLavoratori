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
                return 1;
            }
        }
        public int StipendioNet
        {
            get
            {
                return 1;
            }
        }
        public DateTime DataAssunzione { get; set; }

        public override int Tasse()
        {
            throw new NotImplementedException();
        }
    }
}
