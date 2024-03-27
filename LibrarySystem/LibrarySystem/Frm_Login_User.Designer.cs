namespace LibrarySystem
{
    partial class Frm_Login_User
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(123, 302);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(103, 36);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reg.Location = new System.Drawing.Point(325, 210);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(100, 36);
            this.btn_Reg.TabIndex = 1;
            this.btn_Reg.Text = "立即注册？";
            this.btn_Reg.UseVisualStyleBackColor = false;
            this.btn_Reg.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Location = new System.Drawing.Point(123, 135);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(45, 15);
            this.lbl_Uname.TabIndex = 2;
            this.lbl_Uname.Text = "账号:";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(123, 184);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(45, 15);
            this.lbl_Pwd.TabIndex = 3;
            this.lbl_Pwd.Text = "密码:";
            // 
            // txt_Uname
            // 
            this.txt_Uname.Location = new System.Drawing.Point(213, 130);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(212, 25);
            this.txt_Uname.TabIndex = 4;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(213, 179);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(212, 25);
            this.txt_Pwd.TabIndex = 5;
            // 
            // lbl_tip
            // 
            this.lbl_tip.Location = new System.Drawing.Point(185, 83);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(251, 44);
            this.lbl_tip.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(312, 302);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 36);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label_Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Login.Location = new System.Drawing.Point(12, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(116, 25);
            this.label_Login.TabIndex = 8;
            this.label_Login.Text = "用户登录";
            // 
            // Frm_Login_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 383);
            this.ControlBox = false;
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.btn_Login);
            this.Name = "Frm_Login_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_Login;
    }
}