using Lab2.Class;
using Lab2.Search;
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
    public partial class frmSearch : Form
    {
        SearchType type;
        public Teacher teacher;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (label1.Text == null)
            {
                MessageBox.Show("Dien thieu", "Error");
            }
            else
            {
                teacher = TeacherManagement.Search(type, txtSearch.Text);
                if(teacher == null)
                {
                    MessageBox.Show("Ko tim thay", "infor");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }


        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.rbnID.Checked = true;
            label1.Text = rbnID.Text;
        }

        private void rbnID_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = rbnID.Text;
                    type = SearchType.TheoMa;
                }
            }
    }

        private void rbnName_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = rbnName.Text;
                    type = SearchType.TheoHoTen;
                }
            }
        }

        private void rbnPhoneNum_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = rbnPhoneNum.Text;
                    type = SearchType.TheoSDT;
                }
            }
        }
        
    }
    
}
