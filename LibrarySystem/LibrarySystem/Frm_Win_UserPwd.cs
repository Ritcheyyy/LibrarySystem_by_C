using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Frm_Win_UserPwd : Form
    {
        public string Uid = "";
        public string OldPwd = "";

        public Frm_Win_UserPwd()
        {
            InitializeComponent();
        }

        protected int ChangeQuery(string query)
        {
            //1 客户端发出请求query

            //2 创建并打开数据库连接
            string str = "server=localhost;database=library_db;uid=root;pwd=123456;port=3306";
            MySqlConnection conn = new MySqlConnection(str);
            conn.Open();

            //3 创建执行对象
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //4 执行查询，并返回受影响行数
            int i = cmd.ExecuteNonQuery();

            //5 关闭连接
            conn.Close();

            return i;
        }

        public Boolean check()
        {
            if (txt_OldPwd.Text == "")
            {
                lbl_tip.Text = "请输入原密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_OldPwd.Focus();
                return false;
            }
            else if (txt_NewPwd.Text == "")
            {
                lbl_tip.Text = "请输入新密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_NewPwd.Focus();
                return false;
            }
            else if (txt_Pwd_Confirm.Text == "")
            {
                lbl_tip.Text = "请确认新密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd_Confirm.Focus();
                return false;
            }
            else if(txt_OldPwd.Text != OldPwd)
            {
                lbl_tip.Text = "原始密码输入错误！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_OldPwd.Clear();
                txt_OldPwd.Focus();
                return false;
            }
            else if (txt_NewPwd.Text != txt_Pwd_Confirm.Text)
            {
                lbl_tip.Text = "两次输入的密码不一致！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd_Confirm.Focus();
                return false;
            }
            else
            {
                lbl_tip.Text = "";
                return true;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string Query = string.Format("update reader_info set RPwd = '{0}' where RID = {1}", txt_NewPwd.Text, int.Parse(Uid));
                if(ChangeQuery(Query) > 0)
                {
                    MessageBox.Show("恭喜你，密码修改成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("对不起，密码修改失败！");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
