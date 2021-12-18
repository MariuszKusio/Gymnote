using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymNoteProject
{
    public partial class HomeForm : UserControl
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        // Automatyczne wciśnięcie przycisku z Tipami po uruchomieniu programu
        private void HomeForm_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        
        
        // Przycisk do rosowych Tipów
        private void button1_Click(object sender, EventArgs e)
        {

            List<string> tips = new List<string>();
            
            tips.Add("Żeby budować masę mięśniową należy spożywać 1.5-2.5 gram białka na kilogram masy ciała dziennie.");
            tips.Add("Kreatyna wspomaga budowanie masy mięśniowej. Powinno przyjmować się ok. 5 gram kreatyny dziennie.");
            tips.Add("Bardzo ważnym czynnikiem jest odpoczynek. Mięśnie regenerują się(rosną) w czasie snu. Dlatego warto zadbać o dobry i wystarczająco długi sen. Przyjmuje się, że dla dobrej regeneracji należy spać od 7 do 9 godzin.");
            tips.Add("Przy okresie masy staraj się progresywnie zwiększać ciężar lub ilość powtórzeń z treningu na trening. Tylko progresja, która pozwoli na dosarczenie nowych bodźców mięśniom pozowoli na ich przyrost.");
            tips.Add("Pamiętaj, że bardzo ważnym elementem treningu jest nasz nastawienie psychiczne. Przekraczając bramy siłowni postaraj się myślec tylko o ciężarach i swoim progresie.");
            tips.Add("Każdy dzień jest dobrą drogą do twoich celów jeżeli zrobisz chociaż jeden mały krok w ich celu. Dlatego nawet dzien ze słaby treningiem jest lepszy niż z jego brakiem. Należy również pamietać o tych dniach nietreningowych dla rengenaracji bo te są równie ważne :)");
            tips.Add("Dieta jest tak samo ważna jak ćwiczenia. Zaplanuj dobrze swoją dietę w zależności od celu jaki chcesz osiągnąć. Jeżeli chcesz zrzucić kilogramy to odejmij kalorie od swojego dziennego zapotrzebowania, w przeciwnym wypadku dodaj kalorie. Warto też zadbać o jakość spożywanych posiłków.");
            tips.Add("Pamiętaj, że 'białko' w proszku jest jedynie dodatkiem, a nie zamiennikiem białka spożywanego w normalnych posiłkach. Najbardziej wartościowe białko to te z mięsa oraz nabiału. Takie białko przyswaja się o wiele lepiej co rzutuje na budowaniu jakościowej masy mięśniowej.");
            tips.Add("Rób pomiary swoich obwodów, wagi oraz rób zdjęcia swojej sylwetki. Pozwoli to na lepszą ocenę swojego progresu oraz tego czy wszystko idzie w dobrym kierunku");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Warto liczyć swoje spożyte kalori za pomocą aplikacji takich jak fitatu.");
            tips.Add("Jedyną osobą, która może cię zmotywować jesteś ty sam!");
            tips.Add("Nigdy się nie poddawaj. Na wielkie rzeczy potrzeba czasu.");
            tips.Add("Robiąc ćwiczenia zwracaj uwagę na technikę ich wykonywania. Warto nagrywać samego siebie i porównywać z filmami instruktażowymi.");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");
            tips.Add("Dobra muzyka to najlepsza przedtreningówka :)");


            Random rnd = new Random();
            int index = rnd.Next(tips.Count);

            TBTips.Text = tips[index].ToString();
        }

        // Panele z poroponowanymi kanałami oraz muzyką
        private void PnlYoutube_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.PnlYoutube.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void PnlMusic_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.PnlMusic.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        // Obrazki z proponowanymi kanałami, które po przyciśnięciu przekierowują na dany kanał
        private void PicYT1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/SzymonMoszny");
        }

        private void PicYT2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/Tabrox22");
        }

        private void PicYT3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/JizzzInMyPants");
        }

        private void PicYT4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/TrenerTV");
        }

        private void PicYT5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/monikakolakowska");
        }

        // Obrazki z proponowaną muzyką, która po przyciśnięciu przekierowuje na dany utwór
        private void PicMusic1_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/7z4cco7tnaLJHT2yiXtAl1?si=39fb5686fe1f4e9e");
        }

        private void PicMusic2_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/0xWXwib13plprHeqn2JvMe?si=21c7718020a84c80");
        }

        private void PicMusic3_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/5Ie5RZQsRAFaBy1EIBnc5e?si=9c5e41ae51904f40");
        }

        private void PicMusic4_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/5alzG89z5sn9fsYKfrk11W?si=950a312cc7044a8e");
        }

        private void PicMusic5_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/0a1gcnZhrVPtyj2acYr34n?si=828306ea98514949");
        }

        private void PicMusic6_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/3pMfi7OmK2f5cGAOjbEFNk?si=d16a80d07fcf495e");
        }

        private void PicMusic7_Click(object sender, EventArgs e)
        {
            Process.Start("https://open.spotify.com/track/39pMuJ3ShxDqb7bBIAXSYG?si=ce1e8d62f2724923");
        }

    }    
}
