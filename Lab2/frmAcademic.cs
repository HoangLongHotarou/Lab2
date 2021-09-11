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
    public partial class frmAcademic : System.Windows.Forms.Form
    {
        public frmAcademic()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkITA.Checked) s += int.Parse(lblITAPrice.Text.Split('.')[0]);
            if (chkITB.Checked) s += int.Parse(lblITBPrice.Text.Split('.')[0]);
            if (chkEngA.Checked) s += int.Parse(lblEngAPrice.Text.Split('.')[0]);
            if (chkEngB.Checked) s += int.Parse(lblEngBPrice.Text.Split('.')[0]);
            this.txtSumAmount.Text = s + ".000 Đồng";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cboID.Text = "";
            this.txtName.Text = "";
            this.dtpRegister.Value = DateTime.Now;
            this.rbnMale.Checked = true;
            this.chkEngA.Checked = false;
            this.chkEngB.Checked = false;
            this.chkITA.Checked = false;
            this.chkITB.Checked = false;
            this.txtSumAmount.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
