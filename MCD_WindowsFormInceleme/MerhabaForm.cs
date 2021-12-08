using System;
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
    public partial class MerhabaForm : Form
    {
        public MerhabaForm()
        {
            InitializeComponent();
        }

        public MerhabaForm(string metin)
        {
            label1.Text = metin;
        }

        public string TxtMesajDegeri { get; }

        private void MerhabaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
