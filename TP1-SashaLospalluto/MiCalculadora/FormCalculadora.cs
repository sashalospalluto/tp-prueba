﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
