using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 例子.studentinfo;
using 例子.systeminfo;
using 例子.courseinfo;
using 例子.gradeinfo;

namespace 例子
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmlogin frmtest = new frmlogin();
            frmtest.Show();
           this.Hide();
            this.Close();
        }

        private void 口令修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmodifypsw frmtest = new frmmodifypsw();
            frmtest.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void 学生信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent_input frmtest = new frmstudent_input();
            frmtest.ShowDialog();
        }

        private void 系统备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataStor frmtest = new frmDataStor();
            frmtest.ShowDialog();
        }

        private void 系统还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataRevert frmtest = new frmDataRevert();
            frmtest.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmstudent_input frmtest = new frmstudent_input();
            frmtest.ShowDialog();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent_input frmtest = new frmstudent_input();
            frmtest.ShowDialog();
        }

        private void 课程设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcourse_input frmtest = new frmcourse_input();
            frmtest.ShowDialog();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrade_input frmtest = new frmgrade_input();
            frmtest.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            学生信息录入ToolStripMenuItem_Click(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            课程设置ToolStripMenuItem_Click(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            成绩录入ToolStripMenuItem_Click(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            口令修改ToolStripMenuItem_Click(sender,e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            重新登录ToolStripMenuItem_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
