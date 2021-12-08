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
        public MerhabaForm(string metin)
        {
            InitializeComponent();
            //Eğer bir windows form elemanına dokunmanız gerekli ise buradan veya daha aşağıda bu işlemleri yapabilirsiniz.
            label1.Text = metin;
        }

        private void MerhabaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
