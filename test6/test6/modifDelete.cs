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

namespace test6
{

    public partial class modifDelete : Form
    {
        bool deleted;
        string filepokyp = "";
        string filep;
        int fromFile;
        string pathSclad = Directory.GetCurrentDirectory() + $@"\debug\sclad\";
        string[] roles = { "admin", "cadr", "sclad", "kasprod", "buhg", "pokyp" };
        string[] rolesNormal = { "Администратор","Кадры", "Склад", "Кассир-продавец", "Бухгалтерия", "Покупатель" };
        NumericUpDown count = new NumericUpDown();
        int roleindex;
        public modifDelete()
        {
            
            InitializeComponent();

            count.Location = new Point(130, 100);
            count.Size = new Size(60, 13);
            count.Name = "counter";
            count.ReadOnly = true;
            obrLabel.Hide();
            Controls.Add(count);
            count.Hide();

        }
        public void addList(string filePath)
        {
            string[] files;
            if (test123.role == 5)
            {
                filepokyp = Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\";
            }
            filep = filePath;
            try
            {
                files = Directory.GetFiles(filep);
            }
            catch
            {
                Directory.CreateDirectory(filep);
                files = Directory.GetFiles(filep);
            }

            foreach(string file in files)
            {
                int fileLen = file.Split('\\').Length;
                int fileLenLast = file.Split('\\')[fileLen-1].Length;
                pickUser.Items.Add(file.Split('\\')[fileLen - 1].Substring(0, fileLenLast - 4));
            }

        }

        private void pickUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (test123.scladInfo == false && test123.role != 5)
            {
                updateInfo();
            }
            else if (test123.role == 5)
            {
                updateForUser();
            }
            else if (test123.scladInfo == true && test123.role != 5)
            {
                updateInfoSclad();
            }
        }

