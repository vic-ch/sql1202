namespace 例子.studentinfo
{
    partial class frmstudentprint
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
            this.components = new System.ComponentModel.Container();
            this.viewstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new 例子.studentDataSet1();
            this.view_studentTableAdapter = new 例子.studentDataSet1TableAdapters.view_studentTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewstudentBindingSource
            // 
            this.viewstudentBindingSource.DataMember = "view_student";
            this.viewstudentBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "studentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_studentTableAdapter
            // 
            this.view_studentTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "例子.studentinfo.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(687, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmstudentprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmstudentprint";
            this.Text = "学生信息打印";
            this.Load += new System.EventHandler(this.frmstudentprint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private studentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource viewstudentBindingSource;
        private studentDataSet1TableAdapters.view_studentTableAdapter view_studentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}