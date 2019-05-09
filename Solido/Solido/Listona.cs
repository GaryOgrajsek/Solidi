using System;
using System.Collections.Generic;
using System.Linq;

namespace Solido {
    class Listona : List<Solido> {
        public Listona() { }

        public bool CercaCodice(string cod) => this.Any(s => s.getCodice() == cod);

        public string trovaMaggioreDi(double magg) {
            string risultato = "";
            List<Solido> r = this.FindAll(s => s.getPeso() > magg);
            foreach(Solido y in r) {
                risultato += y.ToString() + "\n";
            }
            return risultato;
        }

        public string trovaPerTipo(string tipo) {
            string risultato = "";
            List<Solido> ls = this.FindAll(s => (Convert.ToString(s.GetType()) == tipo));
            foreach (Solido s in ls) {
                risultato += s.ToString()+"\n";
            }
            return risultato;
        }
    }
}
