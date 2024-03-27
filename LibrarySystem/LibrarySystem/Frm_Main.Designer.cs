namespace LibrarySystem
{
    partial class Frm_Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login_Reader = new System.Windows.Forms.Button();
            this.btn_Login_Admin = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySystem.Properties.Resources.图片2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(958, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用图书管理系统！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login_Reader
            // 
            this.btn_Login_Reader.Location = new System.Drawing.Point(350, 300);
            this.btn_Login_Reader.Name = "btn_Login_Reader";
            this.btn_Login_Reader.Size = new System.Drawing.Size(300, 50);
            this.btn_Login_Reader.TabIndex = 2;
            this.btn_Login_Reader.Text = "用户登录";
            this.btn_Login_Reader.UseVisualStyleBackColor = true;
            this.btn_Login_Reader.Click += new System.EventHandler(this.btn_Login_Reader_Click);
            // 
            // btn_Login_Admin
            // 
            this.btn_Login_Admin.Location = new System.Drawing.Point(350, 370);
            this.btn_Login_Admin.Name = "btn_Login_Admin";
            this.btn_Login_Admin.Size = new System.Drawing.Size(300, 50);
            this.btn_Login_Admin.TabIndex = 3;
            this.btn_Login_Admin.Text = "管理员登录";
            this.btn_Login_Admin.UseVisualStyleBackColor = true;
            this.btn_Login_Admin.Click += new System.EventHandler(this.btn_Login_Admin_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(350, 440);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(300, 50);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "用户注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(350, 509);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(300, 50);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "退出系统";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login_Admin);
            this.Controls.Add(this.btn_Login_Reader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login_Reader;
        private System.Windows.Forms.Button btn_Login_Admin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_exit;
    }
}