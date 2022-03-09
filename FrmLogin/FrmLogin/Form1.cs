using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = textboxusername.Text;
            String password = textboxmatkhau.Text;
            if(username.Equals("admin") && password.Equals("admin"))
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }
    }
}
