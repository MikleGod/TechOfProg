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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin1_Polis OpenWindow = new Admin1_Polis();
            OpenWindow.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin1_Strah OpenWindow = new Admin1_Strah();
            OpenWindow.Show();
            this.Close();
        }
    }
}
