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
    public partial class Frm_Win_AdminRC : Form
    {
        public string RCid = "";

        public Frm_Win_AdminRC()
        {
            InitializeComponent();
            ReaderClassInfo_Load();
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

        protected void InfoClear()
        {
            txt_RCID.Text = "";
            txt_RCName.Text = "";
            nudown_RCNum.Value = 1;
            nudown_RCDay.Value = 15;

            txt_RCID.Text = "会自动分配编号";
            btn_Delete.Enabled = false;
            lbl_State.Text = "添加";
            lbl_tip.Text = "";
        }

        protected void ReaderClassInfo_Load()
        {
            InfoClear();
            string query = "select * from ReaderClass_info;";
            DataTable dt = SearchQuery(query);

            if (dt.Rows.Count > 0)
            {
                lv_ReaderClass.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // 创建一个 ListViewItem 项，并为第1列赋值
                    ListViewItem myitem = new ListViewItem(dr["RCID"].ToString());
                    myitem.SubItems.Add(dr["RCName"].ToString());  // 第2列
                    myitem.SubItems.Add(dr["RCNum"].ToString());  // 第3列
                    myitem.SubItems.Add(dr["RCDay"].ToString());  // 第4列
                    lv_ReaderClass.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string RCID = txt_RCID.Text.Trim();
            string RCName = txt_RCName.Text.Trim();
            string RCNum = nudown_RCNum.Value.ToString();
            string RCDay = nudown_RCDay.Value.ToString();

            if (RCID == "")  // 类别编号为空
            {
                lbl_tip.Text = "类别编号不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_RCID.Focus();
            }
            else if (RCName == "")  // 类别名称为空
            {
                lbl_tip.Text = "类别名称不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_RCName.Focus();
            }
            else if (lbl_State.Text == "添加")  // 如果是“添加”状态
            {
                string query = string.Format("insert into ReaderClass_Info values(null, '{0}', {1}, {2});", 
                                                            RCName, int.Parse(RCNum), int.Parse(RCDay));
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_tip.Text = "恭喜您，读者类别信息添加成功！";
                    lbl_tip.ForeColor = Color.Blue;
                }
                else
                {
                    lbl_tip.Text = "对不起，读者类别信息添加失败！";
                    lbl_tip.ForeColor = Color.Red;
                }
                ReaderClassInfo_Load();
                InfoClear();
            }
            else
            {
                string query = string.Format("update ReaderClass_Info set RCName = '{0}', RCNum = {1}, RCDay = {2} where RCID = {3}",
                                                                  RCName, int.Parse(RCNum), int.Parse(RCDay), RCid);
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_tip.Text = "恭喜您，读者类别信息修改成功！";
                    lbl_tip.ForeColor = Color.Blue;
                    ReaderClassInfo_Load();  // 重新加载信息
                }
                else
                {
                    lbl_tip.Text = "对不起，读者类别信息修改失败！";
                    lbl_tip.ForeColor = Color.Red;
                }
            }
        }

        private void lv_ReaderClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ReaderClass.SelectedItems.Count > 0)  // 如果有选中项
            {
                btn_Delete.Enabled = true;
                ListViewItem myitem = lv_ReaderClass.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                txt_RCID.Text = myitem.SubItems[0].Text;
                RCid = myitem.SubItems[0].Text;
                txt_RCName.Text = myitem.SubItems[1].Text;
                nudown_RCNum.Value = decimal.Parse(myitem.SubItems[2].Text);
                nudown_RCDay.Value = decimal.Parse(myitem.SubItems[3].Text);
                lbl_State.Text = "修改";  // 当前状态
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            InfoClear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (RCid == "")
            {
                lbl_tip.Text = "请先选择要删除的读者类别信息";
                lbl_tip.ForeColor = Color.Red;
            }
            else
            {
                // 弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的读者类别信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)  // 如果确定删除
                {
                    string query = string.Format("delete from ReaderClass_Info where RCID = {0}", RCid);
                    int i = ChangeQuery(query);
                    if (i > 0)
                    {
                        lbl_tip.Text = "恭喜您，读者类别信息删除成功！";
                        lbl_tip.ForeColor = Color.Blue;
                        InfoClear();  // 调用函数，清空各控件
                        ReaderClassInfo_Load();  // 重新加载信息
                    }
                    else
                    {
                        lbl_tip.Text = "对不起，读者类别信息删除失败！";
                        lbl_tip.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
