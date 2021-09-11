
namespace Lab2
{
    partial class frmInform
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
            this.lblInform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Location = new System.Drawing.Point(66, 46);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(35, 13);
            this.lblInform.TabIndex = 0;
            this.lblInform.Text = "label1";
            // 
            // frmInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 292);
            this.Controls.Add(this.lblInform);
            this.Name = "frmInform";
            this.Text = "frmInform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInform;
    }
}