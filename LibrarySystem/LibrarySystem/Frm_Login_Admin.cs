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
    public partial class Frm_Login_Admin : Form
    {
        private Frm_Main re_Frm_Main = null;
        private string AdminKey = "1111";
        public Frm_Login_Admin(Frm_Main re_Frm_Main)
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

        public Boolean check()
        {
            if (txt_Aname.Text == "")
            {
                lbl_tip.Text = "请输入账号！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Aname.Focus();
                return false;
            }
            else if (txt_Pwd.Text == "")
            {
                lbl_tip.Text = "请输入密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd.Focus();
                return false;
            }
            else if (txt_Key.Text == "")
            {
                lbl_tip.Text = "请输入管理员密钥！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Key.Focus();
                return false;
            }
            else if (txt_Key.Text != AdminKey)
            {
                MessageBox.Show("对不起，管理员密钥输入有误！");
                txt_Key.Clear();
                txt_Key.Focus();
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
            txt_Aname.Text = "";
            txt_Pwd.Text = "";
            txt_Key.Text = "";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (check())
            {
                // 客户端发出请求
                string str = string.Format("select APwd,AName from Administrator_Info where AID = {0}", int.Parse(txt_Aname.Text));

                // 创建临时数据表，用于存放查询结果
                DataTable dt = SearchQuery(str);

                // 处理结果
                if (dt.Rows.Count > 0)
                {
                    // 密码是否输入正确判断
                    if (dt.Rows[0][0].ToString() == txt_Pwd.Text)
                    {
                        Frm_Win_Admin frm_Win_Admin = new Frm_Win_Admin(re_Frm_Main);
                        frm_Win_Admin.Aid = txt_Aname.Text;
                        frm_Win_Admin.AName = dt.Rows[0][1].ToString();
                        frm_Win_Admin.Show();
                        InfoClear();
                        this.Close();
                    }
                    else
                    {
                        // 密码输入错误
                        MessageBox.Show("对不起，密码输入有误！");
                        txt_Pwd.Text = "";
                        txt_Key.Text = "";
                    }
                }
                else
                {
                    // 账号输入错误
                    MessageBox.Show("对不起，账号输入有误或账号不存在！");
                    InfoClear();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            InfoClear();
            this.re_Frm_Main.Visible = true;
            this.Close();
        }

        private void Frm_Login_Admin_Load(object sender, EventArgs e)
        {
            txt_Aname.Focus();
        }
    }
}
