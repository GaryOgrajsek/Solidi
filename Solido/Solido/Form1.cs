using System;
using System.Windows.Forms;

namespace Solido {
    public partial class Form1 : Form {
        Listona lista;
        int codice;

        public Form1() {
            InitializeComponent();
            lista = new Listona();
            this.codice = 1;
            this.dataGridView1.Rows.Clear();
        }

        private void cbx_solido_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbx_solido.SelectedIndex) {
                case 0:
                    gpx_cilindro.Enabled = true;
                    gpx_cubo.Enabled = gpx_parall.Enabled = gpx_sfera.Enabled = false;
                    break;
                case 1:
                    gpx_cubo.Enabled = true;
                    gpx_cilindro.Enabled = gpx_parall.Enabled = gpx_sfera.Enabled = false;
                    break;
                case 2:
                    gpx_parall.Enabled = true;
                    gpx_cilindro.Enabled = gpx_cubo.Enabled = gpx_sfera.Enabled = false;
                    break;
                case 3:
                    gpx_sfera.Enabled = true;
                    gpx_cilindro.Enabled = gpx_parall.Enabled = gpx_cubo.Enabled = false;
                    break;
            }

        }

        private void btn_inserisci_Click(object sender, EventArgs e) {
            switch (cbx_solido.SelectedIndex) {
                case 0:
                    Cilindro cil = new Cilindro(Convert.ToDouble(txb_pesoSpec.Text), Convert.ToDouble(txb_raggio.Text), Convert.ToDouble(txb_altezza.Text), codice);
                    lista.Add(cil);
                    txb_pesoSpec.Text = txb_altezza.Text = txb_raggio.Text = "";
                    break;
                case 1:
                    Cubo cub = new Cubo(Convert.ToDouble(txb_pesoSpec.Text), Convert.ToDouble(txb_lato.Text), codice);
                    lista.Add(cub);
                    txb_pesoSpec.Text = txb_lato.Text = "";
                    break;
                case 2:
                    Parallelepipedo par = new Parallelepipedo (Convert.ToDouble(txb_pesoSpec.Text), Convert.ToDouble(txb_lato1.Text), Convert.ToDouble(txb_lato2.Text), Convert.ToDouble(txb_lato3.Text), codice);
                    lista.Add(par);
                    txb_pesoSpec.Text = txb_lato1.Text = txb_lato2.Text = txb_lato3.Text = "";
                    break;
                case 3:
                    Sfera sfe = new Sfera(Convert.ToDouble(txb_pesoSpec.Text), Convert.ToDouble(txb_raggioSfe.Text), codice);
                    lista.Add(sfe);
                    txb_pesoSpec.Text = txb_raggio.Text = "";
                    break;
                default:
                    MessageBox.Show("METTERE UN TIPO DI SOLIDO!!!");
                    return;
            }
            codice++;
            visualizza();
        }

        private void visualizza() {
            string[] riga = new string[9];

            foreach (Solido v in lista) {
                riga = v.ToString().Split('|');
            }

            dataGridView1.Rows.Add(riga);
        }

        private void btn_cerca_Click(object sender, EventArgs e) => MessageBox.Show(lista.trovaMaggioreDi(Convert.ToDouble(txb_maggiore.Text)));

        private void btn_cercaTipo_Click(object sender, EventArgs e) {
            string tipo = "";
            switch (cbx_solido.SelectedIndex) {
                case 0:
                    tipo = "Cilindro";
                    break;
                case 1:
                    tipo = "Cubo";
                    break;
                case 2:
                    tipo = "Parallelepipedo";
                    break;
                case 3:
                    tipo = "Sfera";
                    break;
            }
            MessageBox.Show(lista.trovaPerTipo(tipo));
        }

        private void btn_chiudi_Click(object sender, EventArgs e) => Close();
    }
}