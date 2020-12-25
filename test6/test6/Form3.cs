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

    public partial class Form3 : Form
    {
        int role;
        string delRole;
        string pathsclad;
        string adtov = "nottov";
        bool notClose = false;
        string[] roles = { "admin","cadr", "sclad", "kasprod", "buhg", "pokyp" };
        public Form3()
        {
            InitializeComponent();
            fio.Text = "";
            age.Text = "";
            obrazovanie.Text = "";
            exp.Text = "";

            MaximumSize = new Size(Size.Width, Size.Height);
            MinimumSize = new Size(Size.Width, Size.Height);
            if (test123.reg == true)
            {
                button.Click -= new EventHandler(button_Click);
                button.Click -= new EventHandler(reg_Click);
                button.Click += new EventHandler(reg_Click);
            }


        }

        public string logPassChecker(string text,string textLog, bool reg)
        {
            string psswd = "";
            string[] allDir;
            int findRole;
            //string[] alphabet = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
            string[] alphabetSpec = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "№", "[", "]", "{", "}", "\\", "|", "\'", "\"", ";", ":", "/", "<", ",", ">", ".", "?", "`","~"};
            //string text = exp.Text;
            //string textLog = obrazovanie.Text;
            int textLen = text.Length;
            if (fio.Text.Length > 5 && reg == true)
            {
                allDir = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\debug\user\");
                findRole = allDir.Length;
                for (int i = 0; i < findRole; i++)
                {
                    string[] files = Directory.GetFiles(allDir[i]);
                    int fileslen = files.Length;
                    string logintemp = "";
                    foreach (string file in files)
                    {

                        using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                        {
                            while (reader.PeekChar() > -1)
                            {

                                logintemp = reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();
                                reader.ReadString();

                            }
                            if (logintemp == fio.Text)
                            {
                                return "Такой логин уже существует";
                            }


                        }
                    }
                }
            }
            else if(fio.Text.Length < 5 && reg == true)
            {
                return "Логин должен быть более 5 символов";
            }
            else if (fio.Text.Length < 5 && reg == false)
            {
                return "ФИО должен быть более 5 символов";
            }
            try
            {
                if (int.Parse(age.Text) < 18)
                    return "Младше 18 лет запрещено";
                else if (int.Parse(age.Text) > 100)
                    return "Введите действительный возраст";             
            }
            catch
            {
                return "Введите число в поле возраста";
            }
            allDir = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\debug\user\");
            findRole = allDir.Length;
            for (int i = 0; i < findRole; i++)
            {
                string[] files = Directory.GetFiles(allDir[i]);
                int fileslen = files.Length;
                string logintemp = "";
                foreach (string file in files)
                {

                    using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                    {
                        while (reader.PeekChar() > -1)
                        {

                            string junk = reader.ReadString();
                            junk = reader.ReadString();
                            junk = reader.ReadString();
                            junk = reader.ReadString();
                            junk = reader.ReadString();
                            junk = reader.ReadString();
                            junk = reader.ReadString();
                            logintemp = reader.ReadString();
                            junk = reader.ReadString();

                        }
                        if (logintemp == textLog && reg == true)
                        {
                            return "Такая почта уже существует";
                        }
                        else if (logintemp == textLog && reg == false)
                            return "Такой логин уже существует";


                    }
                }
            }


            if (textLen < 8)
                return "Длина пароля должна быть минимум 8 символов";

            for (int i = 0; i < textLen - 2; i++)
            {
                if (char.IsUpper(text, i) && char.IsUpper(text, i + 1) && char.IsUpper(text,i+2))
                {
                    return "В пароле нельзя 3 заглавные подряд";
                }
                
            }
            int countBig = 0, countSpec = 0, countNumb = 0; ;
            for (int i = 0; i < textLen; i++)
            {
                if (char.IsUpper(text, i))
                {
                    countBig++;
                }
            }
            if (countBig < 3)
                return "В пароле нужно более 3 заглавных";

            for (int i = 0; i < textLen; i++)
            {
                foreach(string a in alphabetSpec)
                {
                    if (text[i].ToString() == a)
                        countSpec++;
                }
            }
            if (countSpec < 2)
                return "В пароле нужно более 2 специальных символов";

            for(int i = 0; i < textLen; i++)
            {
                if (char.IsDigit((char)text[i]))
                    countNumb++;
            }
            if (countNumb < 3)
                return "В пароле нужно более 3 цифр";

            for (int i = 0; i < textLen; i++)
            {
                
                if (char.IsLetter((char)text[i]))
                {
                    if ((int)(char.ToUpper(text[i])) < 64 || (int)(char.ToUpper(text[i])) > 91)
                    {
                        
                        return "В пароле нужны только латинские символы";
                    }
                }

            }
            if (reg == true)
            {
                for (int i = 0; i < fio.Text.Length; i++)
                {

                    if (char.IsLetter((char)fio.Text[i]))
                    {
                        if ((int)(char.ToUpper(fio.Text[i])) < 64 || (int)(char.ToUpper(fio.Text[i])) > 91)
                        {

                            return "В логине нужны только латинские символы";
                        }
                    }

                }
            }
            int dogChecker = 0;
            int dotChecker = 0;
            for (int i = 0; i < textLog.Length; i++)
            {

                if (char.IsLetter((char)textLog[i]))
                {
                    if ((int)(char.ToUpper(textLog[i])) < 64 || (int)(char.ToUpper(textLog[i])) > 91 && reg == true)
                    {

                        return "В почте нужны только латинские символы";
                    }
                    else if ((int)(char.ToUpper(textLog[i])) < 64 || (int)(char.ToUpper(textLog[i])) > 91 && reg ==false)
                        return "В логине только латинские буквы";

                }
                if (textLog[i] == '@')
                {
                    dogChecker++;
                    for (int j = i; j < textLog.Length; j++)
                    {
                        if (textLog[j] == '.')
                            dotChecker++;

                    }
                }

            }
            if ((dogChecker > 1 || dogChecker == 0 || dotChecker == 0 || textLog[textLog.Length - 1] == '.') && reg == true)
            {
                return "Неверный формат почты";
            }

            return "nice";
        }
        public void reg_Click(object sender,EventArgs e)
        {
            adtov = "tov";
            delRole = "nice";
            notClose = false;
            string status = logPassChecker(exp.Text,obrazovanie.Text,true);
            if (status == "nice")
            {

                using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\user\pokyp\{obrazovanie.Text}.dat", FileMode.OpenOrCreate)))
                {
                    write.Write(fio.Text);
                    write.Write(age.Text);
                    write.Write("-");
                    write.Write("-");
                    write.Write("pokyp");
                    write.Write("-");
                    write.Write("-");
                    write.Write(obrazovanie.Text);
                    write.Write(exp.Text);
                }

                MessageBox.Show("Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                delRole = "nice";
                notClose = false;
                Close();
            }
            else
            {
                MessageBox.Show(status, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void button_Click(object sender, EventArgs e)
        {
            save();

           
        }

        public void save()
        {
            string status = logPassChecker(password.Text, login.Text, false);
            if (status == "nice")
            {
                adtov = "tov";
                notClose = false;
                using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\user\{roles[role]}\{login.Text}.dat", FileMode.OpenOrCreate)))
                {
                    write.Write(fio.Text);
                    write.Write(age.Text);
                    write.Write(obrazovanie.Text);
                    write.Write(exp.Text);
                    write.Write(roles[role]);
                    write.Write(place.Text);
                    write.Write(zp.Text);
                    write.Write(login.Text);
                    write.Write(password.Text);
                }
                //File.Delete(Directory.GetCurrentDirectory() + $@"\debug\user\{}\temp_{login.Text}.dat");
                Close();
            }
            else
            {
                notClose = true;
                MessageBox.Show(status, "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = comboBox1.SelectedIndex;
            switch (role)
            {
                case 0:
                    zp.Text =(70000 - 70000 * 0.13).ToString();
                    enableAll();
                    break;   
                case 1:      
                    zp.Text =(50000 - 50000 * 0.13).ToString();
                    enableAll();
                    break;   
                case 2:      
                    zp.Text =(30000- 30000 * 0.13).ToString();
                    enableAll();
                    break;   
                case 3:      
                    zp.Text =( 40000- 40000 * 0.13).ToString();
                    enableAll();
                    break;
                case 4:
                    zp.Text = (50000- 50000 * 0.13).ToString();
                    enableAll();
                    break;
                case 5:
                    obrazovanie.Enabled = false;
                    exp.Enabled = false;
                    place.Enabled = false;
                    zp.Enabled = false;
                    obrazovanie.Text = "-";
                    exp.Text = "-";
                    place.Text = "-";
                    zp.Text = "-";
                    break;



            }
        }
        private void enableAll()
        {
            obrazovanie.Enabled = true;
            exp.Enabled = true;
            place.Enabled = true;

            //obrazovanie.Text = "";
            //exp.Text = "";
            //place.Text = "";

        }
        public void addtov(object sender, EventArgs e)
        {
            delRole = "nice";
            adtov = "tov";
            int count = 0;
            notClose = false;
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}");
            if (File.Exists($@"debug\sclad\{exp.Text}\{fio.Text}.dat"))
            {

                using (BinaryReader reader = new BinaryReader(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}\{fio.Text}.dat", FileMode.OpenOrCreate)))
                {
                    reader.ReadString();
                    reader.ReadString();
                    count = int.Parse(reader.ReadString());
                    reader.ReadString();
                }
                if (int.Parse(obrazovanie.Text) > 99 - count)
                {
                    MessageBox.Show($"На складе уже {count} такого товара, максимум 99", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}\{fio.Text}.dat", FileMode.OpenOrCreate)))
                    {
                        write.Write(fio.Text);
                        write.Write(age.Text);
                        write.Write((count + int.Parse(obrazovanie.Text)).ToString());
                        write.Write(exp.Text);
                    }
                    Close();
                }
            }
            else
            {
                if (int.Parse(obrazovanie.Text) > 99 - count)
                {
                    MessageBox.Show($"На складе уже {count} такого товара, максимум 99", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}\{fio.Text}.dat", FileMode.OpenOrCreate)))
                    {
                        write.Write(fio.Text);
                        write.Write(age.Text);
                        write.Write(obrazovanie.Text);
                        write.Write(exp.Text);
                    }
                    Close();
                }
            }
           
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((fio.Text.Length > 0 || age.Text.Length > 0 || exp.Text.Length > 0 || obrazovanie.Text.Length > 0 || comboBox1.Text.Length > 0 || place.Text.Length > 0 || zp.Text.Length > 0 ||
                login.Text.Length > 0 || password.Text.Length > 0) && adtov == "nottov")
            {
                delRole = "bad";
                notClose = true;
            }
            else if(adtov == "tov")
            {
                delRole = "nice";
                notClose = false;
            }
            if (delRole != "nice")
                save();
            if (notClose == true)
                e.Cancel = true;
     
        }
    }
}
