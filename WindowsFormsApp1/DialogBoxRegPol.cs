﻿using System;
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
    public partial class DialogBoxRegPol : Form
    {
        public DialogBoxRegPol()
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
            New_polis OpenWindow = new New_polis();
            OpenWindow.Show();
            Close();
        }
    }
}
