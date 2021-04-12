
namespace Administrateur
{
    partial class RoleView
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
            this.labelRole = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbRoleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteRole = new System.Windows.Forms.Button();
            this.BtnEditRole = new System.Windows.Forms.Button();
            this.BtnAddRole = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRole);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 36;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(0, 9);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(68, 29);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role";
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
            this.listView1.TabIndex = 35;
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
            this.groupBox1.Controls.Add(this.TbRoleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 73);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // TbRoleName
            // 
            this.TbRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRoleName.Location = new System.Drawing.Point(110, 31);
            this.TbRoleName.Name = "TbRoleName";
            this.TbRoleName.Size = new System.Drawing.Size(150, 23);
            this.TbRoleName.TabIndex = 7;
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
            // BtnDeleteRole
            // 
            this.BtnDeleteRole.Location = new System.Drawing.Point(221, 150);
            this.BtnDeleteRole.Name = "BtnDeleteRole";
            this.BtnDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteRole.TabIndex = 40;
            this.BtnDeleteRole.Text = "Supprimer";
            this.BtnDeleteRole.UseVisualStyleBackColor = true;
            this.BtnDeleteRole.Click += new System.EventHandler(this.BtnDeleteRole_Click);
            // 
            // BtnEditRole
            // 
            this.BtnEditRole.Location = new System.Drawing.Point(113, 150);
            this.BtnEditRole.Name = "BtnEditRole";
            this.BtnEditRole.Size = new System.Drawing.Size(75, 23);
            this.BtnEditRole.TabIndex = 39;
            this.BtnEditRole.Text = "Modifier";
            this.BtnEditRole.UseVisualStyleBackColor = true;
            this.BtnEditRole.Click += new System.EventHandler(this.BtnEditRole_Click);
            // 
            // BtnAddRole
            // 
            this.BtnAddRole.Location = new System.Drawing.Point(5, 150);
            this.BtnAddRole.Name = "BtnAddRole";
            this.BtnAddRole.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRole.TabIndex = 38;
            this.BtnAddRole.Text = "Ajouter";
            this.BtnAddRole.UseVisualStyleBackColor = true;
            this.BtnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // RoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteRole);
            this.Controls.Add(this.BtnEditRole);
            this.Controls.Add(this.BtnAddRole);
            this.Name = "RoleView";
            this.Size = new System.Drawing.Size(812, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbRoleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteRole;
        private System.Windows.Forms.Button BtnEditRole;
        private System.Windows.Forms.Button BtnAddRole;
    }
}
