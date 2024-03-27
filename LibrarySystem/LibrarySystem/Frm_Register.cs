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
    public partial class Frm_Register : Form
    {
        // 全局变量定义
        public string Reg_Uname = "";
        public string Reg_Pwd = "";
        private Frm_Main re_Frm_Main = null;

        public Frm_Register(Frm_Main re_Frm_Main)
        {
            InitializeComponent();
            this.re_Frm_Main = re_Frm_Main;
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
            if (txt_Uid.Text == "")
            {
                lbl_tip.Text = "请输入账号！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Uid.Focus();
                return false;
            }
            else if (txt_Uname.Text == "")
            {
                lbl_tip.Text = "请输入用户名！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Uname.Focus();
                return false;
            }
            else if (txt_Pwd.Text == "")
            {
                lbl_tip.Text = "请输入密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd.Focus();
                return false;
            }
            else if (txt_Pwd_Confirm.Text == "")
            {
                lbl_tip.Text = "请确认密码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd_Confirm.Focus();
                return false;
            }
            else if(txt_Pwd.Text != txt_Pwd_Confirm.Text)
            {
                lbl_tip.Text = "两次输入的密码不一致！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Pwd.Focus();
                return false;
            }
            else if (txt_Phone.Text == "")
            {
                lbl_tip.Text = "请确认电话号码！";
                lbl_tip.ForeColor = System.Drawing.Color.Red;
                txt_Phone.Focus();
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
            txt_Uid.Text = "";
            txt_Uname.Text = "";
            txt_Pwd.Text = "";
            txt_Pwd_Confirm.Text = "";
            txt_Phone.Text = "";
            rbtn_Gender_1.Checked = true;
            rbtn_Gender_2.Checked = false;
            rbtn_Identity_1.Checked = true;
            rbtn_Identity_2.Checked = false;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            int sex = rbtn_Gender_1.Checked == true ? 1 : 2;
            int identity = rbtn_Identity_1.Checked == true ? 1 : 2;
            DateTime RegisterDate = DateTime.Now;
            DateTime ValidDate = RegisterDate.AddYears(4);

            if (check())
            {
                // 客户端发出请求
                string str = string.Format("insert into Reader_Info values({0},{1},'{2}','{3}',{4},'{5}','{6}','{7}', 0, 0, 0, 0, NULL)",
                    int.Parse(txt_Uid.Text), identity, txt_Pwd.Text, txt_Uname.Text, sex, txt_Phone.Text, RegisterDate, ValidDate);

                // 执行操作并返回受影响行数
                int i = 0;
                try 
                {
                    i = ChangeQuery(str);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("很遗憾，未能注册成功！");
                    InfoClear();
                }

                // 处理结果
                if (i > 0)
                {
                    MessageBox.Show("恭喜您，注册成功！");
                    this.re_Frm_Main.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("很遗憾，未能注册成功！");
                    InfoClear();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.re_Frm_Main.Visible = true;
            this.Close();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            txt_Uid.Focus();
            txt_Uid.Text = Reg_Uname;
            txt_Pwd.Text = Reg_Pwd;
        }
    }
}
