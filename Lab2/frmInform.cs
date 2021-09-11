using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmInform : Form
    {
        public frmInform()
        {
            InitializeComponent();
        }

        public void SetText(string s)
        {
            this.lblInform.Text = s;
        }
    }
}
