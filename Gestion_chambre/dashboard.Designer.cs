using Google.Protobuf.WellKnownTypes;
using LiveCharts;
using LiveCharts.Wpf;

using MySql.Data.MySqlClient;

namespace Gestion_chambre
{
    partial class dashboard
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
            this.dash_container = new System.Windows.Forms.Panel();
            this.chart_contain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.price_value = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.name_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dispo_nbt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nbReservation = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.dash_container.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_container
            // 
            this.dash_container.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dash_container.Controls.Add(this.chart_contain);
            this.dash_container.Controls.Add(this.panel3);
            this.dash_container.Controls.Add(this.panel1);
            this.dash_container.Controls.Add(this.panel2);
            this.dash_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dash_container.Location = new System.Drawing.Point(0, 0);
            this.dash_container.Name = "dash_container";
            this.dash_container.Size = new System.Drawing.Size(981, 572);
            this.dash_container.TabIndex = 0;
            // 
            // chart_contain
            // 
            this.chart_contain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.chart_contain.Location = new System.Drawing.Point(22, 174);
            this.chart_contain.Name = "chart_contain";
            this.chart_contain.Size = new System.Drawing.Size(555, 384);
            this.chart_contain.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.price_value);
            this.panel3.Controls.Add(this.price_label);
            this.panel3.Controls.Add(this.name_value);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(594, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 390);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 229);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // price_value
            // 
            this.price_value.AutoSize = true;
            this.price_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.price_value.Location = new System.Drawing.Point(68, 113);
            this.price_value.Name = "price_value";
            this.price_value.Size = new System.Drawing.Size(38, 15);
            this.price_value.TabIndex = 4;
            this.price_value.Text = "label6";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.price_label.Location = new System.Drawing.Point(20, 115);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(36, 15);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Prix : ";
            // 
            // name_value
            // 
            this.name_value.AutoSize = true;
            this.name_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_value.Location = new System.Drawing.Point(69, 82);
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(38, 15);
            this.name_value.TabIndex = 2;
            this.name_value.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Le produit le plus vendu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.dispo_nbt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(312, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 131);
            this.panel1.TabIndex = 2;
            // 
            // dispo_nbt
            // 
            this.dispo_nbt.AutoSize = true;
            this.dispo_nbt.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dispo_nbt.ForeColor = System.Drawing.Color.White;
            this.dispo_nbt.Location = new System.Drawing.Point(13, 52);
            this.dispo_nbt.Name = "dispo_nbt";
            this.dispo_nbt.Size = new System.Drawing.Size(82, 65);
            this.dispo_nbt.TabIndex = 1;
            this.dispo_nbt.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chambre disponible";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.nbReservation);
            this.panel2.Controls.Add(this.label_nombre);
            this.panel2.Location = new System.Drawing.Point(16, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 131);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nbReservation
            // 
            this.nbReservation.AutoSize = true;
            this.nbReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbReservation.ForeColor = System.Drawing.Color.White;
            this.nbReservation.Location = new System.Drawing.Point(13, 52);
            this.nbReservation.Name = "nbReservation";
            this.nbReservation.Size = new System.Drawing.Size(82, 65);
            this.nbReservation.TabIndex = 1;
            this.nbReservation.Text = "00";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.ForeColor = System.Drawing.Color.White;
            this.label_nombre.Location = new System.Drawing.Point(13, 13);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(128, 15);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre de reservation";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dash_container);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(981, 572);
            this.dash_container.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /*
        public void addChart()
        {
            LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart();
            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries{
                    Title = "Series";
                    Values = new ChartValues<double> { 1, 4, 2, 5 };
                }
            };
        }
        */
        public void setValeur()
        {

        }

        private Panel dash_container;
        private Panel panel2;
        private Label nbReservation;
        private Label label_nombre;
        private Panel panel3;
        private Panel panel1;
        private Label dispo_nbt;
        private Label label3;
        private Panel chart_contain;
        private Label label4;
        private Label label5;
        private Label price_label;
        private Label name_value;
        private Label price_value;
        private PictureBox pictureBox1;
    }
}
