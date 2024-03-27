using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Frm_Win_AdminBook : Form
    {
        public string ISBN = "";
        public string BName = "";
        public string BAuthor = "";
        public string PID = "";
        public string PublishNum = "";
        public string PublishDate = "";
        public string Price = "";
        public string BriefIntroduction = "";
        public string CurrNum = "";
        public string TotalNum = "";

        private Frm_Win_Admin re_Frm_Win_Admin = null;

        public Frm_Win_AdminBook(Frm_Win_Admin re_Frm_Win_Admin)
        {
            InitializeComponent();
            this.re_Frm_Win_Admin = re_Frm_Win_Admin;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Query = string.Format("update book_info set BName='{0}', BAuthor='{1}', PID={2}, PublishNum={3}, PublishDate='{4}'," +
                                         "Price={5}, BriefIntroduction='{6}', CurrNum={7}, TotalNum={8} where ISBN = {9}",
                                         txt_BName.Text, txt_BAuthor.Text, int.Parse(txt_PID.Text), int.Parse(txt_PublishNum.Text), txt_PublishDate.Text, 
                                         float.Parse(txt_Price.Text), txt_BriefIntroduction.Text, int.Parse(txt_CurrNum.Text), int.Parse(txt_TotalNum.Text), int.Parse(ISBN));
            int i = ChangeQuery(Query);
            if(i > 0)
            {
                MessageBox.Show("恭喜你，操作成功！");
                this.re_Frm_Win_Admin.BookInfo_Load();
                this.Close();
            }
            else
            {
                MessageBox.Show("对不起，操作失败！");
            }
        }

        private void Frm_Win_AdminBook_Load(object sender, EventArgs e)
        {
            txt_ISBN.Text = ISBN;
            txt_BName.Text = BName;
            txt_BAuthor.Text = BAuthor;
            txt_PID.Text = PID;
            txt_PublishNum.Text = PublishNum;
            txt_PublishDate.Text = PublishDate;
            txt_Price.Text = Price;
            txt_BriefIntroduction.Text = BriefIntroduction;
            txt_CurrNum.Text = CurrNum;
            txt_TotalNum.Text = TotalNum;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // 弹出删除确认提示框
            DialogResult result = MessageBox.Show("确定要删除选中的图书信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)  // 如果确定删除
            {
                string query = string.Format("delete from LibraryCollection_Info where ISBN = {0}", int.Parse(ISBN));
                string query1 = string.Format("delete from Book_Info where ISBN = {0}", int.Parse(ISBN));
                int i = ChangeQuery(query);
                int j = ChangeQuery(query1);
                if (i > 0 && j > 0)
                {
                    MessageBox.Show("恭喜您，图书信息删除成功！");
                    this.re_Frm_Win_Admin.BookInfo_Load();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("对不起，图书信息删除失败！");
                }
            }
        }
    }
}
