namespace Solido {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txb_pesoSpec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_solido = new System.Windows.Forms.ComboBox();
            this.gpx_cilindro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_altezza = new System.Windows.Forms.TextBox();
            this.txb_raggio = new System.Windows.Forms.TextBox();
            this.gpx_cubo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_lato = new System.Windows.Forms.TextBox();
            this.gpx_parall = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_lato1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_lato2 = new System.Windows.Forms.TextBox();
            this.txb_lato3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpx_sfera = new System.Windows.Forms.GroupBox();
            this.txb_raggioSfe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raggio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altezza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_maggiore = new System.Windows.Forms.TextBox();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.btn_cercaTipo = new System.Windows.Forms.Button();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpx_cilindro.SuspendLayout();
            this.gpx_cubo.SuspendLayout();
            this.gpx_parall.SuspendLayout();
            this.gpx_sfera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PesoSp";
            // 
            // txb_pesoSpec
            // 
            this.txb_pesoSpec.Location = new System.Drawing.Point(63, 30);
            this.txb_pesoSpec.Name = "txb_pesoSpec";
            this.txb_pesoSpec.Size = new System.Drawing.Size(100, 20);
            this.txb_pesoSpec.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_solido);
            this.groupBox1.Location = new System.Drawing.Point(169, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo solido";
            // 
            // cbx_solido
            // 
            this.cbx_solido.FormattingEnabled = true;
            this.cbx_solido.Items.AddRange(new object[] {
            "Cilindro",
            "Cubo",
            "Parallelepipedo",
            "Sfera"});
            this.cbx_solido.Location = new System.Drawing.Point(7, 27);
            this.cbx_solido.Name = "cbx_solido";
            this.cbx_solido.Size = new System.Drawing.Size(187, 21);
            this.cbx_solido.TabIndex = 0;
            this.cbx_solido.SelectedIndexChanged += new System.EventHandler(this.cbx_solido_SelectedIndexChanged);
            // 
            // gpx_cilindro
            // 
            this.gpx_cilindro.Controls.Add(this.txb_raggio);
            this.gpx_cilindro.Controls.Add(this.txb_altezza);
            this.gpx_cilindro.Controls.Add(this.label4);
            this.gpx_cilindro.Controls.Add(this.label3);
            this.gpx_cilindro.Location = new System.Drawing.Point(375, 10);
            this.gpx_cilindro.Name = "gpx_cilindro";
            this.gpx_cilindro.Size = new System.Drawing.Size(178, 79);
            this.gpx_cilindro.TabIndex = 5;
            this.gpx_cilindro.TabStop = false;
            this.gpx_cilindro.Text = "Cilindro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Altezza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Raggio";
            // 
            // txb_altezza
            // 
            this.txb_altezza.Location = new System.Drawing.Point(54, 17);
            this.txb_altezza.Name = "txb_altezza";
            this.txb_altezza.Size = new System.Drawing.Size(100, 20);
            this.txb_altezza.TabIndex = 2;
            // 
            // txb_raggio
            // 
            this.txb_raggio.Location = new System.Drawing.Point(54, 48);
            this.txb_raggio.Name = "txb_raggio";
            this.txb_raggio.Size = new System.Drawing.Size(100, 20);
            this.txb_raggio.TabIndex = 3;
            // 
            // gpx_cubo
            // 
            this.gpx_cubo.Controls.Add(this.txb_lato);
            this.gpx_cubo.Controls.Add(this.label5);
            this.gpx_cubo.Location = new System.Drawing.Point(559, 10);
            this.gpx_cubo.Name = "gpx_cubo";
            this.gpx_cubo.Size = new System.Drawing.Size(158, 49);
            this.gpx_cubo.TabIndex = 6;
            this.gpx_cubo.TabStop = false;
            this.gpx_cubo.Text = "Cubo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lato";
            // 
            // txb_lato
            // 
            this.txb_lato.Location = new System.Drawing.Point(41, 17);
            this.txb_lato.Name = "txb_lato";
            this.txb_lato.Size = new System.Drawing.Size(100, 20);
            this.txb_lato.TabIndex = 1;
            // 
            // gpx_parall
            // 
            this.gpx_parall.Controls.Add(this.label8);
            this.gpx_parall.Controls.Add(this.txb_lato3);
            this.gpx_parall.Controls.Add(this.txb_lato2);
            this.gpx_parall.Controls.Add(this.label7);
            this.gpx_parall.Controls.Add(this.txb_lato1);
            this.gpx_parall.Controls.Add(this.label6);
            this.gpx_parall.Location = new System.Drawing.Point(559, 61);
            this.gpx_parall.Name = "gpx_parall";
            this.gpx_parall.Size = new System.Drawing.Size(158, 108);
            this.gpx_parall.TabIndex = 7;
            this.gpx_parall.TabStop = false;
            this.gpx_parall.Text = "Parallelepipedo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lato1";
            // 
            // txb_lato1
            // 
            this.txb_lato1.Location = new System.Drawing.Point(41, 20);
            this.txb_lato1.Name = "txb_lato1";
            this.txb_lato1.Size = new System.Drawing.Size(100, 20);
            this.txb_lato1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lato2";
            // 
            // txb_lato2
            // 
            this.txb_lato2.Location = new System.Drawing.Point(41, 50);
            this.txb_lato2.Name = "txb_lato2";
            this.txb_lato2.Size = new System.Drawing.Size(100, 20);
            this.txb_lato2.TabIndex = 3;
            // 
            // txb_lato3
            // 
            this.txb_lato3.Location = new System.Drawing.Point(41, 76);
            this.txb_lato3.Name = "txb_lato3";
            this.txb_lato3.Size = new System.Drawing.Size(100, 20);
            this.txb_lato3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lato3";
            // 
            // gpx_sfera
            // 
            this.gpx_sfera.Controls.Add(this.label9);
            this.gpx_sfera.Controls.Add(this.txb_raggioSfe);
            this.gpx_sfera.Location = new System.Drawing.Point(375, 96);
            this.gpx_sfera.Name = "gpx_sfera";
            this.gpx_sfera.Size = new System.Drawing.Size(178, 57);
            this.gpx_sfera.TabIndex = 8;
            this.gpx_sfera.TabStop = false;
            this.gpx_sfera.Text = "SferaEbbasta";
            // 
            // txb_raggioSfe
            // 
            this.txb_raggioSfe.Location = new System.Drawing.Point(54, 19);
            this.txb_raggioSfe.Name = "txb_raggioSfe";
            this.txb_raggioSfe.Size = new System.Drawing.Size(100, 20);
            this.txb_raggioSfe.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Raggio";
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(16, 73);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(347, 23);
            this.btn_inserisci.TabIndex = 9;
            this.btn_inserisci.Text = "Inserisci";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codice,
            this.Tipo,
            this.Volume,
            this.Peso,
            this.Raggio,
            this.Altezza,
            this.Lato1,
            this.Lato2,
            this.Lato3});
            this.dataGridView1.Location = new System.Drawing.Point(13, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 353);
            this.dataGridView1.TabIndex = 10;
            // 
            // Codice
            // 
            this.Codice.HeaderText = "Codice";
            this.Codice.Name = "Codice";
            this.Codice.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Raggio
            // 
            this.Raggio.HeaderText = "Raggio";
            this.Raggio.Name = "Raggio";
            this.Raggio.ReadOnly = true;
            // 
            // Altezza
            // 
            this.Altezza.HeaderText = "Altezza";
            this.Altezza.Name = "Altezza";
            this.Altezza.ReadOnly = true;
            // 
            // Lato1
            // 
            this.Lato1.HeaderText = "Lato1";
            this.Lato1.Name = "Lato1";
            this.Lato1.ReadOnly = true;
            // 
            // Lato2
            // 
            this.Lato2.HeaderText = "Lato2";
            this.Lato2.Name = "Lato2";
            this.Lato2.ReadOnly = true;
            // 
            // Lato3
            // 
            this.Lato3.HeaderText = "Lato3";
            this.Lato3.Name = "Lato3";
            this.Lato3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Maggiore di";
            // 
            // txb_maggiore
            // 
            this.txb_maggiore.Location = new System.Drawing.Point(84, 118);
            this.txb_maggiore.Name = "txb_maggiore";
            this.txb_maggiore.Size = new System.Drawing.Size(100, 20);
            this.txb_maggiore.TabIndex = 12;
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(190, 116);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(75, 23);
            this.btn_cerca.TabIndex = 13;
            this.btn_cerca.Text = "Cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // btn_cercaTipo
            // 
            this.btn_cercaTipo.Location = new System.Drawing.Point(272, 116);
            this.btn_cercaTipo.Name = "btn_cercaTipo";
            this.btn_cercaTipo.Size = new System.Drawing.Size(75, 23);
            this.btn_cercaTipo.TabIndex = 14;
            this.btn_cercaTipo.Text = "Find4Type";
            this.btn_cercaTipo.UseVisualStyleBackColor = true;
            this.btn_cercaTipo.Click += new System.EventHandler(this.btn_cercaTipo_Click);
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(19, 145);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(328, 23);
            this.btn_chiudi.TabIndex = 15;
            this.btn_chiudi.Text = "Chiudi il programma";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 553);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.btn_cercaTipo);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.txb_maggiore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_inserisci);
            this.Controls.Add(this.gpx_sfera);
            this.Controls.Add(this.gpx_parall);
            this.Controls.Add(this.gpx_cubo);
            this.Controls.Add(this.gpx_cilindro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txb_pesoSpec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.gpx_cilindro.ResumeLayout(false);
            this.gpx_cilindro.PerformLayout();
            this.gpx_cubo.ResumeLayout(false);
            this.gpx_cubo.PerformLayout();
            this.gpx_parall.ResumeLayout(false);
            this.gpx_parall.PerformLayout();
            this.gpx_sfera.ResumeLayout(false);
            this.gpx_sfera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_pesoSpec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_solido;
        private System.Windows.Forms.GroupBox gpx_cilindro;
        private System.Windows.Forms.TextBox txb_raggio;
        private System.Windows.Forms.TextBox txb_altezza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpx_cubo;
        private System.Windows.Forms.TextBox txb_lato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpx_parall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_lato3;
        private System.Windows.Forms.TextBox txb_lato2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_lato1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpx_sfera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_raggioSfe;
        private System.Windows.Forms.Button btn_inserisci;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raggio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altezza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lato3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_maggiore;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.Button btn_cercaTipo;
        private System.Windows.Forms.Button btn_chiudi;
    }
}

