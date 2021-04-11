
namespace ChefEquipe
{
    partial class Prod_sci_chef
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLaboratoire = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.description,
            this.reference,
            this.type,
            this.lastname,
            this.firstname,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 246);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "#Id";
            this.id.Width = 34;
            // 
            // title
            // 
            this.title.Text = "Titre";
            this.title.Width = 100;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 140;
            // 
            // reference
            // 
            this.reference.Text = "Reference";
            this.reference.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 120;
            // 
            // lastname
            // 
            this.lastname.Text = "Nom";
            // 
            // firstname
            // 
            this.firstname.Text = "Prenom";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Laboratoire";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Equipe";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Création";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLaboratoire);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 36;
            // 
            // labelLaboratoire
            // 
            this.labelLaboratoire.AutoSize = true;
            this.labelLaboratoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratoire.Location = new System.Drawing.Point(0, 9);
            this.labelLaboratoire.Name = "labelLaboratoire";
            this.labelLaboratoire.Size = new System.Drawing.Size(306, 29);
            this.labelLaboratoire.TabIndex = 1;
            this.labelLaboratoire.Text = "Productions scientifiques";
            // 
            // Prod_sci_chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Prod_sci_chef";
            this.Size = new System.Drawing.Size(812, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLaboratoire;
    }
}
