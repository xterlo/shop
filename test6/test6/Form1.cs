using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test6
{

    struct Person
    {
        public static string fio;
        public static string age;
        public static string obrazovanie;
        public static string exp;
        public static string role;
        public static string place;
        public static string zp;
        public static string login;
        public static string password;
        public Person(string f,string a,string o,string e,string r,string p,string z,string l,string pas)
        {
            fio = f;
            age = a;
            obrazovanie = o;
            exp = e;
            role = r;
            place = p;
            zp = z;
            login = l;
            password = pas;
        }
    }
    public partial class Form1 : Form
    {
        string[] roles = { "Администратор", "Кадры", "Склад", "Кассир-продавец", "Бухгалтер", "Покупатель" };
        string[] rolesNorm = { "admin", "cadr", "sclad", "kasprod", "buhg", "pokyp" };
        public string login { get; set; }
        public int role;
        public static string pathMain = Directory.GetCurrentDirectory() + @"\debug";
        public static string pathUser = Directory.GetCurrentDirectory() + @"\debug\user\";
        public static string pathSclad = Directory.GetCurrentDirectory() + @"\debug\sclad\";
        public Form1()
        {
            if (Directory.Exists(pathMain) == false)
            {
                Directory.CreateDirectory(pathUser + @"\admin\");
                Directory.CreateDirectory(pathUser + @"\cadr\");
                Directory.CreateDirectory(pathUser + @"\sclad\");
                Directory.CreateDirectory(pathUser + @"\kasprod\");
                Directory.CreateDirectory(pathUser + @"\buhg\");
                Directory.CreateDirectory(pathUser + @"\pokyp\");
                Directory.CreateDirectory(pathUser + @"\admin\delete\");
                Directory.CreateDirectory(pathUser + @"\cadr\delete");
                Directory.CreateDirectory(pathUser + @"\sclad\delete\");
                Directory.CreateDirectory(pathUser + @"\kasprod\delete\");
                Directory.CreateDirectory(pathUser + @"\buhg\delete\");
                Directory.CreateDirectory(pathUser + @"\pokyp\delete\");
                Directory.CreateDirectory(pathUser + @"\buy\");
                Directory.CreateDirectory(pathUser + @"\pokyp\korzina\");
                Directory.CreateDirectory(pathSclad);
                using (BinaryWriter writer = new BinaryWriter(File.Open(pathUser + @"admin\admin.dat", FileMode.OpenOrCreate)))
                {
                    writer.Write("Шорин Евгений Максимович");
                    writer.Write("17");
                    writer.Write("Высшее");
                    writer.Write("15 лет");
                    writer.Write("admin");
                    writer.Write("Марс");
                    writer.Write("15к");
                    writer.Write("admin");
                    writer.Write("admin");
                }        
            }
            InitializeComponent();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            role = finder(loginString.Text, passwordString.Text);
            if (role != 900)
            {
                test123.role = role;
                Form2 mainMenu = new Form2();
                mainMenu.textRole.Text = roles[role];
                Hide();
                mainMenu.Show();
            }

            else
            {
                MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int finder(string login,string password)
        {
            int result = 900;
            string psswd = "";
            string[] allDir = Directory.GetDirectories(pathUser);
            //string[] cadr = Directory.GetFiles(pathUser+ @"\cadr\");
            //string[] sclad = Directory.GetFiles(pathUser+ @"\sclad\");
            //string[] kasprod = Directory.GetFiles(pathUser+ @"\kasprod\");
            //string[] buhg = Directory.GetFiles(pathUser+ @"\buhg\");
            //string[] pokyp = Directory.GetFiles(pathUser+ @"\pokyp\");
            int findRole = allDir.Length;
            for( int i = 0; i < findRole; i++)
            {
                string[] files = Directory.GetFiles(allDir[i]);
               
                foreach (string file in files){
                    string logintemp="";
                    string role__="";
                    int fileLen = file.Split('\\').Length;
                    if (file.Split('\\')[fileLen - 1] == $@"{login}.dat")
                    {
                        using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                        {
                            while (reader.PeekChar() > -1)
                            {

                                string junk = reader.ReadString();
                                junk = reader.ReadString();
                                junk = reader.ReadString();
                                junk = reader.ReadString();
                                role__ = reader.ReadString();
                                junk = reader.ReadString();
                                junk = reader.ReadString();
                                logintemp = reader.ReadString();
                                psswd = reader.ReadString();
                                
                            }
                            if (psswd == password)
                            {
                                test123.namepokyp = logintemp;
                                result = Array.IndexOf(rolesNorm,role__);
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            test123.reg = true;
            Form3 reg = new Form3();
            reg.label8.Hide();
            reg.label9.Hide();
            reg.label4.Hide();
            reg.label6.Hide();
            reg.label7.Hide();
            reg.comboBox1.Hide();
            reg.place.Hide();
            reg.zp.Hide();
            reg.login.Hide();
            reg.password.Hide();
            reg.button.Location = new Point(12, 214);
            reg.button.Text = "Зарегистрироваться";
            reg.Size = new Size(347,300);
            reg.label3.Text = "Почта";
            reg.label2.Text = "Пароль";
            
            reg.ShowDialog();
        }
    }
}
