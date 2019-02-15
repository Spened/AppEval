namespace AppEval
{
    partial class RH
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
            this.grpRH = new System.Windows.Forms.GroupBox();
            this.grpFinal = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.grpCandidats = new System.Windows.Forms.GroupBox();
            this.lstCandidats = new System.Windows.Forms.ListBox();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numNote = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCritere = new System.Windows.Forms.TextBox();
            this.grpCritere = new System.Windows.Forms.GroupBox();
            this.lblCritere = new System.Windows.Forms.Label();
            this.lstCritere = new System.Windows.Forms.ListBox();
            this.grpOffresEmplois = new System.Windows.Forms.GroupBox();
            this.lstOffreEmplois = new System.Windows.Forms.ListBox();
            this.grpRH.SuspendLayout();
            this.grpFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            this.grpCandidats.SuspendLayout();
            this.grpNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNote)).BeginInit();
            this.grpCritere.SuspendLayout();
            this.grpOffresEmplois.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRH
            // 
            this.grpRH.Controls.Add(this.grpFinal);
            this.grpRH.Controls.Add(this.grpCandidats);
            this.grpRH.Controls.Add(this.lblConnexion);
            this.grpRH.Controls.Add(this.grpNote);
            this.grpRH.Controls.Add(this.grpCritere);
            this.grpRH.Controls.Add(this.grpOffresEmplois);
            this.grpRH.Location = new System.Drawing.Point(9, 10);
            this.grpRH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRH.Name = "grpRH";
            this.grpRH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRH.Size = new System.Drawing.Size(874, 390);
            this.grpRH.TabIndex = 0;
            this.grpRH.TabStop = false;
            this.grpRH.Text = "RH";
            // 
            // grpFinal
            // 
            this.grpFinal.Controls.Add(this.btnValider);
            this.grpFinal.Controls.Add(this.lblBonus);
            this.grpFinal.Controls.Add(this.lblCommentaire);
            this.grpFinal.Controls.Add(this.txtCommentaire);
            this.grpFinal.Controls.Add(this.numBonus);
            this.grpFinal.Location = new System.Drawing.Point(633, 174);
            this.grpFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFinal.Name = "grpFinal";
            this.grpFinal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFinal.Size = new System.Drawing.Size(218, 211);
            this.grpFinal.TabIndex = 7;
            this.grpFinal.TabStop = false;
            this.grpFinal.Text = "Eval Final";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(86, 188);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 19);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(74, 150);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(75, 13);
            this.lblBonus.TabIndex = 6;
            this.lblBonus.Text = "Bonus[-10/10]";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(4, 20);
            this.lblCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(68, 13);
            this.lblCommentaire.TabIndex = 5;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(4, 37);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(210, 111);
            this.txtCommentaire.TabIndex = 4;
            this.txtCommentaire.TextChanged += new System.EventHandler(this.txtCommentaire_TextChanged);
            // 
            // numBonus
            // 
            this.numBonus.Location = new System.Drawing.Point(94, 166);
            this.numBonus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(36, 20);
            this.numBonus.TabIndex = 3;
            // 
            // grpCandidats
            // 
            this.grpCandidats.Controls.Add(this.lstCandidats);
            this.grpCandidats.Location = new System.Drawing.Point(201, 45);
            this.grpCandidats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCandidats.Name = "grpCandidats";
            this.grpCandidats.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCandidats.Size = new System.Drawing.Size(218, 340);
            this.grpCandidats.TabIndex = 6;
            this.grpCandidats.TabStop = false;
            this.grpCandidats.Text = "Candidats";
            // 
            // lstCandidats
            // 
            this.lstCandidats.FormattingEnabled = true;
            this.lstCandidats.Location = new System.Drawing.Point(4, 17);
            this.lstCandidats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCandidats.Name = "lstCandidats";
            this.lstCandidats.Size = new System.Drawing.Size(210, 316);
            this.lstCandidats.TabIndex = 0;
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(9, 18);
            this.lblConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(0, 13);
            this.lblConnexion.TabIndex = 4;
            // 
            // grpNote
            // 
            this.grpNote.Controls.Add(this.btnAjouter);
            this.grpNote.Controls.Add(this.label2);
            this.grpNote.Controls.Add(this.numNote);
            this.grpNote.Controls.Add(this.label1);
            this.grpNote.Controls.Add(this.txtNomCritere);
            this.grpNote.Location = new System.Drawing.Point(632, 45);
            this.grpNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNote.Name = "grpNote";
            this.grpNote.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNote.Size = new System.Drawing.Size(218, 124);
            this.grpNote.TabIndex = 3;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Notes";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(80, 98);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(56, 19);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Attribuer";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note [0/5]";
            // 
            // numNote
            // 
            this.numNote.Location = new System.Drawing.Point(87, 76);
            this.numNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numNote.Name = "numNote";
            this.numNote.Size = new System.Drawing.Size(36, 20);
            this.numNote.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du critères";
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(38, 39);
            this.txtNomCritere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(139, 20);
            this.txtNomCritere.TabIndex = 0;
            // 
            // grpCritere
            // 
            this.grpCritere.Controls.Add(this.lblCritere);
            this.grpCritere.Controls.Add(this.lstCritere);
            this.grpCritere.Location = new System.Drawing.Point(424, 45);
            this.grpCritere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCritere.Name = "grpCritere";
            this.grpCritere.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCritere.Size = new System.Drawing.Size(204, 340);
            this.grpCritere.TabIndex = 2;
            this.grpCritere.TabStop = false;
            this.grpCritere.Text = "Critères";
            // 
            // lblCritere
            // 
            this.lblCritere.AutoSize = true;
            this.lblCritere.Location = new System.Drawing.Point(4, 23);
            this.lblCritere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCritere.Name = "lblCritere";
            this.lblCritere.Size = new System.Drawing.Size(0, 13);
            this.lblCritere.TabIndex = 0;
            // 
            // lstCritere
            // 
            this.lstCritere.FormattingEnabled = true;
            this.lstCritere.Location = new System.Drawing.Point(4, 17);
            this.lstCritere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCritere.Name = "lstCritere";
            this.lstCritere.Size = new System.Drawing.Size(196, 316);
            this.lstCritere.TabIndex = 1;
            this.lstCritere.SelectedIndexChanged += new System.EventHandler(this.lstCritere_SelectedIndexChanged);
            // 
            // grpOffresEmplois
            // 
            this.grpOffresEmplois.Controls.Add(this.lstOffreEmplois);
            this.grpOffresEmplois.Location = new System.Drawing.Point(4, 45);
            this.grpOffresEmplois.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOffresEmplois.Name = "grpOffresEmplois";
            this.grpOffresEmplois.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOffresEmplois.Size = new System.Drawing.Size(191, 340);
            this.grpOffresEmplois.TabIndex = 1;
            this.grpOffresEmplois.TabStop = false;
            this.grpOffresEmplois.Text = "Offres Emplois";
            // 
            // lstOffreEmplois
            // 
            this.lstOffreEmplois.FormattingEnabled = true;
            this.lstOffreEmplois.Location = new System.Drawing.Point(4, 17);
            this.lstOffreEmplois.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOffreEmplois.Name = "lstOffreEmplois";
            this.lstOffreEmplois.Size = new System.Drawing.Size(183, 316);
            this.lstOffreEmplois.TabIndex = 0;
            this.lstOffreEmplois.SelectedIndexChanged += new System.EventHandler(this.lstOffreEmplois_SelectedIndexChanged);
            // 
            // RH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 410);
            this.Controls.Add(this.grpRH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RH";
            this.Text = "RH";
            this.grpRH.ResumeLayout(false);
            this.grpRH.PerformLayout();
            this.grpFinal.ResumeLayout(false);
            this.grpFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            this.grpCandidats.ResumeLayout(false);
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNote)).EndInit();
            this.grpCritere.ResumeLayout(false);
            this.grpCritere.PerformLayout();
            this.grpOffresEmplois.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRH;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCritere;
        private System.Windows.Forms.GroupBox grpCritere;
        private System.Windows.Forms.ListBox lstCritere;
        private System.Windows.Forms.GroupBox grpOffresEmplois;
        private System.Windows.Forms.ListBox lstOffreEmplois;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblCritere;
        private System.Windows.Forms.GroupBox grpCandidats;
        private System.Windows.Forms.ListBox lstCandidats;
        private System.Windows.Forms.GroupBox grpFinal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.NumericUpDown numBonus;
    }
}