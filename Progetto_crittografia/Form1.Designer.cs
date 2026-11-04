namespace Progetto_crittografia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_stringa = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_chiave = new System.Windows.Forms.TextBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.txt_codice = new System.Windows.Forms.TextBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.txt_chiave2 = new System.Windows.Forms.TextBox();
            this.btn_calcola2 = new System.Windows.Forms.Button();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(28, 57);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(224, 24);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "INSERISCI UNA STRINGA";
            this.lbl_n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_stringa
            // 
            this.txt_stringa.BackColor = System.Drawing.Color.LightGray;
            this.txt_stringa.Location = new System.Drawing.Point(51, 84);
            this.txt_stringa.Name = "txt_stringa";
            this.txt_stringa.Size = new System.Drawing.Size(171, 22);
            this.txt_stringa.TabIndex = 1;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(95, 127);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(70, 24);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "chiave:";
            // 
            // txt_chiave
            // 
            this.txt_chiave.BackColor = System.Drawing.Color.LightGray;
            this.txt_chiave.Location = new System.Drawing.Point(73, 154);
            this.txt_chiave.Name = "txt_chiave";
            this.txt_chiave.Size = new System.Drawing.Size(113, 22);
            this.txt_chiave.TabIndex = 3;
            // 
            // btn_conferma
            // 
            this.btn_conferma.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_conferma.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(62, 196);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(142, 32);
            this.btn_conferma.TabIndex = 4;
            this.btn_conferma.Text = "CONFERMA";
            this.btn_conferma.UseVisualStyleBackColor = false;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(83, 244);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(92, 17);
            this.lbl_n3.TabIndex = 5;
            this.lbl_n3.Text = "Risultato: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(568, 56);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(224, 24);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "INSERISCI UNA STRINGA";
            // 
            // txt_codice
            // 
            this.txt_codice.BackColor = System.Drawing.Color.LightGray;
            this.txt_codice.Location = new System.Drawing.Point(593, 83);
            this.txt_codice.Name = "txt_codice";
            this.txt_codice.Size = new System.Drawing.Size(171, 22);
            this.txt_codice.TabIndex = 8;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(646, 127);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(70, 24);
            this.lbl_n5.TabIndex = 9;
            this.lbl_n5.Text = "chiave:";
            // 
            // txt_chiave2
            // 
            this.txt_chiave2.BackColor = System.Drawing.Color.LightGray;
            this.txt_chiave2.Location = new System.Drawing.Point(625, 154);
            this.txt_chiave2.Name = "txt_chiave2";
            this.txt_chiave2.Size = new System.Drawing.Size(113, 22);
            this.txt_chiave2.TabIndex = 10;
            // 
            // btn_calcola2
            // 
            this.btn_calcola2.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_calcola2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcola2.Location = new System.Drawing.Point(610, 196);
            this.btn_calcola2.Name = "btn_calcola2";
            this.btn_calcola2.Size = new System.Drawing.Size(142, 32);
            this.btn_calcola2.TabIndex = 11;
            this.btn_calcola2.Text = "CONFERMA";
            this.btn_calcola2.UseVisualStyleBackColor = false;
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.Location = new System.Drawing.Point(637, 244);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(92, 17);
            this.lbl_n6.TabIndex = 12;
            this.lbl_n6.Text = "Risultato: ";
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(299, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(233, 45);
            this.lbl_titolo.TabIndex = 13;
            this.lbl_titolo.Text = "CIFRARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(876, 475);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.btn_calcola2);
            this.Controls.Add(this.txt_chiave2);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.txt_codice);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.txt_chiave);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txt_stringa);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_stringa;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_chiave;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.TextBox txt_codice;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.TextBox txt_chiave2;
        private System.Windows.Forms.Button btn_calcola2;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_titolo;
    }
}

