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
using MySqlX.XDevAPI;

namespace Gestion_chambre
{
    public partial class chambre_forms : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        int i = 0;

        connectDB dbCon = new connectDB();
        public chambre_forms()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbCon.dbConnect());
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.png)|**.jpg; *.png; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image_contain.Image = Image.FromFile(opf.FileName);
            }
        }

        public void loadData()
        {
            list_chambre.Rows.Clear();
            try
            {
                conn.Open();
                String query = "SELECT * FROM chambre";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list_chambre.Rows.Add(rd["num_chambre"].ToString(), rd["type"].ToString(), rd["tarif"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }
        public void searchChambre(String valeur)
        {
            list_chambre.Rows.Clear();
            try
            {
                conn.Open();
                String query = "SELECT * FROM chambre WHERE num_chambre=" + valeur + " or type LIKE '%" + valeur + "%'";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list_chambre.Rows.Add(rd["num_chambre"].ToString(), rd["type"].ToString(), rd["tarif"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }
        private void resetForm()
        {
            numero.Clear();
            type.Clear();
            caractere.Clear();
            tarif.Clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            String num = numero.Text;
            String tp = type.Text;
            String crt = caractere.Text;
            String trf = tarif.Text;

            MemoryStream ms = new MemoryStream();
            image_contain.Image.Save(ms, image_contain.Image.RawFormat);
            byte[] img = ms.ToArray();



            try
            {

                conn.Open();
                String query = "INSERT INTO chambre (num_chambre,Type,caracteristique,tarif, image) VALUES (@num, @type, @caract, @tarif, @image)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@type", tp);
                cmd.Parameters.AddWithValue("@caract", crt);
                cmd.Parameters.AddWithValue("@tarif", trf);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);

                cmd.Parameters["@image"].Value = img;


                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    MessageBox.Show("La chambre est ajouter avec succes !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

                conn.Close();
                resetForm();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            String searchValue = search_contain.Text;
            if (searchValue == "" || searchValue == null) loadData();
            else searchChambre(searchValue);
        }
    }
}
