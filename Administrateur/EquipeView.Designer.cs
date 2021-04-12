
namespace Administrateur
{
    partial class EquipeView
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
            this.labelLaboratoire = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laboratoire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbLaboratoire = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteTeam = new System.Windows.Forms.Button();
            this.BtnEditTeam = new System.Windows.Forms.Button();
            this.BtnAddTeam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLaboratoire);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 30;
            // 
            // labelLaboratoire
            // 
            this.labelLaboratoire.AutoSize = true;
            this.labelLaboratoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratoire.Location = new System.Drawing.Point(0, 9);
            this.labelLaboratoire.Name = "labelLaboratoire";
            this.labelLaboratoire.Size = new System.Drawing.Size(96, 29);
            this.labelLaboratoire.TabIndex = 1;
            this.labelLaboratoire.Text = "Equipe";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom,
            this.laboratoire});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 246);
            this.listView1.TabIndex = 29;
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
            this.nom.Width = 100;
            // 
            // laboratoire
            // 
            this.laboratoire.Text = "Laboratoire";
            this.laboratoire.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbLaboratoire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbTeamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 110);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // CbLaboratoire
            // 
            this.CbLaboratoire.FormattingEnabled = true;
            this.CbLaboratoire.Location = new System.Drawing.Point(110, 67);
            this.CbLaboratoire.Name = "CbLaboratoire";
            this.CbLaboratoire.Size = new System.Drawing.Size(150, 21);
            this.CbLaboratoire.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Laboratoire";
            // 
            // TbTeamName
            // 
            this.TbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTeamName.Location = new System.Drawing.Point(110, 26);
            this.TbTeamName.Name = "TbTeamName";
            this.TbTeamName.Size = new System.Drawing.Size(150, 23);
            this.TbTeamName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // BtnDeleteTeam
            // 
            this.BtnDeleteTeam.Location = new System.Drawing.Point(219, 178);
            this.BtnDeleteTeam.Name = "BtnDeleteTeam";
            this.BtnDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteTeam.TabIndex = 34;
            this.BtnDeleteTeam.Text = "Supprimer";
            this.BtnDeleteTeam.UseVisualStyleBackColor = true;
            this.BtnDeleteTeam.Click += new System.EventHandler(this.BtnDeleteTeam_Click);
            // 
            // BtnEditTeam
            // 
            this.BtnEditTeam.Location = new System.Drawing.Point(111, 178);
            this.BtnEditTeam.Name = "BtnEditTeam";
            this.BtnEditTeam.Size = new System.Drawing.Size(75, 23);
            this.BtnEditTeam.TabIndex = 33;
            this.BtnEditTeam.Text = "Modifier";
            this.BtnEditTeam.UseVisualStyleBackColor = true;
            this.BtnEditTeam.Click += new System.EventHandler(this.BtnEditTeam_Click);
            // 
            // BtnAddTeam
            // 
            this.BtnAddTeam.Location = new System.Drawing.Point(3, 178);
            this.BtnAddTeam.Name = "BtnAddTeam";
            this.BtnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.BtnAddTeam.TabIndex = 32;
            this.BtnAddTeam.Text = "Ajouter";
            this.BtnAddTeam.UseVisualStyleBackColor = true;
            this.BtnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // EquipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteTeam);
            this.Controls.Add(this.BtnEditTeam);
            this.Controls.Add(this.BtnAddTeam);
            this.Name = "EquipeView";
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
        private System.Windows.Forms.ColumnHeader laboratoire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbLaboratoire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteTeam;
        private System.Windows.Forms.Button BtnEditTeam;
        private System.Windows.Forms.Button BtnAddTeam;
    }
}
