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
    public partial class food : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        int i = 0;

        connectDB dbCon = new connectDB();
        public food()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbCon.dbConnect());
            loadData();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            String food_name = product_name.Text;
            String food_price = prix_unitaire.Text;
            String foodQuantity = quatity_contain.Text;

            /*MemoryStream ms = new MemoryStream();
            image_contain.Image.Save(ms, image_contain.Image.RawFormat);
            byte[] img = ms.ToArray(); */



            try
            {

                conn.Open();
                String query = "INSERT INTO produit (nom_product,prix_unitaire,quantity) VALUES (@nom, @prix, @quantity)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", food_name);
                cmd.Parameters.AddWithValue("@prix", food_price);
                cmd.Parameters.AddWithValue("@quantity", foodQuantity);

                /*cmd.Parameters.Add("@photo", MySqlDbType.Blob);

                cmd.Parameters["@photo"].Value = img; */


                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Enregistrer avec succes !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                conn.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_image_Click(object sender, EventArgs e)
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
            liste_product.Rows.Clear();
            try
            {
                conn.Open();
                String query = "SELECT id,nom_product,prix_unitaire,quantity FROM produit";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    liste_product.Rows.Add(rd["id"].ToString(), rd["nom_product"].ToString(), rd["prix_unitaire"].ToString(), rd["quantity"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public void searchData(String valeur)
        {
            liste_product.Rows.Clear();
            try
            {
                conn.Open();
                String query = "SELECT id,nom_produit,prix_unitaire,quantity FROM produit WHERE nom_produit LIKE '%"+valeur+"%'";
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    liste_product.Rows.Add(rd["id"].ToString(), rd["nom_produit"].ToString(), rd["prix_unitaire"].ToString(), rd["quantity"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void liste_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            liste_product.CurrentRow.Selected = true;
            String id = liste_product.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            id_contain.Text = id;
            //Resprise du valeur du client
            try
            {
                conn.Open();

                String query = "SELECT * FROM produit WHERE id=" + id;
                cmd = new MySqlCommand(query, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    resetForm();
                    product_name.Text = rd["nom_product"].ToString();
                    prix_unitaire.Text = rd["prix_unitaire"].ToString();
                    quatity_contain.Text = rd["quantity"].ToString();

                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void resetForm()
        {
            product_name.Clear();
            prix_unitaire.Clear();
            quatity_contain.Clear();
            image_contain.Image = null;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            String id_product = id_contain.Text;

            String food_name = product_name.Text;
            String food_price = prix_unitaire.Text;
            String foodQuantity = quatity_contain.Text;

            try
            {

                conn.Open();
                String query = "UPDATE produit SET nom_product=@nom, prix_unitaire=@prix, quantity=@quantity WHERE id=" + id_product;
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", food_name);
                cmd.Parameters.AddWithValue("@prix", food_price);
                cmd.Parameters.AddWithValue("@quantity", foodQuantity);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Le produit a ete modifie avec succes !", "Modification Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement", "Modification Prouit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void del_btn_Click(object sender, EventArgs e)
        {
            String id_product = id_contain.Text;
            try
            {

                conn.Open();
                String query = "DELETE FROM produit WHERE id=" + id_product;
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Le produit a ete Supprimer avec succes !", "Suppresion Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Echec de suppresion", "Suppresion Prouit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
