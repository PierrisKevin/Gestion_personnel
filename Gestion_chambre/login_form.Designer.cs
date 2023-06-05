namespace Gestion_chambre
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.connexion_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.mdp_contain = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.username_contain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.connexion_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 592);
            this.panel1.TabIndex = 0;
            // 
            // connexion_btn
            // 
            this.connexion_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.connexion_btn.FlatAppearance.BorderSize = 0;
            this.connexion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion_btn.ForeColor = System.Drawing.Color.White;
            this.connexion_btn.Location = new System.Drawing.Point(50, 430);
            this.connexion_btn.Name = "connexion_btn";
            this.connexion_btn.Size = new System.Drawing.Size(395, 44);
            this.connexion_btn.TabIndex = 3;
            this.connexion_btn.Text = "Connexion";
            this.connexion_btn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.mdp_contain);
            this.panel3.Location = new System.Drawing.Point(47, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 63);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 48);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mdp_contain
            // 
            this.mdp_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.mdp_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdp_contain.ForeColor = System.Drawing.Color.White;
            this.mdp_contain.Location = new System.Drawing.Point(57, 7);
            this.mdp_contain.Multiline = true;
            this.mdp_contain.Name = "mdp_contain";
            this.mdp_contain.Size = new System.Drawing.Size(341, 48);
            this.mdp_contain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.username_contain);
            this.panel2.Location = new System.Drawing.Point(47, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 62);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 48);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // username_contain
            // 
            this.username_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.username_contain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_contain.ForeColor = System.Drawing.Color.White;
            this.username_contain.Location = new System.Drawing.Point(57, 8);
            this.username_contain.Multiline = true;
            this.username_contain.Name = "username_contain";
            this.username_contain.Size = new System.Drawing.Size(341, 48);
            this.username_contain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.Silver;
            this.exit_btn.Location = new System.Drawing.Point(433, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(43, 29);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "x";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 592);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox username_contain;
        private Panel panel3;
        private Button button2;
        private TextBox mdp_contain;
        private Button button1;
        private Button connexion_btn;
        private Button exit_btn;
    }
}