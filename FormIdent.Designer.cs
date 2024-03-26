namespace Crud
{
    partial class FormIdent
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
            this.TBidu = new System.Windows.Forms.TextBox();
            this.labelidu = new System.Windows.Forms.Label();
            this.TBuNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.TBuPrenom = new System.Windows.Forms.TextBox();
            this.labelStatut = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelIdent = new System.Windows.Forms.Label();
            this.TBuIdent = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.TBuPWD = new System.Windows.Forms.TextBox();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.btnConnex = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBidu
            // 
            this.TBidu.Location = new System.Drawing.Point(328, 122);
            this.TBidu.Multiline = true;
            this.TBidu.Name = "TBidu";
            this.TBidu.Size = new System.Drawing.Size(429, 52);
            this.TBidu.TabIndex = 0;
            this.TBidu.TextChanged += new System.EventHandler(this.TBidu_TextChanged);
            // 
            // labelidu
            // 
            this.labelidu.AutoSize = true;
            this.labelidu.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidu.Location = new System.Drawing.Point(134, 125);
            this.labelidu.Name = "labelidu";
            this.labelidu.Size = new System.Drawing.Size(83, 25);
            this.labelidu.TabIndex = 1;
            this.labelidu.Text = "ID User";
            // 
            // TBuNom
            // 
            this.TBuNom.Location = new System.Drawing.Point(328, 217);
            this.TBuNom.Multiline = true;
            this.TBuNom.Name = "TBuNom";
            this.TBuNom.Size = new System.Drawing.Size(429, 52);
            this.TBuNom.TabIndex = 2;
            this.TBuNom.TextChanged += new System.EventHandler(this.TBuNom_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(134, 220);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(56, 25);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(134, 310);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(85, 25);
            this.labelPrenom.TabIndex = 4;
            this.labelPrenom.Text = "Prenom";
            // 
            // TBuPrenom
            // 
            this.TBuPrenom.Location = new System.Drawing.Point(328, 307);
            this.TBuPrenom.Multiline = true;
            this.TBuPrenom.Name = "TBuPrenom";
            this.TBuPrenom.Size = new System.Drawing.Size(429, 52);
            this.TBuPrenom.TabIndex = 5;
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatut.Location = new System.Drawing.Point(134, 396);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(69, 25);
            this.labelStatut.TabIndex = 6;
            this.labelStatut.Text = "Statut";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 393);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 0);
            this.textBox3.TabIndex = 7;
            // 
            // labelIdent
            // 
            this.labelIdent.AutoSize = true;
            this.labelIdent.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdent.Location = new System.Drawing.Point(134, 480);
            this.labelIdent.Name = "labelIdent";
            this.labelIdent.Size = new System.Drawing.Size(106, 25);
            this.labelIdent.TabIndex = 8;
            this.labelIdent.Text = "Identifiant";
            // 
            // TBuIdent
            // 
            this.TBuIdent.Location = new System.Drawing.Point(328, 477);
            this.TBuIdent.Multiline = true;
            this.TBuIdent.Name = "TBuIdent";
            this.TBuIdent.Size = new System.Drawing.Size(429, 52);
            this.TBuIdent.TabIndex = 9;
            this.TBuIdent.TextChanged += new System.EventHandler(this.TBuIdent_TextChanged);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.Location = new System.Drawing.Point(134, 568);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(104, 25);
            this.labelMdp.TabIndex = 10;
            this.labelMdp.Text = "Password";
            // 
            // TBuPWD
            // 
            this.TBuPWD.Location = new System.Drawing.Point(328, 565);
            this.TBuPWD.Multiline = true;
            this.TBuPWD.Name = "TBuPWD";
            this.TBuPWD.Size = new System.Drawing.Size(429, 52);
            this.TBuPWD.TabIndex = 11;
            this.TBuPWD.TextChanged += new System.EventHandler(this.TBuPWD_TextChanged);
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
            "1 - Admin",
            "2 - Opéra"});
            this.comboBoxStatut.Location = new System.Drawing.Point(328, 393);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(429, 33);
            this.comboBoxStatut.TabIndex = 12;
            this.comboBoxStatut.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatut_SelectedIndexChanged);
            // 
            // btnConnex
            // 
            this.btnConnex.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnex.Location = new System.Drawing.Point(601, 648);
            this.btnConnex.Name = "btnConnex";
            this.btnConnex.Size = new System.Drawing.Size(156, 52);
            this.btnConnex.TabIndex = 13;
            this.btnConnex.Text = "Connexion";
            this.btnConnex.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(328, 648);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormIdent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1001, 795);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnex);
            this.Controls.Add(this.comboBoxStatut);
            this.Controls.Add(this.TBuPWD);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.TBuIdent);
            this.Controls.Add(this.labelIdent);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.TBuPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.TBuNom);
            this.Controls.Add(this.labelidu);
            this.Controls.Add(this.TBidu);
            this.Name = "FormIdent";
            this.Text = "FormIdent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBidu;
        private System.Windows.Forms.Label labelidu;
        private System.Windows.Forms.TextBox TBuNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox TBuPrenom;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelIdent;
        private System.Windows.Forms.TextBox TBuIdent;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox TBuPWD;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.Button btnConnex;
        private System.Windows.Forms.Button btnCancel;
    }
}