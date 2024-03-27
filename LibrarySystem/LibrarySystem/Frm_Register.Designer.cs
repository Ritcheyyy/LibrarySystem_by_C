namespace LibrarySystem
{
    partial class Frm_Register
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
            this.label_Reg = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_Uid = new System.Windows.Forms.TextBox();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.lbl_Uid = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Pwd_Confirm = new System.Windows.Forms.TextBox();
            this.lbl_Pwd_Confirm = new System.Windows.Forms.Label();
            this.rbtn_Gender_1 = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Identity = new System.Windows.Forms.Label();
            this.rbtn_Gender_2 = new System.Windows.Forms.RadioButton();
            this.panel_Identity = new System.Windows.Forms.Panel();
            this.rbtn_Identity_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Identity_1 = new System.Windows.Forms.RadioButton();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.panel_Identity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Reg
            // 
            this.label_Reg.AutoSize = true;
            this.label_Reg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label_Reg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Reg.Location = new System.Drawing.Point(12, 9);
            this.label_Reg.Name = "label_Reg";
            this.label_Reg.Size = new System.Drawing.Size(116, 25);
            this.label_Reg.TabIndex = 17;
            this.label_Reg.Text = "用户注册";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(322, 335);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 36);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_tip
            // 
            this.lbl_tip.Location = new System.Drawing.Point(165, 19);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(251, 36);
            this.lbl_tip.TabIndex = 15;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(223, 128);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(212, 25);
            this.txt_Pwd.TabIndex = 14;
            // 
            // txt_Uid
            // 
            this.txt_Uid.Location = new System.Drawing.Point(223, 58);
            this.txt_Uid.Name = "txt_Uid";
            this.txt_Uid.Size = new System.Drawing.Size(212, 25);
            this.txt_Uid.TabIndex = 13;
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(118, 133);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(45, 15);
            this.lbl_Pwd.TabIndex = 12;
            this.lbl_Pwd.Text = "密码:";
            // 
            // lbl_Uid
            // 
            this.lbl_Uid.AutoSize = true;
            this.lbl_Uid.Location = new System.Drawing.Point(118, 63);
            this.lbl_Uid.Name = "lbl_Uid";
            this.lbl_Uid.Size = new System.Drawing.Size(45, 15);
            this.lbl_Uid.TabIndex = 11;
            this.lbl_Uid.Text = "账号:";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(133, 335);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(103, 36);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Pwd_Confirm
            // 
            this.txt_Pwd_Confirm.Location = new System.Drawing.Point(223, 163);
            this.txt_Pwd_Confirm.Name = "txt_Pwd_Confirm";
            this.txt_Pwd_Confirm.PasswordChar = '*';
            this.txt_Pwd_Confirm.Size = new System.Drawing.Size(212, 25);
            this.txt_Pwd_Confirm.TabIndex = 19;
            // 
            // lbl_Pwd_Confirm
            // 
            this.lbl_Pwd_Confirm.AutoSize = true;
            this.lbl_Pwd_Confirm.Location = new System.Drawing.Point(103, 168);
            this.lbl_Pwd_Confirm.Name = "lbl_Pwd_Confirm";
            this.lbl_Pwd_Confirm.Size = new System.Drawing.Size(75, 15);
            this.lbl_Pwd_Confirm.TabIndex = 18;
            this.lbl_Pwd_Confirm.Text = "确认密码:";
            // 
            // rbtn_Gender_1
            // 
            this.rbtn_Gender_1.AutoSize = true;
            this.rbtn_Gender_1.Checked = true;
            this.rbtn_Gender_1.Location = new System.Drawing.Point(223, 237);
            this.rbtn_Gender_1.Name = "rbtn_Gender_1";
            this.rbtn_Gender_1.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Gender_1.TabIndex = 20;
            this.rbtn_Gender_1.TabStop = true;
            this.rbtn_Gender_1.Text = "男";
            this.rbtn_Gender_1.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(118, 239);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(45, 15);
            this.lbl_Gender.TabIndex = 21;
            this.lbl_Gender.Text = "性别:";
            // 
            // lbl_Identity
            // 
            this.lbl_Identity.AutoSize = true;
            this.lbl_Identity.Location = new System.Drawing.Point(118, 274);
            this.lbl_Identity.Name = "lbl_Identity";
            this.lbl_Identity.Size = new System.Drawing.Size(45, 15);
            this.lbl_Identity.TabIndex = 22;
            this.lbl_Identity.Text = "身份:";
            // 
            // rbtn_Gender_2
            // 
            this.rbtn_Gender_2.AutoSize = true;
            this.rbtn_Gender_2.Location = new System.Drawing.Point(373, 237);
            this.rbtn_Gender_2.Name = "rbtn_Gender_2";
            this.rbtn_Gender_2.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Gender_2.TabIndex = 25;
            this.rbtn_Gender_2.Text = "女";
            this.rbtn_Gender_2.UseVisualStyleBackColor = true;
            // 
            // panel_Identity
            // 
            this.panel_Identity.Controls.Add(this.rbtn_Identity_2);
            this.panel_Identity.Controls.Add(this.rbtn_Identity_1);
            this.panel_Identity.Location = new System.Drawing.Point(223, 262);
            this.panel_Identity.Name = "panel_Identity";
            this.panel_Identity.Size = new System.Drawing.Size(212, 42);
            this.panel_Identity.TabIndex = 26;
            // 
            // rbtn_Identity_2
            // 
            this.rbtn_Identity_2.AutoSize = true;
            this.rbtn_Identity_2.Location = new System.Drawing.Point(150, 11);
            this.rbtn_Identity_2.Name = "rbtn_Identity_2";
            this.rbtn_Identity_2.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Identity_2.TabIndex = 1;
            this.rbtn_Identity_2.Text = "教师";
            this.rbtn_Identity_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Identity_1
            // 
            this.rbtn_Identity_1.AutoSize = true;
            this.rbtn_Identity_1.Checked = true;
            this.rbtn_Identity_1.Location = new System.Drawing.Point(0, 12);
            this.rbtn_Identity_1.Name = "rbtn_Identity_1";
            this.rbtn_Identity_1.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Identity_1.TabIndex = 0;
            this.rbtn_Identity_1.TabStop = true;
            this.rbtn_Identity_1.Text = "学生";
            this.rbtn_Identity_1.UseVisualStyleBackColor = true;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(223, 198);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '*';
            this.txt_Phone.Size = new System.Drawing.Size(212, 25);
            this.txt_Phone.TabIndex = 28;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(103, 203);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(75, 15);
            this.lbl_Phone.TabIndex = 27;
            this.lbl_Phone.Text = "手机号码:";
            // 
            // txt_Uname
            // 
            this.txt_Uname.Location = new System.Drawing.Point(223, 93);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(212, 25);
            this.txt_Uname.TabIndex = 30;
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Location = new System.Drawing.Point(110, 98);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(60, 15);
            this.lbl_Uname.TabIndex = 29;
            this.lbl_Uname.Text = "用户名:";
            this.lbl_Uname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 383);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.panel_Identity);
            this.Controls.Add(this.rbtn_Gender_2);
            this.Controls.Add(this.lbl_Identity);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.rbtn_Gender_1);
            this.Controls.Add(this.txt_Pwd_Confirm);
            this.Controls.Add(this.lbl_Pwd_Confirm);
            this.Controls.Add(this.label_Reg);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_Uid);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Uid);
            this.Controls.Add(this.btn_Register);
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Register";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            this.panel_Identity.ResumeLayout(false);
            this.panel_Identity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Reg;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_Uid;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.Label lbl_Uid;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_Pwd_Confirm;
        private System.Windows.Forms.Label lbl_Pwd_Confirm;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Identity;
        private System.Windows.Forms.RadioButton rbtn_Gender_1;
        private System.Windows.Forms.RadioButton rbtn_Gender_2;
        private System.Windows.Forms.Panel panel_Identity;
        private System.Windows.Forms.RadioButton rbtn_Identity_1;
        private System.Windows.Forms.RadioButton rbtn_Identity_2;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.Label lbl_Uname;
    }
}