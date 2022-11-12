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
    internal class User
    {
        private string username;
        private string password;
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

        private void CreateStructure()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Organized\\" + HashString(username);
            Directory.CreateDirectory(appDataFolder);
            Directory.CreateDirectory(appDataFolder + "\\sketches");
            Directory.CreateDirectory(appDataFolder + "\\todo");
            Directory.CreateDirectory(appDataFolder + "\\user-settings");
        }  
        protected static string HashString(string inputString)
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
                if (HashString(korisnik.ChildNodes[0].InnerText.Trim()) == username.Trim() && HashString(korisnik.ChildNodes[1].InnerText.Trim()) == password.Trim())
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
                MessageBox.Show(node.InnerText);
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
            return true;
        }
    }
}
