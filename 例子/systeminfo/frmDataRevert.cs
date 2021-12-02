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

namespace 例子.systeminfo
{
    public partial class frmDataRevert : Form
    {
        public frmDataRevert()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand com;
        private void frmDataRevert_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=(local);integrated security=true;database=student";
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";//设定初始目录
            openFileDialog1.Filter = "bak files (*.bak)|*.bak";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            txtDRPath.Text = openFileDialog1.FileName.ToString().Trim();
        }

        private void btnDRevert_Click(object sender, EventArgs e)
        {


            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string sqlString = "use master restore database student from disk='" + txtDRPath.Text.Trim() + "' with replace,norecovery";
                com = new SqlCommand(sqlString, conn);

                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
