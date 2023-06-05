using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Definitions.Series;

namespace Gestion_chambre
{

    public partial class dashboard : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        int i = 0;

        connectDB dbCon = new connectDB();
        public dashboard()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbCon.dbConnect());

            setNbrReservation();
            setDispo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void setNbrReservation()
        {
            try
            {
                conn.Open();
                String query = "SELECT COUNT(*) as nbr FROM reservation";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nbReservation.Text = rd["nbr"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setDispo()
        {
            try
            {
                conn.Open();
                String query = "SELECT COUNT(*) as nbr FROM chambre WHERE disponibilite=true";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dispo_nbt.Text = rd["nbr"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
