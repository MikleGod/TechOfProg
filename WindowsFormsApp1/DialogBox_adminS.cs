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
    public partial class DialogBox_adminS : Form
    {
        public DialogBox_adminS()
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
            Admin1_Strah OpenWindow = new Admin1_Strah();
            OpenWindow.Show();
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin1_Strah OpenWindow = new Admin1_Strah();
            OpenWindow.Show();
            Close();
        }
    }
}
