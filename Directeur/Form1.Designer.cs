
namespace Directeur
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnEquipe = new System.Windows.Forms.Button();
            this.BtnChercheure = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.equipe1 = new Directeur.Equipe();
            this.chercheur1 = new Directeur.Chercheur();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Directeur.Properties.Resources.baseline_account_circle_black_48dp;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 561);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BtnEquipe);
            this.panel4.Controls.Add(this.BtnChercheure);
            this.panel4.Location = new System.Drawing.Point(3, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 401);
            this.panel4.TabIndex = 2;
            // 
            // BtnEquipe
            // 
            this.BtnEquipe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEquipe.Location = new System.Drawing.Point(3, 44);
            this.BtnEquipe.Name = "BtnEquipe";
            this.BtnEquipe.Size = new System.Drawing.Size(156, 35);
            this.BtnEquipe.TabIndex = 2;
            this.BtnEquipe.Text = "Equipes";
            this.BtnEquipe.UseVisualStyleBackColor = true;
            this.BtnEquipe.Click += new System.EventHandler(this.BtnEquipe_Click);
            // 
            // BtnChercheure
            // 
            this.BtnChercheure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnChercheure.Location = new System.Drawing.Point(3, 3);
            this.BtnChercheure.Name = "BtnChercheure";
            this.BtnChercheure.Size = new System.Drawing.Size(156, 35);
            this.BtnChercheure.TabIndex = 1;
            this.BtnChercheure.Text = "Chercheures";
            this.BtnChercheure.UseVisualStyleBackColor = true;
            this.BtnChercheure.Click += new System.EventHandler(this.BtnChercheure_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 112);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 30);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directeur";
            // 
            // equipe1
            // 
            this.equipe1.Location = new System.Drawing.Point(169, 3);
            this.equipe1.Name = "equipe1";
            this.equipe1.Size = new System.Drawing.Size(812, 319);
            this.equipe1.TabIndex = 4;
            this.equipe1.Load += new System.EventHandler(this.equipe1_Load);
            // 
            // chercheur1
            // 
            this.chercheur1.Location = new System.Drawing.Point(169, 3);
            this.chercheur1.Name = "chercheur1";
            this.chercheur1.Size = new System.Drawing.Size(812, 319);
            this.chercheur1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.equipe1);
            this.Controls.Add(this.chercheur1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnEquipe;
        private System.Windows.Forms.Button BtnChercheure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Chercheur chercheur1;
        private Equipe equipe1;
    }
}

