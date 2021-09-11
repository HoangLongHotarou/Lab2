
using System.Drawing;

namespace Lab2
{
    partial class frmAcademic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcademic));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkITA = new System.Windows.Forms.CheckBox();
            this.chkITB = new System.Windows.Forms.CheckBox();
            this.chkEngA = new System.Windows.Forms.CheckBox();
            this.chkEngB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblITAPrice = new System.Windows.Forms.Label();
            this.lblITBPrice = new System.Windows.Forms.Label();
            this.lblEngAPrice = new System.Windows.Forms.Label();
            this.lblEngBPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpRegister = new System.Windows.Forms.DateTimePicker();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFermale = new System.Windows.Forms.RadioButton();
            this.txtSumAmount = new System.Windows.Forms.TextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính tiền học trung tâm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã học viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // chkITA
            // 
            this.chkITA.AutoSize = true;
            this.chkITA.Location = new System.Drawing.Point(81, 176);
            this.chkITA.Name = "chkITA";
            this.chkITA.Size = new System.Drawing.Size(72, 17);
            this.chkITA.TabIndex = 5;
            this.chkITA.Text = "Tin học A";
            this.chkITA.UseVisualStyleBackColor = true;
            // 
            // chkITB
            // 
            this.chkITB.AutoSize = true;
            this.chkITB.Location = new System.Drawing.Point(81, 199);
            this.chkITB.Name = "chkITB";
            this.chkITB.Size = new System.Drawing.Size(74, 17);
            this.chkITB.TabIndex = 6;
            this.chkITB.Text = "Tin Học B";
            this.chkITB.UseVisualStyleBackColor = true;
            // 
            // chkEngA
            // 
            this.chkEngA.AutoSize = true;
            this.chkEngA.Location = new System.Drawing.Point(81, 222);
            this.chkEngA.Name = "chkEngA";
            this.chkEngA.Size = new System.Drawing.Size(84, 17);
            this.chkEngA.TabIndex = 7;
            this.chkEngA.Text = "Tiếng anh A";
            this.chkEngA.UseVisualStyleBackColor = true;
            // 
            // chkEngB
            // 
            this.chkEngB.AutoSize = true;
            this.chkEngB.Location = new System.Drawing.Point(81, 245);
            this.chkEngB.Name = "chkEngB";
            this.chkEngB.Size = new System.Drawing.Size(84, 17);
            this.chkEngB.TabIndex = 8;
            this.chkEngB.Text = "Tiếng anh B";
            this.chkEngB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền";
            // 
            // lblITAPrice
            // 
            this.lblITAPrice.AutoSize = true;
            this.lblITAPrice.Location = new System.Drawing.Point(262, 177);
            this.lblITAPrice.Name = "lblITAPrice";
            this.lblITAPrice.Size = new System.Drawing.Size(74, 13);
            this.lblITAPrice.TabIndex = 2;
            this.lblITAPrice.Text = "300.000 đồng";
            // 
            // lblITBPrice
            // 
            this.lblITBPrice.AutoSize = true;
            this.lblITBPrice.Location = new System.Drawing.Point(262, 200);
            this.lblITBPrice.Name = "lblITBPrice";
            this.lblITBPrice.Size = new System.Drawing.Size(74, 13);
            this.lblITBPrice.TabIndex = 2;
            this.lblITBPrice.Text = "500.000 đồng";
            // 
            // lblEngAPrice
            // 
            this.lblEngAPrice.AutoSize = true;
            this.lblEngAPrice.Location = new System.Drawing.Point(262, 226);
            this.lblEngAPrice.Name = "lblEngAPrice";
            this.lblEngAPrice.Size = new System.Drawing.Size(74, 13);
            this.lblEngAPrice.TabIndex = 2;
            this.lblEngAPrice.Text = "400.000 đồng";
            // 
            // lblEngBPrice
            // 
            this.lblEngBPrice.AutoSize = true;
            this.lblEngBPrice.Location = new System.Drawing.Point(262, 246);
            this.lblEngBPrice.Name = "lblEngBPrice";
            this.lblEngBPrice.Size = new System.Drawing.Size(74, 13);
            this.lblEngBPrice.TabIndex = 2;
            this.lblEngBPrice.Text = "600.000 đồng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 3;
            // 
            // dtpRegister
            // 
            this.dtpRegister.Location = new System.Drawing.Point(92, 119);
            this.dtpRegister.Name = "dtpRegister";
            this.dtpRegister.Size = new System.Drawing.Size(200, 20);
            this.dtpRegister.TabIndex = 4;
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(92, 57);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(121, 21);
            this.cboID.TabIndex = 0;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(282, 58);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(47, 17);
            this.rbnMale.TabIndex = 1;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Nam";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFermale
            // 
            this.rbnFermale.AutoSize = true;
            this.rbnFermale.Location = new System.Drawing.Point(335, 58);
            this.rbnFermale.Name = "rbnFermale";
            this.rbnFermale.Size = new System.Drawing.Size(39, 17);
            this.rbnFermale.TabIndex = 2;
            this.rbnFermale.TabStop = true;
            this.rbnFermale.Text = "Nữ";
            this.rbnFermale.UseVisualStyleBackColor = true;
            // 
            // txtSumAmount
            // 
            this.txtSumAmount.Enabled = false;
            this.txtSumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumAmount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSumAmount.Location = new System.Drawing.Point(177, 283);
            this.txtSumAmount.Name = "txtSumAmount";
            this.txtSumAmount.Size = new System.Drawing.Size(205, 22);
            this.txtSumAmount.TabIndex = 9;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(81, 333);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 11;
            this.btnBill.Text = "Tính tiền";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(192, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 368);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.txtSumAmount);
            this.Controls.Add(this.rbnFermale);
            this.Controls.Add(this.rbnMale);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.dtpRegister);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEngBPrice);
            this.Controls.Add(this.lblEngAPrice);
            this.Controls.Add(this.lblITBPrice);
            this.Controls.Add(this.lblITAPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkEngB);
            this.Controls.Add(this.chkEngA);
            this.Controls.Add(this.chkITB);
            this.Controls.Add(this.chkITA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAcademic";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkITA;
        private System.Windows.Forms.CheckBox chkITB;
        private System.Windows.Forms.CheckBox chkEngA;
        private System.Windows.Forms.CheckBox chkEngB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblITAPrice;
        private System.Windows.Forms.Label lblITBPrice;
        private System.Windows.Forms.Label lblEngAPrice;
        private System.Windows.Forms.Label lblEngBPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpRegister;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.RadioButton rbnFermale;
        private System.Windows.Forms.TextBox txtSumAmount;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

