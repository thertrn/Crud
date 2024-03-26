namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnex = new System.Windows.Forms.Button();
            this.TBResult = new System.Windows.Forms.TextBox();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.btnPointInterr = new System.Windows.Forms.Button();
            this.RTBClients = new System.Windows.Forms.RichTextBox();
            this.btnRemplissage = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnAffich = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnIdent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnex
            // 
            this.btnConnex.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConnex.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnex.Location = new System.Drawing.Point(67, 98);
            this.btnConnex.Name = "btnConnex";
            this.btnConnex.Size = new System.Drawing.Size(168, 44);
            this.btnConnex.TabIndex = 0;
            this.btnConnex.Text = "Connexion";
            this.btnConnex.UseVisualStyleBackColor = false;
            // 
            // TBResult
            // 
            this.TBResult.Location = new System.Drawing.Point(67, 40);
            this.TBResult.Multiline = true;
            this.TBResult.Name = "TBResult";
            this.TBResult.Size = new System.Drawing.Size(592, 51);
            this.TBResult.TabIndex = 1;
            // 
            // btnDisconn
            // 
            this.btnDisconn.BackColor = System.Drawing.Color.Crimson;
            this.btnDisconn.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconn.Location = new System.Drawing.Point(289, 98);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(168, 44);
            this.btnDisconn.TabIndex = 2;
            this.btnDisconn.Text = "Déconnexion";
            this.btnDisconn.UseVisualStyleBackColor = false;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // btnPointInterr
            // 
            this.btnPointInterr.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointInterr.Location = new System.Drawing.Point(699, 75);
            this.btnPointInterr.Name = "btnPointInterr";
            this.btnPointInterr.Size = new System.Drawing.Size(65, 67);
            this.btnPointInterr.TabIndex = 3;
            this.btnPointInterr.Text = "?";
            this.btnPointInterr.UseVisualStyleBackColor = true;
            this.btnPointInterr.Click += new System.EventHandler(this.btnPointInterr_Click);
            // 
            // RTBClients
            // 
            this.RTBClients.Location = new System.Drawing.Point(40, 569);
            this.RTBClients.Name = "RTBClients";
            this.RTBClients.Size = new System.Drawing.Size(661, 117);
            this.RTBClients.TabIndex = 4;
            this.RTBClients.Text = "";
            // 
            // btnRemplissage
            // 
            this.btnRemplissage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemplissage.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemplissage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemplissage.Location = new System.Drawing.Point(530, 182);
            this.btnRemplissage.Name = "btnRemplissage";
            this.btnRemplissage.Size = new System.Drawing.Size(138, 47);
            this.btnRemplissage.TabIndex = 5;
            this.btnRemplissage.Text = "Remplir";
            this.btnRemplissage.UseVisualStyleBackColor = false;
            this.btnRemplissage.Click += new System.EventHandler(this.btnRemplissage_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(35, 711);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(24, 25);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 318);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 218);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOuvrir.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrir.Location = new System.Drawing.Point(409, 235);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(131, 47);
            this.btnOuvrir.TabIndex = 8;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = false;
            //this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnAffich
            // 
            this.btnAffich.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAffich.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffich.Location = new System.Drawing.Point(289, 182);
            this.btnAffich.Name = "btnAffich";
            this.btnAffich.Size = new System.Drawing.Size(132, 47);
            this.btnAffich.TabIndex = 9;
            this.btnAffich.Text = "Afficher";
            this.btnAffich.UseVisualStyleBackColor = false;
            //this.btnAffich.Click += new System.EventHandler(this.btnAffich_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(154, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(40, 182);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 47);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Ajouter";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnIdent
            // 
            this.btnIdent.BackColor = System.Drawing.Color.Navy;
            this.btnIdent.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdent.Location = new System.Drawing.Point(506, 98);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(153, 44);
            this.btnIdent.TabIndex = 12;
            this.btnIdent.Text = "Identification";
            this.btnIdent.UseVisualStyleBackColor = false;
            this.btnIdent.Click += new System.EventHandler(this.btnIdent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 768);
            this.Controls.Add(this.btnIdent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAffich);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnRemplissage);
            this.Controls.Add(this.RTBClients);
            this.Controls.Add(this.btnPointInterr);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.TBResult);
            this.Controls.Add(this.btnConnex);
            this.Name = "Form1";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnex;
        private System.Windows.Forms.TextBox TBResult;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Button btnPointInterr;
        private System.Windows.Forms.RichTextBox RTBClients;
        private System.Windows.Forms.Button btnRemplissage;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnAffich;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnIdent;
    }
}

