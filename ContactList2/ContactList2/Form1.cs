﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addContact_Click(object sender, EventArgs e)
        {
            AddContactForm addForm = new AddContactForm();
            addForm.ShowDialog();
        }
    }
}
