using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 例子.studentinfo
{
    public partial class frmstudent_input : Form
    {
        public frmstudent_input()
        {
            InitializeComponent();
        }
        int AddOrEdit;//标记是添加或修改了记录
        SqlConnection conn;
        SqlCommand com;
        SqlDataAdapter da;

        private void ClearText()//清除控件内容
        {
            txtsno.Clear();
            txtsname.Clear();
            combsex.Text = "";
            txtage.Clear();
            combsdept.Text = "";
         
     
        }

        private void LockedTextBox()//锁定文本框和组合框
        {
            txtsno.Enabled = false;
            txtsname.Enabled = false;
            combsex.Enabled = false;
            txtage.Enabled = false;
            combsdept.Enabled = false;
            
        }

        private void UnLockedTextBox()//解锁文本框和组合框
        {
            txtsno.Enabled =true;
            txtsname.Enabled = true;
            combsex.Enabled = true;
            txtage.Enabled = true;
            combsdept.Enabled = true;
            
        }
        private void FillDataGridView()//填充表格数据
        {
            da = new SqlDataAdapter("select * from student order by sno", conn);//
            DataSet ds = new DataSet();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int count = da.Fill(ds, "学生表");
                conn.Close();
                dvstudent.DataSource = ds.Tables["学生表"];                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmstudent_input_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=(local);integrated security=true;database=student";
            
            tsbsave.Enabled = false;
            tsbcancel.Enabled = false;

            //添加查询条件列表值
            cbxCondition.Items.Clear();
            cbxCondition.Items.Add("sno");
            cbxCondition.Items.Add("sname");
            cbxCondition.Items.Add("sex");
            cbxCondition.Items.Add("sage");
            cbxCondition.Items.Add("sdept");

    
            //绑定系别组合框
            da = new SqlDataAdapter("select distinct sdept from student", conn);
            DataSet ds1 = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da.Fill(ds1, "系别表");
            conn.Close();
            combsdept.DataSource = ds1.Tables["系别表"];
            combsdept.DisplayMember = "sdept";

            //绑定性别组合框
            da = new SqlDataAdapter("select distinct sex from student", conn);
            DataSet ds2 = new DataSet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da.Fill(ds2, "性别");
            conn.Close();
            combsex.DataSource = ds2.Tables["性别"];
            combsex.DisplayMember = "sex";

            //充填格网

            FillDataGridView();
            //gridview与文本框一致

            LockedTextBox();
            txtsno.Text = Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtsname.Text = Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim();
            combsex.Text = Convert.ToString(dvstudent[2, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtage.Text = Convert.ToString(dvstudent[3, dvstudent.CurrentCell.RowIndex].Value).Trim();
            combsdept.Text = Convert.ToString(dvstudent[4, dvstudent.CurrentCell.RowIndex].Value).Trim();
            

        }

        private void dvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsno.Text = Convert.ToString(dvstudent[0,dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtsname.Text = Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim();
            combsex.Text = Convert.ToString(dvstudent[2, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtage.Text = Convert.ToString(dvstudent[3, dvstudent.CurrentCell.RowIndex].Value).Trim();
            combsdept.Text = Convert.ToString(dvstudent[4, dvstudent.CurrentCell.RowIndex].Value).Trim();
        }

        private void tsbadd_Click(object sender, EventArgs e)
        {
            txtsno.Enabled =true;
            txtsname.Enabled =true;
            combsex.Enabled =true;
            txtage.Enabled =true;
            combsdept.Enabled =true;

            tsbsave.Enabled = true;
            tsbcancel.Enabled = true;

            ClearText();
            txtsno.Focus();
            AddOrEdit= 0;

        }

        private void tsbsave_Click(object sender, EventArgs e)
        {
            if (txtsno.Text == "")
            {
                MessageBox.Show("学号不能为空！");
                return;
            }
            if (txtsname.Text == "")
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }

            if (AddOrEdit == 0)

            {
                //添加记录后的保存
                try
                {

                    //判断班级编号是否已存在
                    da = new SqlDataAdapter("select * from student where sno='" + txtsno.Text.Trim() + "'", conn);
                    DataSet ds = new DataSet();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    int count = da.Fill(ds, "学生表");
                    conn.Close();
                    if (count != 0)
                    {
                        MessageBox.Show("该学号已存在，请重新输入！");
                        txtsno.Focus();
                        return;
                    }
                   
                    com = new SqlCommand("insert into student(sno,sname,sex,sage,sdept)values('" + txtsno.Text.Trim() + "','" + txtsname.Text.Trim() + "','" + combsex.Text.Trim()+ "','" + txtage.Text + "','" + combsdept.Text.Trim() + "')", conn);
                   
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("添加数据成功！");
                    FillDataGridView();

                    tsbsave.Enabled = false;
                    tsbcancel.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            LockedTextBox();
            }

            if (AddOrEdit == 1)
            {

                //修改记录后的保存
                try
                {
                    com = new SqlCommand("update student set sno='" + txtsno.Text.Trim() + "',sname='" + txtsname.Text.Trim() + "',sex='" + combsex.Text.Trim() + "',sage='" + txtage.Text.Trim() + "',sdept='" + combsdept.Text.Trim() + "' where sno=" + Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim(), conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改数据成功！");
                    FillDataGridView();
                    tsbsave.Enabled = false;
                    tsbcancel.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                LockedTextBox();
            }            

        }

        private void tsbedit_Click(object sender, EventArgs e)
        {
            tsbsave.Enabled = true;
            tsbcancel.Enabled = true;
            AddOrEdit = 1;
            UnLockedTextBox();
            txtsno.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbcancel_Click(object sender, EventArgs e)
        {
            LockedTextBox();
            tsbcancel.Enabled = false;
            tsbsave.Enabled = false;
        }

        private void tsbdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该系信息吗？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    com = new SqlCommand("delete from student where sno=" + Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim(), conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("删除数据成功！");
                    ClearText();
                    FillDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void tsbfind_Click(object sender, EventArgs e)
        {
            if (cbxCondition.Text.Length != 0)
            {
                try
                {
                    if (txtFindValue.Text.Length == 0)
                    {
                        this.FillDataGridView();//显示所有记录
                    }
                    //分别按"sno"、"sname"、"sex"、"sage"、"sdept"进行查询;
                    else
                    {
                        string fieldName = cbxCondition.Text;
                        string findValue = txtFindValue.Text.Trim();
                        //获得查询视图
                        
                        da = new SqlDataAdapter("select * from student where " + fieldName + " like '%" + findValue + "%'", conn);
                        DataSet ds = new DataSet();
                        if(conn.State==ConnectionState.Closed)
                        conn.Open();

                        com = new SqlCommand("alter view view_student as select * from student where " + fieldName + " like '%" + findValue + "%'", conn);
                        com.ExecuteNonQuery();
                        int count = da.Fill(ds, "学生表");
                        conn.Close();
                        if (count != 0)
                        {
                            dvstudent.DataSource = ds.Tables["学生表"];                            
                        }
                        else
                        {
                            MessageBox.Show("没有查询到符合条件的记录！");
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                MessageBox.Show("请选择查询条件");
            }
        }

        private void 打印_Click(object sender, EventArgs e)
        {
            frmstudentprint frmtest = new frmstudentprint();
            frmtest.ShowDialog();
        }

    
    }
}
