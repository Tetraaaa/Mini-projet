namespace Gestion_de_budget
{
    partial class FormAjoutPoste
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
            this.labelNomPosteAjout = new System.Windows.Forms.Label();
            this.txtBxAjoutPoste = new System.Windows.Forms.TextBox();
            this.btnAjouterPoste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomPosteAjout
            // 
            this.labelNomPosteAjout.AutoSize = true;
            this.labelNomPosteAjout.Location = new System.Drawing.Point(13, 13);
            this.labelNomPosteAjout.Name = "labelNomPosteAjout";
            this.labelNomPosteAjout.Size = new System.Drawing.Size(82, 13);
            this.labelNomPosteAjout.TabIndex = 0;
            this.labelNomPosteAjout.Text = "Nom du poste : ";
            // 
            // txtBxAjoutPoste
            // 
            this.txtBxAjoutPoste.Location = new System.Drawing.Point(101, 10);
            this.txtBxAjoutPoste.Name = "txtBxAjoutPoste";
            this.txtBxAjoutPoste.Size = new System.Drawing.Size(202, 20);
            this.txtBxAjoutPoste.TabIndex = 1;
            // 
            // btnAjouterPoste
            // 
            this.btnAjouterPoste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterPoste.Location = new System.Drawing.Point(208, 36);
            this.btnAjouterPoste.Name = "btnAjouterPoste";
            this.btnAjouterPoste.Size = new System.Drawing.Size(95, 44);
            this.btnAjouterPoste.TabIndex = 2;
            this.btnAjouterPoste.Text = "Ajouter";
            this.btnAjouterPoste.UseVisualStyleBackColor = true;
            // 
            // FormAjoutPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 89);
            this.Controls.Add(this.btnAjouterPoste);
            this.Controls.Add(this.txtBxAjoutPoste);
            this.Controls.Add(this.labelNomPosteAjout);
            this.Name = "FormAjoutPoste";
            this.Text = "Ajouter un poste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomPosteAjout;
        private System.Windows.Forms.TextBox txtBxAjoutPoste;
        private System.Windows.Forms.Button btnAjouterPoste;
    }
}