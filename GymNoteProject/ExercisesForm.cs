using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymNoteProject
{
    public partial class ExercisesForm : UserControl
    {
        public ExercisesForm()
        {
            InitializeComponent();
        }

        //connection path
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kusio\source\repos\GymNoteProject\GymNoteProject\MyDatabase.mdf;Integrated Security=True");
        
        private void populate()
        {
            Con.Open();
            string query = "select * from Excercises";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TbExList.DataSource = ds.Tables[0];
            Con.Close();
        }

        // Buttons

        // Przycisk do dodawania ćwiczenia. Przy uzupełnionych dwóch potrzebnych textbox'ach można dodać pozycję. Zostaje wtedy otwarte połączenie
        // z bazą danych i wysyłany jest kod, który dodaje podane wartości do tabeli Excercises. Następnie wysietlany jest komunikat o udanym 
        // dodaniu pozycji i połączenie z bazą danych jest zamykane.
        private void BtnNameAdd_Click(object sender, EventArgs e)
        {
            if (BoxExIDAdd.Text == "" || BoxExNameAdd.Text == "")
            {
                MessageBox.Show("Enter missing values");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Excercises values('"+BoxExIDAdd.Text+"','"+BoxExNameAdd.Text+"','"+0+"','"+0+"','"+0+ "','" +0+ "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excercises added succesfully!");
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
        // Przycisk do aktualizacji wybranych ćwiczeń. Pozwala na zmianę wartości w wybranej pozycji. Działa analogicznie jak przycisk dodawania pozycji.
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (BoxExIDUp.Text == "" || BoxSeries.Text == "" || BoxRepeat.Text == "" || BoxLoad.Text == "")
            {
                MessageBox.Show("Enter missing values");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Excercises set Exseries='" + BoxSeries.Text + "', ExRepeat='" + BoxRepeat.Text + "',ExKg='" + BoxLoad.Text + "',ExDay='" + BoxDayPicker.Text.ToString() + "' where ExID='" + BoxExIDUp.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excercises updated succesfully!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();
                }
                
            }
        }

        // Przycisk usuwania pozycji. Usuwa pozycję o wpisanym przez użytkownika ID. Wysyła do bazy danych kod, w którym wskazywana jest pozycja
        // do usunięcia o podanym ID.
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            
            if (BoxExIDAdd.Text == "")
            {
                MessageBox.Show("Enter ID to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Excercises where ExID ='" + BoxExIDAdd.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excercises deleted succesfully!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();
                }

            }
        }

        private void ExercisesForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        // Przechwytywanie wartości przez textbox'y kiedy zostaje wybrana pozycja.
        private void TbExList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow TbRow = TbExList.Rows[e.RowIndex];
                BoxExIDUp.Text = TbRow.Cells[0].Value.ToString();
                BoxSeries.Text = TbRow.Cells[2].Value.ToString();
                BoxRepeat.Text = TbRow.Cells[3].Value.ToString();
                BoxLoad.Text = TbRow.Cells[4].Value.ToString();
                
                BoxExIDAdd.Text = TbRow.Cells[0].Value.ToString();
                BoxExNameAdd.Text = TbRow.Cells[1].Value.ToString();

            }           
        }        
    }
}
