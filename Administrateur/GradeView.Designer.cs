
namespace Administrateur
{
    partial class GradeView
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
            this.labelGrade = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbGradeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteGrade = new System.Windows.Forms.Button();
            this.BtnEditGrade = new System.Windows.Forms.Button();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelGrade);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 42;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.Location = new System.Drawing.Point(0, 9);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(85, 29);
            this.labelGrade.TabIndex = 1;
            this.labelGrade.Text = "Grade";
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
            this.groupBox1.Controls.Add(this.TbGradeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // TbGradeName
            // 
            this.TbGradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbGradeName.Location = new System.Drawing.Point(110, 31);
            this.TbGradeName.Name = "TbGradeName";
            this.TbGradeName.Size = new System.Drawing.Size(150, 23);
            this.TbGradeName.TabIndex = 7;
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
            // BtnDeleteGrade
            // 
            this.BtnDeleteGrade.Location = new System.Drawing.Point(221, 150);
            this.BtnDeleteGrade.Name = "BtnDeleteGrade";
            this.BtnDeleteGrade.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteGrade.TabIndex = 46;
            this.BtnDeleteGrade.Text = "Supprimer";
            this.BtnDeleteGrade.UseVisualStyleBackColor = true;
            this.BtnDeleteGrade.Click += new System.EventHandler(this.BtnDeleteGrade_Click);
            // 
            // BtnEditGrade
            // 
            this.BtnEditGrade.Location = new System.Drawing.Point(113, 150);
            this.BtnEditGrade.Name = "BtnEditGrade";
            this.BtnEditGrade.Size = new System.Drawing.Size(75, 23);
            this.BtnEditGrade.TabIndex = 45;
            this.BtnEditGrade.Text = "Modifier";
            this.BtnEditGrade.UseVisualStyleBackColor = true;
            this.BtnEditGrade.Click += new System.EventHandler(this.BtnEditGrade_Click);
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.Location = new System.Drawing.Point(5, 150);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.BtnAddGrade.TabIndex = 44;
            this.BtnAddGrade.Text = "Ajouter";
            this.BtnAddGrade.UseVisualStyleBackColor = true;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // GradeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteGrade);
            this.Controls.Add(this.BtnEditGrade);
            this.Controls.Add(this.BtnAddGrade);
            this.Name = "GradeView";
            this.Size = new System.Drawing.Size(812, 319);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbGradeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteGrade;
        private System.Windows.Forms.Button BtnEditGrade;
        private System.Windows.Forms.Button BtnAddGrade;
    }
}
