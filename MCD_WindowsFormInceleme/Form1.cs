﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_WindowsFormInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMesaj.Text = "Metin Griniz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            //Musteri M1 = new Musteri();

            string txtMesajDegeri = txtMesaj.Text;

            MerhabaForm merhabaForm = new MerhabaForm(txtMesajDegeri);
        }

        private void txtMesaj_Enter(object sender, EventArgs e)
        {

        }

        private void txtMesaj_MouseClick(object sender, MouseEventArgs e)
        {
            //txtMesaj.Text = " ";
            txtMesaj.Clear();
        }
    }
}
