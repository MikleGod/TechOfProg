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
    public partial class Admin1_Strah : Form
    {
        public Admin1_Strah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin OpenWindow = new Admin();
            OpenWindow.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBox_adminS OpenWindow = new DialogBox_adminS();
            OpenWindow.Show();
            Close();
        }
    }
}
