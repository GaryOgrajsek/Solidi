using System;

namespace Solido {
    class Cilindro : Solido{
        private double raggio;
        private double altezza;

        public double Raggio { get => raggio; set => raggio = value; }
        public double Altezza { get => altezza; set => altezza = value; }

        public Cilindro(double pc, double r, double a, string cod) : base(cod) {
            this.Raggio = r;
            this.Altezza = a;
            calcolaV();
            calcolaP(pc);
        }

        public override void calcolaP(double pc) => this.Peso = (pc * Volume);

        public override void calcolaV() => this.Volume = Math.PI * (Raggio * Raggio) * Altezza;

        public override string ToString() => Convert.ToString(this.Codice) + "|" + Convert.ToString(this.GetType().Name) + "|" + this.Volume + "|" + this.Peso + "|" + this.Raggio + "|" + this.Altezza + "|" + "|" + "|";

        public override double getPeso() => Peso;

        public override string getCodice() => Codice;
    }
}
