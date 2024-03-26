namespace Crud
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBClientNom = new System.Windows.Forms.TextBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBAdresse = new System.Windows.Forms.TextBox();
            this.TBVille = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // TBClientNom
            // 
            this.TBClientNom.Location = new System.Drawing.Point(183, 80);
            this.TBClientNom.Name = "TBClientNom";
            this.TBClientNom.Size = new System.Drawing.Size(502, 31);
            this.TBClientNom.TabIndex = 1;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(93, 346);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(126, 40);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(577, 346);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(142, 35);
            this.btnEnreg.TabIndex = 3;
            this.btnEnreg.Text = "Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresse";
            // 
            // TBAdresse
            // 
            this.TBAdresse.Location = new System.Drawing.Point(183, 156);
            this.TBAdresse.Name = "TBAdresse";
            this.TBAdresse.Size = new System.Drawing.Size(502, 31);
            this.TBAdresse.TabIndex = 5;
            // 
            // TBVille
            // 
            this.TBVille.Location = new System.Drawing.Point(183, 235);
            this.TBVille.Name = "TBVille";
            this.TBVille.Size = new System.Drawing.Size(502, 31);
            this.TBVille.TabIndex = 6;
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(86, 238);
            this.Ville.Name = "Ville";
            this.Ville.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ville.Size = new System.Drawing.Size(53, 25);
            this.Ville.TabIndex = 7;
            this.Ville.Text = "Ville";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.TBVille);
            this.Controls.Add(this.TBAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.TBClientNom);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBClientNom;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBAdresse;
        private System.Windows.Forms.TextBox TBVille;
        private System.Windows.Forms.Label Ville;
    }
}