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
        //lettura dettagli lavoratore 
        //lettura dettagli stipendio
        public virtual string GetDettaglioStipendio()
        {
            return Nome+ Environment.NewLine+" :";
        }
        public Lavoratore()
        {

        }


        public abstract int Tasse();
        public override string ToString()
        {
            return "Nome : " + Nome + Environment.NewLine +
            "Cognome : " + Cognome + Environment.NewLine +
            "Età : " + Età + Environment.NewLine +
            "Data di Nascita : " + DataDiNasciata + Environment.NewLine;
        }

    }
}
