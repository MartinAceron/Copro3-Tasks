﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPublicAccess : Form
    {
        public frmPublicAccess()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            Class1 compute = new Class1();

            if (txtFirstNumber.Text == String.Empty)
            {
                MessageBox.Show("First Number cannot be empty");
                txtFirstNumber.Focus();
                return;
            }
            if (txtSecondNumber.Text == String.Empty)
            {
                MessageBox.Show("Second Number cannot be empty");
                txtSecondNumber.Focus();
                return;
            }

            compute.FirstNumber = Convert.ToDouble(txtFirstNumber.Text);
            compute.SecondNumber = Convert.ToDouble(txtSecondNumber.Text);

            MessageBox.Show("The public result is: " + Convert.ToString(compute.ShowResult()));
            txtSecondNumber.Text = String.Empty;
            txtFirstNumber.Text = String.Empty;
           
          
        }
       
        

        private void btnPrivate_Click(object sender, EventArgs e)
        {
            frmPrivateAccess frmPrivate = new frmPrivateAccess();
            frmPrivate.Show();
            this.Hide();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
