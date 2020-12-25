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
        Form4 dohod = new Form4();
        Form3 addtov = new Form3();
        public int moneys;
        public int role;
        public int price_, count_,allprice_=0;

        public Form2()
        {
            
            InitializeComponent();
            MaximumSize = new Size(Size.Width, Size.Height);
            MinimumSize = new Size(Size.Width, Size.Height);
            if (test123.role == 0)
            {
                //addTovar.Click -= new EventHandler(addTovar_Click);
                //addTovar.Click += new EventHandler(openZakazi);
            }
            if (test123.role == 1)
            {

                findTovar.Hide();
                dohodi.Hide();
                deletedUsers.Hide();
                addTovar.Hide();
            }
            if (test123.role == 2)
            {
                addTovar.Location = createUser.Location;
                findTovar.Location = modDelButton.Location;
                createUser.Hide();
                modDelButton.Hide();
                deletedUsers.Hide();
                dohodi.Hide();
            }
            if (test123.role == 3)
            {
                addTovar.Click -= new EventHandler(addTovar_Click);
                addTovar.Click += new EventHandler(openZakazi);
                addTovar.Text = "Заказы";
                addTovar.Location = createUser.Location;
                createUser.Hide();
                findTovar.Hide();
                modDelButton.Hide();
                deletedUsers.Hide();
                dohodi.Hide();
            }
            if(test123.role == 4)
            {
                dohodi.Location = createUser.Location;
                createUser.Hide();
                modDelButton.Hide(); 
                deletedUsers.Hide();
                addTovar.Hide();
                findTovar.Hide();
            }
            if (test123.role == 5)
            {
                addTovar.Location = createUser.Location;
                findTovar.Location = modDelButton.Location;
                createUser.Hide();
                deletedUsers.Hide();
                modDelButton.Hide();
                dohodi.Hide();
                addTovar.Click -= new EventHandler(addTovar_Click);
                addTovar.Click += new EventHandler(Openkorzina);
                addTovar.Text = "Корзина";
            }
            if(test123.guest == true)
            {
                findTovar.Location = createUser.Location;
                createUser.Hide();
                deletedUsers.Hide();
                modDelButton.Hide();
                dohodi.Hide();
                addTovar.Hide();
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

        public  void dohodi_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            dohod.admin.Hide();
            dohod.cadr.Hide();
            dohod.sclad.Hide();
            dohod.kasprod.Hide();
            dohod.buhg.Hide();
            dohod.pokyp.Hide();
            Label lb1 = new Label() { Location = new Point(13, 90), Name = "lb1",Text = "Доход: " };
            Label lb2 = new Label() { Location = new Point(13, 151), Name = "lb2",Text = "Чистая прибыль: " };
            Label lb3 = new Label() { Location = new Point(140, 90), Name = "lb3",Text =""};
            Label lb4 = new Label() { Location = new Point(140, 151), Name = "lb4",Text =""};
            ComboBox cb = new ComboBox() { Location = new Point(13, 36), Size = new Size(252, 25),DropDownStyle = ComboBoxStyle.DropDownList};
            cb.Items.Add("За сегодня");
            cb.Items.Add("За месяц");
            cb.Items.Add("За год");
            cb.Items.Add("За все время");
            cb.SelectedValueChanged += new EventHandler(checkDohod);
            dohod.Controls.Add(lb1);
            dohod.Controls.Add(lb2);
            dohod.Controls.Add(lb3);
            dohod.Controls.Add(lb4);
            dohod.Controls.Add(cb);

            dohod.ShowDialog();
        }

        public void checkDohod(object sender, EventArgs e)
        {

            string mod = "";
            float money=0;
            if (sender is ComboBox)
            {
                mod = (sender as ComboBox).Text;
            }
            Label lb1 = dohod.Controls.Find("lb1", true).FirstOrDefault() as Label;
            Label lb2 = dohod.Controls.Find("lb2", true).FirstOrDefault() as Label;
            Label lb3 = dohod.Controls.Find("lb3", true).FirstOrDefault() as Label;
            Label lb4 = dohod.Controls.Find("lb4", true).FirstOrDefault() as Label;
            string[] dirs = Directory.GetDirectories($@"{Directory.GetCurrentDirectory()}\debug\user\");
            foreach (string dir in dirs)
            {
                string dirname = dir.Split('\\')[dir.Split('\\').Length - 1];
                if (dirname != "korzina" && dirname != "pokyp" && dirname != "buy") 
                {
                    string[] files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        using(BinaryReader reader = new BinaryReader(File.OpenRead(file)))
                        {
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            reader.ReadString();
                            money = (float)int.Parse(reader.ReadString());
                            reader.ReadString();
                            reader.ReadString();

                        }

                    }
                }
            }
            float clearsumma;
            switch (mod)
            {
               
                case "За сегодня":
                    clearsumma = fileFinder($@"{Directory.GetCurrentDirectory()}\debug\moneylog\",0,false);
                    lb3.Text = clearsumma.ToString();
                    if (clearsumma > 0)
                    {
                        lb4.Text = (clearsumma - (money + (Math.Abs(clearsumma) * 0.492))).ToString();
                    }
                    else
                    {
                        lb4.Text = clearsumma.ToString();
                    }
                    break;
                case "За месяц":
                    clearsumma = fileFinder($@"{Directory.GetCurrentDirectory()}\debug\moneylog\", 1, false);
                    lb3.Text = clearsumma.ToString();
                    lb3.Text = clearsumma.ToString();
                    if (clearsumma > 0)
                    {
                        lb4.Text = (clearsumma - (money + (Math.Abs(clearsumma) * 0.492))).ToString();
                    }
                    else
                    {
                        lb4.Text = clearsumma.ToString();
                    }
                    break;
                case "За год":
                    clearsumma = fileFinder($@"{Directory.GetCurrentDirectory()}\debug\moneylog\", 2,false);
                    lb3.Text = clearsumma.ToString();
                    lb4.Text = (clearsumma - ((money* DateTime.Now.Month) + (Math.Abs(clearsumma) * 0.492))).ToString();
                    break;
                case "За все время":
                    clearsumma = fileFinder($@"{Directory.GetCurrentDirectory()}\debug\moneylog\", 0,true);
                    //lb3.Text = clearsumma.ToString();
                    
                    int test = (DateTime.Now-test123.startmagaz).Days;
                    int test1 = (int)(((float)(Math.Abs(test) / 30)));
                    if (test1 == 0 && clearsumma >0)
                    {
                        lb4.Text = (clearsumma - ((money) + (Math.Abs(clearsumma) * 0.492))).ToString();
                    }
                    else if(test1 > 0 && clearsumma>0)
                    {
                        lb4.Text = (clearsumma - ((money * test1) + (Math.Abs(clearsumma) * 0.492))).ToString();

                    }
                    else if(clearsumma < 0)
                    {
                        lb4.Text = clearsumma.ToString();
                    }
                    break;
            }

        }
        private float fileFinder(string path,int mod,bool alltime)
        {
            DateTime dt = DateTime.Now;
            string[] date = new string[] { dt.Day.ToString(), dt.Month.ToString(), dt.Year.ToString() };
            float summa=0;
            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                string filename = file.Split('\\')[file.Split('\\').Length - 1].Replace(".dat","");
                string[] names = filename.Split('.');
                if (mod == 0 &&names[0] == date[0] && names [1] == date[1]&& names[2] == date[2] && alltime == false){
                    using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
                    {
                        summa += float.Parse(reader.ReadString());
                    }
                }
                else if(mod == 1 && names[1] == date[1] && names[2] == date[2] && alltime == false)
                {
                    using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
                    {
                        summa += float.Parse(reader.ReadString());
                    }
                }       
                else if(mod == 2 && names[2] == date[2] && alltime == false)
                {
                    using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
                    {
                        summa += float.Parse(reader.ReadString());
                    }
                }
                else if( alltime == true)
                {
                    using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
                    {
                        summa += float.Parse(reader.ReadString());
                    }
                }
            }
            return summa;
        }
        private void addTovar_Click(object sender, EventArgs e)
        {
            addtov.age.KeyPress += new KeyPressEventHandler(checkNumber);
            addtov.obrazovanie.KeyPress += new KeyPressEventHandler(checkNumber);
            addtov.age.TextChanged += new EventHandler(changePrice);
            addtov.obrazovanie.TextChanged += new EventHandler(changePrice);
            addtov.label1.Text = "Название:";
            addtov.label5.Text = "Цена:";
            addtov.label3.Text = "Кол-во:";
            addtov.label2.Text = "Категория:";
            Label lb1 = new Label() { Location = new Point(1, 230), Name = "allprice"};
            Label lb2= new Label() { Location = new Point(1, 200), Text = "Сумма заказа (без наценки): " ,Size = new Size(200,25)};
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
            addtov.Controls.Add(lb1);
            addtov.Controls.Add(lb2);
            addtov.button.Location = new Point(190, 200);
            addtov.button.Size = new Size(102, 25);
            addtov.button.Click += new EventHandler(clickSave);
            addtov.Size = new Size(347, 350);
            addtov.MaximumSize = new Size(Size.Width, Size.Height);
            addtov.MinimumSize = new Size(Size.Width, Size.Height);
            addtov.MaximumSize = new Size(347, 350);
            addtov.MinimumSize = new Size(347, 350);
            addtov.button.Click -= new System.EventHandler(addtov.button_Click);
            addtov.button.Click += new System.EventHandler(addtov.addtov);
            
            addtov.ShowDialog();

        }
        public void clickSave(object sender, EventArgs e)
        {
            float money_ = 0;
            Label lb = addtov.Controls.Find("allprice", true).FirstOrDefault() as Label;
            string path = Directory.GetCurrentDirectory() + $@"\debug\moneylog\{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}.min.dat";
            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
                {
                    money_ = float.Parse(reader.ReadString());
                }
            }
            using (BinaryWriter writer= new BinaryWriter(File.Open(path,FileMode.OpenOrCreate)))
            {
                writer.Write((-(float.Parse(lb.Text) + money_)).ToString());
            }
        }
        public void changePrice(object sender, EventArgs e)
        {
            Label lb = addtov.Controls.Find("allprice", true).FirstOrDefault() as Label;
            try
            {
                float withoutP = (float)(int.Parse(addtov.age.Text) * int.Parse(addtov.obrazovanie.Text));
                withoutP -= withoutP * (float)0.3;
                lb.Text = (withoutP).ToString();
            }
            catch
            {
                lb.Text = "0";
            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Hide();
            f.Show();
        }

        public void checkNumber(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            char key = e.KeyChar;
            //MessageBox.Show(key.ToString());
            if (!char.IsDigit(key) && key != 8)
            {

                e.Handled = true;
            }

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
            if (test123.guest == true)
            {
                show.redact.Hide();
                show.delUser.Hide();
            }

            pathPicker.ShowDialog();

            show.addList(Directory.GetCurrentDirectory() + $@"\debug\sclad\{test123.pathScl}\");
            if (test123.scladInfo == true)
            {
                show.ShowDialog();
            }

        }

    }
    public static class test123
    {
        public static DateTime startmagaz;
        public static string namepokyp;
        public static bool guest;
        public static bool reg;
        public static int role;
        public static string pathScl;
        public static bool scladInfo = false;
    }
}
