﻿using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_About : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_About()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_About_Load(object sender, EventArgs e)
        {
            Label_About.Text = string.Format("\n\nEuroText Editor\n\nProgrammer: Jordi Martínez\n(jmarti856)\n\nVersion: {0}", Application.ProductVersion);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
