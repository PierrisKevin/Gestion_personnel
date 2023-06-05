using MySql.Data.MySqlClient;

namespace Gestion_chambre
{
    partial class food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(food));
            this.panel1 = new System.Windows.Forms.Panel();
            this.liste_product = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_controld = new System.Windows.Forms.Panel();
            this.id_contain = new System.Windows.Forms.TextBox();
            this.add_image = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.image_contain = new System.Windows.Forms.PictureBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quatity_contain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prix_unitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_product)).BeginInit();
            this.form_controld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.liste_product);
            this.panel1.Controls.Add(this.form_controld);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 572);
            this.panel1.TabIndex = 0;
            // 
            // liste_product
            // 
            this.liste_product.AllowUserToAddRows = false;
            this.liste_product.AllowUserToDeleteRows = false;
            this.liste_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.liste_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.prix,
            this.quantity});
            this.liste_product.Location = new System.Drawing.Point(500, 181);
            this.liste_product.Name = "liste_product";
            this.liste_product.ReadOnly = true;
            this.liste_product.RowHeadersVisible = false;
            this.liste_product.RowTemplate.Height = 25;
            this.liste_product.Size = new System.Drawing.Size(461, 377);
            this.liste_product.TabIndex = 2;
            this.liste_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste_product_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantite";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // form_controld
            // 
            this.form_controld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.form_controld.Controls.Add(this.id_contain);
            this.form_controld.Controls.Add(this.add_image);
            this.form_controld.Controls.Add(this.del_btn);
            this.form_controld.Controls.Add(this.edit_btn);
            this.form_controld.Controls.Add(this.image_contain);
            this.form_controld.Controls.Add(this.add_btn);
            this.form_controld.Controls.Add(this.label5);
            this.form_controld.Controls.Add(this.quatity_contain);
            this.form_controld.Controls.Add(this.label4);
            this.form_controld.Controls.Add(this.prix_unitaire);
            this.form_controld.Controls.Add(this.label3);
            this.form_controld.Controls.Add(this.product_name);
            this.form_controld.Location = new System.Drawing.Point(20, 181);
            this.form_controld.Name = "form_controld";
            this.form_controld.Size = new System.Drawing.Size(462, 377);
            this.form_controld.TabIndex = 1;
            // 
            // id_contain
            // 
            this.id_contain.Location = new System.Drawing.Point(262, 263);
            this.id_contain.Name = "id_contain";
            this.id_contain.Size = new System.Drawing.Size(100, 23);
            this.id_contain.TabIndex = 11;
            // 
            // add_image
            // 
            this.add_image.Location = new System.Drawing.Point(163, 254);
            this.add_image.Name = "add_image";
            this.add_image.Size = new System.Drawing.Size(41, 23);
            this.add_image.TabIndex = 10;
            this.add_image.Text = "c";
            this.add_image.UseVisualStyleBackColor = true;
            this.add_image.Click += new System.EventHandler(this.add_image_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Image = ((System.Drawing.Image)(resources.GetObject("del_btn.Image")));
            this.del_btn.Location = new System.Drawing.Point(335, 338);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(109, 29);
            this.del_btn.TabIndex = 9;
            this.del_btn.Text = "supprimer";
            this.del_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.Location = new System.Drawing.Point(131, 338);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(99, 29);
            this.edit_btn.TabIndex = 8;
            this.edit_btn.Text = "modifier";
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // image_contain
            // 
            this.image_contain.Location = new System.Drawing.Point(18, 251);
            this.image_contain.Name = "image_contain";
            this.image_contain.Size = new System.Drawing.Size(136, 78);
            this.image_contain.TabIndex = 7;
            this.image_contain.TabStop = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.Location = new System.Drawing.Point(15, 338);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(99, 29);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Ajouter";
            this.add_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantite : ";
            // 
            // quatity_contain
            // 
            this.quatity_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.quatity_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quatity_contain.ForeColor = System.Drawing.Color.White;
            this.quatity_contain.Location = new System.Drawing.Point(15, 202);
            this.quatity_contain.Multiline = true;
            this.quatity_contain.Name = "quatity_contain";
            this.quatity_contain.Size = new System.Drawing.Size(429, 36);
            this.quatity_contain.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix unitaire : ";
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.prix_unitaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prix_unitaire.ForeColor = System.Drawing.Color.White;
            this.prix_unitaire.Location = new System.Drawing.Point(15, 123);
            this.prix_unitaire.Multiline = true;
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.Size = new System.Drawing.Size(429, 36);
            this.prix_unitaire.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom du produit : ";
            // 
            // product_name
            // 
            this.product_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.product_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_name.ForeColor = System.Drawing.Color.White;
            this.product_name.Location = new System.Drawing.Point(15, 41);
            this.product_name.Multiline = true;
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(429, 36);
            this.product_name.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(105, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 154);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produits";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(282, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 65);
            this.label6.TabIndex = 3;
            this.label6.Text = "Produit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(297, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Gestion";
            // 
            // food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "food";
            this.Size = new System.Drawing.Size(981, 572);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_product)).EndInit();
            this.form_controld.ResumeLayout(false);
            this.form_controld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel form_controld;
        private Label label3;
        private TextBox product_name;
        private Label label5;
        private TextBox quatity_contain;
        private Label label4;
        private TextBox prix_unitaire;
        private PictureBox image_contain;
        private Button add_btn;
        private Button del_btn;
        private Button edit_btn;
        private Button add_image;
        private DataGridView liste_product;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn prix;
        private DataGridViewTextBoxColumn quantity;
        private TextBox id_contain;
        private Label label7;
        private Label label6;
    }
}
