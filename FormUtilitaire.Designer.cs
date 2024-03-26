namespace Crud
{
    partial class FormUtilitaire
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
            this.btnTransfert = new System.Windows.Forms.Button();
            this.TBClair = new System.Windows.Forms.TextBox();
            this.TBCrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransfert
            // 
            this.btnTransfert.Location = new System.Drawing.Point(266, 172);
            this.btnTransfert.Name = "btnTransfert";
            this.btnTransfert.Size = new System.Drawing.Size(181, 52);
            this.btnTransfert.TabIndex = 0;
            this.btnTransfert.Text = "-->";
            this.btnTransfert.UseVisualStyleBackColor = true;
            this.btnTransfert.Click += new System.EventHandler(this.btnTransfert_Click);
            // 
            // TBClair
            // 
            this.TBClair.Location = new System.Drawing.Point(266, 87);
            this.TBClair.Multiline = true;
            this.TBClair.Name = "TBClair";
            this.TBClair.Size = new System.Drawing.Size(423, 40);
            this.TBClair.TabIndex = 1;
            // 
            // TBCrypt
            // 
            this.TBCrypt.Location = new System.Drawing.Point(266, 315);
            this.TBCrypt.Multiline = true;
            this.TBCrypt.Name = "TBCrypt";
            this.TBCrypt.Size = new System.Drawing.Size(423, 46);
            this.TBCrypt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Données en clair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Données cryptées";
            // 
            // FormUtilitaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCrypt);
            this.Controls.Add(this.TBClair);
            this.Controls.Add(this.btnTransfert);
            this.Name = "FormUtilitaire";
            this.Text = "FormUtilitaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfert;
        private System.Windows.Forms.TextBox TBClair;
        private System.Windows.Forms.TextBox TBCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}