using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 例子.gradeinfo
{
    public partial class frmgrade_input : Form
    {
        public frmgrade_input()
        {
            InitializeComponent();
        }
        int AddOrEdit;//标记是添加或修改了记录
        SqlConnection conn;
        SqlCommand com;
        SqlDataAdapter da;

        private void ClearText()//清除控件内容
        {
            txtcno.Clear();
            txtsno.Clear();

            txtgrade.Clear();



        }

        private void LockedTextBox()//锁定文本框和组合框
        {
            txtcno.Enabled = false;
            txtsno.Enabled = false;

            txtgrade.Enabled = false;


        }

        private void UnLockedTextBox()//解锁文本框和组合框
        {
            txtcno.Enabled = true;
            txtsno.Enabled = true;

            txtgrade.Enabled = true;

        }
        private void FillDataGridView()//填充表格数据
        {
            da = new SqlDataAdapter("select * from sc order by cno", conn);//
            DataSet ds = new DataSet();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int count = da.Fill(ds, "分数表");
                conn.Close();
                dvstudent.DataSource = ds.Tables["分数表"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmgrade_input_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=(local);integrated security=true;database=student";

            tsbsave.Enabled = false;
            tsbcancel.Enabled = false;

            //添加查询条件列表值
            cbxCondition.Items.Clear();
            cbxCondition.Items.Add("sno");
            cbxCondition.Items.Add("cno");
            cbxCondition.Items.Add("grade");



            //充填格网

            FillDataGridView();
            //gridview与文本框一致

            LockedTextBox();
            
            txtsno.Text = Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtcno.Text = Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtgrade.Text = Convert.ToString(dvstudent[2, dvstudent.CurrentCell.RowIndex].Value).Trim();
            //todo


        }

        private void dvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtsno.Text = Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim();
            txtcno.Text = Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim();

            txtgrade.Text = Convert.ToString(dvstudent[2, dvstudent.CurrentCell.RowIndex].Value).Trim();

        }

        private void tsbadd_Click(object sender, EventArgs e)
        {

            txtcno.Enabled = true;
            txtsno.Enabled = true;

            txtgrade.Enabled = true;

            tsbsave.Enabled = true;
            tsbcancel.Enabled = true;

            ClearText();
            txtcno.Focus();
            AddOrEdit = 0;

        }

        private void tsbsave_Click(object sender, EventArgs e)
        {
            if (txtgrade.Text == "")
            {
                MessageBox.Show("成绩不能为空！");
                return;
            }


            if (AddOrEdit == 0)

            {
                //添加记录后的保存
                try
                {

                    //判断班级编号是否已存在
                    da = new SqlDataAdapter("select * from sc where cno='" + txtcno.Text.Trim() + "' and sno= '" + txtsno.Text.Trim() + "'", conn);
                    DataSet ds = new DataSet();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    int count = da.Fill(ds, "学分表");
                    conn.Close();

                    /*if (count!=1)
                    {
                        MessageBox.Show("该成绩记录不存在，请重新输入！");
                        txtcno.Focus();
                        return;
                    }
                    */

                    com = new SqlCommand("insert into sc(cno,sno,grade)values('" + txtcno.Text.Trim() + "','" + txtsno.Text.Trim() + "','" + txtgrade.Text + "')", conn);


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
                    com = new SqlCommand("update sc set grade='" + txtgrade.Text.Trim() + "'  where sno= '" + Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim() + "' and cno= '" + Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim() + "'", conn);
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


            txtcno.Enabled = false;
            txtsno.Enabled = false;
            txtgrade.Enabled = true;
            //UnLockedTextBox();
            txtgrade.Focus();
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
            if (MessageBox.Show("确定要删除该成绩记录吗？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    com = new SqlCommand("delete from sc where sno=" + Convert.ToString(dvstudent[0, dvstudent.CurrentCell.RowIndex].Value).Trim() + " and cno= " + Convert.ToString(dvstudent[1, dvstudent.CurrentCell.RowIndex].Value).Trim(), conn);
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
                    //分别按"cno"、"sno"、"grade"进行查询;
                    else
                    {
                        string fieldName = cbxCondition.Text;
                        string findValue = txtFindValue.Text.Trim();
                        //获得查询视图

                        da = new SqlDataAdapter("select * from sc where " + fieldName + " like '%" + findValue + "%'", conn);
                        DataSet ds = new DataSet();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        com = new SqlCommand("alter view view_student as select * from sc where " + fieldName + " like '%" + findValue + "%'", conn);
                        com.ExecuteNonQuery();
                        int count = da.Fill(ds, "分数表");
                        conn.Close();
                        if (count != 0)
                        {
                            dvstudent.DataSource = ds.Tables["分数表"];
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


    }
}
