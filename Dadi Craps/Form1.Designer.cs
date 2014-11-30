namespace Dadi_Craps
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLancia = new System.Windows.Forms.Button();
            this.lstNum_estratti = new System.Windows.Forms.ListBox();
            this.lblRis = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pcbDado2 = new System.Windows.Forms.PictureBox();
            this.pcbDado1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLancia
            // 
            this.btnLancia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLancia.Location = new System.Drawing.Point(12, 12);
            this.btnLancia.Name = "btnLancia";
            this.btnLancia.Size = new System.Drawing.Size(83, 30);
            this.btnLancia.TabIndex = 0;
            this.btnLancia.Text = "Lancia!!";
            this.btnLancia.UseVisualStyleBackColor = false;
            this.btnLancia.Click += new System.EventHandler(this.btnLancia_Click);
            // 
            // lstNum_estratti
            // 
            this.lstNum_estratti.FormattingEnabled = true;
            this.lstNum_estratti.Location = new System.Drawing.Point(12, 183);
            this.lstNum_estratti.Name = "lstNum_estratti";
            this.lstNum_estratti.Size = new System.Drawing.Size(86, 134);
            this.lstNum_estratti.TabIndex = 2;
            // 
            // lblRis
            // 
            this.lblRis.AutoSize = true;
            this.lblRis.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRis.ForeColor = System.Drawing.Color.Lime;
            this.lblRis.Location = new System.Drawing.Point(12, 347);
            this.lblRis.Name = "lblRis";
            this.lblRis.Size = new System.Drawing.Size(43, 13);
            this.lblRis.TabIndex = 3;
            this.lblRis.Text = "START";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Location = new System.Drawing.Point(12, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pcbDado2
            // 
            this.pcbDado2.Image = ((System.Drawing.Image)(resources.GetObject("pcbDado2.Image")));
            this.pcbDado2.InitialImage = global::Dadi_Craps.Properties.Resources.Nload;
            this.pcbDado2.Location = new System.Drawing.Point(387, 26);
            this.pcbDado2.Name = "pcbDado2";
            this.pcbDado2.Size = new System.Drawing.Size(78, 66);
            this.pcbDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbDado2.TabIndex = 4;
            this.pcbDado2.TabStop = false;
            // 
            // pcbDado1
            // 
            this.pcbDado1.Image = ((System.Drawing.Image)(resources.GetObject("pcbDado1.Image")));
            this.pcbDado1.InitialImage = global::Dadi_Craps.Properties.Resources.Nload;
            this.pcbDado1.Location = new System.Drawing.Point(303, 26);
            this.pcbDado1.Name = "pcbDado1";
            this.pcbDado1.Size = new System.Drawing.Size(78, 66);
            this.pcbDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbDado1.TabIndex = 1;
            this.pcbDado1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(310, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dado 2";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLancia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Dadi_Craps.Properties.Resources.Dadi_sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(480, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pcbDado2);
            this.Controls.Add(this.lblRis);
            this.Controls.Add(this.lstNum_estratti);
            this.Controls.Add(this.pcbDado1);
            this.Controls.Add(this.btnLancia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Il gioco dei Dadi CRAPS";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancia;
        private System.Windows.Forms.PictureBox pcbDado1;
        private System.Windows.Forms.ListBox lstNum_estratti;
        private System.Windows.Forms.Label lblRis;
        private System.Windows.Forms.PictureBox pcbDado2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

