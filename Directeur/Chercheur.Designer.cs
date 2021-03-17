
namespace Directeur
{
    partial class Chercheur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChercheure = new System.Windows.Forms.Label();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDeleteChercheure = new System.Windows.Forms.Button();
            this.BtnEditChercheure = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAddChercheure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbRole);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 148);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // CbRole
            // 
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Items.AddRange(new object[] {
            "",
            "Chef d\'équipe",
            "Chercheur"});
            this.CbRole.Location = new System.Drawing.Point(96, 111);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(150, 21);
            this.CbRole.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Role";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(96, 73);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 23);
            this.tbLastName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // TbFirstName
            // 
            this.TbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFirstName.Location = new System.Drawing.Point(96, 35);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(150, 23);
            this.TbFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prénom";
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
            // id
            // 
            this.id.Text = "#Id";
            // 
            // BtnDeleteChercheure
            // 
            this.BtnDeleteChercheure.Location = new System.Drawing.Point(221, 217);
            this.BtnDeleteChercheure.Name = "BtnDeleteChercheure";
            this.BtnDeleteChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteChercheure.TabIndex = 24;
            this.BtnDeleteChercheure.Text = "Supprimer";
            this.BtnDeleteChercheure.UseVisualStyleBackColor = true;
            this.BtnDeleteChercheure.Click += new System.EventHandler(this.BtnDeleteChercheure_Click);
            // 
            // BtnEditChercheure
            // 
            this.BtnEditChercheure.Location = new System.Drawing.Point(113, 217);
            this.BtnEditChercheure.Name = "BtnEditChercheure";
            this.BtnEditChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnEditChercheure.TabIndex = 23;
            this.BtnEditChercheure.Text = "Modifier";
            this.BtnEditChercheure.UseVisualStyleBackColor = true;
            this.BtnEditChercheure.Click += new System.EventHandler(this.BtnEditChercheure_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.firstname,
            this.lastname,
            this.role});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 246);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // firstname
            // 
            this.firstname.Text = "Nom";
            this.firstname.Width = 100;
            // 
            // lastname
            // 
            this.lastname.Text = "Prénom";
            this.lastname.Width = 100;
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelChercheure);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 19;
            // 
            // BtnAddChercheure
            // 
            this.BtnAddChercheure.Location = new System.Drawing.Point(5, 217);
            this.BtnAddChercheure.Name = "BtnAddChercheure";
            this.BtnAddChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChercheure.TabIndex = 22;
            this.BtnAddChercheure.Text = "Ajouter";
            this.BtnAddChercheure.UseVisualStyleBackColor = true;
            this.BtnAddChercheure.Click += new System.EventHandler(this.BtnAddChercheure_Click);
            // 
            // Chercheur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteChercheure);
            this.Controls.Add(this.BtnEditChercheure);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAddChercheure);
            this.Name = "Chercheur";
            this.Size = new System.Drawing.Size(812, 319);
            this.Load += new System.EventHandler(this.Chercheur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChercheure;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button BtnDeleteChercheure;
        private System.Windows.Forms.Button BtnEditChercheure;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAddChercheure;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ComboBox CbRole;
    }
}
