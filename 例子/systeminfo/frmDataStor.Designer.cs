namespace 例子.systeminfo
{
    partial class frmDataStor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataStor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDSPath = new System.Windows.Forms.TextBox();
            this.btnDStore = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDStore);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据备份";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(147, 101);
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
            this.groupBox2.Controls.Add(this.txtDSPath);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnSel
            // 
            this.btnSel.Image = ((System.Drawing.Image)(resources.GetObject("btnSel.Image")));
            this.btnSel.Location = new System.Drawing.Point(231, 49);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(43, 21);
            this.btnSel.TabIndex = 1;
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "单击选择按钮，选择备份文件的路径并输入文件名（不需扩展名）";
            // 
            // txtDSPath
            // 
            this.txtDSPath.Location = new System.Drawing.Point(17, 50);
            this.txtDSPath.Name = "txtDSPath";
            this.txtDSPath.Size = new System.Drawing.Size(199, 21);
            this.txtDSPath.TabIndex = 0;
            // 
            // btnDStore
            // 
            this.btnDStore.Location = new System.Drawing.Point(23, 101);
            this.btnDStore.Name = "btnDStore";
            this.btnDStore.Size = new System.Drawing.Size(75, 23);
            this.btnDStore.TabIndex = 2;
            this.btnDStore.Text = "数据备份";
            this.btnDStore.UseVisualStyleBackColor = true;
            this.btnDStore.Click += new System.EventHandler(this.btnDStore_Click);
            // 
            // frmDataStor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 169);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frmDataStor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份";
            this.Load += new System.EventHandler(this.frmDataStor_Load);
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
        private System.Windows.Forms.TextBox txtDSPath;
        private System.Windows.Forms.Button btnDStore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}