        private void modifDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            pickUser.Items.Clear();
            clearAll();
            test123.scladInfo = false;
        }

        public void redact_Click(object sender, EventArgs e)
        {
            File.Copy(filep + $@"\{loginLabel.Text}.dat", filep + $@"\temp_{loginLabel.Text}.dat");
            File.Delete(filep + $@"\{loginLabel.Text}.dat");
            Form3 modif = new Form3();
            modif.fio.Text = fioLabel.Text;
            modif.age.Text = ageLabel.Text;
            modif.obrazovanie.Text = obrLabel.Text;
            modif.exp.Text = expLabel.Text;
            modif.comboBox1.SelectedIndex = roleindex;
            modif.place.Text = placeLabel.Text;
            modif.zp.Text = zpLabel.Text;
            modif.login.Text = loginLabel.Text;
            modif.password.Text = passwordLabel.Text;
            modif.button.Text = "Редактировать";
            modif.ShowDialog();
            try
            {
                updateInfo();
            }
            catch
            {
                clearAll();
            }

        }

        private void delUser_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(filep + $@"\delete\");
            File.Move(filep + $@"\{loginLabel.Text}.dat", filep + $@"\delete\{loginLabel.Text}.dat");
            clearAll();
            
        }

        private void clearAll()
        {
            fioLabel.Text = "";
            ageLabel.Text = "";
            obrLabel.Text = "";
            expLabel.Text = "";
            roleLabel.Text = "";
            placeLabel.Text = "";
            zpLabel.Text = "";
            loginLabel.Text = "";
            passwordLabel.Text = "";
            count.Hide();
            pickUser.Items.Remove(pickUser.Text);

        }
        void updateInfo()
        {
            if (deleted == true)
            {
                redact.Text = "Восстановить";
                redact.Click -= new System.EventHandler(redact_Click);
                redact.Click += new System.EventHandler(restoreUser);
                delUser.Text = "Удалить полностью";
                delUser.Click -= new System.EventHandler(delUser_Click);
                delUser.Click += new System.EventHandler(removeUser);
            }
            else
            {
                redact.Text = "Редактировать";
                redact.Click += new System.EventHandler(redact_Click);
                redact.Click -= new System.EventHandler(restoreUser);
                delUser.Text = "Удалить";
                delUser.Click += new System.EventHandler(delUser_Click);
                delUser.Click -= new System.EventHandler(removeUser);
            }

            using (BinaryReader reader = new BinaryReader(File.OpenRead($@"{filep}\{pickUser.Text}.dat")))
            {
                fioLabel.Text = reader.ReadString();
                ageLabel.Text = reader.ReadString();
                obrLabel.Text = reader.ReadString();
                expLabel.Text = reader.ReadString();
                roleLabel.Text = rolesNormal[Array.IndexOf(roles, reader.ReadString())];
                placeLabel.Text = reader.ReadString();
                zpLabel.Text = reader.ReadString();
                loginLabel.Text = reader.ReadString();
                passwordLabel.Text = reader.ReadString();
            }
            roleindex = Array.IndexOf(rolesNormal, roleLabel.Text);
        }
        void updateInfoSclad()
        {

            if (deleted == true)
            {
                redact.Text = "Восстановить";
                redact.Click -= new System.EventHandler(redact_Click);
                redact.Click += new System.EventHandler(restoreUser);
                delUser.Text = "Удалить полностью";
                delUser.Click -= new System.EventHandler(delUser_Click);
                delUser.Click += new System.EventHandler(removeUser);
            }
            else
            {
                redact.Text = "Сохранить";
                redact.Click += new System.EventHandler(saveTovar);
                redact.Click -= new System.EventHandler(restoreUser);
                delUser.Text = "Удалить";
                delUser.Click += new System.EventHandler(delTovar);
                delUser.Click -= new System.EventHandler(removeUser);
            }

            using (BinaryReader reader = new BinaryReader(File.OpenRead($@"{filep}\{pickUser.Text}.dat")))
            {
                fioLabel.Text = reader.ReadString();
                ageLabel.Text = reader.ReadString();
                count.Value = int.Parse(reader.ReadString());
                expLabel.Text = reader.ReadString();
            }
            
            count.Show();
        }

        public void updateForUser()
        {

            
            //redact.Text = "Сохранить";
            //redact.Click += new System.EventHandler(saveTovar);
            //redact.Click -= new System.EventHandler(restoreUser);
            redact.Hide();
            delUser.Text = "В корзину";
            delUser.Click += new System.EventHandler(toKorzina);
            delUser.Click -= new System.EventHandler(removeUser);
            using (BinaryReader reader = new BinaryReader(File.OpenRead($@"{filep}\{pickUser.Text}.dat")))
            {
                fioLabel.Text = reader.ReadString();
                ageLabel.Text = reader.ReadString();
                count.Value = 0;
                fromFile = int.Parse(reader.ReadString());
                count.Maximum = fromFile;
                expLabel.Text = reader.ReadString();
            }
            count.Show();
        }

        public void saveTovar(object sender, EventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open($@"{filep}\{pickUser.Text}.dat",FileMode.Open)))
            {
                writer.Write(fioLabel.Text);
                writer.Write(ageLabel.Text);
                writer.Write(count.Text);
                writer.Write(expLabel.Text);
            }
        }

        public void delTovar(object sender, EventArgs e)
        {
            File.Delete($@"{filep}\{pickUser.Text}.dat");
            clearAll();
        }

        public void toKorzina(object sender, EventArgs e)
        {
            Directory.CreateDirectory($@"{filepokyp}");
            int buy = int.Parse(count.Value.ToString());
            int wasCount=0;
            if (File.Exists($@"{filepokyp}\{pickUser.Text}.dat"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open($@"{filepokyp}\{pickUser.Text}.dat", FileMode.OpenOrCreate)))
                {

                    reader.ReadString();
                    reader.ReadString();
                    wasCount = int.Parse(reader.ReadString());
                    reader.ReadString();

                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open($@"{filepokyp}\{pickUser.Text}.dat", FileMode.OpenOrCreate)))
            {
                writer.Write(fioLabel.Text);
                writer.Write(ageLabel.Text);
                writer.Write((int.Parse(count.Text)+wasCount).ToString());
                writer.Write(expLabel.Text);

            }
            using (BinaryWriter writer = new BinaryWriter(File.Open($@"{pathSclad}\{expLabel.Text}\{fioLabel.Text}.dat",FileMode.Open)))
            {
                writer.Write(fioLabel.Text);
                writer.Write(ageLabel.Text);
                writer.Write((fromFile - buy).ToString());
                writer.Write(expLabel.Text);
            }
            
        }

        public void deletedUsers()
        {
            deleted = true;
        }
        public void notDeleted()
        {
            deleted = false;
        }
        private void removeUser(object sender, EventArgs e)
        {
            File.Delete(filep + $@"\{loginLabel.Text}.dat");
            clearAll();
        }
        private void restoreUser(object sender, EventArgs e)
        {
            File.Move(filep + $@"\{loginLabel.Text}.dat", filep.Replace("delete","") + $@"\{loginLabel.Text}.dat");
            clearAll();
        }
    }
}
