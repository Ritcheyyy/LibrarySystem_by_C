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
    public partial class Frm_Win_AdminPublisher : Form
    {
        public string Pid = "1";

        public Frm_Win_AdminPublisher()
        {
            InitializeComponent();
            PublisherInfo_Load();
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
            txt_PID.Text = "";
            txt_PName.Text = "";
            txt_Contact.Text = "";
            txt_Phone.Text = "";
            txt_PFax.Text = "";
            txt_Province.Text = "";
            txt_City.Text = "";
            txt_Street.Text = "";
            txt_DetailAddr.Text = "";

            txt_PID.Text = "会自动分配编号";
            btn_Delete.Enabled = false;
            lbl_State.Text = "添加";
            lbl_tip.Text = "";
        }

        protected void PublisherInfo_Load()
        {
            InfoClear();
            string query = "select * from Publisher_info;";
            DataTable dt = SearchQuery(query);

            cbb_Publisher.DataSource = dt;
            cbb_Publisher.DisplayMember = "PName";
            cbb_Publisher.ValueMember = "PID";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string PID = txt_PID.Text.Trim();
            string PName = txt_PName.Text.Trim();
            string Contact = txt_Contact.Text.Trim();
            string Phone = txt_Phone.Text.Trim();
            string PFax = txt_PFax.Text.Trim();
            string Province = txt_Province.Text.Trim();
            string City = txt_City.Text.Trim();
            string Street = txt_Street.Text.Trim();
            string DetailAddr = txt_DetailAddr.Text.Trim();

            if (PID == "")  // 类别编号为空
            {
                lbl_tip.Text = "类别编号不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_PID.Focus();
            }
            else if (PName == "")  // 类别名称为空
            {
                lbl_tip.Text = "类别名称不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_PName.Focus();
            }
            else if (Contact == "")
            {
                lbl_tip.Text = "联系人不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_Contact.Focus();
            }
            else if (Phone == "")
            {
                lbl_tip.Text = "联系人电话不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_Phone.Focus();
            }
            else if (PFax == "")
            {
                lbl_tip.Text = "传真不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_PFax.Focus();
            }
            else if (Province == "")
            {
                lbl_tip.Text = "省份不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_Province.Focus();
            }
            else if (City == "")
            {
                lbl_tip.Text = "城市不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_City.Focus();
            }
            else if (Street == "")
            {
                lbl_tip.Text = "街道不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_Street.Focus();
            }
            else if (DetailAddr == "")
            {
                lbl_tip.Text = "详细地址不能为空！";
                lbl_tip.ForeColor = Color.Red;
                txt_DetailAddr.Focus();
            }
            else if (lbl_State.Text == "添加")  // 如果是“添加”状态
            {
                string query = string.Format("insert into Publisher_Info values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                                            PName, Contact, Phone, PFax, Province, City, Street, DetailAddr);
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_tip.Text = "恭喜您，出版社信息添加成功！";
                    lbl_tip.ForeColor = Color.Blue;
                }
                else
                {
                    lbl_tip.Text = "对不起，出版社信息添加失败！";
                    lbl_tip.ForeColor = Color.Red;
                }
                PublisherInfo_Load();
                InfoClear();
            }
            else
            {
                string query = string.Format("update Publisher_Info set PName='{0}', Contact='{1}', Phone='{2}', PFax='{3}', Province='{4}'" +
                                             ", City='{5}', Street='{6}', DetailAddress='{7}' where PID = {8}",
                                             PName, Contact, Phone, PFax, Province, City, Street, DetailAddr, Pid);
                int i = ChangeQuery(query);
                if (i > 0)
                {
                    lbl_tip.Text = "恭喜您，出版社信息修改成功！";
                    lbl_tip.ForeColor = Color.Blue;
                    PublisherInfo_Load();  // 重新加载信息
                }
                else
                {
                    lbl_tip.Text = "对不起，出版社信息修改失败！";
                    lbl_tip.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            InfoClear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Pid == "")
            {
                lbl_tip.Text = "请先选择要删除的出版社信息";
                lbl_tip.ForeColor = Color.Red;
            }
            else
            {
                // 弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的出版社信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)  // 如果确定删除
                {
                    string query = string.Format("delete from Publisher_Info where PID = {0}", Pid);
                    int i = ChangeQuery(query);
                    if (i > 0)
                    {
                        lbl_tip.Text = "恭喜您，出版社信息删除成功！";
                        lbl_tip.ForeColor = Color.Blue;
                        InfoClear();  // 调用函数，清空各控件
                        PublisherInfo_Load();  // 重新加载信息
                    }
                    else
                    {
                        lbl_tip.Text = "对不起，出版社信息删除失败！";
                        lbl_tip.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            txt_PID.Text = cbb_Publisher.SelectedValue.ToString();
            Pid = txt_PID.Text;
            txt_PName.Text = cbb_Publisher.Text;
            string Query = string.Format("select * from Publisher_info where PID = {0}", int.Parse(Pid));
            DataTable dt = SearchQuery(Query);
            txt_Contact.Text = dt.Rows[0][2].ToString();
            txt_Phone.Text = dt.Rows[0][3].ToString();
            txt_PFax.Text = dt.Rows[0][4].ToString();
            txt_Province.Text = dt.Rows[0][5].ToString();
            txt_City.Text = dt.Rows[0][6].ToString();
            txt_Street.Text = dt.Rows[0][7].ToString();
            txt_DetailAddr.Text = dt.Rows[0][8].ToString();
            lbl_State.Text = "修改";  // 当前状态
        }
    }
}
