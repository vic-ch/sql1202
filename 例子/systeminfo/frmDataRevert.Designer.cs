﻿namespace 例子.systeminfo
{
    partial class frmDataRevert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataRevert));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDRPath = new System.Windows.Forms.TextBox();
            this.btnDRevert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDRevert);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据还原";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDRPath);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnSel
            // 
            this.btnSel.Image = ((System.Drawing.Image)(resources.GetObject("btnSel.Image")));
            this.btnSel.Location = new System.Drawing.Point(201, 34);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(42, 23);
            this.btnSel.TabIndex = 1;
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要还原的文件";
            // 
            // txtDRPath
            // 
            this.txtDRPath.Location = new System.Drawing.Point(37, 36);
            this.txtDRPath.Name = "txtDRPath";
            this.txtDRPath.Size = new System.Drawing.Size(157, 21);
            this.txtDRPath.TabIndex = 0;
            // 
            // btnDRevert
            // 
            this.btnDRevert.Location = new System.Drawing.Point(62, 101);
            this.btnDRevert.Name = "btnDRevert";
            this.btnDRevert.Size = new System.Drawing.Size(75, 23);
            this.btnDRevert.TabIndex = 2;
            this.btnDRevert.Text = "数据还原";
            this.btnDRevert.UseVisualStyleBackColor = true;
            this.btnDRevert.Click += new System.EventHandler(this.btnDRevert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDataRevert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 164);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDataRevert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据还原";
            this.Load += new System.EventHandler(this.frmDataRevert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDRPath;
        private System.Windows.Forms.Button btnDRevert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}