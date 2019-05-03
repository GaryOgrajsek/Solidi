namespace Solido {
    abstract class Solido {
        private double volume;
        private double peso;
        private string codice;

        protected string Codice { get => codice; set => codice = value; }
        protected double Volume { get => volume; set => volume = value; }
        protected double Peso { get => peso; set => peso = value; }

        public Solido(string c) {
            this.Codice = c;
        }

        abstract public void calcolaP(double pc);
        abstract public void calcolaV();
        abstract public double getPeso();
    }
}
