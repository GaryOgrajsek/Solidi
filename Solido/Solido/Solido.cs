namespace Solido {
    abstract class Solido {
        private double volume;
        private double peso;
        private int codice;

        protected int Codice { get => codice; set => codice = value; }
        protected double Volume { get => volume; set => volume = value; }
        protected double Peso { get => peso; set => peso = value; }

        abstract public void calcolaP(double pc);
        abstract public void calcolaV();
        abstract public double getPeso();
    }
}