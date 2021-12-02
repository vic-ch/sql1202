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

namespace 例子
{
    public partial class frmmodifypsw : Form
    {
        public frmmodifypsw()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand com;
        SqlDataAdapter da;
      //  SqlDataReader dr;
        DataSet ds;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmmodifypsw_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("server=(local);integrated security=true;database=student");
                ds = new DataSet();
                da = new SqlDataAdapter("select operator_name from operator", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(ds, "operator_name");
                conn.Close();
                cbxUserName.DataSource = ds.Tables["operator_name"];
                cbxUserName.DisplayMember = "operator_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                da = new SqlDataAdapter("select * from operator where operator_name='" + cbxUserName.Text.Trim() + "' and psw='" + txtUserPwd.Text.Trim() + "'", conn);
                DataSet ds = new DataSet();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(ds, "operator");
                conn.Close();
                if (ds.Tables["operator"].Rows.Count > 0 &&  textBox1.Text.Trim()==textBox2.Text.Trim())
                {

                    com = new SqlCommand("update operator set psw='" + textBox1.Text.Trim() + "' where operator_name='"+cbxUserName.Text.Trim()+"'", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    com.ExecuteNonQuery();
                    conn.Close();                 
                    
                    
                    
                    MessageBox.Show("修改密码成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserPwd.Text = "";
                    cbxUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            frmlogin frmtest = new frmlogin();
            frmtest.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
