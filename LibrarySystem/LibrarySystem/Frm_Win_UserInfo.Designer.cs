namespace LibrarySystem
{
    partial class Frm_Win_UserInfo
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
            this.lbl_UserInfo = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_TotalBookNum = new System.Windows.Forms.TextBox();
            this.lbl_TotalBookNum = new System.Windows.Forms.Label();
            this.txt_CurrBookNum = new System.Windows.Forms.TextBox();
            this.lbl_CurrBookNum = new System.Windows.Forms.Label();
            this.txt_ValidDate = new System.Windows.Forms.TextBox();
            this.lbl_ValidDate = new System.Windows.Forms.Label();
            this.txt_RegDate = new System.Windows.Forms.TextBox();
            this.lbl_RegDate = new System.Windows.Forms.Label();
            this.txt_ViolationNum = new System.Windows.Forms.TextBox();
            this.lbl_ViolationNum = new System.Windows.Forms.Label();
            this.lbl_Lost = new System.Windows.Forms.Label();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.txt_RName = new System.Windows.Forms.TextBox();
            this.lbl_RName = new System.Windows.Forms.Label();
            this.txt_RPwd = new System.Windows.Forms.TextBox();
            this.lbl_RPwd = new System.Windows.Forms.Label();
            this.txt_RCID = new System.Windows.Forms.TextBox();
            this.lbl_RCID = new System.Windows.Forms.Label();
            this.txt_RID = new System.Windows.Forms.TextBox();
            this.lbl_RID = new System.Windows.Forms.Label();
            this.cbb_isLost = new System.Windows.Forms.ComboBox();
            this.btn_editPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UserInfo
            // 
            this.lbl_UserInfo.AutoSize = true;
            this.lbl_UserInfo.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_UserInfo.Location = new System.Drawing.Point(13, 13);
            this.lbl_UserInfo.Name = "lbl_UserInfo";
            this.lbl_UserInfo.Size = new System.Drawing.Size(174, 25);
            this.lbl_UserInfo.TabIndex = 0;
            this.lbl_UserInfo.Text = "个人信息修改";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(285, 519);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 40);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "确认";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(585, 519);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 40);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_TotalBookNum
            // 
            this.txt_TotalBookNum.Location = new System.Drawing.Point(677, 287);
            this.txt_TotalBookNum.Name = "txt_TotalBookNum";
            this.txt_TotalBookNum.ReadOnly = true;
            this.txt_TotalBookNum.Size = new System.Drawing.Size(200, 25);
            this.txt_TotalBookNum.TabIndex = 22;
            this.txt_TotalBookNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TotalBookNum
            // 
            this.lbl_TotalBookNum.AutoSize = true;
            this.lbl_TotalBookNum.Location = new System.Drawing.Point(566, 292);
            this.lbl_TotalBookNum.Name = "lbl_TotalBookNum";
            this.lbl_TotalBookNum.Size = new System.Drawing.Size(67, 15);
            this.lbl_TotalBookNum.TabIndex = 21;
            this.lbl_TotalBookNum.Text = "总借书数";
            // 
            // txt_CurrBookNum
            // 
            this.txt_CurrBookNum.Location = new System.Drawing.Point(677, 231);
            this.txt_CurrBookNum.Name = "txt_CurrBookNum";
            this.txt_CurrBookNum.ReadOnly = true;
            this.txt_CurrBookNum.Size = new System.Drawing.Size(200, 25);
            this.txt_CurrBookNum.TabIndex = 20;
            this.txt_CurrBookNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CurrBookNum
            // 
            this.lbl_CurrBookNum.AutoSize = true;
            this.lbl_CurrBookNum.Location = new System.Drawing.Point(566, 236);
            this.lbl_CurrBookNum.Name = "lbl_CurrBookNum";
            this.lbl_CurrBookNum.Size = new System.Drawing.Size(67, 15);
            this.lbl_CurrBookNum.TabIndex = 19;
            this.lbl_CurrBookNum.Text = "现借书数";
            // 
            // txt_ValidDate
            // 
            this.txt_ValidDate.Location = new System.Drawing.Point(677, 175);
            this.txt_ValidDate.Name = "txt_ValidDate";
            this.txt_ValidDate.ReadOnly = true;
            this.txt_ValidDate.Size = new System.Drawing.Size(200, 25);
            this.txt_ValidDate.TabIndex = 18;
            this.txt_ValidDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ValidDate
            // 
            this.lbl_ValidDate.AutoSize = true;
            this.lbl_ValidDate.Location = new System.Drawing.Point(566, 180);
            this.lbl_ValidDate.Name = "lbl_ValidDate";
            this.lbl_ValidDate.Size = new System.Drawing.Size(67, 15);
            this.lbl_ValidDate.TabIndex = 17;
            this.lbl_ValidDate.Text = "有效期至";
            // 
            // txt_RegDate
            // 
            this.txt_RegDate.Location = new System.Drawing.Point(677, 119);
            this.txt_RegDate.Name = "txt_RegDate";
            this.txt_RegDate.ReadOnly = true;
            this.txt_RegDate.Size = new System.Drawing.Size(200, 25);
            this.txt_RegDate.TabIndex = 16;
            this.txt_RegDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RegDate
            // 
            this.lbl_RegDate.AutoSize = true;
            this.lbl_RegDate.Location = new System.Drawing.Point(566, 124);
            this.lbl_RegDate.Name = "lbl_RegDate";
            this.lbl_RegDate.Size = new System.Drawing.Size(67, 15);
            this.lbl_RegDate.TabIndex = 15;
            this.lbl_RegDate.Text = "注册日期";
            // 
            // txt_ViolationNum
            // 
            this.txt_ViolationNum.Location = new System.Drawing.Point(677, 399);
            this.txt_ViolationNum.Name = "txt_ViolationNum";
            this.txt_ViolationNum.ReadOnly = true;
            this.txt_ViolationNum.Size = new System.Drawing.Size(200, 25);
            this.txt_ViolationNum.TabIndex = 26;
            this.txt_ViolationNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ViolationNum
            // 
            this.lbl_ViolationNum.AutoSize = true;
            this.lbl_ViolationNum.Location = new System.Drawing.Point(566, 404);
            this.lbl_ViolationNum.Name = "lbl_ViolationNum";
            this.lbl_ViolationNum.Size = new System.Drawing.Size(67, 15);
            this.lbl_ViolationNum.TabIndex = 25;
            this.lbl_ViolationNum.Text = "违规次数";
            // 
            // lbl_Lost
            // 
            this.lbl_Lost.AutoSize = true;
            this.lbl_Lost.Location = new System.Drawing.Point(566, 348);
            this.lbl_Lost.Name = "lbl_Lost";
            this.lbl_Lost.Size = new System.Drawing.Size(67, 15);
            this.lbl_Lost.TabIndex = 24;
            this.lbl_Lost.Text = "是否挂失";
            // 
            // txt_Sex
            // 
            this.txt_Sex.Location = new System.Drawing.Point(179, 343);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.ReadOnly = true;
            this.txt_Sex.Size = new System.Drawing.Size(200, 25);
            this.txt_Sex.TabIndex = 39;
            this.txt_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(179, 399);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(200, 25);
            this.txt_Phone.TabIndex = 38;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(75, 404);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_Phone.TabIndex = 37;
            this.lbl_Phone.Text = "联系电话";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(90, 348);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(37, 15);
            this.lbl_Sex.TabIndex = 36;
            this.lbl_Sex.Text = "性别";
            // 
            // txt_RName
            // 
            this.txt_RName.Location = new System.Drawing.Point(179, 287);
            this.txt_RName.Name = "txt_RName";
            this.txt_RName.Size = new System.Drawing.Size(200, 25);
            this.txt_RName.TabIndex = 35;
            this.txt_RName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RName
            // 
            this.lbl_RName.AutoSize = true;
            this.lbl_RName.Location = new System.Drawing.Point(75, 292);
            this.lbl_RName.Name = "lbl_RName";
            this.lbl_RName.Size = new System.Drawing.Size(67, 15);
            this.lbl_RName.TabIndex = 34;
            this.lbl_RName.Text = "读者名称";
            // 
            // txt_RPwd
            // 
            this.txt_RPwd.Location = new System.Drawing.Point(179, 231);
            this.txt_RPwd.Name = "txt_RPwd";
            this.txt_RPwd.PasswordChar = '*';
            this.txt_RPwd.ReadOnly = true;
            this.txt_RPwd.Size = new System.Drawing.Size(200, 25);
            this.txt_RPwd.TabIndex = 33;
            this.txt_RPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RPwd
            // 
            this.lbl_RPwd.AutoSize = true;
            this.lbl_RPwd.Location = new System.Drawing.Point(90, 236);
            this.lbl_RPwd.Name = "lbl_RPwd";
            this.lbl_RPwd.Size = new System.Drawing.Size(37, 15);
            this.lbl_RPwd.TabIndex = 32;
            this.lbl_RPwd.Text = "密码";
            // 
            // txt_RCID
            // 
            this.txt_RCID.Location = new System.Drawing.Point(179, 175);
            this.txt_RCID.Name = "txt_RCID";
            this.txt_RCID.ReadOnly = true;
            this.txt_RCID.Size = new System.Drawing.Size(200, 25);
            this.txt_RCID.TabIndex = 31;
            this.txt_RCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RCID
            // 
            this.lbl_RCID.AutoSize = true;
            this.lbl_RCID.Location = new System.Drawing.Point(75, 180);
            this.lbl_RCID.Name = "lbl_RCID";
            this.lbl_RCID.Size = new System.Drawing.Size(67, 15);
            this.lbl_RCID.TabIndex = 30;
            this.lbl_RCID.Text = "读者类别";
            // 
            // txt_RID
            // 
            this.txt_RID.Location = new System.Drawing.Point(179, 119);
            this.txt_RID.Name = "txt_RID";
            this.txt_RID.ReadOnly = true;
            this.txt_RID.Size = new System.Drawing.Size(200, 25);
            this.txt_RID.TabIndex = 29;
            this.txt_RID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RID
            // 
            this.lbl_RID.AutoSize = true;
            this.lbl_RID.Location = new System.Drawing.Point(75, 124);
            this.lbl_RID.Name = "lbl_RID";
            this.lbl_RID.Size = new System.Drawing.Size(67, 15);
            this.lbl_RID.TabIndex = 28;
            this.lbl_RID.Text = "读者编号";
            // 
            // cbb_isLost
            // 
            this.cbb_isLost.FormattingEnabled = true;
            this.cbb_isLost.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbb_isLost.Location = new System.Drawing.Point(677, 343);
            this.cbb_isLost.Name = "cbb_isLost";
            this.cbb_isLost.Size = new System.Drawing.Size(200, 23);
            this.cbb_isLost.TabIndex = 40;
            // 
            // btn_editPwd
            // 
            this.btn_editPwd.Location = new System.Drawing.Point(400, 231);
            this.btn_editPwd.Name = "btn_editPwd";
            this.btn_editPwd.Size = new System.Drawing.Size(100, 25);
            this.btn_editPwd.TabIndex = 41;
            this.btn_editPwd.Text = "修改密码？";
            this.btn_editPwd.UseVisualStyleBackColor = true;
            this.btn_editPwd.Click += new System.EventHandler(this.btn_editPwd_Click);
            // 
            // Frm_Win_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btn_editPwd);
            this.Controls.Add(this.cbb_isLost);
            this.Controls.Add(this.txt_Sex);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.txt_RName);
            this.Controls.Add(this.lbl_RName);
            this.Controls.Add(this.txt_RPwd);
            this.Controls.Add(this.lbl_RPwd);
            this.Controls.Add(this.txt_RCID);
            this.Controls.Add(this.lbl_RCID);
            this.Controls.Add(this.txt_RID);
            this.Controls.Add(this.lbl_RID);
            this.Controls.Add(this.txt_ViolationNum);
            this.Controls.Add(this.lbl_ViolationNum);
            this.Controls.Add(this.lbl_Lost);
            this.Controls.Add(this.txt_TotalBookNum);
            this.Controls.Add(this.lbl_TotalBookNum);
            this.Controls.Add(this.txt_CurrBookNum);
            this.Controls.Add(this.lbl_CurrBookNum);
            this.Controls.Add(this.txt_ValidDate);
            this.Controls.Add(this.lbl_ValidDate);
            this.Controls.Add(this.txt_RegDate);
            this.Controls.Add(this.lbl_RegDate);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_UserInfo);
            this.Name = "Frm_Win_UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_UserInfo";
            this.Load += new System.EventHandler(this.Frm_Win_UserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserInfo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_TotalBookNum;
        private System.Windows.Forms.Label lbl_TotalBookNum;
        private System.Windows.Forms.TextBox txt_CurrBookNum;
        private System.Windows.Forms.Label lbl_CurrBookNum;
        private System.Windows.Forms.TextBox txt_ValidDate;
        private System.Windows.Forms.Label lbl_ValidDate;
        private System.Windows.Forms.TextBox txt_RegDate;
        private System.Windows.Forms.Label lbl_RegDate;
        private System.Windows.Forms.TextBox txt_ViolationNum;
        private System.Windows.Forms.Label lbl_ViolationNum;
        private System.Windows.Forms.Label lbl_Lost;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.TextBox txt_RName;
        private System.Windows.Forms.Label lbl_RName;
        private System.Windows.Forms.TextBox txt_RPwd;
        private System.Windows.Forms.Label lbl_RPwd;
        private System.Windows.Forms.TextBox txt_RCID;
        private System.Windows.Forms.Label lbl_RCID;
        private System.Windows.Forms.TextBox txt_RID;
        private System.Windows.Forms.Label lbl_RID;
        private System.Windows.Forms.ComboBox cbb_isLost;
        private System.Windows.Forms.Button btn_editPwd;
    }
}