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
    public partial class DialogBox_adminP : Form
    {
        public DialogBox_adminP()
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
            Admin1_Polis OpenWindow = new Admin1_Polis();
            OpenWindow.Show();
            Close();
        }
    }
}
