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
    public partial class Register_client_Fiz : Form
    {
        public Register_client_Fiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register_client OpenWindow = new Register_client();
            OpenWindow.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBoxRegF OpenWindow = new DialogBoxRegF();
            OpenWindow.Show();
            Close();
        }
    }
}
