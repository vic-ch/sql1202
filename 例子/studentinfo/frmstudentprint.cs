using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例子.studentinfo
{
    public partial class frmstudentprint : Form
    {
        public frmstudentprint()
        {
            InitializeComponent();
        }

        private void frmstudentprint_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“studentDataSet1.view_student”中。您可以根据需要移动或删除它。
          //  this.view_studentTableAdapter.Fill(this.view_studentTableAdapter.GetData());

            this.reportViewer1.RefreshReport();
this.reportViewer1.RefreshReport();
        }
    }
}
