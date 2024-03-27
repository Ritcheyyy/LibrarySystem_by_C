namespace CustomerInfoManage
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.nudown_Age = new System.Windows.Forms.NumericUpDown();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Note = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.nudown_Age);
            this.groupBox1.Controls.Add(this.rbtn_Sex2);
            this.groupBox1.Controls.Add(this.rbtn_Sex1);
            this.groupBox1.Controls.Add(this.lbl_Age);
            this.groupBox1.Controls.Add(this.lbl_Sex);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.lbl_Address);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.lbl_Telephone);
            this.groupBox1.Controls.Add(this.txt_Company);
            this.groupBox1.Controls.Add(this.lbl_Company);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑客户信息  状态：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(322, 172);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(148, 172);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // nudown_Age
            // 
            this.nudown_Age.Location = new System.Drawing.Point(374, 76);
            this.nudown_Age.Name = "nudown_Age";
            this.nudown_Age.Size = new System.Drawing.Size(175, 25);
            this.nudown_Age.TabIndex = 13;
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(166, 76);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex2.TabIndex = 12;
            this.rbtn_Sex2.TabStop = true;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Checked = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(82, 76);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex1.TabIndex = 11;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(302, 76);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(45, 15);
            this.lbl_Age.TabIndex = 10;
            this.lbl_Age.Text = "年龄:";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(6, 76);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(45, 15);
            this.lbl_Sex.TabIndex = 9;
            this.lbl_Sex.Text = "性别:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(374, 128);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(175, 25);
            this.txt_Address.TabIndex = 8;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(299, 131);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 15);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "地址:";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(82, 125);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(175, 25);
            this.txt_Telephone.TabIndex = 6;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Location = new System.Drawing.Point(7, 128);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(45, 15);
            this.lbl_Telephone.TabIndex = 5;
            this.lbl_Telephone.Text = "电话:";
            // 
            // txt_Company
            // 
            this.txt_Company.Location = new System.Drawing.Point(374, 22);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(175, 25);
            this.txt_Company.TabIndex = 4;
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(299, 25);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(52, 15);
            this.lbl_Company.TabIndex = 3;
            this.lbl_Company.Text = "单位：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(82, 22);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(175, 25);
            this.txt_Name.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(7, 25);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 15);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "姓名:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(163, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 15);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "添加";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户信息列表";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.CustomerName,
            this.Company,
            this.Sex,
            this.Age,
            this.Telephone,
            this.Address});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(7, 25);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(553, 177);
            this.lv_Customer.TabIndex = 0;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.SelectedIndexChanged += new System.EventHandler(this.lv_Customer_SelectedIndexChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "编号";
            this.CustomerID.Width = 45;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "姓名";
            this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Company
            // 
            this.Company.Text = "单位";
            this.Company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Company.Width = 120;
            // 
            // Sex
            // 
            this.Sex.Text = "性别";
            this.Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sex.Width = 45;
            // 
            // Age
            // 
            this.Age.Text = "年龄";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 45;
            // 
            // Telephone
            // 
            this.Telephone.Text = "电话";
            this.Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telephone.Width = 108;
            // 
            // Address
            // 
            this.Address.Text = "地址";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 130;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(241, 223);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 15);
            this.lbl_Note.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(126, 224);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 447);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_main";
            this.Text = "Frm_main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_Age)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown nudown_Age;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader Company;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Address;
    }
}