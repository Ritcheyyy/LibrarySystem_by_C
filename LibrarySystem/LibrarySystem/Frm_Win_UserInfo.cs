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
    public partial class Frm_Win_UserInfo : Form
    { 
        private Frm_Win_User re_Frm_Win_User = null;
        public string Uid = "";

        public Frm_Win_UserInfo(Frm_Win_User re_Frm_Win_User)
        {
            InitializeComponent();
            this.re_Frm_Win_User = re_Frm_Win_User;
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

        public void Load_ReaderInfo()
        {
            string query = string.Format("select * from Reader_info where RID = {0};", Uid);
            DataTable dt = SearchQuery(query);

            if (dt.Rows.Count > 0)
            {
                txt_RID.Text = dt.Rows[0][0].ToString();
                txt_RCID.Text = dt.Rows[0][1].ToString() == "1" ? "学生" : "老师";
                txt_RPwd.Text = dt.Rows[0][2].ToString();
                txt_RName.Text = dt.Rows[0][3].ToString();
                txt_Sex.Text = dt.Rows[0][4].ToString() == "1" ? "男" : "女";
                txt_Phone.Text = dt.Rows[0][5].ToString();
                txt_RegDate.Text = dt.Rows[0][6].ToString();
                txt_ValidDate.Text = dt.Rows[0][7].ToString();
                txt_CurrBookNum.Text = dt.Rows[0][8].ToString();
                txt_TotalBookNum.Text = dt.Rows[0][9].ToString();
                cbb_isLost.Text = dt.Rows[0][10].ToString() == "0" ? "否" : "是";
                txt_ViolationNum.Text = dt.Rows[0][11].ToString();
            }
        }

        private void Frm_Win_UserInfo_Load(object sender, EventArgs e)
        {
            Load_ReaderInfo();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.re_Frm_Win_User.Visible = true;
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_RName.Text == "")
            {
                MessageBox.Show("读者姓名不能为空！");
            }
            else if(txt_Phone.Text == "")
            {
                MessageBox.Show("联系电话不能为空！");
            }
            else
            {
                int Lost = cbb_isLost.Text == "是" ? 1 : 0;
                string Query = string.Format("update reader_info set RName = '{0}', Phone = '{1}', Lost = {2} where RID = {3}", txt_RName.Text, txt_Phone.Text, Lost, int.Parse(Uid));
                if (ChangeQuery(Query) > 0)
                {
                    MessageBox.Show("恭喜你，个人信息修改成功！");
                    this.re_Frm_Win_User.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("对不起，个人信息未能成功修改！");
                }
            }
        }

        private void btn_editPwd_Click(object sender, EventArgs e)
        {
            Frm_Win_UserPwd frm_Win_UserPwd = new Frm_Win_UserPwd();
            frm_Win_UserPwd.Uid = Uid;
            frm_Win_UserPwd.OldPwd = txt_RPwd.Text;
            frm_Win_UserPwd.Show();
        }
    }
}
