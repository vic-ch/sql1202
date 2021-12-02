using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
namespace 例子
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        
        public static string userName;//记录登录用户名字//主窗体中使用 //例子.userName
        public static string userRight;//记录登录用户的权限//主窗体中使用 //例子.userRight

        SqlConnection conn;
        SqlCommand com;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        private void frmlogin_Load(object sender, EventArgs e)
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

        private void cbxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("select operator_name,Permission from operator where operator_name='" + cbxUserName.Text + "'", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dr = com.ExecuteReader();


                if (dr.Read())
                {
                    lblUserRight.Text = dr["Permission"].ToString();
                    userRight = lblUserRight.Text;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                if (ds.Tables["operator"].Rows.Count > 0)
                {
                    userName = cbxUserName.Text;

                    frmmain frmmain = new frmmain();
                    this.Hide();
                    frmmain.Show();
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
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
