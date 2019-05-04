using System;

namespace Solido {
    class Sfera : Solido{
        private double raggio;

        public double Raggio { get => raggio; set => raggio = value; }

        public Sfera(double pc, double r, string cod) : base(cod){
            this.Raggio = r;
            calcolaV();
            calcolaP(pc);  
        }

        public override void calcolaP(double pc) => this.Peso = (pc * Volume);

        public override void calcolaV() => this.Volume = (4 / 3) * Math.PI * (raggio * raggio * raggio);

        public override string ToString() => Convert.ToString(this.Codice) + "|" + Convert.ToString(this.GetType().Name) + "|" + this.Volume + "|" + this.Peso + "|" + this.Raggio + "|" + "|" + "|" + "|";

        public override double getPeso() => Peso;

        public override string getCodice() => Codice;
    }
}
