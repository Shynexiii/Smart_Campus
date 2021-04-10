
namespace Administrateur
{
    partial class ChercheurView
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
            this.BtnAddChercheure = new System.Windows.Forms.Button();
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDeleteChercheure = new System.Windows.Forms.Button();
            this.BtnEditChercheure = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laboratoire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChercheure = new System.Windows.Forms.Label();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTeam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbLaboratoire = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddChercheure
            // 
            this.BtnAddChercheure.Location = new System.Drawing.Point(3, 285);
            this.BtnAddChercheure.Name = "BtnAddChercheure";
            this.BtnAddChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChercheure.TabIndex = 28;
            this.BtnAddChercheure.Text = "Ajouter";
            this.BtnAddChercheure.UseVisualStyleBackColor = true;
            this.BtnAddChercheure.Click += new System.EventHandler(this.BtnAddChercheure_Click);
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 100;
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
            // BtnDeleteChercheure
            // 
            this.BtnDeleteChercheure.Location = new System.Drawing.Point(219, 285);
            this.BtnDeleteChercheure.Name = "BtnDeleteChercheure";
            this.BtnDeleteChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteChercheure.TabIndex = 30;
            this.BtnDeleteChercheure.Text = "Supprimer";
            this.BtnDeleteChercheure.UseVisualStyleBackColor = true;
            this.BtnDeleteChercheure.Click += new System.EventHandler(this.BtnDeleteChercheure_Click);
            // 
            // BtnEditChercheure
            // 
            this.BtnEditChercheure.Location = new System.Drawing.Point(111, 285);
            this.BtnEditChercheure.Name = "BtnEditChercheure";
            this.BtnEditChercheure.Size = new System.Drawing.Size(75, 23);
            this.BtnEditChercheure.TabIndex = 29;
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
            this.role,
            this.laboratoire,
            this.team,
            this.email,
            this.password});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 246);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
            // 
            // id
            // 
            this.id.Text = "#Id";
            // 
            // laboratoire
            // 
            this.laboratoire.Text = "Laboratoire";
            this.laboratoire.Width = 100;
            // 
            // team
            // 
            this.team.Text = "Equipe";
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 100;
            // 
            // password
            // 
            this.password.Text = "Mot de passe";
            this.password.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelChercheure);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 25;
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
            // CbRole
            // 
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Location = new System.Drawing.Point(107, 137);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(150, 21);
            this.CbRole.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Role";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(107, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 23);
            this.tbLastName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // TbFirstName
            // 
            this.TbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFirstName.Location = new System.Drawing.Point(107, 21);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(150, 23);
            this.TbFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prénom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTeam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CbLaboratoire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbRole);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 217);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // CbTeam
            // 
            this.CbTeam.FormattingEnabled = true;
            this.CbTeam.Location = new System.Drawing.Point(107, 190);
            this.CbTeam.MaxDropDownItems = 10;
            this.CbTeam.Name = "CbTeam";
            this.CbTeam.Size = new System.Drawing.Size(150, 21);
            this.CbTeam.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Equipe";
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(107, 108);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(150, 23);
            this.TbPassword.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mot de passe";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(107, 79);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(150, 23);
            this.TbEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // CbLaboratoire
            // 
            this.CbLaboratoire.FormattingEnabled = true;
            this.CbLaboratoire.Location = new System.Drawing.Point(107, 164);
            this.CbLaboratoire.Name = "CbLaboratoire";
            this.CbLaboratoire.Size = new System.Drawing.Size(150, 21);
            this.CbLaboratoire.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Laboratoire";
            // 
            // ChercheurView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddChercheure);
            this.Controls.Add(this.BtnDeleteChercheure);
            this.Controls.Add(this.BtnEditChercheure);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChercheurView";
            this.Size = new System.Drawing.Size(812, 319);
            this.Load += new System.EventHandler(this.ChercheurView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddChercheure;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.Button BtnDeleteChercheure;
        private System.Windows.Forms.Button BtnEditChercheure;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChercheure;
        private System.Windows.Forms.ComboBox CbRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader laboratoire;
        private System.Windows.Forms.ComboBox CbLaboratoire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader team;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ComboBox CbTeam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label5;
    }
}
