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
        string pathsclad;
        string[] roles = { "admin", "cadr", "sclad", "kasprod", "buhg", "pokyp" };
        public Form3()
        {
            InitializeComponent();
            if (test123.reg == true)
            {
                button.Click -= new EventHandler(button_Click);
                button.Click += new EventHandler(reg_Click);
            }

        }
        public void reg_Click(object sender,EventArgs e)
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
            MessageBox.Show("Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
        public void button_Click(object sender, EventArgs e)
        {


            using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\user\{roles[role]}\{login.Text}.dat",FileMode.OpenOrCreate)))
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
            File.Delete(Directory.GetCurrentDirectory() + $@"\debug\user\{roles[role]}\temp_{login.Text}.dat");
            Close();
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
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}");
            if (File.Exists($@"debug\sclad\{exp.Text}\{fio.Text}.dat"))
            {
                int count;
                using (BinaryReader reader = new BinaryReader(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}\{fio.Text}.dat", FileMode.OpenOrCreate)))
                {
                    reader.ReadString();
                    reader.ReadString();
                    count = int.Parse(reader.ReadString());
                    reader.ReadString();
                }
                using (BinaryWriter write = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{exp.Text}\{fio.Text}.dat", FileMode.OpenOrCreate)))
                {
                    write.Write(fio.Text);
                    write.Write(age.Text);
                    write.Write((count+int.Parse(obrazovanie.Text)).ToString());
                    write.Write(exp.Text);
                }
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
            }
            Close();
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.Move(Directory.GetCurrentDirectory() + $@"\debug\user\{roles[role]}\temp_{login.Text}.dat", Directory.GetCurrentDirectory() + $@"\debug\user\{roles[role]}\{login.Text}.dat");
            }
            catch
            {

            }
        }
    }
}
