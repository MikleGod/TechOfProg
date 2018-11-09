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
    public partial class Show_user_card : Form
    {
        public Show_user_card()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_users_all OpenWindow = new Show_users_all();
            OpenWindow.Show();
            Close();
        }

        private void Show_user_card_Load(object sender, EventArgs e)
        {

        }
    }
}
