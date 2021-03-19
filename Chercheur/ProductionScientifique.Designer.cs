
namespace Chercheur
{
    partial class ProductionScientifique
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
            this.TbType = new System.Windows.Forms.TextBox();
            this.type_id = new System.Windows.Forms.Label();
            this.TbReference = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChercheur = new System.Windows.Forms.Label();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDeleteProduction = new System.Windows.Forms.Button();
            this.BtnEditProduction = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAddProduction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_at = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbType);
            this.groupBox1.Controls.Add(this.type_id);
            this.groupBox1.Controls.Add(this.TbReference);
            this.groupBox1.Controls.Add(this.TbDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 200);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créartion / Modification";
            // 
            // TbType
            // 
            this.TbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbType.Location = new System.Drawing.Point(96, 168);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(150, 23);
            this.TbType.TabIndex = 15;
            // 
            // type_id
            // 
            this.type_id.AutoSize = true;
            this.type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_id.Location = new System.Drawing.Point(7, 168);
            this.type_id.Name = "type_id";
            this.type_id.Size = new System.Drawing.Size(40, 18);
            this.type_id.TabIndex = 14;
            this.type_id.Text = "Type";
            // 
            // TbReference
            // 
            this.TbReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbReference.Location = new System.Drawing.Point(96, 131);
            this.TbReference.Name = "TbReference";
            this.TbReference.Size = new System.Drawing.Size(150, 23);
            this.TbReference.TabIndex = 11;
            // 
            // TbDescription
            // 
            this.TbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDescription.Location = new System.Drawing.Point(96, 64);
            this.TbDescription.MaxLength = 300;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.TbDescription.Size = new System.Drawing.Size(150, 60);
            this.TbDescription.TabIndex = 10;
            this.TbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // TbTitle
            // 
            this.TbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitle.Location = new System.Drawing.Point(96, 35);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(150, 23);
            this.TbTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titre";
            // 
            // labelChercheur
            // 
            this.labelChercheur.AutoSize = true;
            this.labelChercheur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChercheur.Location = new System.Drawing.Point(1, 9);
            this.labelChercheur.Name = "labelChercheur";
            this.labelChercheur.Size = new System.Drawing.Size(149, 29);
            this.labelChercheur.TabIndex = 2;
            this.labelChercheur.Text = "Chercheure";
            // 
            // id
            // 
            this.id.Text = "#Id";
            this.id.Width = 34;
            // 
            // BtnDeleteProduction
            // 
            this.BtnDeleteProduction.Location = new System.Drawing.Point(219, 268);
            this.BtnDeleteProduction.Name = "BtnDeleteProduction";
            this.BtnDeleteProduction.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteProduction.TabIndex = 36;
            this.BtnDeleteProduction.Text = "Supprimer";
            this.BtnDeleteProduction.UseVisualStyleBackColor = true;
            this.BtnDeleteProduction.Click += new System.EventHandler(this.BtnDeleteProduction_Click);
            // 
            // BtnEditProduction
            // 
            this.BtnEditProduction.Location = new System.Drawing.Point(111, 268);
            this.BtnEditProduction.Name = "BtnEditProduction";
            this.BtnEditProduction.Size = new System.Drawing.Size(75, 23);
            this.BtnEditProduction.TabIndex = 35;
            this.BtnEditProduction.Text = "Modifier";
            this.BtnEditProduction.UseVisualStyleBackColor = true;
            this.BtnEditProduction.Click += new System.EventHandler(this.BtnEditProduction_Click);
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
            this.create_at});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 246);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // title
            // 
            this.title.Text = "Titre";
            this.title.Width = 76;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 138;
            // 
            // reference
            // 
            this.reference.Text = "Reference";
            this.reference.Width = 71;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 120;
            // 
            // BtnAddProduction
            // 
            this.BtnAddProduction.Location = new System.Drawing.Point(3, 268);
            this.BtnAddProduction.Name = "BtnAddProduction";
            this.BtnAddProduction.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProduction.TabIndex = 34;
            this.BtnAddProduction.Text = "Ajouter";
            this.BtnAddProduction.UseVisualStyleBackColor = true;
            this.BtnAddProduction.Click += new System.EventHandler(this.BtnAddProduction_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelChercheur);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 31;
            // 
            // create_at
            // 
            this.create_at.Text = "Date";
            // 
            // ProductionScientifique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDeleteProduction);
            this.Controls.Add(this.BtnEditProduction);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnAddProduction);
            this.Controls.Add(this.panel1);
            this.Name = "ProductionScientifique";
            this.Size = new System.Drawing.Size(812, 319);
            this.Load += new System.EventHandler(this.ProductionScientifique_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChercheur;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button BtnDeleteProduction;
        private System.Windows.Forms.Button BtnEditProduction;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.Button BtnAddProduction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TbDescription;
        private System.Windows.Forms.TextBox TbReference;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.TextBox TbType;
        private System.Windows.Forms.Label type_id;
        private System.Windows.Forms.ColumnHeader create_at;
    }
}
