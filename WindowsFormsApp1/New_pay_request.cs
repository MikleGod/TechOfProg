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
    public partial class New_pay_request : Form
    {
        public New_pay_request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User OpenWindow = new User();
            OpenWindow.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBoxRegPol OpenWindow = new DialogBoxRegPol();
            OpenWindow.Show();
            Close();

        }
    }
}
