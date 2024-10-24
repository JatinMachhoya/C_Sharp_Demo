using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(txtunm.Text=="Jatin" && txtpwd.Text == "3424")
            {
                MessageBox.Show("Login is Done", "Login");
                Form2 f2 = new Form2();
                f2.Show();
            }
            else 
            {
                MessageBox.Show("Enter Valid Username and Password","Error");    
            }
        }

        void clear()
        {
            txtunm.Text = "";
            txtpwd.Text = "";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
