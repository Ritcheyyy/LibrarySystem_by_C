namespace LibrarySystem
{
    partial class Frm_Win_UserPwd
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
            this.lbl_OldPwd = new System.Windows.Forms.Label();
            this.txt_OldPwd = new System.Windows.Forms.TextBox();
            this.txt_NewPwd = new System.Windows.Forms.TextBox();
            this.lbl_NewPwd = new System.Windows.Forms.Label();
            this.txt_Pwd_Confirm = new System.Windows.Forms.TextBox();
            this.lbl_Pwd_Confirm = new System.Windows.Forms.Label();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_OldPwd
            // 
            this.lbl_OldPwd.AutoSize = true;
            this.lbl_OldPwd.Location = new System.Drawing.Point(43, 55);
            this.lbl_OldPwd.Name = "lbl_OldPwd";
            this.lbl_OldPwd.Size = new System.Drawing.Size(127, 15);
            this.lbl_OldPwd.TabIndex = 0;
            this.lbl_OldPwd.Text = "请输入原始密码：";
            // 
            // txt_OldPwd
            // 
            this.txt_OldPwd.Location = new System.Drawing.Point(213, 50);
            this.txt_OldPwd.Name = "txt_OldPwd";
            this.txt_OldPwd.PasswordChar = '*';
            this.txt_OldPwd.Size = new System.Drawing.Size(200, 25);
            this.txt_OldPwd.TabIndex = 1;
            // 
            // txt_NewPwd
            // 
            this.txt_NewPwd.Location = new System.Drawing.Point(213, 105);
            this.txt_NewPwd.Name = "txt_NewPwd";
            this.txt_NewPwd.PasswordChar = '*';
            this.txt_NewPwd.Size = new System.Drawing.Size(200, 25);
            this.txt_NewPwd.TabIndex = 3;
            // 
            // lbl_NewPwd
            // 
            this.lbl_NewPwd.AutoSize = true;
            this.lbl_NewPwd.Location = new System.Drawing.Point(50, 110);
            this.lbl_NewPwd.Name = "lbl_NewPwd";
            this.lbl_NewPwd.Size = new System.Drawing.Size(112, 15);
            this.lbl_NewPwd.TabIndex = 2;
            this.lbl_NewPwd.Text = "请输入新密码：";
            // 
            // txt_Pwd_Confirm
            // 
            this.txt_Pwd_Confirm.Location = new System.Drawing.Point(213, 160);
            this.txt_Pwd_Confirm.Name = "txt_Pwd_Confirm";
            this.txt_Pwd_Confirm.PasswordChar = '*';
            this.txt_Pwd_Confirm.Size = new System.Drawing.Size(200, 25);
            this.txt_Pwd_Confirm.TabIndex = 5;
            // 
            // lbl_Pwd_Confirm
            // 
            this.lbl_Pwd_Confirm.AutoSize = true;
            this.lbl_Pwd_Confirm.Location = new System.Drawing.Point(50, 165);
            this.lbl_Pwd_Confirm.Name = "lbl_Pwd_Confirm";
            this.lbl_Pwd_Confirm.Size = new System.Drawing.Size(112, 15);
            this.lbl_Pwd_Confirm.TabIndex = 4;
            this.lbl_Pwd_Confirm.Text = "请确认新密码：";
            // 
            // lbl_tip
            // 
            this.lbl_tip.Location = new System.Drawing.Point(141, 17);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(216, 38);
            this.lbl_tip.TabIndex = 6;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(81, 218);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(100, 30);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(274, 218);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Frm_Win_UserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.ControlBox = false;
            this.Controls.Add(this.txt_OldPwd);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.txt_Pwd_Confirm);
            this.Controls.Add(this.lbl_Pwd_Confirm);
            this.Controls.Add(this.txt_NewPwd);
            this.Controls.Add(this.lbl_NewPwd);
            this.Controls.Add(this.lbl_OldPwd);
            this.Name = "Frm_Win_UserPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_UserPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OldPwd;
        private System.Windows.Forms.TextBox txt_OldPwd;
        private System.Windows.Forms.TextBox txt_NewPwd;
        private System.Windows.Forms.Label lbl_NewPwd;
        private System.Windows.Forms.TextBox txt_Pwd_Confirm;
        private System.Windows.Forms.Label lbl_Pwd_Confirm;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
    }
}