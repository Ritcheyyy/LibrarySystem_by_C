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
    public partial class Frm_Win_AdminBookAdd : Form
    {
        private Frm_Win_Admin re_Frm_Win_Admin = null;

        public Frm_Win_AdminBookAdd(Frm_Win_Admin re_Frm_Win_Admin)
        {
            InitializeComponent();
            this.re_Frm_Win_Admin = re_Frm_Win_Admin;
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

            //4 执行查询，并返回受影响行数
            int i = cmd.ExecuteNonQuery();

            //5 关闭连接
            conn.Close();

            return i;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ISBN = txt_ISBN.Text;
            string BName = txt_BName.Text;
            string BAuthor = txt_BAuthor.Text;
            string PID = txt_PID.Text;
            string PublishNum = txt_PublishNum.Text;
            string PublishDate = txt_PublishDate.Text;
            string Price = txt_Price.Text;
            string BriefIntroduction = txt_BriefIntroduction.Text;
            string CurrNum = txt_CurrNum.Text;
            string TotalNum = txt_TotalNum.Text;
            
            string Query = string.Format("insert into book_info values({0},'{1}','{2}',{3},{4},'{5}',{6},'{7}',{8},{9})",
                                         int.Parse(ISBN), BName, BAuthor, int.Parse(PID), int.Parse(PublishNum), PublishDate,
                                         float.Parse(Price), BriefIntroduction, int.Parse(CurrNum), int.Parse(TotalNum));
            int i = ChangeQuery(Query);

            // 更新馆藏信息
            int j = int.Parse(TotalNum);
            DateTime currTime = DateTime.Now;
            string Query1;
            string BID;
            Boolean isAdded = true;
            for(int k = 1; k <= j; k++)
            {
                BID = string.Format("{0}-{1}", int.Parse(ISBN), k);
                Query1 = string.Format("insert into LibraryCollection_info values('{0}',{1},'{2}',{3})", BID, int.Parse(ISBN), currTime, 1);
                if(ChangeQuery(Query1) <= 0)
                {
                    isAdded = false;
                }
            }
            if (i > 0 && isAdded)
            {
                MessageBox.Show("恭喜你，图书添加成功！");
                this.re_Frm_Win_Admin.BookInfo_Load();
                this.Close();
            }
            else
            {
                MessageBox.Show("对不起，图书添加失败！");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
