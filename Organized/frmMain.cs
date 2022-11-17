using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Organized.Properties;
using System.Xml;

namespace Organized
{
    public partial class frmMain : Form
    {
        public frmMain(User user)
        {
            InitializeComponent();
            this.user = user;
            vSata = pbxClock.Height;
            sSata = pbxClock.Width;
            sekundaraDuzina = 55;
            minutaraDuzina = 45;
            sataraDuzina = 30;
            clock = new Bitmap(sSata, vSata);
            centarX = sSata / 2;
            centarY = vSata / 2;
        }
        private User user;
        private DateTime danas = DateTime.Now;
        private void PrikaziKalendar()
        {
            calendarPanel.Controls.Clear();
            lblYearMonth.Text = String.Format("{0}, {1}", danas.ToString("MMMM"), danas.ToString("yyyy"));
            DateTime prviDanUMesecu = new DateTime(danas.Year, danas.Month, 1);
            int brojDanaUMesecu = DateTime.DaysInMonth(danas.Year, danas.Month);
            int brojPrvogDana = Convert.ToInt32(prviDanUMesecu.DayOfWeek.ToString("d")) + user.FirstWorkingDay;

            Label[] daniUNedelji = new Label[] { lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6, lblDay7 };
            string[] naziviDana = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int brojac = 0;
            for (int i = user.FirstWorkingDay + 1; i < 7; i++)
            {
                daniUNedelji[i].Text = naziviDana[brojac];
                brojac++;
            }
            for (int i = 0; i < user.FirstWorkingDay + 1; i++)
            {
                daniUNedelji[i].Text = naziviDana[brojac];
                brojac++;
            }

            for (int i = 0; i < brojPrvogDana; i++)
            {
                CalendarElementBlank b = new CalendarElementBlank();
                calendarPanel.Controls.Add(b);
            }
            for (int i = 1; i <= brojDanaUMesecu; i++)
            {
                int temp = 0;
                string path = user.KorisnikovFolder + "todo\\" +
                    danas.ToString("yyyy.MM.") + (i.ToString("00"));
                string[] a = null;
                if (Directory.Exists(path))
                {
                    temp = Directory.GetFiles(path).Length;
                    a = Directory.GetFiles(path);
                }
                else temp = 0;
                CalendarElementDay d = new CalendarElementDay(temp);
                for (int j = 0; j < temp; j++)
                {
                    d.PostaviEvent(File.ReadAllLines(a[j])[1]);
                }
                d.PostaviDan(i);
                calendarPanel.Controls.Add(d);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            PrikaziKalendar();
            UcitajEventove();
            lblWelcome.Text = "Welcome, " + user.Name + "!";
            cmbLanguage.SelectedIndex = user.Language == "en-US" ? 0 : 1;
            string prvi = user.DateFormat.Split('.')[0];
            string drugi = user.DateFormat.Split('.')[1];
            string treci = user.DateFormat.Split('.')[2];
            cmbDate1.SelectedItem = prvi;
            cmbDate2.SelectedItem = drugi;
            cmbDate3.SelectedItem = treci;
            int temp = 0;
            switch (user.FirstWorkingDay)
            {
                case -1:
                    temp = 0;
                    break;
                case 5:
                    temp = 1;
                    break;
                case 4:
                    temp = 2;
                    break;
                case 3:
                    temp = 3;
                    break;
                case 2:
                    temp = 4;
                    break;
                case 1:
                    temp = 5;
                    break;
                case 0:
                    temp = 6;
                    break;
            }
            cmbFirstDayOfWeek.SelectedIndex = temp;
            lblFocus.Focus();
            this.ActiveControl = lblFocus;
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            danas = danas.AddMonths(1);
            PrikaziKalendar();
        }

        private void pbxPrevious_Click(object sender, EventArgs e)
        {
            danas = danas.AddMonths(-1);
            PrikaziKalendar();
        }

        private void pbxNew_Click(object sender, EventArgs e)
        {
            frmEvent f = new frmEvent(user);
            f.ShowDialog();
            PrikaziKalendar();
            UcitajEventove();
        }

        private void pbxChangeMode_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabListView;
        }

