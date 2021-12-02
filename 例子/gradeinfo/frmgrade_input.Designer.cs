namespace 例子.gradeinfo
{
    partial class frmgrade_input
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgrade_input));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.txtcno = new System.Windows.Forms.TextBox();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvstudent = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtFindValue = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.打印 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbadd = new System.Windows.Forms.ToolStripButton();
            this.tsbedit = new System.Windows.Forms.ToolStripButton();
            this.tsbdel = new System.Windows.Forms.ToolStripButton();
            this.tsbsave = new System.Windows.Forms.ToolStripButton();
            this.tsbcancel = new System.Windows.Forms.ToolStripButton();
            this.tsbfind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvstudent)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgrade);
            this.groupBox1.Controls.Add(this.txtcno);
            this.groupBox1.Controls.Add(this.txtsno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtgrade
            // 
            this.txtgrade.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtgrade.Location = new System.Drawing.Point(182, 139);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(197, 26);
            this.txtgrade.TabIndex = 9;
            // 
            // txtcno
            // 
            this.txtcno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcno.Location = new System.Drawing.Point(182, 96);
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(197, 26);
            this.txtcno.TabIndex = 8;
            // 
            // txtsno
            // 
            this.txtsno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsno.Location = new System.Drawing.Point(182, 41);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(197, 26);
            this.txtsno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(126, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = " 分数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(126, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvstudent);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息表";
            // 
            // dvstudent
            // 
            this.dvstudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvstudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvstudent.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvstudent.Location = new System.Drawing.Point(6, 20);
            this.dvstudent.Name = "dvstudent";
            this.dvstudent.RowTemplate.Height = 23;
            this.dvstudent.Size = new System.Drawing.Size(669, 176);
            this.dvstudent.TabIndex = 0;
            this.dvstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvstudent_CellClick);
            this.dvstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvstudent_CellContentClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "查询条件";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // cbxCondition
            // 
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "查询值";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // 打印
            // 
            this.打印.Name = "打印";
            this.打印.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbadd,
            this.toolStripSeparator1,
            this.tsbedit,
            this.toolStripSeparator2,
            this.tsbdel,
            this.toolStripSeparator3,
            this.tsbsave,
            this.toolStripSeparator4,
            this.tsbcancel,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.cbxCondition,
            this.toolStripLabel2,
            this.txtFindValue,
            this.tsbfind,
            this.toolStripSeparator7,
            this.打印,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbadd
            // 
            this.tsbadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbadd.Image = ((System.Drawing.Image)(resources.GetObject("tsbadd.Image")));
            this.tsbadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbadd.Name = "tsbadd";
            this.tsbadd.Size = new System.Drawing.Size(36, 22);
            this.tsbadd.Text = "添加";
            this.tsbadd.Click += new System.EventHandler(this.tsbadd_Click);
            // 
            // tsbedit
            // 
            this.tsbedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbedit.Image = ((System.Drawing.Image)(resources.GetObject("tsbedit.Image")));
            this.tsbedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbedit.Name = "tsbedit";
            this.tsbedit.Size = new System.Drawing.Size(36, 22);
            this.tsbedit.Text = "修改";
            this.tsbedit.Click += new System.EventHandler(this.tsbedit_Click);
            // 
            // tsbdel
            // 
            this.tsbdel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbdel.Image = ((System.Drawing.Image)(resources.GetObject("tsbdel.Image")));
            this.tsbdel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbdel.Name = "tsbdel";
            this.tsbdel.Size = new System.Drawing.Size(36, 22);
            this.tsbdel.Text = "删除";
            this.tsbdel.Click += new System.EventHandler(this.tsbdel_Click);
            // 
            // tsbsave
            // 
            this.tsbsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbsave.Image = ((System.Drawing.Image)(resources.GetObject("tsbsave.Image")));
            this.tsbsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsave.Name = "tsbsave";
            this.tsbsave.Size = new System.Drawing.Size(36, 22);
            this.tsbsave.Text = "保存";
            this.tsbsave.Click += new System.EventHandler(this.tsbsave_Click);
            // 
            // tsbcancel
            // 
            this.tsbcancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbcancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbcancel.Image")));
            this.tsbcancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbcancel.Name = "tsbcancel";
            this.tsbcancel.Size = new System.Drawing.Size(36, 22);
            this.tsbcancel.Text = "取消";
            this.tsbcancel.Click += new System.EventHandler(this.tsbcancel_Click);
            // 
            // tsbfind
            // 
            this.tsbfind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbfind.Image = ((System.Drawing.Image)(resources.GetObject("tsbfind.Image")));
            this.tsbfind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbfind.Name = "tsbfind";
            this.tsbfind.Size = new System.Drawing.Size(36, 22);
            this.tsbfind.Text = "查询";
            this.tsbfind.Click += new System.EventHandler(this.tsbfind_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "退出";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmgrade_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmgrade_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩信息输入";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.frmgrade_input_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvstudent)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.TextBox txtcno;
        private System.Windows.Forms.TextBox txtsno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvstudent;
        private System.Windows.Forms.ToolStripButton tsbadd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbedit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbdel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbsave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbcancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtFindValue;
        private System.Windows.Forms.ToolStripButton tsbfind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton 打印;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}