namespace Gestion_chambre
{
    partial class main_views
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_views));
            this.sieBars_contain = new System.Windows.Forms.Panel();
            this.facture_link = new System.Windows.Forms.Button();
            this.command_link = new System.Windows.Forms.Button();
            this.room_link = new System.Windows.Forms.Button();
            this.client_link = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.headear = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.dashboard1 = new Gestion_chambre.dashboard();
            this.client_interface1 = new Gestion_chambre.client_interface();
            this.sieBars_contain.SuspendLayout();
            this.headear.SuspendLayout();
            this.SuspendLayout();
            // 
            // sieBars_contain
            // 
            this.sieBars_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.sieBars_contain.Controls.Add(this.facture_link);
            this.sieBars_contain.Controls.Add(this.command_link);
            this.sieBars_contain.Controls.Add(this.room_link);
            this.sieBars_contain.Controls.Add(this.client_link);
            this.sieBars_contain.Controls.Add(this.button1);
            this.sieBars_contain.Dock = System.Windows.Forms.DockStyle.Left;
            this.sieBars_contain.Location = new System.Drawing.Point(0, 0);
            this.sieBars_contain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sieBars_contain.Name = "sieBars_contain";
            this.sieBars_contain.Size = new System.Drawing.Size(213, 610);
            this.sieBars_contain.TabIndex = 0;
            // 
            // facture_link
            // 
            this.facture_link.FlatAppearance.BorderSize = 0;
            this.facture_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facture_link.ForeColor = System.Drawing.Color.White;
            this.facture_link.Image = ((System.Drawing.Image)(resources.GetObject("facture_link.Image")));
            this.facture_link.Location = new System.Drawing.Point(3, 241);
            this.facture_link.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facture_link.Name = "facture_link";
            this.facture_link.Size = new System.Drawing.Size(189, 37);
            this.facture_link.TabIndex = 4;
            this.facture_link.Text = " Reservation";
            this.facture_link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.facture_link.UseVisualStyleBackColor = true;
            // 
            // command_link
            // 
            this.command_link.FlatAppearance.BorderSize = 0;
            this.command_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.command_link.ForeColor = System.Drawing.Color.White;
            this.command_link.Image = ((System.Drawing.Image)(resources.GetObject("command_link.Image")));
            this.command_link.Location = new System.Drawing.Point(3, 200);
            this.command_link.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.command_link.Name = "command_link";
            this.command_link.Size = new System.Drawing.Size(189, 37);
            this.command_link.TabIndex = 3;
            this.command_link.Text = " command";
            this.command_link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.command_link.UseVisualStyleBackColor = true;
            // 
            // room_link
            // 
            this.room_link.FlatAppearance.BorderSize = 0;
            this.room_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_link.ForeColor = System.Drawing.Color.White;
            this.room_link.Image = ((System.Drawing.Image)(resources.GetObject("room_link.Image")));
            this.room_link.Location = new System.Drawing.Point(3, 158);
            this.room_link.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room_link.Name = "room_link";
            this.room_link.Size = new System.Drawing.Size(189, 37);
            this.room_link.TabIndex = 2;
            this.room_link.Text = " chambre";
            this.room_link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.room_link.UseVisualStyleBackColor = true;
            // 
            // client_link
            // 
            this.client_link.FlatAppearance.BorderSize = 0;
            this.client_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_link.ForeColor = System.Drawing.Color.White;
            this.client_link.Image = ((System.Drawing.Image)(resources.GetObject("client_link.Image")));
            this.client_link.Location = new System.Drawing.Point(0, 117);
            this.client_link.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.client_link.Name = "client_link";
            this.client_link.Size = new System.Drawing.Size(189, 37);
            this.client_link.TabIndex = 1;
            this.client_link.Text = " client";
            this.client_link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.client_link.UseVisualStyleBackColor = true;
            this.client_link.Click += new System.EventHandler(this.client_link_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(9, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = " dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headear
            // 
            this.headear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headear.Controls.Add(this.exit_btn);
            this.headear.Dock = System.Windows.Forms.DockStyle.Top;
            this.headear.Location = new System.Drawing.Point(213, 0);
            this.headear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headear.Name = "headear";
            this.headear.Size = new System.Drawing.Size(981, 49);
            this.headear.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(921, 5);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(60, 27);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(213, 41);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(981, 569);
            this.dashboard1.TabIndex = 2;
            // 
            // client_interface1
            // 
            this.client_interface1.Location = new System.Drawing.Point(213, 41);
            this.client_interface1.Name = "client_interface1";
            this.client_interface1.Size = new System.Drawing.Size(981, 561);
            this.client_interface1.TabIndex = 3;
            // 
            // main_views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 610);
            this.Controls.Add(this.client_interface1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.headear);
            this.Controls.Add(this.sieBars_contain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main_views";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_views";
            this.sieBars_contain.ResumeLayout(false);
            this.headear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sieBars_contain;
        private Panel headear;
        private Button button1;
        private Button facture_link;
        private Button command_link;
        private Button room_link;
        private Button client_link;
        private Button exit_btn;
        private dashboard dashboard1;
        private client_interface client_interface1;
    }
}