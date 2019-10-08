﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    abstract class Lavoratore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNasciata { get; set; }
        public int StipendioAnn { get; set; }
        public int Età
        {
            get
            {
                    int anno;
                    var annoAttuale = DateTime.Now.Year;
                    var annoDiNascita = DataDiNasciata.Year;
                    anno = annoAttuale - annoDiNascita;
                    return anno;
            }
        }

        public virtual string GetDettaglioLavoratore()
        {
            return 
            "Nome : "+ Nome + Environment.NewLine+
            "Cognome : "+ Cognome + Environment.NewLine+
            "Età : "+ Età + Environment.NewLine+
            "Data di Nascita : "+ DataDiNasciata + Environment.NewLine;
        }

        public virtual string GetDettaglioStipendio()
        {
            return Nome+ Environment.NewLine+" :";
        }


        public abstract int Tasse();

    }
}
