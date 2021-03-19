
namespace ChefEquipe
{
    partial class EquipeChercheur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelChercheure = new System.Windows.Forms.Label();
            this.BtnRetirerChercheure = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Text = "#Id";
            // 
            // labelChercheure
            // 
            this.labelChercheure.AutoSize = true;
            this.labelChercheure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChercheure.Location = new System.Drawing.Point(1, 9);
            this.labelChercheure.Name = "labelChercheure";
            this.labelChercheure.Size = new System.Drawing.Size(149, 29);
            this.labelChercheure.TabIndex = 2;
            this.labelChercheure.Text = "Chercheure";
            // 
            // BtnRetirerChercheure
            // 
            this.BtnRetirerChercheure.Location = new System.Drawing.Point(3, 56);
            this.BtnRetirerChercheure.Name = "BtnRetirerChercheure";
            this.BtnRetirerChercheure.Size = new System.Drawing.Size(111, 41);
            this.BtnRetirerChercheure.TabIndex = 36;
            this.BtnRetirerChercheure.Text = "Retirer";
            this.BtnRetirerChercheure.UseVisualStyleBackColor = true;
            this.BtnRetirerChercheure.Click += new System.EventHandler(this.BtnRetirerChercheure_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.firstname,
            this.lastname});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(688, 216);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lastname
            // 
            this.lastname.Text = "Nom";
            this.lastname.Width = 100;
            // 
            // firstname
            // 
            this.firstname.Text = "Prénom";
            this.firstname.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelChercheure);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 31;
            // 
            // EquipeChercheur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRetirerChercheure);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "EquipeChercheur";
            this.Size = new System.Drawing.Size(812, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label labelChercheure;
        private System.Windows.Forms.Button BtnRetirerChercheure;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.Panel panel1;
    }
}
