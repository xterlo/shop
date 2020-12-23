using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace test6
{

    public partial class Form2 : Form
    {

        
        public int role;

        public Form2()
        {
            
            InitializeComponent();    
            if (test123.role == 5)
            {
                addTovar.Click -= new EventHandler(addTovar_Click);
                addTovar.Click += new EventHandler(Openkorzina);
                addTovar.Text = "Корзина";
            }
            if (test123.role == 3)
            {
                addTovar.Click -= new EventHandler(addTovar_Click);
                addTovar.Click += new EventHandler(openZakazi);
                addTovar.Text = "Заказы";
            }
        }

        private void openZakazi(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + $@"\debug\user\buy\";
            Form5 korz = new Form5();
            korz.ShowDialog();
            korzina korzina = new korzina();
            korzina.ShowDialog();
        }

        private void Openkorzina(object sender, EventArgs e)
        {
            korzina korz = new korzina();
            korz.ShowDialog();

        }

        private void createUser_Click(object sender, EventArgs e)
        {
            Form3 createUser = new Form3();
            createUser.ShowDialog();
        }

        private void modDelButton_Click(object sender, EventArgs e)
        {
            Form4 modDelUser = new Form4();
            modDelUser.notDeleted();
            modDelUser.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deletedUsers_Click(object sender, EventArgs e)
        {
            Form4 modDelUser = new Form4();
            modDelUser.deletedUsers();
            modDelUser.ShowDialog();
        }

        private void dohodi_Click(object sender, EventArgs e)
        {
            Form4 dohod = new Form4();
            dohod.cadr.Hide();
            //dohod.sclad.Hide();
            Label lb1 = new Label();
            lb1.Location = new Point(12, 130);
            lb1.Size = new Size(253, 31);
            lb1.Name = "test";
            lb1.Text = "HELLO AJUHUFHIUFHSDUFUHDISF";
            dohod.Controls.Add(lb1);
            dohod.ShowDialog();
        }


        private void addTovar_Click(object sender, EventArgs e)
        {
            Form3 addtov = new Form3();
            addtov.label1.Text = "Название:";
            addtov.label5.Text = "Цена:";
            addtov.label3.Text = "Кол-во:";
            addtov.label2.Text = "Категория:";
            addtov.comboBox1.Hide();
            addtov.place.Hide();
            addtov.zp.Hide();
            addtov.login.Hide();
            addtov.password.Hide();
            addtov.label4.Hide();
            addtov.label6.Hide();
            addtov.label7.Hide();
            addtov.label8.Hide();
            addtov.label9.Hide();
            addtov.button.Location = new Point(16, 200);
            addtov.Size = new Size(347, 350);
            addtov.MaximumSize = new Size(347, 350);
            addtov.MinimumSize = new Size(347, 350);
            addtov.button.Click -= new System.EventHandler(addtov.button_Click);
            addtov.button.Click += new System.EventHandler(addtov.addtov);
            addtov.ShowDialog();

        }

        private void findTovar_Click(object sender, EventArgs e)
        {
            modifDelete show = new modifDelete();
            
            Form5 pathPicker = new Form5();
            show.label1.Text = "Название:";
            show.label2.Text = "Цена:";
            show.label7.Text = "Кол-во:";
            show.label6.Text = "Категория:";
            show.label3.Hide();
            show.label4.Hide();
            show.label5.Hide();
            show.label8.Hide();
            show.label9.Hide();
            show.redact.Text = "Сохранить";


            pathPicker.ShowDialog();

            show.addList(Directory.GetCurrentDirectory() + $@"\debug\sclad\{test123.pathScl}\");
            if (test123.pathScl != "")
            {
                show.ShowDialog();
            }

        }

    }
    public static class test123
    {

        public static string namepokyp;
        public static bool reg;
        public static int role;
        public static string pathScl;
        public static bool scladInfo = false;
    }
}
