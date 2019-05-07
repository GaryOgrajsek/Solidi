using System;
using System.Collections.Generic;
using System.Linq;

namespace Solido {
    class Listona : List<Solido> {
        public Listona() { }

        public bool CercaCodice(string cod) {
            return this.Any(s => s.getCodice() == cod);
        }

        public string trovaMaggioreDi(double magg) {
            return "NonFinito";
            /*IEnumerable<Solido> r = this.All(s => s.getPeso() > magg);
<//var l = FindAll();
            return Convert.ToString(r);*/
        }

        public string trovaPerTipo(string tipo) {
            string risultato = "";
            risultato = Convert.ToString(this.FindAll(s => Convert.ToString(s.GetType()).Equals(tipo)));
            /*foreach (Solido s in this) {
                if(Convert.ToString(s.GetType()) == tipo) {
                    risultato += (s.ToString() + "\n");
                }
            }*/
            return risultato;
        }
    }
}
