
namespace Administrateur
{
    partial class LaboratoireView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.labelLaboratoire = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbLaboratoireName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteLaboratoire = new System.Windows.Forms.Button();
            this.BtnEditLaboratoire = new System.Windows.Forms.Button();
            this.BtnAddLaboratoire = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.labelLaboratoire);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 42;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(725, 15);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 32;
            this.BtnRefresh.Text = "Rafraîchir";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labelLaboratoire
            // 
            this.labelLaboratoire.AutoSize = true;
            this.labelLaboratoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratoire.Location = new System.Drawing.Point(0, 9);
            this.labelLaboratoire.Name = "labelLaboratoire";
            this.labelLaboratoire.Size = new System.Drawing.Size(147, 29);
            this.labelLaboratoire.TabIndex = 1;
            this.labelLaboratoire.Text = "Laboratoire";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 246);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // id
            // 
            this.id.Text = "#Id";
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbLaboratoireName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // TbLaboratoireName
            // 
            this.TbLaboratoireName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLaboratoireName.Location = new System.Drawing.Point(110, 31);
            this.TbLaboratoireName.Name = "TbLaboratoireName";
            this.TbLaboratoireName.Size = new System.Drawing.Size(150, 23);
            this.TbLaboratoireName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // BtnDeleteLaboratoire
            // 
            this.BtnDeleteLaboratoire.Location = new System.Drawing.Point(221, 150);
            this.BtnDeleteLaboratoire.Name = "BtnDeleteLaboratoire";
            this.BtnDeleteLaboratoire.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteLaboratoire.TabIndex = 46;
            this.BtnDeleteLaboratoire.Text = "Supprimer";
            this.BtnDeleteLaboratoire.UseVisualStyleBackColor = true;
            this.BtnDeleteLaboratoire.Click += new System.EventHandler(this.BtnDeleteLaboratoire_Click);
            // 
            // BtnEditLaboratoire
            // 
            this.BtnEditLaboratoire.Location = new System.Drawing.Point(113, 150);
            this.BtnEditLaboratoire.Name = "BtnEditLaboratoire";
            this.BtnEditLaboratoire.Size = new System.Drawing.Size(75, 23);
            this.BtnEditLaboratoire.TabIndex = 45;
            this.BtnEditLaboratoire.Text = "Modifier";
            this.BtnEditLaboratoire.UseVisualStyleBackColor = true;
            this.BtnEditLaboratoire.Click += new System.EventHandler(this.BtnEditLaboratoire_Click);
            // 
            // BtnAddLaboratoire
            // 
            this.BtnAddLaboratoire.Location = new System.Drawing.Point(5, 150);
            this.BtnAddLaboratoire.Name = "BtnAddLaboratoire";
            this.BtnAddLaboratoire.Size = new System.Drawing.Size(75, 23);
            this.BtnAddLaboratoire.TabIndex = 44;
            this.BtnAddLaboratoire.Text = "Ajouter";
            this.BtnAddLaboratoire.UseVisualStyleBackColor = true;
            this.BtnAddLaboratoire.Click += new System.EventHandler(this.BtnAddLaboratoire_Click);
            // 
            // LaboratoireView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteLaboratoire);
            this.Controls.Add(this.BtnEditLaboratoire);
            this.Controls.Add(this.BtnAddLaboratoire);
            this.Name = "LaboratoireView";
            this.Size = new System.Drawing.Size(812, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLaboratoire;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbLaboratoireName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteLaboratoire;
        private System.Windows.Forms.Button BtnEditLaboratoire;
        private System.Windows.Forms.Button BtnAddLaboratoire;
        private System.Windows.Forms.Button BtnRefresh;
    }
}
