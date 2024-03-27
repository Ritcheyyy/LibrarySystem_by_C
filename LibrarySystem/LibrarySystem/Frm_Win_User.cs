using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Frm_Win_User : Form
    {
        // 全局变量定义
        public string Uid = "";
        public string Uname = "";
        public string Ukind = "";
        private Frm_Main re_Frm_Main = null;

        public Frm_Win_User(Frm_Main re_Frm_Main)
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

        protected void BookInfo_Load()
        {
            btn_function.Text = "立即借阅？";
            cb_isBroken.Visible = false;

            string query = "select * from Book_info;";
            DataTable dt = SearchQuery(query);

            if (dt.Rows.Count > 0)
            {
                lv_Borrow.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["ISBN"].ToString());
                    myitem.SubItems.Add(dr["BName"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["BAuthor"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["PID"].ToString());  // 第4列
                    myitem.SubItems.Add(dr["PublishNum"].ToString());  // 第5列
                    myitem.SubItems.Add(dr["PublishDate"].ToString());  // 第6列
                    myitem.SubItems.Add(dr["Price"].ToString());  // 第7列
                    myitem.SubItems.Add(dr["BriefIntroduction"].ToString());  // 第8列
                    myitem.SubItems.Add(dr["CurrNum"].ToString());  // 第9列
                    myitem.SubItems.Add(dr["TotalNum"].ToString());  // 第10列
                    lv_Borrow.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        protected void ReturnBook_Load()
        {
            lv_Borrow.Items.Clear();
            btn_function.Text = "立即归还？";
            cb_isBroken.Visible = true;

            string query = string.Format("select BID from Borrow_info where RID = {0};", int.Parse(Uid));
            DataTable dt1 = SearchQuery(query);
            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    string BID = dr[0].ToString();
                    // 判断是否归还
                    string CheckQuery = string.Format("select * from Return_info where RID = {0} AND BID = '{1}';", int.Parse(Uid), BID);
                    if(SearchQuery(CheckQuery).Rows.Count > 0)
                    {
                        continue;
                    }
                    string query1 = string.Format("select ISBN from LibraryCollection_Info where BID = '{0}';", BID);
                    int ISBN = int.Parse(SearchQuery(query1).Rows[0][0].ToString());
                    string query2 = string.Format("select * from Book_Info where ISBN = {0};", ISBN);
                    DataTable dt2 = SearchQuery(query2);
                    DataRow dataRow = dt2.Rows[0];
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dataRow["ISBN"].ToString());
                    myitem.SubItems.Add(dataRow["BName"].ToString());  // 第2列
                    myitem.SubItems.Add(dataRow["BAuthor"].ToString());  // 第3列
                    myitem.SubItems.Add(dataRow["PID"].ToString());  // 第4列
                    myitem.SubItems.Add(dataRow["PublishNum"].ToString());  // 第5列
                    myitem.SubItems.Add(dataRow["PublishDate"].ToString());  // 第6列
                    myitem.SubItems.Add(dataRow["Price"].ToString());  // 第7列
                    myitem.SubItems.Add(dataRow["BriefIntroduction"].ToString());  // 第8列
                    myitem.SubItems.Add(dataRow["CurrNum"].ToString());  // 第9列
                    myitem.SubItems.Add(dataRow["TotalNum"].ToString());  // 第10列
                    myitem.SubItems.Add(dr["BID"].ToString());
                    lv_Borrow.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void Frm_Win_User_Load(object sender, EventArgs e)
        {
            lbl_Welcome2.Text = Uname;
            lbl_Welcome3.Text = Ukind == "1" ? "同学" : "老师";
            BookInfo_Load();
            string CheckQuery = string.Format("select B.RID from LatePenalty_Info L join Borrow_Info B on L.BRID = B.BRID and B.RID = {0}", Uid);
            if(SearchQuery(CheckQuery).Rows.Count > 0)
            {
                MessageBox.Show("你还有未处理的罚款记录，请寻找管理员处理！");
            }
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            BookInfo_Load();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ReturnBook_Load();
        }

        private void btn_function_Click(object sender, EventArgs e)
        {
            if (lv_Borrow.SelectedItems.Count > 0)  // 如果有选中项
            {
                ListViewItem myitem = lv_Borrow.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                string ISBN = myitem.SubItems[0].Text;
                string BName = myitem.SubItems[1].Text;

                // 借阅业务的处理
                if (btn_function.Text == "立即借阅？")
                {
                    string str = string.Format("确定要借阅《{0}》？", BName);
                    DialogResult result = MessageBox.Show(str, "借阅提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)  // 如果确定借阅
                    {
                        MySqlConnection conn = new MySqlConnection("server=localhost;database=library_db;uid=root;pwd=123456;port=3306");
                        conn.Open();
                        MySqlTransaction transaction = conn.BeginTransaction();
                        try
                        {
                            // 检查书籍是否可借
                            string checkQuery = string.Format("SELECT * FROM Book_Info WHERE ISBN = {0} AND CurrNum > 0", int.Parse(ISBN));
                            if (SearchQuery(checkQuery).Rows.Count > 0)
                            {
                                string checkQuery2 = string.Format("SELECT BID FROM LibraryCollection_Info WHERE ISBN = {0} AND BState = 1", int.Parse(ISBN));
                                string BID = SearchQuery(checkQuery2).Rows[0][0].ToString();
                                // 更新馆藏状态为借出
                                string updateQuery = string.Format("UPDATE LibraryCollection_Info SET BState = 2 WHERE BID = '{0}'", BID);
                                MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn, transaction);
                                updateCommand.ExecuteNonQuery();
                                // 更新读者借书数量
                                string updateQuery1 = string.Format("UPDATE Reader_Info SET CurrentBookNum = CurrentBookNum + 1 WHERE RID = {0}", int.Parse(Uid));
                                MySqlCommand updateCommand1 = new MySqlCommand(updateQuery1, conn, transaction);
                                updateCommand1.ExecuteNonQuery();  // 当前借书数
                                string updateQuery2 = string.Format("UPDATE Reader_Info SET TotalBookNum = TotalBookNum + 1 WHERE RID = {0}", int.Parse(Uid));
                                MySqlCommand updateCommand2 = new MySqlCommand(updateQuery2, conn, transaction);
                                updateCommand2.ExecuteNonQuery();  // 累计借书数
                                                                   // 更新在馆数量
                                string updateQuery3 = string.Format("UPDATE Book_Info SET CurrNum = CurrNum - 1 WHERE ISBN = {0}", int.Parse(ISBN));
                                MySqlCommand updateCommand3 = new MySqlCommand(updateQuery3, conn, transaction);
                                updateCommand3.ExecuteNonQuery();
                                // 添加借书记录
                                string Query = string.Format("SELECT RCDay, RCNum FROM ReaderClass_Info WHERE RCID = {0}", int.Parse(Ukind));
                                int RCDay = int.Parse(SearchQuery(Query).Rows[0][0].ToString());
                                int RCNum = int.Parse(SearchQuery(Query).Rows[0][1].ToString());

                                string Query1 = string.Format("SELECT CurrentBookNum FROM Reader_Info WHERE RID = {0}", int.Parse(Uid));
                                int CurrentBookNum = int.Parse(SearchQuery(Query1).Rows[0][0].ToString());
                                if (RCNum < CurrentBookNum)  // 判断是否达到借阅上限
                                {
                                    string error = string.Format("你已经借阅了{0}本书，无法继续借阅！\n 请尝试归还书籍以继续借阅！", RCNum);
                                    throw new Exception(error);
                                }
                                DateTime currentTime = DateTime.Now;
                                DateTime exceptTime = currentTime.AddDays(RCDay);
                                string updateQuery4 = string.Format("insert into borrow_info(`BID`, `RID`, `BRTime`, `RTExpectTime`, `RenewalNum`) values('{0}',{1},'{2}','{3}',0)",
                                                                                                            BID, int.Parse(Uid), currentTime, exceptTime);
                                MySqlCommand updateCommand4 = new MySqlCommand(updateQuery4, conn, transaction);
                                updateCommand4.ExecuteNonQuery();

                                MessageBox.Show("恭喜你，借阅成功！");
                            }
                            else
                            {
                                MessageBox.Show("该书籍不存在或已被借出！");
                            }
                            // 提交事务
                            transaction.Commit();
                            BookInfo_Load();
                        }
                        catch (Exception ex)
                        {
                            // 发生异常，回滚事务
                            transaction.Rollback();
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
                // 归还业务的处理
                else
                {
                    string BID_RT = myitem.SubItems[10].Text;

                    string str = string.Format("确定要归还《{0}》？", BName);
                    DialogResult result = MessageBox.Show(str, "归还提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)  // 如果确定归还
                    {
                        MySqlConnection conn = new MySqlConnection("server=localhost;database=library_db;uid=root;pwd=123456;port=3306");
                        conn.Open();
                        MySqlTransaction transaction = conn.BeginTransaction();
                        try
                        {
                            // 更新馆藏状态为在库
                            string updateQuery = string.Format("UPDATE LibraryCollection_Info SET BState = 1 WHERE BID = '{0}'", BID_RT);
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn, transaction);
                            updateCommand.ExecuteNonQuery();
                            // 更新读者借书数量
                            string updateQuery1 = string.Format("UPDATE Reader_Info SET CurrentBookNum = CurrentBookNum - 1 WHERE RID = {0}", int.Parse(Uid));
                            MySqlCommand updateCommand1 = new MySqlCommand(updateQuery1, conn, transaction);
                            updateCommand1.ExecuteNonQuery();
                            
                            string Query = string.Format("SELECT BRID, RTExpectTime FROM Borrow_Info WHERE BID = '{0}'", BID_RT);
                            int BRID = int.Parse(SearchQuery(Query).Rows[0][0].ToString());
                            string RTExpectTime = SearchQuery(Query).Rows[0][1].ToString();
                            DateTime currentTime = DateTime.Now;
                            int comparison = string.Compare(RTExpectTime, currentTime.ToString());
                            // 是否超期
                            int isLate = comparison < 0 ? 1 : 0;
                            // 是否损坏或丢失
                            int isBroken = cb_isBroken.Checked == true ? 1 : 0;
                            if(isBroken == 0)
                            {
                                // 更新在馆数量
                                string updateQuery3 = string.Format("UPDATE Book_Info SET CurrNum = CurrNum + 1 WHERE ISBN = {0}", int.Parse(ISBN));
                                MySqlCommand updateCommand3 = new MySqlCommand(updateQuery3, conn, transaction);
                                updateCommand3.ExecuteNonQuery();
                            }
                            if(isBroken == 1)  // 若损坏或丢失
                            {
                                string BQuery1 = string.Format("SELECT price FROM Book_Info WHERE ISBN = {0}", int.Parse(ISBN));
                                float PAmount = float.Parse(SearchQuery(BQuery1).Rows[0][0].ToString());
                                // 更新读者惩罚次数
                                string BQuery2 = string.Format("UPDATE Reader_Info SET ViolationNum = ViolationNum + 1 WHERE RID = {0}", int.Parse(Uid));
                                MySqlCommand Bcmd1 = new MySqlCommand(BQuery2, conn, transaction);
                                Bcmd1.ExecuteNonQuery();
                                // 添加惩罚记录
                                string BQuery3 = string.Format("insert into LatePenalty_Info values(null, {0}, {1}, 0, '{2}', null, null)",
                                                                                                            BRID, PAmount, currentTime);
                                MySqlCommand Bcmd2 = new MySqlCommand(BQuery3, conn, transaction);
                                Bcmd2.ExecuteNonQuery();
                            }
                            else if (isLate == 1)  // 若超期归还
                            {
                                // 超时的小时数
                                TimeSpan duration = currentTime - DateTime.Parse(RTExpectTime);
                                int hours = duration.Hours;
                                float PAmount = (float)(0.05 * hours);
                                // 更新读者惩罚次数
                                string LQuery1 = string.Format("UPDATE Reader_Info SET ViolationNum = ViolationNum + 1 WHERE RID = {0}", int.Parse(Uid));
                                MySqlCommand Lcmd1 = new MySqlCommand(LQuery1, conn, transaction);
                                Lcmd1.ExecuteNonQuery();
                                // 添加惩罚记录
                                string LQuery2 = string.Format("insert into LatePenalty_Info(`BRID`, `PAmount`, `Submit`, `PDate`) values({0}, {1}, 0, '{2}')",
                                                                                                            BRID, PAmount, currentTime);
                                MySqlCommand Lcmd2 = new MySqlCommand(LQuery2, conn, transaction);
                                Lcmd2.ExecuteNonQuery();
                            }
                            // 添加归还记录
                            string updateQuery4 = string.Format("insert into return_info(`BID`, `RID`, `RTTime`, `Late`, `Broken`) values('{0}', {1}, '{2}', {3}, {4})",
                                                                                                        BID_RT, int.Parse(Uid), currentTime, isLate, isBroken);
                            MySqlCommand updateCommand4 = new MySqlCommand(updateQuery4, conn, transaction);
                            updateCommand4.ExecuteNonQuery();
                            // 提交事务
                            transaction.Commit();
                            ReturnBook_Load();
                            MessageBox.Show("恭喜你，归还成功！");
                        }
                        catch (Exception ex)
                        {
                            // 发生异常，回滚事务
                            transaction.Rollback();
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
            }
            else if (btn_function.Text == "立即借阅？")
            {
                MessageBox.Show("请选中你要借阅的图书！");
            }
            else
            {
                MessageBox.Show("请选中你要归还的图书！");
            }
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            Frm_Win_UserInfo frm_win_userinfo = new Frm_Win_UserInfo(this);
            frm_win_userinfo.Uid = Uid;
            frm_win_userinfo.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.re_Frm_Main.Visible = true;
            this.Close();
        }
    }
}
