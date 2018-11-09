using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show_kat_polis OpenWindow = new Show_kat_polis();
            OpenWindow.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Show_users_all OpenWindow = new Show_users_all();
            OpenWindow.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register_client OpenWindow = new Register_client();
            OpenWindow.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_polis OpenWindow = new New_polis();
            OpenWindow.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_pay_request OpenWindow = new New_pay_request();
            OpenWindow.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_pay OpenWindow = new New_pay();
            OpenWindow.Show();
            Close();
        }
    }
}
