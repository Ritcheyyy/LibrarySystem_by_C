namespace LibrarySystem
{
    partial class Frm_Win_AdminPublisher
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
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.lbl_PName = new System.Windows.Forms.Label();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lbl_PID = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.cbb_Publisher = new System.Windows.Forms.ComboBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.txt_PFax = new System.Windows.Forms.TextBox();
            this.lbl_PFax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_DetailAddr = new System.Windows.Forms.TextBox();
            this.lbl_DetailAddr = new System.Windows.Forms.Label();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Province = new System.Windows.Forms.TextBox();
            this.lbl_Province = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_GetInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_PFax);
            this.groupBox1.Controls.Add(this.lbl_PFax);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.lbl_Phone);
            this.groupBox1.Controls.Add(this.txt_Contact);
            this.groupBox1.Controls.Add(this.lbl_Contact);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_PName);
            this.groupBox1.Controls.Add(this.lbl_PName);
            this.groupBox1.Controls.Add(this.txt_PID);
            this.groupBox1.Controls.Add(this.lbl_PID);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑出版社信息  状态：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(396, 230);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(315, 230);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_PName
            // 
            this.txt_PName.Location = new System.Drawing.Point(105, 86);
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(150, 25);
            this.txt_PName.TabIndex = 6;
            // 
            // lbl_PName
            // 
            this.lbl_PName.AutoSize = true;
            this.lbl_PName.Location = new System.Drawing.Point(6, 91);
            this.lbl_PName.Name = "lbl_PName";
            this.lbl_PName.Size = new System.Drawing.Size(97, 15);
            this.lbl_PName.TabIndex = 5;
            this.lbl_PName.Text = "出版社名称：";
            // 
            // txt_PID
            // 
            this.txt_PID.Location = new System.Drawing.Point(105, 37);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.ReadOnly = true;
            this.txt_PID.Size = new System.Drawing.Size(150, 25);
            this.txt_PID.TabIndex = 4;
            // 
            // lbl_PID
            // 
            this.lbl_PID.AutoSize = true;
            this.lbl_PID.Location = new System.Drawing.Point(6, 42);
            this.lbl_PID.Name = "lbl_PID";
            this.lbl_PID.Size = new System.Drawing.Size(97, 15);
            this.lbl_PID.TabIndex = 3;
            this.lbl_PID.Text = "出版社编号：";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(477, 230);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(183, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 15);
            this.lbl_State.TabIndex = 0;
            this.lbl_State.Text = "添加";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(7, 27);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(127, 15);
            this.lbl_Publisher.TabIndex = 2;
            this.lbl_Publisher.Text = "当前选择出版社：";
            // 
            // cbb_Publisher
            // 
            this.cbb_Publisher.FormattingEnabled = true;
            this.cbb_Publisher.Location = new System.Drawing.Point(147, 23);
            this.cbb_Publisher.Name = "cbb_Publisher";
            this.cbb_Publisher.Size = new System.Drawing.Size(248, 23);
            this.cbb_Publisher.TabIndex = 3;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(104, 184);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(150, 25);
            this.txt_Phone.TabIndex = 16;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(6, 189);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(97, 15);
            this.lbl_Phone.TabIndex = 15;
            this.lbl_Phone.Text = "联系人电话：";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(104, 135);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(150, 25);
            this.txt_Contact.TabIndex = 14;
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Location = new System.Drawing.Point(21, 140);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(67, 15);
            this.lbl_Contact.TabIndex = 13;
            this.lbl_Contact.Text = "联系人：";
            // 
            // txt_PFax
            // 
            this.txt_PFax.Location = new System.Drawing.Point(104, 233);
            this.txt_PFax.Name = "txt_PFax";
            this.txt_PFax.Size = new System.Drawing.Size(150, 25);
            this.txt_PFax.TabIndex = 18;
            // 
            // lbl_PFax
            // 
            this.lbl_PFax.AutoSize = true;
            this.lbl_PFax.Location = new System.Drawing.Point(28, 238);
            this.lbl_PFax.Name = "lbl_PFax";
            this.lbl_PFax.Size = new System.Drawing.Size(52, 15);
            this.lbl_PFax.TabIndex = 17;
            this.lbl_PFax.Text = "传真：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_DetailAddr);
            this.groupBox2.Controls.Add(this.lbl_DetailAddr);
            this.groupBox2.Controls.Add(this.txt_Street);
            this.groupBox2.Controls.Add(this.lbl_Street);
            this.groupBox2.Controls.Add(this.txt_City);
            this.groupBox2.Controls.Add(this.lbl_City);
            this.groupBox2.Controls.Add(this.txt_Province);
            this.groupBox2.Controls.Add(this.lbl_Province);
            this.groupBox2.Location = new System.Drawing.Point(272, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 212);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出版社地址";
            // 
            // txt_DetailAddr
            // 
            this.txt_DetailAddr.Location = new System.Drawing.Point(114, 172);
            this.txt_DetailAddr.Name = "txt_DetailAddr";
            this.txt_DetailAddr.Size = new System.Drawing.Size(150, 25);
            this.txt_DetailAddr.TabIndex = 34;
            // 
            // lbl_DetailAddr
            // 
            this.lbl_DetailAddr.AutoSize = true;
            this.lbl_DetailAddr.Location = new System.Drawing.Point(16, 177);
            this.lbl_DetailAddr.Name = "lbl_DetailAddr";
            this.lbl_DetailAddr.Size = new System.Drawing.Size(82, 15);
            this.lbl_DetailAddr.TabIndex = 33;
            this.lbl_DetailAddr.Text = "详细地址：";
            // 
            // txt_Street
            // 
            this.txt_Street.Location = new System.Drawing.Point(114, 123);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(150, 25);
            this.txt_Street.TabIndex = 32;
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Location = new System.Drawing.Point(31, 128);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(52, 15);
            this.lbl_Street.TabIndex = 31;
            this.lbl_Street.Text = "街道：";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(115, 74);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(150, 25);
            this.txt_City.TabIndex = 30;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(31, 79);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(52, 15);
            this.lbl_City.TabIndex = 29;
            this.lbl_City.Text = "城市：";
            // 
            // txt_Province
            // 
            this.txt_Province.Location = new System.Drawing.Point(115, 25);
            this.txt_Province.Name = "txt_Province";
            this.txt_Province.Size = new System.Drawing.Size(150, 25);
            this.txt_Province.TabIndex = 28;
            // 
            // lbl_Province
            // 
            this.lbl_Province.AutoSize = true;
            this.lbl_Province.Location = new System.Drawing.Point(31, 30);
            this.lbl_Province.Name = "lbl_Province";
            this.lbl_Province.Size = new System.Drawing.Size(52, 15);
            this.lbl_Province.TabIndex = 27;
            this.lbl_Province.Text = "省份：";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(291, 69);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(0, 15);
            this.lbl_tip.TabIndex = 4;
            // 
            // btn_GetInfo
            // 
            this.btn_GetInfo.Location = new System.Drawing.Point(408, 19);
            this.btn_GetInfo.Name = "btn_GetInfo";
            this.btn_GetInfo.Size = new System.Drawing.Size(156, 30);
            this.btn_GetInfo.TabIndex = 5;
            this.btn_GetInfo.Text = "获取出版社信息";
            this.btn_GetInfo.UseVisualStyleBackColor = true;
            this.btn_GetInfo.Click += new System.EventHandler(this.btn_GetInfo_Click);
            // 
            // Frm_Win_AdminPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btn_GetInfo);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.cbb_Publisher);
            this.Controls.Add(this.lbl_Publisher);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Win_AdminPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_AdminPublisher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_PName;
        private System.Windows.Forms.Label lbl_PName;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lbl_PID;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_Publisher;
        private System.Windows.Forms.ComboBox cbb_Publisher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_PFax;
        private System.Windows.Forms.Label lbl_PFax;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txt_DetailAddr;
        private System.Windows.Forms.Label lbl_DetailAddr;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Province;
        private System.Windows.Forms.Label lbl_Province;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_GetInfo;
    }
}