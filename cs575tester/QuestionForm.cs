﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs575tester
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("YEAH");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Try Again.");
        }
    }
}
