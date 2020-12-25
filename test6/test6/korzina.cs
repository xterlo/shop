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
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace test6
{
    public partial class korzina : Form
    {

        int totalPrice = 0;

        public korzina()
        {
            InitializeComponent();
            //tableLayoutPanel1.Controls.Add()
            MaximumSize = new Size(Size.Width, Size.Height);
            MinimumSize = new Size(Size.Width, Size.Height);
            if (test123.role == 5)
                createAll();
            if (test123.role == 3)
                changehook();
        }


        public void changehook()
        {
            tableLayoutPanel1.ColumnCount = 5;
            string[] files = Directory.GetFiles(test123.pathScl);
            int countTovars = files.Length;

            tableLayoutPanel1.RowCount = countTovars;
            string name, price, group, allprice;

            int count;


            for (int i = 0; i < countTovars; i++)
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(files[i])))
                {
                    name = reader.ReadString();
                    price = reader.ReadString();
                    count = int.Parse(reader.ReadString());
                    group = reader.ReadString();
                }
                allprice = (int.Parse(price) * count).ToString();
                Label labelName = new Label() { Name = $"name{i}", Text = name };
                Label labelGroup = new Label() { Name = $"group{i}", Text = group };
                Label labelPrice = new Label() { Name = $"price{i}", Text = price };
                Button declineKorz = new Button() { Name = $"button{i}", Text = "✗", Size = new Size(100, 23) };
                Button acceptKorz = new Button() { Name = $"buttonA{i}", Text = "✓", Size = new Size(100, 23) };
                Label labelPriceCount = new Label() { Name = $"allprice{i}", Text = allprice };
                Label numCount = new Label() { Name = $"count{i}", Text = count.ToString()};
                declineKorz.Click += new EventHandler(decline_Click);
                acceptKorz.Click += new EventHandler(accept_Click); 
                tableLayoutPanel1.Controls.Add(labelPriceCount, 4, i);
                tableLayoutPanel1.Controls.Add(labelPrice, 3, i);
                tableLayoutPanel1.Controls.Add(numCount, 2, i);
                tableLayoutPanel1.Controls.Add(labelName, 1, i);
                tableLayoutPanel1.Controls.Add(labelGroup, 0, i);
                totalPrice += int.Parse(allprice);
                allPrice.Text = totalPrice.ToString();
                button1.Hide();
                Controls.Add(declineKorz);
                Controls.Add(acceptKorz);
                acceptKorz.Location = new Point(button1.Location.X,button1.Location.Y);
                declineKorz.Location = new Point(button1.Location.X-150,button1.Location.Y);
            }
        }
        
    
    
        public void decline_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                string wasCount;
                Label name = Controls.Find($"name{i}", true).FirstOrDefault() as Label;
                Label group = Controls.Find($"group{i}", true).FirstOrDefault() as Label;
                Label count = Controls.Find($"count{i}", true).FirstOrDefault() as Label;
                Label price = Controls.Find($"price{i}", true).FirstOrDefault() as Label;
                using (BinaryReader reader = new BinaryReader(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{group.Text}\{name.Text}.dat", FileMode.Open)))
                {
                    reader.ReadString();
                    reader.ReadString();
                    wasCount = reader.ReadString();
                    reader.ReadString();
                }
                using (BinaryWriter writer = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\sclad\{group.Text}\{name.Text}.dat",FileMode.Open)))
                {
                    writer.Write(name.Text);
                    writer.Write(price.Text);
                    writer.Write((int.Parse(count.Text)+int.Parse(wasCount)).ToString());
                    writer.Write(group.Text);
                }
                File.Delete(test123.pathScl + $"{name.Text}.dat");
            }

            Directory.Delete(test123.pathScl);
            MessageBox.Show($"Заказ был успешно отменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void accept_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                Label name = Controls.Find($"name{i}", true).FirstOrDefault() as Label;
                File.Delete(test123.pathScl + $"{name.Text}.dat");
            }
            Directory.Delete(test123.pathScl);
            string kek = test123.pathScl;
            string mail = kek.Split('\\')[kek.Split('\\').Length - 2];
            MessageBox.Show($"Письмо с чеком было отправлено покупателю на почту на почту {mail}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            string path;
            DateTime dt = DateTime.Now;
            int moneys=0;
            path = Directory.GetCurrentDirectory() + $@"\debug\moneylog\{dt.Day}.{dt.Month}.{dt.Year}.dat";
            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
                {
                    moneys = int.Parse(reader.ReadString());
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write((totalPrice+moneys).ToString());
            }


        }
        public void createAll()
        {
            Controls.Add(tableLayoutPanel1);
            string path = Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            int countTovars = Directory.GetFiles(path).Length;
            string[] files = Directory.GetFiles(path);
            tableLayoutPanel1.RowCount = countTovars;
            string name, price, group, allprice;

            int count;
            tableLayoutPanel1.ColumnCount = 6;

            for (int i = 0; i < countTovars; i++)
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(files[i])))
                {
                    //labelName[i].Text = reader.ReadString();
                    //labelPrice[i].Text = reader.ReadString();
                    //numCount[i].Value = int.Parse(reader.ReadString());
                    //labelGroup[i].Text = reader.ReadString();
                    name = reader.ReadString();
                    price = reader.ReadString();
                    count = int.Parse(reader.ReadString());
                    group = reader.ReadString();
                }
                allprice = (int.Parse(price) * count).ToString();
                Label labelName = new Label() { Name = $"name{i}", Text = name };
                Label labelGroup = new Label() { Name = $"group{i}", Text = group };
                Label labelPrice = new Label() { Name = $"price{i}", Text = price };
                Button delKorz = new Button() { Name = $"button{i}", Text = "X", Size = new Size(100, 23) };
                Label labelPriceCount = new Label() { Name = $"allprice{i}", Text = allprice };
                NumericUpDown numCount = new NumericUpDown() { Name = $"count{i}", Value = count, ReadOnly = true };
                numCount.ValueChanged += new EventHandler(updatepriceAll);
                delKorz.Click += new EventHandler(delKorz_click);
                tableLayoutPanel1.Controls.Add(delKorz, 5, i);
                tableLayoutPanel1.Controls.Add(labelPriceCount, 4, i);
                tableLayoutPanel1.Controls.Add(labelPrice, 3, i);
                tableLayoutPanel1.Controls.Add(numCount, 2, i);
                tableLayoutPanel1.Controls.Add(labelName, 1, i);
                tableLayoutPanel1.Controls.Add(labelGroup, 0, i);
                totalPrice += int.Parse(allprice);


                //flowLayoutPanel1.Controls.Add(tableLayoutPanel1);

            }
            if (tableLayoutPanel1.Controls.Count == 0)
            {
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            }
            else
            {
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            }

            allPrice.Text = totalPrice.ToString();

            //tableLayoutPanel1.RowCount =
        }
        public void delKorz_click(object sender, EventArgs e)
        {

            string n = "";
            if (sender is Button)
                n = (sender as Button).Name.Replace("button", "");
            Label lb = Controls.Find($"name{n}", true).FirstOrDefault() as Label;
            File.Delete(Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\{lb.Text}.dat");
            for (int i = 0; i < 6; i++)
            {
                var control = tableLayoutPanel1.GetControlFromPosition(i, int.Parse(n));
                tableLayoutPanel1.Controls.Remove(control);


            }
            if (tableLayoutPanel1.Controls.Count == 0)
            {
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            }
            else
            {
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            }
            //Controls.Remove(tableLayoutPanel1);
            ////tableLayoutPanel1.Visible = false;
            //createAll();
        }
        public void updatepriceAll(object sender, EventArgs e)
        {
            string a = "";
            int numValue = 0;
            if (sender is NumericUpDown) {
                a = (sender as NumericUpDown).Name.Replace("count", ""); ;
                numValue = int.Parse((sender as NumericUpDown).Value.ToString());
            }
            Label name = Controls.Find($"name{a}",true).FirstOrDefault() as Label;
            Label group = Controls.Find($"group{a}",true).FirstOrDefault() as Label;
            Label price = Controls.Find($"price{a}",true).FirstOrDefault() as Label;
            NumericUpDown count= Controls.Find($"count{a}",true).FirstOrDefault() as NumericUpDown;
            Label priceall = Controls.Find($"allprice{a}",true).FirstOrDefault() as Label;
            int oldPrice = int.Parse(priceall.Text);
            priceall.Text = (int.Parse(price.Text) * numValue).ToString();
            using (BinaryWriter writer = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\{name.Text}.dat",FileMode.Open)))
            {
                writer.Write(name.Text);
                writer.Write(price.Text);
                writer.Write(count.Value.ToString());
                writer.Write(group.Text);

            }
            //for (int i=0; i < tableLayoutPanel1.RowCount; i++)
            //{
            //    Label fortotal = Controls.Find($"allprice{i}", true).FirstOrDefault() as Label;
            //    totalPrice += int.Parse(fortotal.Text);
            //    allPrice.Text = totalPrice.ToString();


            //}
            totalPrice += (int.Parse(priceall.Text) - oldPrice);
            allPrice.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + $@"\debug\user\buy\{test123.namepokyp}\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\");
            foreach(string file in files)
            {
                string nameFile = file.Split('\\')[file.Split('\\').Length - 1];
                File.Move(file, Directory.GetCurrentDirectory() + $@"\debug\user\buy\{test123.namepokyp}\{nameFile}");
            }
            Close();
                //Directory.GetCurrentDirectory() + $@"\debug\user\korzina\{test123.namepokyp}\{lb.Text}.dat"
        }

        private void korzina_Load(object sender, EventArgs e)
        {

        }
    }
}