        private void pbxChangeModeTab2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCalendarView;
        }
        private void UcitajEventove()
        {
            lbxEvents.Items.Clear();
            string pathToDo = user.KorisnikovFolder + "todo\\";
            string[] datumi = Directory.GetDirectories(pathToDo).Where(n => Convert.ToDateTime(Path.GetFileName(n)) >= DateTime.Now).ToArray();
            foreach (var item in datumi)
            {
                string[] fajlovi = Directory.GetFiles(item + "\\");
                foreach (var fajl in fajlovi)
                {
                    lbxEvents.Items.Add(String.Format("{0}: {1}", File.ReadAllLines(fajl)[0], File.ReadAllLines(fajl)[1]));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrikaziKalendar();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            DialogResult = DialogResult.OK;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (DialogResult == DialogResult.Cancel)
                {
                    if (MessageBox.Show("Are you sure you want to exit the application?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    else e.Cancel = true;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabSettings;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added in future updates. We're sorry for the inconvinience.", "We're sorry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbFirstDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument settingsFile = new XmlDocument();
            settingsFile.Load(user.KorisnikovFolder + "user-settings\\settings.xml");
            int temp = 0;
            switch (cmbFirstDayOfWeek.SelectedIndex)
            {
                case 0:
                    temp = -1;
                    break;
                case 1:
                    temp = 5;
                    break;
                case 2:
                    temp = 4;
                    break;
                case 3:
                    temp = 3;
                    break;
                case 4:
                    temp = 2;
                    break;
                case 5:
                    temp = 1;
                    break;
                case 6:
                    temp = 0;
                    break;
            }
            settingsFile.SelectSingleNode("SETTINGS/FirstWorkingDay").InnerText = temp.ToString();
            settingsFile.Save(user.KorisnikovFolder + "user-settings\\settings.xml");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCalendarView;
        }

        private void cmbDate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument settingsFile = new XmlDocument();
            settingsFile.Load(user.KorisnikovFolder + "user-settings\\settings.xml");
            settingsFile.SelectSingleNode("SETTINGS/DateFormat").InnerText = String.Format("{0}.{1}.{2}.",
                cmbDate1.Text, cmbDate2.Text, cmbDate3.Text);
            settingsFile.Save(user.KorisnikovFolder + "user-settings\\settings.xml");
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument settingsFile = new XmlDocument();
            settingsFile.Load(user.KorisnikovFolder + "user-settings\\settings.xml");
            string temp = "";
            switch (cmbLanguage.Text)
            {
                case "english":
                    temp = "en-US";
                    break;
                case "srpski (latinica)":
                    temp = "sr-Lat";
                    break;
                case "српски (ћирилица)":
                    temp = "sr-Cyrl";
                    break;
            }
            settingsFile.SelectSingleNode("SETTINGS/Language").InnerText = temp;
            settingsFile.Save(user.KorisnikovFolder + "user-settings\\settings.xml");
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            frmNotebook notebook = new frmNotebook(user);
            notebook.ShowDialog();
        }
        private int sSata;
        private int vSata;
        private int sekundaraDuzina;
        private int minutaraDuzina;
        private int sataraDuzina;
        private Bitmap clock;
        private Graphics gClock;
        private int centarX;
        private int centarY;
        private int[] KoordinateSekundareIMinutare(int vrednostNaSatu, int duzinaKazaljke)
        {
            int[] a = new int[2];
            vrednostNaSatu *= 6;
            a[1] = centarY - (int)(duzinaKazaljke * Math.Cos(Math.PI * vrednostNaSatu / 180));
            if (vrednostNaSatu >= 0 && vrednostNaSatu <= 180)
                a[0] = centarX + (int)(duzinaKazaljke * Math.Sin(Math.PI * vrednostNaSatu / 180));
            else
                a[0] = centarX - (int)(duzinaKazaljke * -Math.Sin(Math.PI * vrednostNaSatu / 180));
            return a;
        }
        private int[] KoordinateSatare(int vrednostNaSatuSata, int vrednostNaSatuMinuta, int duzinaKazaljke)
        {
            int[] a = new int[2];
            int vrednostNaSatu = (int)((vrednostNaSatuSata * 30) + (vrednostNaSatuMinuta * 0.5));
            a[1] = centarY - (int)(duzinaKazaljke * Math.Cos(Math.PI * vrednostNaSatu / 180));
            if (vrednostNaSatu >= 0 && vrednostNaSatu <= 180)
                a[0] = centarX + (int)(duzinaKazaljke * Math.Sin(Math.PI * vrednostNaSatu / 180));
            else
                a[0] = centarX - (int)(duzinaKazaljke * -Math.Sin(Math.PI * vrednostNaSatu / 180));
            return a;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            gClock = Graphics.FromImage(clock);
            int sat = DateTime.Now.Hour;
            int minut = DateTime.Now.Minute;
            int sekund = DateTime.Now.Second;
            gClock.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Black);
            gClock.DrawEllipse(pen, 0, 0, sSata, vSata);
            gClock.DrawLine(pen, centarX, 0, centarX, 10);
            gClock.DrawLine(pen, centarX, vSata, centarX, vSata - 10);
            gClock.DrawLine(pen, 0, centarY, 10, centarY);
            gClock.DrawLine(pen, sSata, centarY, sSata - 10, centarY);
            int[] a = KoordinateSekundareIMinutare(sekund, sekundaraDuzina);
            Pen pen2 = new Pen(Color.Red);
            gClock.DrawLine(pen2, centarX, centarY, a[0], a[1]);
            a = KoordinateSekundareIMinutare(minut, minutaraDuzina);
            gClock.DrawLine(pen, centarX, centarY, a[0], a[1]);
            a = KoordinateSatare(sat, minut, sataraDuzina);
            gClock.DrawLine(pen, centarX, centarY, a[0], a[1]);
            pbxClock.Image = clock;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            PrikaziKalendar();
            UcitajEventove();
        }
    }
}
