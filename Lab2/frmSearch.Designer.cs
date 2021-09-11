
namespace Lab2
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPhoneNum = new System.Windows.Forms.RadioButton();
            this.rbnName = new System.Windows.Forms.RadioButton();
            this.rbnID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPhoneNum);
            this.groupBox1.Controls.Add(this.rbnName);
            this.groupBox1.Controls.Add(this.rbnID);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rbnPhoneNum
            // 
            this.rbnPhoneNum.AutoSize = true;
            this.rbnPhoneNum.Location = new System.Drawing.Point(350, 29);
            this.rbnPhoneNum.Name = "rbnPhoneNum";
            this.rbnPhoneNum.Size = new System.Drawing.Size(47, 17);
            this.rbnPhoneNum.TabIndex = 2;
            this.rbnPhoneNum.TabStop = true;
            this.rbnPhoneNum.Text = "SĐT";
            this.rbnPhoneNum.UseVisualStyleBackColor = true;
            this.rbnPhoneNum.CheckedChanged += new System.EventHandler(this.rbnPhoneNum_CheckedChanged);
            // 
            // rbnName
            // 
            this.rbnName.AutoSize = true;
            this.rbnName.Location = new System.Drawing.Point(185, 29);
            this.rbnName.Name = "rbnName";
            this.rbnName.Size = new System.Drawing.Size(57, 17);
            this.rbnName.TabIndex = 1;
            this.rbnName.TabStop = true;
            this.rbnName.Text = "Họ tên";
            this.rbnName.UseVisualStyleBackColor = true;
            this.rbnName.CheckedChanged += new System.EventHandler(this.rbnName_CheckedChanged);
            // 
            // rbnID
            // 
            this.rbnID.AutoSize = true;
            this.rbnID.Location = new System.Drawing.Point(32, 29);
            this.rbnID.Name = "rbnID";
            this.rbnID.Size = new System.Drawing.Size(58, 17);
            this.rbnID.TabIndex = 0;
            this.rbnID.TabStop = true;
            this.rbnID.Text = "Mã GV";
            this.rbnID.UseVisualStyleBackColor = true;
            this.rbnID.CheckedChanged += new System.EventHandler(this.rbnID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(197, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(400, 95);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 136);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnPhoneNum;
        private System.Windows.Forms.RadioButton rbnName;
        private System.Windows.Forms.RadioButton rbnID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOk;
    }
}