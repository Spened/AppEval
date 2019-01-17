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
            this.lstOffreEmplois = new System.Windows.Forms.ListBox();
            this.grpOffresEmplois = new System.Windows.Forms.GroupBox();
            this.grpCritere = new System.Windows.Forms.GroupBox();
            this.lstCritere = new System.Windows.Forms.ListBox();
            this.grpEval = new System.Windows.Forms.GroupBox();
            this.txtNomCritere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblCritere = new System.Windows.Forms.Label();
            this.grpRH.SuspendLayout();
            this.grpOffresEmplois.SuspendLayout();
            this.grpCritere.SuspendLayout();
            this.grpEval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRH
            // 
            this.grpRH.Controls.Add(this.lblConnexion);
            this.grpRH.Controls.Add(this.grpEval);
            this.grpRH.Controls.Add(this.grpCritere);
            this.grpRH.Controls.Add(this.grpOffresEmplois);
            this.grpRH.Location = new System.Drawing.Point(12, 12);
            this.grpRH.Name = "grpRH";
            this.grpRH.Size = new System.Drawing.Size(842, 356);
            this.grpRH.TabIndex = 0;
            this.grpRH.TabStop = false;
            this.grpRH.Text = "RH";
            // 
            // lstOffreEmplois
            // 
            this.lstOffreEmplois.FormattingEnabled = true;
            this.lstOffreEmplois.ItemHeight = 16;
            this.lstOffreEmplois.Location = new System.Drawing.Point(6, 21);
            this.lstOffreEmplois.Name = "lstOffreEmplois";
            this.lstOffreEmplois.Size = new System.Drawing.Size(243, 260);
            this.lstOffreEmplois.TabIndex = 0;
            this.lstOffreEmplois.SelectedIndexChanged += new System.EventHandler(this.lstOffreEmplois_SelectedIndexChanged);
            // 
            // grpOffresEmplois
            // 
            this.grpOffresEmplois.Controls.Add(this.lstOffreEmplois);
            this.grpOffresEmplois.Location = new System.Drawing.Point(6, 55);
            this.grpOffresEmplois.Name = "grpOffresEmplois";
            this.grpOffresEmplois.Size = new System.Drawing.Size(255, 294);
            this.grpOffresEmplois.TabIndex = 1;
            this.grpOffresEmplois.TabStop = false;
            this.grpOffresEmplois.Text = "Offres Emplois";
            // 
            // grpCritere
            // 
            this.grpCritere.Controls.Add(this.lblCritere);
            this.grpCritere.Controls.Add(this.lstCritere);
            this.grpCritere.Location = new System.Drawing.Point(267, 55);
            this.grpCritere.Name = "grpCritere";
            this.grpCritere.Size = new System.Drawing.Size(272, 294);
            this.grpCritere.TabIndex = 2;
            this.grpCritere.TabStop = false;
            this.grpCritere.Text = "Critères";
            // 
            // lstCritere
            // 
            this.lstCritere.FormattingEnabled = true;
            this.lstCritere.ItemHeight = 16;
            this.lstCritere.Location = new System.Drawing.Point(6, 21);
            this.lstCritere.Name = "lstCritere";
            this.lstCritere.Size = new System.Drawing.Size(260, 260);
            this.lstCritere.TabIndex = 1;
            this.lstCritere.SelectedIndexChanged += new System.EventHandler(this.lstCritere_SelectedIndexChanged);
            // 
            // grpEval
            // 
            this.grpEval.Controls.Add(this.btnValider);
            this.grpEval.Controls.Add(this.label2);
            this.grpEval.Controls.Add(this.numericUpDown1);
            this.grpEval.Controls.Add(this.label1);
            this.grpEval.Controls.Add(this.txtNomCritere);
            this.grpEval.Location = new System.Drawing.Point(545, 55);
            this.grpEval.Name = "grpEval";
            this.grpEval.Size = new System.Drawing.Size(291, 294);
            this.grpEval.TabIndex = 3;
            this.grpEval.TabStop = false;
            this.grpEval.Text = "Évalutation";
            // 
            // txtNomCritere
            // 
            this.txtNomCritere.Location = new System.Drawing.Point(51, 48);
            this.txtNomCritere.Name = "txtNomCritere";
            this.txtNomCritere.Size = new System.Drawing.Size(184, 22);
            this.txtNomCritere.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du critères";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note [0/5]";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(99, 217);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(12, 22);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(0, 17);
            this.lblConnexion.TabIndex = 4;
            // 
            // lblCritere
            // 
            this.lblCritere.AutoSize = true;
            this.lblCritere.Location = new System.Drawing.Point(6, 28);
            this.lblCritere.Name = "lblCritere";
            this.lblCritere.Size = new System.Drawing.Size(0, 17);
            this.lblCritere.TabIndex = 0;
            // 
            // RH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 374);
            this.Controls.Add(this.grpRH);
            this.Name = "RH";
            this.Text = "RH";
            this.grpRH.ResumeLayout(false);
            this.grpRH.PerformLayout();
            this.grpOffresEmplois.ResumeLayout(false);
            this.grpCritere.ResumeLayout(false);
            this.grpCritere.PerformLayout();
            this.grpEval.ResumeLayout(false);
            this.grpEval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRH;
        private System.Windows.Forms.GroupBox grpEval;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCritere;
        private System.Windows.Forms.GroupBox grpCritere;
        private System.Windows.Forms.ListBox lstCritere;
        private System.Windows.Forms.GroupBox grpOffresEmplois;
        private System.Windows.Forms.ListBox lstOffreEmplois;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblCritere;
    }
}