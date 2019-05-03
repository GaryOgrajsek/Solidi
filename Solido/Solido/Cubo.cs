using System;

namespace Solido {
    class Cubo : Solido{
        private double lato;

        public double Lato { get => lato; set => lato = value; }

        public Cubo(double pc, double l, string cod) : base(cod) {
            this.Lato = l;
            calcolaV();
            calcolaP(pc);     
        }

        public override void calcolaP(double pc) => this.Peso = (pc * Volume);

        public override void calcolaV() => this.Volume = Lato * Lato * Lato;

        public override string ToString() => Convert.ToString(this.Codice) + "|" + Convert.ToString(this.GetType().Name) + "|" + this.Volume + "|" + this.Peso + "|" + "|" + "|" + this.Lato + "|" + "|";

        public override double getPeso() => Peso;
    }
}
