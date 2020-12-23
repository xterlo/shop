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


    public partial class Form4 : Form
    {
        modifDelete list = new modifDelete();
        bool deleted;
        public Form4()
        {
            InitializeComponent();
            string[] roles = { "admin", "cadr", "sclad", "kasprod", "buhg", "pokyp" };
        }
        private void admin_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\admin\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\admin\delete\");
                list.ShowDialog();
            }
        }
        private void pokyp_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\pokyp\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\pokyp\delete\");
                list.ShowDialog();
            }
        }
        private void cadr_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\cadr\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\cadr\delete\");
                list.ShowDialog();
            }
        }

        private void sclad_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\sclad\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\sclad\delete\");
                list.ShowDialog();
            }
        }

        private void kasprod_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\kasprod\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\kasprod\delete\");
                list.ShowDialog();
            }
        }

        private void buhg_Click(object sender, EventArgs e)
        {
            if (deleted == false)
            {
                list.notDeleted();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\buhg\");
                list.ShowDialog();
            }
            else
            {
                list.deletedUsers();
                list.addList(Directory.GetCurrentDirectory() + $@"\debug\user\buhg\delete\");
                list.ShowDialog();
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
    }
}
