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
    public partial class Frm_Win_Admin : Form
    {
        private Frm_Main re_Frm_Main = null;
        public string Aid = "";
        public string AName = "";
        public Frm_Win_Admin(Frm_Main re_Frm_Main)
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

        public void ReaderInfo_Load()
        {
            string query = "select * from Reader_info;";
            DataTable dt = SearchQuery(query);

            if (dt.Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["RID"].ToString());
                    myitem.SubItems.Add(dr["RCID"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["RName"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["Sex"].ToString());  // 第4列
                    myitem.SubItems.Add(dr["Phone"].ToString());  // 第5列
                    myitem.SubItems.Add(dr["RegisterDate"].ToString());  // 第6列
                    myitem.SubItems.Add(dr["ValidDate"].ToString());  // 第7列
                    myitem.SubItems.Add(dr["CurrentBookNum"].ToString());  // 第8列
                    myitem.SubItems.Add(dr["TotalBookNum"].ToString());  // 第9列
                    myitem.SubItems.Add(dr["Lost"].ToString());  // 第10列
                    myitem.SubItems.Add(dr["ViolationNum"].ToString());
                    myitem.SubItems.Add(dr["Remark"].ToString());
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Reader_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            ListView.Columns.Add("读者编号");
            ListView.Columns.Add("读者类别编号");
            ListView.Columns.Add("姓名");
            ListView.Columns.Add("性别");
            ListView.Columns.Add("电话");
            ListView.Columns.Add("注册日期");
            ListView.Columns.Add("有效期至");
            ListView.Columns.Add("现借书数");
            ListView.Columns.Add("总借书数");
            ListView.Columns.Add("是否挂失");
            ListView.Columns.Add("违规次数");
            ListView.Columns.Add("备注");

            btn_function.Text = "删除读者？";

            ReaderInfo_Load();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.re_Frm_Main.Visible = true;
            this.Close();
        }

        private void Frm_Win_Admin_Load(object sender, EventArgs e)
        {
            lbl_Welcome2.Text = AName;

            ListView.Clear();
            ListView.Columns.Add("借阅编号");
            ListView.Columns.Add("图书馆藏编号");
            ListView.Columns.Add("读者编号");
            ListView.Columns.Add("借阅时间");
            ListView.Columns.Add("应还时间");
            ListView.Columns.Add("续借次数");
            ListView.Columns.Add("管理员编号");

            btn_function.Text = "确认借书记录？";

            BorrowInfo_Load();
        }

        private void btn_function_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)  // 如果有选中项
            {
                // 读者信息管理
                if (btn_function.Text == "删除读者？")
                {
                    ListViewItem myitem = ListView.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                    string RID = myitem.SubItems[0].Text;
                    string Query = string.Format("delete from Reader_info where RID = {0}", int.Parse(RID));
                    if (ChangeQuery(Query) > 0)
                    {
                        MessageBox.Show("恭喜你，删除读者成功！");
                        ReaderInfo_Load();
                    }
                    else
                    {
                        MessageBox.Show("对不起，删除读者失败！");
                    }
                }
                else if(btn_function.Text == "确认借书记录？")
                {
                    ListViewItem myitem = ListView.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                    string BRID = myitem.SubItems[0].Text;
                    string Query = string.Format("update borrow_info set AID = {0} where BRID = {1}", int.Parse(Aid), int.Parse(BRID));
                    if(ChangeQuery(Query) > 0)
                    {
                        MessageBox.Show("恭喜你，操作成功！");
                        BorrowInfo_Load();
                    }
                    else
                    {
                        MessageBox.Show("对不起，操作失败！");
                    }
                }
                else if (btn_function.Text == "确认还书记录？")
                {
                    ListViewItem myitem = ListView.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                    string RTID = myitem.SubItems[0].Text;
                    string Query = string.Format("update return_info set AID = {0} where RTID = {1}", int.Parse(Aid), int.Parse(RTID));
                    if (ChangeQuery(Query) > 0)
                    {
                        MessageBox.Show("恭喜你，操作成功！");
                        ReturnInfo_Load();
                    }
                    else
                    {
                        MessageBox.Show("对不起，操作失败！");
                    }
                }
                else if (btn_function.Text == "确认罚款记录？")
                {
                    ListViewItem myitem = ListView.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                    string PID = myitem.SubItems[0].Text;
                    string Query = string.Format("update LatePenalty_info set Submit = {0}, AID = {1} where PID = {2}", 1, int.Parse(Aid), int.Parse(PID));
                    if (ChangeQuery(Query) > 0)
                    {
                        MessageBox.Show("恭喜你，操作成功！");
                        PenaltyInfo_Load();
                    }
                    else
                    {
                        MessageBox.Show("对不起，操作失败！");
                    }
                }
                else if (btn_function.Text == "修改图书信息？")
                {
                    ListViewItem myitem = ListView.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）

                    Frm_Win_AdminBook frm_Win_AdminBook = new Frm_Win_AdminBook(this);
                    frm_Win_AdminBook.ISBN = myitem.SubItems[0].Text;
                    frm_Win_AdminBook.BName = myitem.SubItems[1].Text;
                    frm_Win_AdminBook.BAuthor = myitem.SubItems[2].Text;
                    frm_Win_AdminBook.PID = myitem.SubItems[3].Text;
                    frm_Win_AdminBook.PublishNum = myitem.SubItems[4].Text;
                    frm_Win_AdminBook.PublishDate = myitem.SubItems[5].Text;
                    frm_Win_AdminBook.Price = myitem.SubItems[6].Text;
                    frm_Win_AdminBook.BriefIntroduction = myitem.SubItems[7].Text;
                    frm_Win_AdminBook.CurrNum = myitem.SubItems[8].Text;
                    frm_Win_AdminBook.TotalNum = myitem.SubItems[9].Text;
                    frm_Win_AdminBook.Show();

                    BookInfo_Load();
                }
            }
            else
            {
                MessageBox.Show("请选中要修改的信息所在的行！");
            }
        }

        protected void BorrowInfo_Load()
        {
            string query = "select * from Borrow_info where AID is null;";

            if (SearchQuery(query).Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in SearchQuery(query).Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["BRID"].ToString());
                    myitem.SubItems.Add(dr["BID"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["RID"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["BRTime"].ToString());  // 第4列
                    myitem.SubItems.Add(dr["RTExpectTime"].ToString());  // 第5列
                    myitem.SubItems.Add(dr["RenewalNum"].ToString());  // 第6列
                    myitem.SubItems.Add(dr["AID"].ToString());  // 第7列
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            ListView.Columns.Add("借阅编号");
            ListView.Columns.Add("图书馆藏编号");
            ListView.Columns.Add("读者编号");
            ListView.Columns.Add("借阅时间");
            ListView.Columns.Add("应还时间");
            ListView.Columns.Add("续借次数");
            ListView.Columns.Add("管理员编号");

            btn_function.Text = "确认借书记录？";

            BorrowInfo_Load();
        }

        protected void ReturnInfo_Load()
        {
            string query = "select * from Return_info where AID is null;";

            if (SearchQuery(query).Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in SearchQuery(query).Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["RTID"].ToString());
                    myitem.SubItems.Add(dr["BID"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["RID"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["RTTime"].ToString());  // 第4列
                    myitem.SubItems.Add(dr["Late"].ToString());  // 第5列
                    myitem.SubItems.Add(dr["Broken"].ToString());  // 第6列
                    myitem.SubItems.Add(dr["AID"].ToString());  // 第7列
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            ListView.Columns.Add("归还编号");
            ListView.Columns.Add("图书馆藏编号");
            ListView.Columns.Add("读者编号");
            ListView.Columns.Add("归还时间");
            ListView.Columns.Add("是否逾期");
            ListView.Columns.Add("是否丢失、损坏");
            ListView.Columns.Add("管理员编号");

            btn_function.Text = "确认还书记录？";

            ReturnInfo_Load();
        }

        protected void PenaltyInfo_Load()
        {
            string query = "select * from LatePenalty_info where AID is null;";

            if (SearchQuery(query).Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in SearchQuery(query).Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["PID"].ToString());
                    myitem.SubItems.Add(dr["BRID"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["PAmount"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["Submit"].ToString());  // 第4列
                    myitem.SubItems.Add(dr["PDate"].ToString());  // 第5列
                    myitem.SubItems.Add(dr["AID"].ToString());  // 第6列
                    myitem.SubItems.Add(dr["Remark"].ToString());  // 第7列
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Penalty_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            ListView.Columns.Add("罚款编号");
            ListView.Columns.Add("借阅编号");
            ListView.Columns.Add("罚款金额");
            ListView.Columns.Add("是否交款");
            ListView.Columns.Add("罚款日期");
            ListView.Columns.Add("管理员编号");
            ListView.Columns.Add("备注");

            btn_function.Text = "确认罚款记录？";

            PenaltyInfo_Load();
        }

        public void BookInfo_Load()
        {
            string query = "select * from Book_info;";

            if (SearchQuery(query).Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in SearchQuery(query).Rows)
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
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            ListView.Columns.Add("ISBN");
            ListView.Columns.Add("书名");
            ListView.Columns.Add("作者");
            ListView.Columns.Add("出版社编号");
            ListView.Columns.Add("版次");
            ListView.Columns.Add("出版日期");
            ListView.Columns.Add("价格");
            ListView.Columns.Add("简介");
            ListView.Columns.Add("在库数量");
            ListView.Columns.Add("库存总量");

            btn_function.Text = "修改图书信息？";

            BookInfo_Load();
        }

        /*protected void LibCollectionInfo_Load()
        {
            string query = "select * from LibraryCollection_info;";

            if (SearchQuery(query).Rows.Count > 0)
            {
                ListView.Items.Clear();
                foreach (DataRow dr in SearchQuery(query).Rows)
                {
                    // 创建一个 ListViewItem 项，并为每一列赋值
                    ListViewItem myitem = new ListViewItem(dr["BID"].ToString());
                    myitem.SubItems.Add(dr["ISBN"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["InboundTime"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["BState"].ToString());  // 第4列
                    ListView.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }*/

        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            /*ListView.Clear();
            ListView.Columns.Add("图书馆藏编号");
            ListView.Columns.Add("ISBN");
            ListView.Columns.Add("入库时间");
            ListView.Columns.Add("状态");

            btn_function.Text = "修改图书馆藏信息？";

            LibCollectionInfo_Load();*/
            ListView.Clear();
            ListView.Columns.Add("ISBN");
            ListView.Columns.Add("书名");
            ListView.Columns.Add("作者");
            ListView.Columns.Add("出版社编号");
            ListView.Columns.Add("版次");
            ListView.Columns.Add("出版日期");
            ListView.Columns.Add("价格");
            ListView.Columns.Add("简介");
            ListView.Columns.Add("在库数量");
            ListView.Columns.Add("库存总量");

            btn_function.Text = "修改图书信息？";
            btn_Book.Focus();
            BookInfo_Load();
            Frm_Win_AdminBookAdd frm_Win_AdminBookAdd = new Frm_Win_AdminBookAdd(this);
            frm_Win_AdminBookAdd.Show();
        }

        private void btn_ReaderClass_Click(object sender, EventArgs e)
        {
            Frm_Win_AdminRC frm_Win_AdminRC = new Frm_Win_AdminRC();
            frm_Win_AdminRC.Show();
        }

        private void btn_Publisher_Click(object sender, EventArgs e)
        {
            Frm_Win_AdminPublisher frm_Win_AdminPublisher = new Frm_Win_AdminPublisher();
            frm_Win_AdminPublisher.Show();
        }
    }
}
