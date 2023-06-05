namespace Gestion_chambre
{
    partial class client_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_interface));
            this.client_container = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_contain = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.list_container = new System.Windows.Forms.DataGridView();
            this.identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_contain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.image_contain = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresse_contain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_contain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cin_contain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prename_contain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_contain = new System.Windows.Forms.TextBox();
            this.client_container.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_container)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).BeginInit();
            this.SuspendLayout();
            // 
            // client_container
            // 
            this.client_container.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.client_container.Controls.Add(this.search_btn);
            this.client_container.Controls.Add(this.search_contain);
            this.client_container.Controls.Add(this.panel2);
            this.client_container.Controls.Add(this.panel1);
            this.client_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_container.Location = new System.Drawing.Point(0, 0);
            this.client_container.Name = "client_container";
            this.client_container.Size = new System.Drawing.Size(981, 572);
            this.client_container.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(473, 36);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(32, 23);
            this.search_btn.TabIndex = 3;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_contain
            // 
            this.search_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.search_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_contain.Location = new System.Drawing.Point(15, 31);
            this.search_contain.Multiline = true;
            this.search_contain.Name = "search_contain";
            this.search_contain.Size = new System.Drawing.Size(505, 37);
            this.search_contain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.list_container);
            this.panel2.Location = new System.Drawing.Point(538, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 462);
            this.panel2.TabIndex = 1;
            // 
            // list_container
            // 
            this.list_container.AllowUserToAddRows = false;
            this.list_container.AllowUserToDeleteRows = false;
            this.list_container.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.list_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_container.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifiant,
            this.nom,
            this.prenom,
            this.adresse});
            this.list_container.EnableHeadersVisualStyles = false;
            this.list_container.Location = new System.Drawing.Point(3, 2);
            this.list_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_container.Name = "list_container";
            this.list_container.ReadOnly = true;
            this.list_container.RowHeadersVisible = false;
            this.list_container.RowHeadersWidth = 51;
            this.list_container.RowTemplate.Height = 29;
            this.list_container.Size = new System.Drawing.Size(419, 458);
            this.list_container.TabIndex = 0;
            this.list_container.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_container_CellContentClick);
            // 
            // identifiant
            // 
            this.identifiant.HeaderText = "ID";
            this.identifiant.MinimumWidth = 6;
            this.identifiant.Name = "identifiant";
            this.identifiant.ReadOnly = true;
            this.identifiant.Width = 125;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.MinimumWidth = 6;
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.id_contain);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.image_contain);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.adresse_contain);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tel_contain);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cin_contain);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prename_contain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name_contain);
            this.panel1.Location = new System.Drawing.Point(15, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 463);
            this.panel1.TabIndex = 0;
            // 
            // id_contain
            // 
            this.id_contain.Location = new System.Drawing.Point(306, 282);
            this.id_contain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_contain.Name = "id_contain";
            this.id_contain.Size = new System.Drawing.Size(110, 23);
            this.id_contain.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(205, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "c";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Image = ((System.Drawing.Image)(resources.GetObject("del_btn.Image")));
            this.del_btn.Location = new System.Drawing.Point(382, 417);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(108, 36);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "supprimer";
            this.del_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.del_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.Location = new System.Drawing.Point(140, 417);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(108, 36);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "modifier";
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.Location = new System.Drawing.Point(18, 417);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(108, 36);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "enregistrer";
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // image_contain
            // 
            this.image_contain.Location = new System.Drawing.Point(16, 277);
            this.image_contain.Name = "image_contain";
            this.image_contain.Size = new System.Drawing.Size(176, 113);
            this.image_contain.TabIndex = 10;
            this.image_contain.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresse : ";
            // 
            // adresse_contain
            // 
            this.adresse_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.adresse_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresse_contain.ForeColor = System.Drawing.Color.White;
            this.adresse_contain.Location = new System.Drawing.Point(16, 212);
            this.adresse_contain.Multiline = true;
            this.adresse_contain.Name = "adresse_contain";
            this.adresse_contain.Size = new System.Drawing.Size(474, 37);
            this.adresse_contain.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(276, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero telephone : ";
            // 
            // tel_contain
            // 
            this.tel_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.tel_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel_contain.ForeColor = System.Drawing.Color.White;
            this.tel_contain.Location = new System.Drawing.Point(276, 125);
            this.tel_contain.Multiline = true;
            this.tel_contain.Name = "tel_contain";
            this.tel_contain.Size = new System.Drawing.Size(211, 37);
            this.tel_contain.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero CIN : ";
            // 
            // cin_contain
            // 
            this.cin_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cin_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cin_contain.ForeColor = System.Drawing.Color.White;
            this.cin_contain.Location = new System.Drawing.Point(13, 125);
            this.cin_contain.Multiline = true;
            this.cin_contain.Name = "cin_contain";
            this.cin_contain.Size = new System.Drawing.Size(235, 37);
            this.cin_contain.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom : ";
            // 
            // prename_contain
            // 
            this.prename_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.prename_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prename_contain.ForeColor = System.Drawing.Color.White;
            this.prename_contain.Location = new System.Drawing.Point(276, 46);
            this.prename_contain.Multiline = true;
            this.prename_contain.Name = "prename_contain";
            this.prename_contain.Size = new System.Drawing.Size(211, 37);
            this.prename_contain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // name_contain
            // 
            this.name_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.name_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_contain.ForeColor = System.Drawing.Color.White;
            this.name_contain.Location = new System.Drawing.Point(13, 46);
            this.name_contain.Multiline = true;
            this.name_contain.Name = "name_contain";
            this.name_contain.Size = new System.Drawing.Size(235, 37);
            this.name_contain.TabIndex = 0;
            // 
            // client_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.client_container);
            this.Name = "client_interface";
            this.Size = new System.Drawing.Size(981, 572);
            this.client_container.ResumeLayout(false);
            this.client_container.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_container)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel client_container;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private TextBox name_contain;
        private PictureBox image_contain;
        private Label label5;
        private TextBox adresse_contain;
        private Label label4;
        private TextBox tel_contain;
        private Label label3;
        private TextBox cin_contain;
        private Label label2;
        private TextBox prename_contain;
        private Button del_btn;
        private Button edit_btn;
        private Button save_btn;
        private Button search_btn;
        private TextBox search_contain;
        private Button button1;
        private DataGridView list_container;
        private DataGridViewTextBoxColumn identifiant;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn adresse;
        private TextBox id_contain;
    }
}
