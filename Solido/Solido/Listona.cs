using System;
using System.Collections.Generic;

namespace Solido {
    class Listona : List<Solido> {
        public Listona() { }

        public string trovaMaggioreDi(double magg) {
            string risultato = "";
            int codice = 1;
            foreach(Solido s in this) {
                if (s.getPeso() > magg) {
                    risultato += (codice + "\n");
                }
                codice++;
            }
            return risultato;
        }

        public string trovaPerTipo(string tipo) {
            tipo = "Solido." + tipo;
            string risultato = "";
            int codice = 1;

            foreach(Solido s in this) {
                if(Convert.ToString(s.GetType()) == tipo) {
                    risultato += (codice + "\n");
                }
                codice++;
            }
            return risultato;
        }
    }
}