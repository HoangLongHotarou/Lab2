using Lab2.Class;
using Lab2.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmTeacherInfor : Form
    {

        public frmTeacherInfor()
        {
            InitializeComponent();
        }

        private void frmTeacherInfor_Load(object sender, EventArgs e)
        {
            string contact = "https://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbContact.Links.Add(0, contact.Length, contact);
            this.cboID.SelectedItem = this.cboID.Items[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cboID.Text = "";
            this.txtName.Text = "";
            this.txtMail.Text = "";
            this.mtbPhoneNum.Text = "";
            this.rbnMale.Checked = true;

            for (int i = 0; i < clbLanguage.Items.Count; i++)
            {
                clbLanguage.SetItemChecked(i, false);
            }
            foreach (var item in this.lbLsOfTeach.Items)
            {
                this.lbCategory.Items.Add(item);
            }
            this.lbLsOfTeach.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmInform frm = new frmInform();
            frm.SetText(GetTeacher().ToString());
            frm.ShowDialog();
        }

        private Teacher GetTeacher()
        {
            string gt = "Nam";
            if (rbnFermale.Checked) gt = "Nữ";
            Teacher gv = new Teacher();
            gv.ID = this.cboID.Text;
            gv.Sex = gt;
            gv.Name = this.txtName.Text;
            gv.Mail = this.txtMail.Text;
            gv.phoneNum = "0633"+this.mtbPhoneNum.Text;

            string language = "";
            for (int i = 0; i < clbLanguage.Items.Count; i++)
            {
                if (clbLanguage.GetItemChecked(i))
                    language += clbLanguage.Items[i] + "i";
            }
            gv.Languages = language.Split(';');
            Category sj = new Category();
            foreach (var item in lbLsOfTeach.Items)
            {
                sj.ls.Add(new Subject(item.ToString()));
            }
            gv.SubjectCategory = sj;
            return gv;
        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = this.lbCategory.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbLsOfTeach.Items.Add(lbCategory.SelectedItems[i]);
                this.lbCategory.Items.Remove(lbCategory.SelectedItems[i]);
                i--;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = this.lbLsOfTeach.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbCategory.Items.Add(lbLsOfTeach.SelectedItems[i]);
                this.lbLsOfTeach.Items.Remove(lbLsOfTeach.SelectedItems[i]);
                i--;
            }
        }

        private void linklbContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ShowDialog();
            if (search.DialogResult == DialogResult.OK)
            {
                frmInform frm = new frmInform();
                frm.SetText(search.teacher.ToString());
                frm.ShowDialog();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (TeacherManagement.Add(GetTeacher()))
            {
                MessageBox.Show("Thanh cong", "infor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khong Thanh cong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
