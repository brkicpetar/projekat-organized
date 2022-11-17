using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Organized
{
    public class User
    {
        private string username;
        private string password;
        private string name;
        private XmlDocument fajl;
        public User()
        {
            fajl = new XmlDocument();
            if (!File.Exists("Users.xml"))
            {
                fajl.AppendChild(fajl.CreateElement("USERS"));
                fajl.Save("Users.xml");
            }
            else fajl.Load("Users.xml");
        }
        public User(string username, string password)
        {
            fajl = new XmlDocument();
            if (!File.Exists("Users.xml"))
            {
                fajl.AppendChild(fajl.CreateElement("USERS"));
                fajl.Save("Users.xml");
            }
            else fajl.Load("Users.xml");

            this.username = username;
            this.password = password;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get
            {
                XmlDocument settingsFile = new XmlDocument();
                settingsFile.Load(KorisnikovFolder + "user-settings\\settings.xml");
                return settingsFile.SelectSingleNode("SETTINGS/Name").InnerText;
            }
            set { name = value; }
        }
        internal string KorisnikovFolder
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Organized\\" + HashString(username) + "\\"; }
        }
        public string DateFormat
        {
            get
            {
                XmlDocument settingsFile = new XmlDocument();
                settingsFile.Load(KorisnikovFolder + "user-settings\\settings.xml");
                XmlNodeList list = settingsFile.SelectNodes("SETTINGS/DateFormat");
                return list[0].InnerText;
            }
        }
        public string Language
        {
            get
            {
                XmlDocument settingsFile = new XmlDocument();
                settingsFile.Load(KorisnikovFolder + "user-settings\\settings.xml");
                XmlNodeList list = settingsFile.SelectNodes("SETTINGS/Language");
                return list[0].InnerText;
            }
        }
        private void CreateStructure()
        {
            Directory.CreateDirectory(KorisnikovFolder);
            Directory.CreateDirectory(KorisnikovFolder + "sketches");
            Directory.CreateDirectory(KorisnikovFolder + "todo");
            Directory.CreateDirectory(KorisnikovFolder + "user-settings");
        }
        private void CreateUserSettings()
        {
            File.Copy("UserSettings-template.xml", KorisnikovFolder + "user-settings\\settings.xml", true);
            XmlDocument settingsFile = new XmlDocument();
            settingsFile.Load(KorisnikovFolder + "user-settings\\settings.xml");
            XmlNode glGrana = settingsFile.SelectSingleNode("SETTINGS");
            XmlElement name = settingsFile.CreateElement("Name");
            name.InnerText = this.name;
            glGrana.AppendChild(name);
            XmlElement prviRadniDan = settingsFile.CreateElement("FirstWorkingDay");
            prviRadniDan.InnerText = "-1";
            glGrana.AppendChild(prviRadniDan);
            XmlElement dateFormat = settingsFile.CreateElement("DateFormat");
            dateFormat.InnerText = "dd.MM.yyyy.";
            glGrana.AppendChild(dateFormat);
            XmlElement language = settingsFile.CreateElement("Language");
            language.InnerText = "en-US";
            glGrana.AppendChild(language);
            settingsFile.Save(KorisnikovFolder + "user-settings\\settings.xml");
        }
        public int FirstWorkingDay
        {
            get
            {
                XmlDocument settingsFile = new XmlDocument();
                settingsFile.Load(KorisnikovFolder + "user-settings\\settings.xml");
                XmlNodeList list = settingsFile.SelectNodes("SETTINGS/FirstWorkingDay");
                return int.Parse(list[0].InnerText);
            }
        }
        internal static string HashString(string inputString)
        {
            byte[] encData = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(inputString));
            StringBuilder bob = new StringBuilder();
            for (int i = 0; i < encData.Length; i++)
            {
                bob.Append(encData[i].ToString("x2"));
            }
            return bob.ToString();
        }
        public bool TryLogin()
        {
            XmlNodeList korisnici = fajl.SelectNodes("USERS/USER");
            foreach (XmlNode korisnik in korisnici)
            {
                if (korisnik.ChildNodes[0].InnerText.Trim() == HashString(username.Trim()) && korisnik.ChildNodes[1].InnerText.Trim() == HashString(password.Trim()))
                    return true;
            }
            return false;
        }
        public static bool TryLogin(string username, string password)
        {
            XmlDocument fajl = new XmlDocument();
            fajl.Load("Users.xml");
            XmlNodeList korisnici = fajl.SelectNodes("USERS/USER");
            foreach (XmlNode korisnik in korisnici)
            {
                if (HashString(korisnik.ChildNodes[0].InnerText.Trim()) == username.Trim() && HashString(korisnik.ChildNodes[1].InnerText.Trim()) == password.Trim())
                    return true;
            }
            return false;
        }
        public bool TryRegister()
        {
            XmlNode glavnaGrana = fajl.SelectSingleNode("USERS");
            XmlNodeList list = fajl.SelectNodes("USERS/USER/username");
            foreach (XmlNode node in list)
            {
                if (node.InnerText == HashString(username)) return false;
            }
            XmlElement korisnik = fajl.CreateElement("USER");
            glavnaGrana.AppendChild(korisnik);
            XmlElement korisnickoIme = fajl.CreateElement("username");
            XmlElement lozinka = fajl.CreateElement("password");
            korisnickoIme.InnerText = HashString(this.username);
            lozinka.InnerText = HashString(this.password);
            korisnik.AppendChild(korisnickoIme);
            korisnik.AppendChild(lozinka);
            XmlAttribute idKorisnika = fajl.CreateAttribute("id");
            idKorisnika.Value = fajl.SelectNodes("USERS/USER").Count.ToString();
            korisnik.Attributes.Append(idKorisnika);
            fajl.Save("Users.xml");
            CreateStructure();
            CreateUserSettings();
            return true;
        }
    }
}
