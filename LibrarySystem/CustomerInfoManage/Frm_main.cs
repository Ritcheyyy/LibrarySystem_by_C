using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CustomerInfoManage
{
    public partial class Frm_main : Form
    {
        string customerid = ""; //定义全局变量，用于存储客户编号

        public Frm_main()
        {
            InitializeComponent();
            Load_CustomerInfo();
        }

        protected DataTable SearchQuery(string query)
        {
            //1 客户端发出请求query

            //2 创建并打开数据库连接
            string str = "server=localhost;database=DB_CASE0705;uid=root;pwd=123456;port=3306";
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
            string str = "server=localhost;database=DB_CASE0705;uid=root;pwd=123456;port=3306";
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
            txt_Name.Text = "";
            txt_Company.Text = "";
            rbtn_Sex1.Checked = true;
            rbtn_Sex2.Checked = false;
            nudown_Age.Value = 0;
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            
            lbl_Status.Text = "添加";
            lbl_Note.Text = "";
        }

        protected void Load_CustomerInfo()
        {
            string query = "select * from Customer_info;";
            DataTable dt = SearchQuery(query);

            if (dt.Rows.Count > 0)
            {
                lv_Customer.Items.Clear();
                foreach(DataRow dr in dt.Rows)
                {
                    // 创建一个 ListViewItem 项，并为第1列赋值，客户编号
                    ListViewItem myitem = new ListViewItem(dr["CustomerID"].ToString());
                    myitem.SubItems.Add(dr["CustomerName"].ToString());  // 第2列，姓名
                    myitem.SubItems.Add(dr["Company"].ToString());  // 第3列，单位
                    myitem.SubItems.Add(dr["Sex"].ToString());  // 第4列，性别
                    myitem.SubItems.Add(dr["Age"].ToString());  // 第5列，年龄
                    myitem.SubItems.Add(dr["Telephone"].ToString());  // 第6列，电话
                    myitem.SubItems.Add(dr["Address"].ToString());  // 第7列，地址
                    lv_Customer.Items.Add(myitem);  // 将新建项添加到ListView控件中
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();  // 姓名
            string company = txt_Company.Text.Trim();  // 单位
            string sex = rbtn_Sex1.Checked == true ? "男" : "女";  // 性别
            string age = nudown_Age.Value.ToString();  // 年龄
            string telephone = txt_Telephone.Text.Trim();  // 电话
            string address = txt_Address.Text.Trim();  // 地址

            if (name == "")  // 姓名为空
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (lbl_Status.Text == "添加")  // 如果是“添加”状态
            {
                string query = string.Format("insert into Customer_Info values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", name, company, sex, age, telephone, address);
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
                Load_CustomerInfo();
                InfoClear();
            }
            else
            {
                string query = string.Format("update Customer_Info set CustomerName = '{0}', Company = '{1}', Sex = '{2}', Age ={3}, Telephone = '{4}', Address = '{5}'" +
                                                " where CustomerID = {6}", name, company, sex, age, telephone, address, customerid);
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    Load_CustomerInfo();  // 重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            InfoClear();
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)  // 如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];  // 获取选中的第一行（一次只能选一行）
                customerid = myitem.SubItems[0].Text;  // 将选中行第1列的值赋值全局变量，客户编号
                txt_Name.Text = myitem.SubItems[1].Text;  // 第2列，姓名
                txt_Company.Text = myitem.SubItems[2].Text;  // 单位
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "男" ? true : false;  // 性别
                rbtn_Sex2.Checked = myitem.SubItems[3].Text == "女" ? true : false;  // 性别
                nudown_Age.Value = decimal.Parse(myitem.SubItems[4].Text);  // 年龄
                txt_Telephone.Text = myitem.SubItems[5].Text;  // 电话
                txt_Address.Text = myitem.SubItems[6].Text;  // 地址
                lbl_Status.Text = "修改";  // 当前状态
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (customerid == "")  // 如果没有选中要删除的客户信息
            {
                lbl_Note.Text = "请先选择要删除的客户信息";
                lbl_Note.ForeColor = Color.Red;
            }
            else
            {
                // 弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的客户信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)  // 如果确定删除
                {
                    string query = string.Format("delete from Customer_Info where CustomerID = {0}", customerid);
                    int i = ChangeQuery(query);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，客户信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        InfoClear();  // 调用函数，清空各控件
                        Load_CustomerInfo();  // 重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，客户信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
