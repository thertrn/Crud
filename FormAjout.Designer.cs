namespace Crud
{
    partial class FormAjout
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
            this.labelNomNew = new System.Windows.Forms.Label();
            this.TBnomNew = new System.Windows.Forms.TextBox();
            this.TBprenNew = new System.Windows.Forms.TextBox();
            this.TBloginNew = new System.Windows.Forms.TextBox();
            this.TBpasswdNew = new System.Windows.Forms.TextBox();
            this.CBStatutNew = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomNew
            // 
            this.labelNomNew.AutoSize = true;
            this.labelNomNew.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomNew.Location = new System.Drawing.Point(102, 84);
            this.labelNomNew.Name = "labelNomNew";
            this.labelNomNew.Size = new System.Drawing.Size(64, 29);
            this.labelNomNew.TabIndex = 0;
            this.labelNomNew.Text = "Nom";
            this.labelNomNew.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBnomNew
            // 
            this.TBnomNew.Location = new System.Drawing.Point(236, 81);
            this.TBnomNew.Multiline = true;
            this.TBnomNew.Name = "TBnomNew";
            this.TBnomNew.Size = new System.Drawing.Size(571, 47);
            this.TBnomNew.TabIndex = 5;
            // 
            // TBprenNew
            // 
            this.TBprenNew.Location = new System.Drawing.Point(236, 184);
            this.TBprenNew.Multiline = true;
            this.TBprenNew.Name = "TBprenNew";
            this.TBprenNew.Size = new System.Drawing.Size(571, 47);
            this.TBprenNew.TabIndex = 6;
            // 
            // TBloginNew
            // 
            this.TBloginNew.Location = new System.Drawing.Point(236, 279);
            this.TBloginNew.Multiline = true;
            this.TBloginNew.Name = "TBloginNew";
            this.TBloginNew.Size = new System.Drawing.Size(571, 47);
            this.TBloginNew.TabIndex = 7;
            // 
            // TBpasswdNew
            // 
            this.TBpasswdNew.Location = new System.Drawing.Point(236, 383);
            this.TBpasswdNew.Multiline = true;
            this.TBpasswdNew.Name = "TBpasswdNew";
            this.TBpasswdNew.Size = new System.Drawing.Size(571, 47);
            this.TBpasswdNew.TabIndex = 8;
            // 
            // CBStatutNew
            // 
            this.CBStatutNew.FormattingEnabled = true;
            this.CBStatutNew.Location = new System.Drawing.Point(236, 486);
            this.CBStatutNew.Name = "CBStatutNew";
            this.CBStatutNew.Size = new System.Drawing.Size(571, 33);
            this.CBStatutNew.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(873, 84);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 69);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(102, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mdp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Statut";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(873, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1102, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.CBStatutNew);
            this.Controls.Add(this.TBpasswdNew);
            this.Controls.Add(this.TBloginNew);
            this.Controls.Add(this.TBprenNew);
            this.Controls.Add(this.TBnomNew);
            this.Controls.Add(this.labelNomNew);
            this.Name = "FormAjout";
            this.Text = "FormAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomNew;
        private System.Windows.Forms.TextBox TBnomNew;
        private System.Windows.Forms.TextBox TBprenNew;
        private System.Windows.Forms.TextBox TBloginNew;
        private System.Windows.Forms.TextBox TBpasswdNew;
        private System.Windows.Forms.ComboBox CBStatutNew;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}