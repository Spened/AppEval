﻿namespace AppEval
{
    partial class Connexion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.grpConnexion = new System.Windows.Forms.GroupBox();
            this.grpConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(152, 224);
            this.btnConnecter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(133, 28);
            this.btnConnecter.TabIndex = 3;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(21, 59);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 17);
            this.lblIdentifiant.TabIndex = 4;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(21, 154);
            this.lblMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(93, 17);
            this.lblMDP.TabIndex = 5;
            this.lblMDP.Text = "Mot de passe";
            // 
            // grpConnexion
            // 
            this.grpConnexion.Controls.Add(this.lblMDP);
            this.grpConnexion.Controls.Add(this.lblIdentifiant);
            this.grpConnexion.Controls.Add(this.btnConnecter);
            this.grpConnexion.Controls.Add(this.textBox2);
            this.grpConnexion.Controls.Add(this.textBox1);
            this.grpConnexion.Location = new System.Drawing.Point(13, 13);
            this.grpConnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnexion.Name = "grpConnexion";
            this.grpConnexion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnexion.Size = new System.Drawing.Size(339, 303);
            this.grpConnexion.TabIndex = 6;
            this.grpConnexion.TabStop = false;
            this.grpConnexion.Text = "Connexion";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 327);
            this.Controls.Add(this.grpConnexion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.grpConnexion.ResumeLayout(false);
            this.grpConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.GroupBox grpConnexion;
    }
}