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

namespace Gestion_chambre
{
    public partial class client_interface : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        int i = 0;

        connectDB dbCon = new connectDB();
        public client_interface()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbCon.dbConnect());
            loadData();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            String client_name = name_contain.Text;
            String client_prenom = prename_contain.Text;
            String client_cin = cin_contain.Text;
            String client_tel = tel_contain.Text;
            String client_adresse = adresse_contain.Text;

            MemoryStream ms = new MemoryStream();
            image_contain.Image.Save(ms, image_contain.Image.RawFormat);
            byte[] img = ms.ToArray(); 



            try
            {

                conn.Open();
                String query = "INSERT INTO client (nom,prenom,adresse,numTel,CIN, photo) VALUES (@nom, @prenom, @adresse, @numTel, @cin, @photo)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", client_name);
                cmd.Parameters.AddWithValue("@prenom", client_prenom);
                cmd.Parameters.AddWithValue("@adresse", client_adresse);
                cmd.Parameters.AddWithValue("@numTel", client_tel);
                cmd.Parameters.AddWithValue("@cin", client_cin);
                cmd.Parameters.Add("@photo", MySqlDbType.Blob);

                cmd.Parameters["@photo"].Value = img; 


                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    loadData();
                    MessageBox.Show("Le client est ajouter avec succes !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetForm();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.png)|**.jpg; *.png; *.png";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                image_contain.Image = Image.FromFile(opf.FileName);
            }
        }

        public void resetForm()
        {
            name_contain.Text="";
            prename_contain.Text="";
            cin_contain.Text="";
            tel_contain.Text = "";
            adresse_contain.Text="";
            image_contain.Image = null;
        }
        public void loadData()
        {
            list_container.Rows.Clear();
            try
            {
                conn.Open();
                String query = "SELECT id,nom,prenom,adresse FROM client";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    list_container.Rows.Add(rd["id"].ToString(), rd["nom"].ToString(), rd["prenom"].ToString(), rd["adresse"].ToString());
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                
            }
            
        }
        public void SearchData(String valeur)
        {
            list_container.Rows.Clear();
            try
            {
                conn.Open();
                
                String query = "SELECT id,nom,prenom,adresse FROM client WHERE nom LIKE '%" + valeur +"%' OR prenom LIKE '%"+ valeur +"%'";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list_container.Rows.Add(rd["id"].ToString(), rd["nom"].ToString(), rd["prenom"].ToString(), rd["adresse"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            String searchValue = search_contain.Text;
            if (searchValue == "" || searchValue == null) loadData();
            else SearchData(searchValue);
        }

        private void list_container_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list_container.CurrentRow.Selected = true;
            String id = list_container.Rows[e.RowIndex].Cells["identifiant"].FormattedValue.ToString();

            //Resprise du valeur du client
            try
            {
                conn.Open();

                String query = "SELECT * FROM client WHERE id="+id;
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    resetForm();
                    name_contain.Text = rd["nom"].ToString();
                    prename_contain.Text = rd["prenom"].ToString();
                    cin_contain.Text = rd["CIN"].ToString();
                    tel_contain.Text = rd["adresse"].ToString();
                    adresse_contain.Text = rd["adresse"].ToString();
                    id_contain.Text = rd["id"].ToString();

                    image_contain.Image = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            String id = id_contain.Text;

            String client_name = name_contain.Text;
            String client_prenom = prename_contain.Text;
            String client_cin = cin_contain.Text;
            String client_tel = tel_contain.Text;
            String client_adresse = adresse_contain.Text;

            try
            {

                conn.Open();
                String query = "UPDATE client SET nom=@nom, prenom=@prenom, adresse=@adresse, CIN=@cin, numTel=@numtel WHERE id="+id;
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", client_name);
                cmd.Parameters.AddWithValue("@prenom", client_prenom);
                cmd.Parameters.AddWithValue("@adresse", client_adresse);
                cmd.Parameters.AddWithValue("@numtel", client_tel);
                cmd.Parameters.AddWithValue("@cin", client_cin);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Le client a ete modifie avec succes !", "Modification client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement", "Modification client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
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
    }
}
