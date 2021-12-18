using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web.UI.WebControls;


namespace GymNoteProject
{
    public partial class WeightForm : UserControl
    {
        public WeightForm()
        {
            InitializeComponent();
        }
        // connection path
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kusio\source\repos\GymNoteProject\GymNoteProject\MyDatabase.mdf;Integrated Security=True");
        
        private void populate()
        {
            Con.Open();
            string query = "select * from WeightTable1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TbWeight.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Przycisk dodający nową pozycję po wpisaniu wagi do textbox'u. Wysyła on kod do bazy danych wraz z wartością wpisaną w texbox'ie.
        // Dodatkowo wykorzystujemy GETDATE() do automatycznego pobrania daty z systemu i wprowadzenia jej do bazy danych. W bazie danych
        // Jest użyta auto inkrementacja ID, dzięki czemu użytkownik nie musi wpisywać tego paremetru.
        private void BtnWeightAdd_Click_1(object sender, EventArgs e)
        {
            if (BoxWightAdd.Text == "")
            {
                MessageBox.Show("Enter your weight");
            }
            else
            {
                try
                {

                    Con.Open();
                    string query = "insert into WeightTable1 (Date, Weight) values (GETDATE(), '" + BoxWightAdd.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Weight added succesfully!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Con.Close();
                }
            }
        }

        // Przechwytywanie ID wybranej pozycji przez textbox
        private void TbWeight_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                DataGridViewRow TbRow = TbWeight.Rows[e.RowIndex];
                BoxDeleteWeight.Text = TbRow.Cells[0].Value.ToString();

            }
            
        }
        // Przycisk do usuwania pozycji. Jeżeli nie zostanie zaznaczona żadna pozycja to wyświetli się komunikat o prośbie wyboru pozycji. Przy 
        // wybranej pozycji, usuwa się ona z bazy danych jak i z aplikacji. Wykorzystany został tutaj textbox który przechwytuje ID wybranej pozycji
        // i następnie przekazuje go w kodzie do bazy danych dzięki czemu usuwana jest wybrana pozycja.
        private void BtnDeleteRow_Click_1(object sender, EventArgs e)
        {
            if (BoxDeleteWeight.Text == "")
            {
                MessageBox.Show("Select row to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from WeightTable1 where WID ='" + BoxDeleteWeight.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Weight deleted succesfully!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(Ex.Message);
                    Con.Close();
                }

            }
        }

        // populate okna
        private void WeightForm_Load_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
