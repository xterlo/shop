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
    public partial class Form5 : Form
    {
        public static string path {get;set;}
        string filep;
        public Form5()
        {

            InitializeComponent();
            MaximumSize = new Size(Size.Width, Size.Height);
            MinimumSize = new Size(Size.Width, Size.Height);

            if (test123.role == 3)
            {
                getpathbuy();
                okButton.Click -= new EventHandler(okButton_Click);
                okButton.Click += new EventHandler(okButton_zakazi);
                test123.scladInfo = false;
            }
            else
            {
                getpath();
            }

        }

        public void okButton_zakazi(object sender, EventArgs e)
        {
            test123.pathScl = Directory.GetCurrentDirectory() + $@"\debug\user\buy\{comboBox1.Text}\";
            Close();
        }

        public void getpathbuy()
        {

            string path = Directory.GetCurrentDirectory() + $@"\debug\user\buy\";
            string[] files = Directory.GetDirectories(path);
            foreach(string file in files)
            {
                comboBox1.Items.Add(file.Split('\\')[file.Split('\\').Length - 1]);
            }
        }

        public void getpath()
        {
            string[] files;
            filep = Directory.GetCurrentDirectory() + $@"\debug\sclad\";
            try
            {
                files = Directory.GetDirectories(filep);
            }
            catch
            {
                Directory.CreateDirectory(filep);
                files = Directory.GetDirectories(filep);
            }

            foreach (string file in files)
            {
                int fileLen = file.Split('\\').Length;
                string a = file.Split('\\')[fileLen - 1];
                comboBox1.Items.Add(a);
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            test123.pathScl = comboBox1.Text;
            test123.scladInfo = true;
            Close();

        }
    }
}
