using System;

namespace Solido {
    class Parallelepipedo : Solido{
        private double lato1;
        private double lato2;
        private double lato3;

        public double Lato1 { get => lato1; set => lato1 = value; }
        public double Lato2 { get => lato2; set => lato2 = value; }
        public double Lato3 { get => lato3; set => lato3 = value; }

        public Parallelepipedo(double pc, double l1, double l2, double l3, int cod) {
            this.Lato1 = l1;
            this.Lato2 = l2;
            this.Lato3 = l3;
            this.Codice = cod;
            calcolaV();
            calcolaP(pc);
        }

        public override void calcolaP(double pc) => this.Peso = (pc * Volume);

        public override void calcolaV() => this.Volume = Lato1 * Lato2 * Lato3;

        public override string ToString() => Convert.ToString(this.Codice) + "|" + Convert.ToString(this.GetType().Name) + "|" + this.Volume + "|" + this.Peso + "|" + "|" + "|" + this.Lato1 + "|" + this.Lato2 + "|" + this.Lato3;

        public override double getPeso() => Peso;
    }
}