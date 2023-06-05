namespace Gestion_chambre
{
    partial class chambre_forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chambre_forms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_contain = new System.Windows.Forms.TextBox();
            this.list_chambre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.image_contain = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tarif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caractere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_chambre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.list_chambre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 572);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Controls.Add(this.search_contain);
            this.panel3.Location = new System.Drawing.Point(31, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 57);
            this.panel3.TabIndex = 2;
            this.panel3.UseWaitCursor = true;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(849, 9);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(52, 40);
            this.search_btn.TabIndex = 1;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.UseWaitCursor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_contain
            // 
            this.search_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_contain.ForeColor = System.Drawing.Color.White;
            this.search_contain.Location = new System.Drawing.Point(544, 9);
            this.search_contain.Multiline = true;
            this.search_contain.Name = "search_contain";
            this.search_contain.Size = new System.Drawing.Size(357, 40);
            this.search_contain.TabIndex = 0;
            this.search_contain.UseWaitCursor = true;
            // 
            // list_chambre
            // 
            this.list_chambre.AllowUserToAddRows = false;
            this.list_chambre.AllowUserToDeleteRows = false;
            this.list_chambre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.list_chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.list_chambre.Location = new System.Drawing.Point(394, 90);
            this.list_chambre.Name = "list_chambre";
            this.list_chambre.ReadOnly = true;
            this.list_chambre.RowHeadersVisible = false;
            this.list_chambre.RowTemplate.Height = 25;
            this.list_chambre.Size = new System.Drawing.Size(570, 468);
            this.list_chambre.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tarif";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.del_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.image_contain);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tarif);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.caractere);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numero);
            this.panel2.Location = new System.Drawing.Point(23, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 476);
            this.panel2.TabIndex = 0;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Red;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Image = ((System.Drawing.Image)(resources.GetObject("del_btn.Image")));
            this.del_btn.Location = new System.Drawing.Point(238, 436);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(100, 28);
            this.del_btn.TabIndex = 12;
            this.del_btn.Text = "Supprimer";
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
            this.edit_btn.Location = new System.Drawing.Point(113, 436);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(90, 28);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.Text = "Modifier";
            this.edit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Blue;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.Location = new System.Drawing.Point(15, 436);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(82, 28);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Ajouter";
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "c";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_contain
            // 
            this.image_contain.Location = new System.Drawing.Point(18, 280);
            this.image_contain.Name = "image_contain";
            this.image_contain.Size = new System.Drawing.Size(218, 125);
            this.image_contain.TabIndex = 8;
            this.image_contain.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarif : ";
            // 
            // tarif
            // 
            this.tarif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.tarif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tarif.ForeColor = System.Drawing.Color.White;
            this.tarif.Location = new System.Drawing.Point(16, 225);
            this.tarif.Multiline = true;
            this.tarif.Name = "tarif";
            this.tarif.Size = new System.Drawing.Size(318, 31);
            this.tarif.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteristique : ";
            // 
            // caractere
            // 
            this.caractere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.caractere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caractere.ForeColor = System.Drawing.Color.White;
            this.caractere.Location = new System.Drawing.Point(16, 110);
            this.caractere.Multiline = true;
            this.caractere.Name = "caractere";
            this.caractere.Size = new System.Drawing.Size(318, 73);
            this.caractere.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type : ";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(139, 37);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(195, 31);
            this.type.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero : ";
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numero.ForeColor = System.Drawing.Color.White;
            this.numero.Location = new System.Drawing.Point(16, 37);
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 31);
            this.numero.TabIndex = 0;
            // 
            // chambre_forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "chambre_forms";
            this.Size = new System.Drawing.Size(981, 572);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_chambre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_contain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox numero;
        private Label label1;
        private Button button1;
        private PictureBox image_contain;
        private Label label4;
        private TextBox tarif;
        private Label label3;
        private TextBox caractere;
        private Label label2;
        private TextBox type;
        private Button save_btn;
        private Button edit_btn;
        private Button del_btn;
        private DataGridView list_chambre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panel3;
        private TextBox search_contain;
        private Button search_btn;
    }
}
