using System;
using System.Collections.Generic;

namespace Solido {
    class Listona : List<Solido> {
        public Listona() { }

        public bool CercaCodice(string cod) {
            foreach(Solido s in this) {
                if (s.getCodice() == cod) {
                    return false;
                }
            }
            return true;
        }

        public string trovaMaggioreDi(double magg) {
            string risultato = "";
            foreach(Solido s in this) {
                if (s.getPeso() > magg) {
                    risultato += (s.ToString() + "\n");
                }
            }
            return risultato;
        }

        public string trovaPerTipo(string tipo) {
            string risultato = "";

            foreach(Solido s in this) {
                if(Convert.ToString(s.GetType()) == tipo) {
                    risultato += (s.ToString() + "\n");
                }
            }
            return risultato;
        }
    }
}
