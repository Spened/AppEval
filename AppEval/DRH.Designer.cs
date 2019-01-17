namespace AppEval
{
    partial class DRH
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
            this.txtNomCritere = new System.Windows.Forms.TextBox();
            this.txtExpirationOffre = new System.Windows.Forms.TextBox();
            this.cmbChoixOffre = new System.Windows.Forms.ComboBox();
            this.lblNomCritere = new System.Windows.Forms.Label();
            this.lblCoeffCritere = new System.Windows.Forms.Label();
            this.nbCoefCritere = new System.Windows.Forms.NumericUpDown();
            this.DRHGroup = new System.Windows.Forms.GroupBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.lstCriteres = new System.Windows.Forms.ListBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).BeginInit();
            this.DRHGroup.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixOffre
            // 
            this.lblChoixOffre.AutoSize = true;
            this.lblChoixOffre.Location = new System.Drawing.Point(10, 47);
            this.lblChoixOffre.Name = "lblChoixOffre";
            this.lblChoixOffre.Size = new System.Drawing.Size(82, 13);
            this.lblChoixOffre.TabIndex = 1;
            this.lblChoixOffre.Text = "Choix de l\'offre :";
            // 
            // lblExpirationOffre
            // 
            this.lblExpirationOffre.AutoSize = true;
            this.lblExpirationOffre.Location = new System.Drawing.Point(10, 99);
            this.lblExpirationOffre.Name = "lblExpirationOffre";
            this.lblExpirationOffre.Size = new System.Drawing.Size(135, 13);
            this.lblExpirationOffre.TabIndex = 2;
            this.lblExpirationOffre.Text = "Date d\'expiration de l\'offre :";
            // 
            // lblListeCriteres
            // 
            this.lblListeCriteres.AutoSize = true;
            this.lblListeCriteres.Location = new System.Drawing.Point(10, 158);
            this.lblListeCriteres.Name = "lblListeCriteres";
            this.lblListeCriteres.Size = new System.Drawing.Size(92, 13);
            this.lblListeCriteres.TabIndex = 6;
            this.lblListeCriteres.Text = "Liste des critères :";
            // 
            // btnAjouterCritere
            // 
            this.btnAjouterCritere.Location = new System.Drawing.Point(40, 109);
            this.btnAjouterCritere.Name = "btnAjouterCritere";
            this.btnAjouterCritere.Size = new System.Drawing.Size(151, 24);
            this.btnAjouterCritere.TabIndex = 7;
            this.btnAjouterCritere.Text = "Ajouter un critère";
            this.btnAjouterCritere.UseVisualStyleBackColor = true;
            this.btnAjouterCritere.Click += new System.EventHandler(this.btnAjouterCritere_Click);
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(40, 35);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(151, 20);
            this.txtNomCritere.TabIndex = 9;
            // 
            // txtExpirationOffre
            // 
            this.txtExpirationOffre.Location = new System.Drawing.Point(191, 97);
            this.txtExpirationOffre.Name = "txtExpirationOffre";
            this.txtExpirationOffre.Size = new System.Drawing.Size(226, 20);
            this.txtExpirationOffre.TabIndex = 10;
            // 
            // cmbChoixOffre
            // 
            this.cmbChoixOffre.FormattingEnabled = true;
            this.cmbChoixOffre.Location = new System.Drawing.Point(191, 45);
            this.cmbChoixOffre.Name = "cmbChoixOffre";
            this.cmbChoixOffre.Size = new System.Drawing.Size(226, 21);
            this.cmbChoixOffre.TabIndex = 12;
            this.cmbChoixOffre.SelectedIndexChanged += new System.EventHandler(this.cmbChoixOffre_SelectedIndexChanged);
            // 
            // lblNomCritere
            // 
            this.lblNomCritere.AutoSize = true;
            this.lblNomCritere.Location = new System.Drawing.Point(38, 19);
            this.lblNomCritere.Name = "lblNomCritere";
            this.lblNomCritere.Size = new System.Drawing.Size(61, 13);
            this.lblNomCritere.TabIndex = 13;
            this.lblNomCritere.Text = "Nom critère";
            // 
            // lblCoeffCritere
            // 
            this.lblCoeffCritere.AutoSize = true;
            this.lblCoeffCritere.Location = new System.Drawing.Point(38, 67);
            this.lblCoeffCritere.Name = "lblCoeffCritere";
            this.lblCoeffCritere.Size = new System.Drawing.Size(89, 13);
            this.lblCoeffCritere.TabIndex = 14;
            this.lblCoeffCritere.Text = "Coefficient critère";
            // 
            // nbCoefCritere
            // 
            this.nbCoefCritere.Location = new System.Drawing.Point(40, 84);
            this.nbCoefCritere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbCoefCritere.Name = "nbCoefCritere";
            this.nbCoefCritere.Size = new System.Drawing.Size(151, 20);
            this.nbCoefCritere.TabIndex = 19;
            // 
            // DRHGroup
            // 
            this.DRHGroup.Controls.Add(this.grpAdd);
            this.DRHGroup.Controls.Add(this.lstCriteres);
            this.DRHGroup.Controls.Add(this.btnSupprimer);
            this.DRHGroup.Controls.Add(this.btnModifier);
            this.DRHGroup.Controls.Add(this.btnAjouter);
            this.DRHGroup.Controls.Add(this.lblChoixOffre);
            this.DRHGroup.Controls.Add(this.lblExpirationOffre);
            this.DRHGroup.Controls.Add(this.lblListeCriteres);
            this.DRHGroup.Controls.Add(this.cmbChoixOffre);
            this.DRHGroup.Controls.Add(this.txtExpirationOffre);
            this.DRHGroup.Location = new System.Drawing.Point(9, 10);
            this.DRHGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DRHGroup.Name = "DRHGroup";
            this.DRHGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DRHGroup.Size = new System.Drawing.Size(592, 366);
            this.DRHGroup.TabIndex = 20;
            this.DRHGroup.TabStop = false;
            this.DRHGroup.Text = "DRH";
            this.DRHGroup.Enter += new System.EventHandler(this.DRHGroup_Enter);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.lblNomCritere);
            this.grpAdd.Controls.Add(this.txtNomCritere);
            this.grpAdd.Controls.Add(this.btnAjouterCritere);
            this.grpAdd.Controls.Add(this.lblCoeffCritere);
            this.grpAdd.Controls.Add(this.nbCoefCritere);
            this.grpAdd.Location = new System.Drawing.Point(356, 196);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdd.Size = new System.Drawing.Size(221, 150);
            this.grpAdd.TabIndex = 24;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Ajouter / Modifier Offre";
            // 
            // lstCriteres
            // 
            this.lstCriteres.FormattingEnabled = true;
            this.lstCriteres.Location = new System.Drawing.Point(13, 200);
            this.lstCriteres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCriteres.Name = "lstCriteres";
            this.lstCriteres.Size = new System.Drawing.Size(140, 147);
            this.lstCriteres.TabIndex = 23;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(191, 300);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(126, 42);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(191, 251);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(126, 42);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(191, 200);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(126, 42);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // DRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 383);
            this.Controls.Add(this.DRHGroup);
            this.Name = "DRH";
            this.Text = "DRH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbCoefCritere)).EndInit();
            this.DRHGroup.ResumeLayout(false);
            this.DRHGroup.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChoixOffre;
        private System.Windows.Forms.Label lblExpirationOffre;
        private System.Windows.Forms.Label lblListeCriteres;
        private System.Windows.Forms.Button btnAjouterCritere;
        private System.Windows.Forms.TextBox txtNomCritere;
        private System.Windows.Forms.TextBox txtExpirationOffre;
        private System.Windows.Forms.ComboBox cmbChoixOffre;
        private System.Windows.Forms.Label lblNomCritere;
        private System.Windows.Forms.Label lblCoeffCritere;
        private System.Windows.Forms.NumericUpDown nbCoefCritere;
        private System.Windows.Forms.GroupBox DRHGroup;
        private System.Windows.Forms.ListBox lstCriteres;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grpAdd;
    }
}

