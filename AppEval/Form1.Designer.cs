﻿namespace AppEval
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
            this.txtCoeffCritere = new System.Windows.Forms.TextBox();
            this.lblIdCritere = new System.Windows.Forms.Label();
            this.txtIdCritere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblChoixOffre
            // 
            this.lblChoixOffre.AutoSize = true;
            this.lblChoixOffre.Location = new System.Drawing.Point(51, 41);
            this.lblChoixOffre.Name = "lblChoixOffre";
            this.lblChoixOffre.Size = new System.Drawing.Size(82, 13);
            this.lblChoixOffre.TabIndex = 1;
            this.lblChoixOffre.Text = "Choix de l\'offre :";
            // 
            // lblExpirationOffre
            // 
            this.lblExpirationOffre.AutoSize = true;
            this.lblExpirationOffre.Location = new System.Drawing.Point(51, 93);
            this.lblExpirationOffre.Name = "lblExpirationOffre";
            this.lblExpirationOffre.Size = new System.Drawing.Size(135, 13);
            this.lblExpirationOffre.TabIndex = 2;
            this.lblExpirationOffre.Text = "Date d\'expiration de l\'offre :";
            // 
            // lblListeCriteres
            // 
            this.lblListeCriteres.AutoSize = true;
            this.lblListeCriteres.Location = new System.Drawing.Point(51, 152);
            this.lblListeCriteres.Name = "lblListeCriteres";
            this.lblListeCriteres.Size = new System.Drawing.Size(92, 13);
            this.lblListeCriteres.TabIndex = 6;
            this.lblListeCriteres.Text = "Liste des critères :";
            // 
            // btnAjouterCritere
            // 
            this.btnAjouterCritere.Location = new System.Drawing.Point(232, 307);
            this.btnAjouterCritere.Name = "btnAjouterCritere";
            this.btnAjouterCritere.Size = new System.Drawing.Size(151, 24);
            this.btnAjouterCritere.TabIndex = 7;
            this.btnAjouterCritere.Text = "Ajouter un critère";
            this.btnAjouterCritere.UseVisualStyleBackColor = true;
            // 
            // lstCriteres
            // 
            this.lstCriteres.Location = new System.Drawing.Point(54, 195);
            this.lstCriteres.Name = "lstCriteres";
            this.lstCriteres.Size = new System.Drawing.Size(132, 136);
            this.lstCriteres.TabIndex = 8;
            this.lstCriteres.UseCompatibleStateImageBehavior = false;
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(232, 233);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(151, 20);
            this.txtNomCritere.TabIndex = 9;
            // 
            // txtExpirationOffre
            // 
            this.txtExpirationOffre.Location = new System.Drawing.Point(232, 90);
            this.txtExpirationOffre.Name = "txtExpirationOffre";
            this.txtExpirationOffre.Size = new System.Drawing.Size(226, 20);
            this.txtExpirationOffre.TabIndex = 10;
            // 
            // cmbChoixOffre
            // 
            this.cmbChoixOffre.FormattingEnabled = true;
            this.cmbChoixOffre.Location = new System.Drawing.Point(232, 38);
            this.cmbChoixOffre.Name = "cmbChoixOffre";
            this.cmbChoixOffre.Size = new System.Drawing.Size(226, 21);
            this.cmbChoixOffre.TabIndex = 12;
            this.cmbChoixOffre.SelectedIndexChanged += new System.EventHandler(this.cmbChoixOffre_SelectedIndexChanged);
            // 
            // lblNomCritere
            // 
            this.lblNomCritere.AutoSize = true;
            this.lblNomCritere.Location = new System.Drawing.Point(229, 217);
            this.lblNomCritere.Name = "lblNomCritere";
            this.lblNomCritere.Size = new System.Drawing.Size(61, 13);
            this.lblNomCritere.TabIndex = 13;
            this.lblNomCritere.Text = "Nom critère";
            // 
            // lblCoeffCritere
            // 
            this.lblCoeffCritere.AutoSize = true;
            this.lblCoeffCritere.Location = new System.Drawing.Point(229, 265);
            this.lblCoeffCritere.Name = "lblCoeffCritere";
            this.lblCoeffCritere.Size = new System.Drawing.Size(89, 13);
            this.lblCoeffCritere.TabIndex = 14;
            this.lblCoeffCritere.Text = "Coefficient critère";
            // 
            // txtCoeffCritere
            // 
            this.txtCoeffCritere.Location = new System.Drawing.Point(232, 281);
            this.txtCoeffCritere.Name = "txtCoeffCritere";
            this.txtCoeffCritere.Size = new System.Drawing.Size(151, 20);
            this.txtCoeffCritere.TabIndex = 15;
            // 
            // lblIdCritere
            // 
            this.lblIdCritere.AutoSize = true;
            this.lblIdCritere.Location = new System.Drawing.Point(229, 171);
            this.lblIdCritere.Name = "lblIdCritere";
            this.lblIdCritere.Size = new System.Drawing.Size(50, 13);
            this.lblIdCritere.TabIndex = 16;
            this.lblIdCritere.Text = "ID critère";
            // 
            // txtIdCritere
            // 
            this.txtIdCritere.Location = new System.Drawing.Point(232, 187);
            this.txtIdCritere.Name = "txtIdCritere";
            this.txtIdCritere.Size = new System.Drawing.Size(151, 20);
            this.txtIdCritere.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdCritere);
            this.Controls.Add(this.lblIdCritere);
            this.Controls.Add(this.txtCoeffCritere);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtCoeffCritere;
        private System.Windows.Forms.Label lblIdCritere;
        private System.Windows.Forms.TextBox txtIdCritere;
    }
}

