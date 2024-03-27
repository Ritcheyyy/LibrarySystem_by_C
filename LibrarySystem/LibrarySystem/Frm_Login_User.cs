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
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class Frm_Login_User : Form
    {
        private Frm_Main re_Frm_Main = null;
        public Frm_Login_User(Frm_Main re_Frm_Main)
        {
            InitializeComponent();
            this.re_Frm_Main = re_Frm_Main;
        }

        protected DataTable SearchQuery(string query)
        {
            //1 客户端发出请求query

            //2 创建并打开数据库连接
            string str = "server=localhost;database=library_db;uid=root;pwd=123456;port=3306";
            MySqlConnection conn = new MySqlConnection(str);
            conn.Open();

            //3 创建执行对象
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            //4 创建临时数据表
            DataTable dt = new DataTable();

            //5 执行查询，并将返回结果存入临时数据表
            da.Fill(dt);

            //6 关闭连接
            conn.Close();

            return dt;
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

            //4 =执行查询，并返回受影响行数
            int i = cmd.ExecuteNonQuery();

            //5 关闭连接
            conn.Close();

            return i;
        }

        public Boolean check()
        {
            if(txt_Uname.Text == "")
            {
                lbl_tip.Text = "请输入账号！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Uname.Focus();
                return false;
            }
            else if(txt_Pwd.Text == "")
            {
                lbl_tip.Text = "请输入密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd.Focus();
                return false;
            }
            else
            {
                lbl_tip.Text = "";
                return true;
            }
        }

        protected void InfoClear()
        {
            txt_Uname.Text = "";
            txt_Pwd.Text = "";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (check())
            {
                // 客户端发出请求
                string str = string.Format("select RPwd,RName,RCID from reader_Info where RID = {0}", int.Parse(txt_Uname.Text));

                // 创建临时数据表，用于存放查询结果
                DataTable dt = SearchQuery(str);

                // 处理结果
                if (dt.Rows.Count > 0)
                {
                    // 密码是否输入正确判断
                    if (dt.Rows[0][0].ToString() == txt_Pwd.Text.ToString())
                    {
                        Frm_Win_User frm_Win_User = new Frm_Win_User(re_Frm_Main);
                        frm_Win_User.Uid = txt_Uname.Text.ToString();
                        frm_Win_User.Uname = dt.Rows[0][1].ToString();
                        frm_Win_User.Ukind = dt.Rows[0][2].ToString();
                        frm_Win_User.Show();
                        InfoClear();
                        this.Close();
                    }
                    else
                    {
                        // 密码输入错误
                        MessageBox.Show("对不起，密码输入有误！");
                        txt_Pwd.Clear();
                    }
                }
                else
                {
                    // 账号输入错误
                    MessageBox.Show("对不起，账号输入有误或账号不存在！\n   请尝试修改账号或进行注册！");
                }
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Frm_Register frm_Register = new Frm_Register(re_Frm_Main);
            frm_Register.Reg_Uname = txt_Uname.Text.ToString();
            frm_Register.Reg_Pwd = txt_Pwd.Text.ToString();
            frm_Register.Show();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            InfoClear();
            this.re_Frm_Main.Visible = true;
            this.Close();
        }

        private void Frm_Login_User_Load(object sender, EventArgs e)
        {
            txt_Uname.Focus();
        }
    }
}
