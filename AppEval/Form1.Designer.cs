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
            this.nbCoefCritere = new System.Windows.Forms.NumericUpDown();
            this.DRHGroup = new System.Windows.Forms.GroupBox();
            this.RHGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).BeginInit();
            this.DRHGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixOffre
            // 
            this.lblChoixOffre.AutoSize = true;
            this.lblChoixOffre.Location = new System.Drawing.Point(14, 58);
            this.lblChoixOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixOffre.Name = "lblChoixOffre";
            this.lblChoixOffre.Size = new System.Drawing.Size(109, 17);
            this.lblChoixOffre.TabIndex = 1;
            this.lblChoixOffre.Text = "Choix de l\'offre :";
            // 
            // lblExpirationOffre
            // 
            this.lblExpirationOffre.AutoSize = true;
            this.lblExpirationOffre.Location = new System.Drawing.Point(14, 122);
            this.lblExpirationOffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationOffre.Name = "lblExpirationOffre";
            this.lblExpirationOffre.Size = new System.Drawing.Size(181, 17);
            this.lblExpirationOffre.TabIndex = 2;
            this.lblExpirationOffre.Text = "Date d\'expiration de l\'offre :";
            // 
            // lblListeCriteres
            // 
            this.lblListeCriteres.AutoSize = true;
            this.lblListeCriteres.Location = new System.Drawing.Point(14, 195);
            this.lblListeCriteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeCriteres.Name = "lblListeCriteres";
            this.lblListeCriteres.Size = new System.Drawing.Size(124, 17);
            this.lblListeCriteres.TabIndex = 6;
            this.lblListeCriteres.Text = "Liste des critères :";
            // 
            // btnAjouterCritere
            // 
            this.btnAjouterCritere.Location = new System.Drawing.Point(255, 386);
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
            this.lstCriteres.Location = new System.Drawing.Point(18, 248);
            this.lstCriteres.Margin = new System.Windows.Forms.Padding(4);
            this.lstCriteres.Name = "lstCriteres";
            this.lstCriteres.Size = new System.Drawing.Size(175, 166);
            this.lstCriteres.TabIndex = 8;
            this.lstCriteres.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(255, 295);
            this.txtNomCritere.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(200, 22);
            this.txtNomCritere.TabIndex = 9;
            // 
            // txtExpirationOffre
            // 
            this.txtExpirationOffre.Location = new System.Drawing.Point(255, 119);
            this.txtExpirationOffre.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpirationOffre.Name = "txtExpirationOffre";
            this.txtExpirationOffre.Size = new System.Drawing.Size(300, 22);
            this.txtExpirationOffre.TabIndex = 10;
            // 
            // cmbChoixOffre
            // 
            this.cmbChoixOffre.FormattingEnabled = true;
            this.cmbChoixOffre.Location = new System.Drawing.Point(255, 55);
            this.cmbChoixOffre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoixOffre.Name = "cmbChoixOffre";
            this.cmbChoixOffre.Size = new System.Drawing.Size(300, 24);
            this.cmbChoixOffre.TabIndex = 12;
            this.cmbChoixOffre.SelectedIndexChanged += new System.EventHandler(this.cmbChoixOffre_SelectedIndexChanged);
            // 
            // lblNomCritere
            // 
            this.lblNomCritere.AutoSize = true;
            this.lblNomCritere.Location = new System.Drawing.Point(251, 275);
            this.lblNomCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCritere.Name = "lblNomCritere";
            this.lblNomCritere.Size = new System.Drawing.Size(81, 17);
            this.lblNomCritere.TabIndex = 13;
            this.lblNomCritere.Text = "Nom critère";
            // 
            // lblCoeffCritere
            // 
            this.lblCoeffCritere.AutoSize = true;
            this.lblCoeffCritere.Location = new System.Drawing.Point(251, 334);
            this.lblCoeffCritere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoeffCritere.Name = "lblCoeffCritere";
            this.lblCoeffCritere.Size = new System.Drawing.Size(118, 17);
            this.lblCoeffCritere.TabIndex = 14;
            this.lblCoeffCritere.Text = "Coefficient critère";
            // 
            // nbCoefCritere
            // 
            this.nbCoefCritere.Location = new System.Drawing.Point(255, 355);
            this.nbCoefCritere.Name = "nbCoefCritere";
            this.nbCoefCritere.Size = new System.Drawing.Size(201, 22);
            this.nbCoefCritere.TabIndex = 19;
            // 
            // DRHGroup
            // 
            this.DRHGroup.Controls.Add(this.lstCriteres);
            this.DRHGroup.Controls.Add(this.nbCoefCritere);
            this.DRHGroup.Controls.Add(this.lblChoixOffre);
            this.DRHGroup.Controls.Add(this.lblCoeffCritere);
            this.DRHGroup.Controls.Add(this.lblExpirationOffre);
            this.DRHGroup.Controls.Add(this.lblNomCritere);
            this.DRHGroup.Controls.Add(this.lblListeCriteres);
            this.DRHGroup.Controls.Add(this.cmbChoixOffre);
            this.DRHGroup.Controls.Add(this.btnAjouterCritere);
            this.DRHGroup.Controls.Add(this.txtExpirationOffre);
            this.DRHGroup.Controls.Add(this.txtNomCritere);
            this.DRHGroup.Location = new System.Drawing.Point(12, 12);
            this.DRHGroup.Name = "DRHGroup";
            this.DRHGroup.Size = new System.Drawing.Size(569, 451);
            this.DRHGroup.TabIndex = 20;
            this.DRHGroup.TabStop = false;
            this.DRHGroup.Text = "DRH";
            // 
            // RHGroup
            // 
            this.RHGroup.Location = new System.Drawing.Point(599, 13);
            this.RHGroup.Name = "RHGroup";
            this.RHGroup.Size = new System.Drawing.Size(600, 450);
            this.RHGroup.TabIndex = 21;
            this.RHGroup.TabStop = false;
            this.RHGroup.Text = "RH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 554);
            this.Controls.Add(this.RHGroup);
            this.Controls.Add(this.DRHGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).EndInit();
            this.DRHGroup.ResumeLayout(false);
            this.DRHGroup.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.NumericUpDown nbCoefCritere;
        private System.Windows.Forms.GroupBox DRHGroup;
        private System.Windows.Forms.GroupBox RHGroup;
    }
}

