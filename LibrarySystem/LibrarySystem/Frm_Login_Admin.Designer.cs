namespace LibrarySystem
{
    partial class Frm_Login_Admin
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
            this.label_Login = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_Aname = new System.Windows.Forms.TextBox();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.lbl_Aname = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.label_Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Login.Location = new System.Drawing.Point(12, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(142, 25);
            this.label_Login.TabIndex = 17;
            this.label_Login.Text = "管理员登录";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(317, 306);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 36);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_tip
            // 
            this.lbl_tip.Location = new System.Drawing.Point(181, 71);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(251, 44);
            this.lbl_tip.TabIndex = 15;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(220, 170);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(212, 25);
            this.txt_Pwd.TabIndex = 14;
            // 
            // txt_Aname
            // 
            this.txt_Aname.Location = new System.Drawing.Point(220, 118);
            this.txt_Aname.Name = "txt_Aname";
            this.txt_Aname.Size = new System.Drawing.Size(212, 25);
            this.txt_Aname.TabIndex = 13;
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(130, 175);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(45, 15);
            this.lbl_Pwd.TabIndex = 12;
            this.lbl_Pwd.Text = "密码:";
            // 
            // lbl_Aname
            // 
            this.lbl_Aname.AutoSize = true;
            this.lbl_Aname.Location = new System.Drawing.Point(130, 123);
            this.lbl_Aname.Name = "lbl_Aname";
            this.lbl_Aname.Size = new System.Drawing.Size(45, 15);
            this.lbl_Aname.TabIndex = 11;
            this.lbl_Aname.Text = "账号:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(128, 306);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(103, 36);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(220, 222);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.PasswordChar = '*';
            this.txt_Key.Size = new System.Drawing.Size(212, 25);
            this.txt_Key.TabIndex = 19;
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Location = new System.Drawing.Point(130, 227);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(45, 15);
            this.lbl_Key.TabIndex = 18;
            this.lbl_Key.Text = "密钥:";
            // 
            // Frm_Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 383);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_Aname);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Aname);
            this.Controls.Add(this.btn_Login);
            this.Name = "Frm_Login_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login_Admin";
            this.Load += new System.EventHandler(this.Frm_Login_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_Aname;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.Label lbl_Aname;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label lbl_Key;
    }
}