using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;


namespace GymNoteProject
{
    public partial class Weight : Form
    {

        // Pola
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        

        // Konstruktor
        public Weight()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PnlMenu.Controls.Add(leftBorderBtn);

            // Okno
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        // Kolory
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }
        
        
        //
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                
            }
        }

            private void DisableButton()
            {
                if(currentBtn != null)
                {
                    currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                    currentBtn.ForeColor = Color.White;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.White;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                }
            }

        // Przyciski boczne do wyświetlania wybranego okna
        private void BtnHome_Click(object sender, EventArgs e)
        {

            // Chowanie innych okien
            weightForm.Hide();
            exercisesForm.Hide();
            // Pokazanie aktualnie wybranego okna
            homeForm.Show();
            homeForm.BringToFront();
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnWeight_Click(object sender, EventArgs e)
        {

            // Chowanie innych okien
            homeForm.Hide();
            exercisesForm.Hide();
            // Pokazanie aktualnie wybranego okna
            weightForm.Show();
            weightForm.BringToFront();
            ActivateButton(sender, RGBColors.color2);
        }

        private void BtnExercises_Click(object sender, EventArgs e)
        {
            
            // Chowanie innych okien
            weightForm.Hide();
            homeForm.Hide();
            // Pokazanie aktualnie wybranego okna
            exercisesForm.Show();
            exercisesForm.BringToFront();
            ActivateButton(sender, RGBColors.color3);
        }
        


        // Przesuwanie okienka
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

  
        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {
            // Chowanie innych okien
            homeForm.Hide();
            weightForm.Hide();
            exercisesForm.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
