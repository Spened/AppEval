namespace AppEval
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
            this.lblChoixOffre = new System.Windows.Forms.Label();
            this.lblExpirationOffre = new System.Windows.Forms.Label();
            this.lblListeCriteres = new System.Windows.Forms.Label();
            this.btnAjouterCritere = new System.Windows.Forms.Button();
            this.lstCriteres = new System.Windows.Forms.ListView();
            this.txtNomCritere = new System.Windows.Forms.TextBox();
            this.txtExpirationOffre = new System.Windows.Forms.TextBox();
            this.cmbChoixOffre = new System.Windows.Forms.ComboBox();
            this.lblNomCritere = new System.Windows.Forms.Label();
            this.lblCoeffCritere = new System.Windows.Forms.Label();
            this.lblIdCritere = new System.Windows.Forms.Label();
            this.nbIdCritere = new System.Windows.Forms.NumericUpDown();
            this.nbCoefCritere = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbIdCritere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoixOffre
            // 
            this.lblChoixOffre.AutoSize = true;
            this.lblChoixOffre.Location = new System.Drawing.Point(68, 50);
            this.lblChoixOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixOffre.Name = "lblChoixOffre";
            this.lblChoixOffre.Size = new System.Drawing.Size(109, 17);
            this.lblChoixOffre.TabIndex = 1;
            this.lblChoixOffre.Text = "Choix de l\'offre :";
            // 
            // lblExpirationOffre
            // 
            this.lblExpirationOffre.AutoSize = true;
            this.lblExpirationOffre.Location = new System.Drawing.Point(68, 114);
            this.lblExpirationOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationOffre.Name = "lblExpirationOffre";
            this.lblExpirationOffre.Size = new System.Drawing.Size(181, 17);
            this.lblExpirationOffre.TabIndex = 2;
            this.lblExpirationOffre.Text = "Date d\'expiration de l\'offre :";
            // 
            // lblListeCriteres
            // 
            this.lblListeCriteres.AutoSize = true;
            this.lblListeCriteres.Location = new System.Drawing.Point(68, 187);
            this.lblListeCriteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeCriteres.Name = "lblListeCriteres";
            this.lblListeCriteres.Size = new System.Drawing.Size(124, 17);
            this.lblListeCriteres.TabIndex = 6;
            this.lblListeCriteres.Text = "Liste des critères :";
            // 
            // btnAjouterCritere
            // 
            this.btnAjouterCritere.Location = new System.Drawing.Point(309, 378);
            this.btnAjouterCritere.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterCritere.Name = "btnAjouterCritere";
            this.btnAjouterCritere.Size = new System.Drawing.Size(201, 30);
            this.btnAjouterCritere.TabIndex = 7;
            this.btnAjouterCritere.Text = "Ajouter un critère";
            this.btnAjouterCritere.UseVisualStyleBackColor = true;
            this.btnAjouterCritere.Click += new System.EventHandler(this.btnAjouterCritere_Click);
            // 
            // lstCriteres
            // 
            this.lstCriteres.Location = new System.Drawing.Point(72, 240);
            this.lstCriteres.Margin = new System.Windows.Forms.Padding(4);
            this.lstCriteres.Name = "lstCriteres";
            this.lstCriteres.Size = new System.Drawing.Size(175, 166);
            this.lstCriteres.TabIndex = 8;
            this.lstCriteres.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(309, 287);
            this.txtNomCritere.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(200, 22);
            this.txtNomCritere.TabIndex = 9;
            // 
            // txtExpirationOffre
            // 
            this.txtExpirationOffre.Location = new System.Drawing.Point(309, 111);
            this.txtExpirationOffre.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpirationOffre.Name = "txtExpirationOffre";
            this.txtExpirationOffre.Size = new System.Drawing.Size(300, 22);
            this.txtExpirationOffre.TabIndex = 10;
            // 
            // cmbChoixOffre
            // 
            this.cmbChoixOffre.FormattingEnabled = true;
            this.cmbChoixOffre.Location = new System.Drawing.Point(309, 47);
            this.cmbChoixOffre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoixOffre.Name = "cmbChoixOffre";
            this.cmbChoixOffre.Size = new System.Drawing.Size(300, 24);
            this.cmbChoixOffre.TabIndex = 12;
            this.cmbChoixOffre.SelectedIndexChanged += new System.EventHandler(this.cmbChoixOffre_SelectedIndexChanged);
            // 
            // lblNomCritere
            // 
            this.lblNomCritere.AutoSize = true;
            this.lblNomCritere.Location = new System.Drawing.Point(305, 267);
            this.lblNomCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCritere.Name = "lblNomCritere";
            this.lblNomCritere.Size = new System.Drawing.Size(81, 17);
            this.lblNomCritere.TabIndex = 13;
            this.lblNomCritere.Text = "Nom critère";
            // 
            // lblCoeffCritere
            // 
            this.lblCoeffCritere.AutoSize = true;
            this.lblCoeffCritere.Location = new System.Drawing.Point(305, 326);
            this.lblCoeffCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoeffCritere.Name = "lblCoeffCritere";
            this.lblCoeffCritere.Size = new System.Drawing.Size(118, 17);
            this.lblCoeffCritere.TabIndex = 14;
            this.lblCoeffCritere.Text = "Coefficient critère";
            // 
            // lblIdCritere
            // 
            this.lblIdCritere.AutoSize = true;
            this.lblIdCritere.Location = new System.Drawing.Point(305, 210);
            this.lblIdCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCritere.Name = "lblIdCritere";
            this.lblIdCritere.Size = new System.Drawing.Size(65, 17);
            this.lblIdCritere.TabIndex = 16;
            this.lblIdCritere.Text = "ID critère";
            // 
            // nbIdCritere
            // 
            this.nbIdCritere.Location = new System.Drawing.Point(308, 240);
            this.nbIdCritere.Name = "nbIdCritere";
            this.nbIdCritere.Size = new System.Drawing.Size(201, 22);
            this.nbIdCritere.TabIndex = 18;
            // 
            // nbCoefCritere
            // 
            this.nbCoefCritere.Location = new System.Drawing.Point(309, 347);
            this.nbCoefCritere.Name = "nbCoefCritere";
            this.nbCoefCritere.Size = new System.Drawing.Size(201, 22);
            this.nbCoefCritere.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.nbCoefCritere);
            this.Controls.Add(this.nbIdCritere);
            this.Controls.Add(this.lblIdCritere);
            this.Controls.Add(this.lblCoeffCritere);
            this.Controls.Add(this.lblNomCritere);
            this.Controls.Add(this.cmbChoixOffre);
            this.Controls.Add(this.txtExpirationOffre);
            this.Controls.Add(this.txtNomCritere);
            this.Controls.Add(this.lstCriteres);
            this.Controls.Add(this.btnAjouterCritere);
            this.Controls.Add(this.lblListeCriteres);
            this.Controls.Add(this.lblExpirationOffre);
            this.Controls.Add(this.lblChoixOffre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbIdCritere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixOffre;
        private System.Windows.Forms.Label lblExpirationOffre;
        private System.Windows.Forms.Label lblListeCriteres;
        private System.Windows.Forms.Button btnAjouterCritere;
        private System.Windows.Forms.ListView lstCriteres;
        private System.Windows.Forms.TextBox txtNomCritere;
        private System.Windows.Forms.TextBox txtExpirationOffre;
        private System.Windows.Forms.ComboBox cmbChoixOffre;
        private System.Windows.Forms.Label lblNomCritere;
        private System.Windows.Forms.Label lblCoeffCritere;
        private System.Windows.Forms.Label lblIdCritere;
        private System.Windows.Forms.NumericUpDown nbIdCritere;
        private System.Windows.Forms.NumericUpDown nbCoefCritere;
    }
}

