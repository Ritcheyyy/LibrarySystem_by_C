namespace LibrarySystem
{
    partial class Frm_Win_User
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Welcome1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Welcome2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Welcome3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lv_Borrow = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BriefIntroduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_function = new System.Windows.Forms.Button();
            this.cb_isBroken = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.LPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Welcome1,
            this.lbl_Welcome2,
            this.lbl_Welcome3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Welcome1
            // 
            this.lbl_Welcome1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Welcome1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Welcome1.Name = "lbl_Welcome1";
            this.lbl_Welcome1.Size = new System.Drawing.Size(120, 25);
            this.lbl_Welcome1.Text = "欢迎你，";
            // 
            // lbl_Welcome2
            // 
            this.lbl_Welcome2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Welcome2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Welcome2.Name = "lbl_Welcome2";
            this.lbl_Welcome2.Size = new System.Drawing.Size(26, 25);
            this.lbl_Welcome2.Text = "1";
            // 
            // lbl_Welcome3
            // 
            this.lbl_Welcome3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Welcome3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Welcome3.Name = "lbl_Welcome3";
            this.lbl_Welcome3.Size = new System.Drawing.Size(93, 25);
            this.lbl_Welcome3.Text = "同学！";
            // 
            // LPanel
            // 
            this.LPanel.Controls.Add(this.lv_Borrow);
            this.LPanel.Location = new System.Drawing.Point(195, 45);
            this.LPanel.Name = "LPanel";
            this.LPanel.Size = new System.Drawing.Size(775, 478);
            this.LPanel.TabIndex = 1;
            // 
            // lv_Borrow
            // 
            this.lv_Borrow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.BName,
            this.BAuthor,
            this.PID,
            this.PublishNum,
            this.PublishDate,
            this.Price,
            this.BriefIntroduction,
            this.CurrNum,
            this.TotalNum});
            this.lv_Borrow.FullRowSelect = true;
            this.lv_Borrow.GridLines = true;
            this.lv_Borrow.HideSelection = false;
            this.lv_Borrow.Location = new System.Drawing.Point(3, 3);
            this.lv_Borrow.MultiSelect = false;
            this.lv_Borrow.Name = "lv_Borrow";
            this.lv_Borrow.Size = new System.Drawing.Size(772, 473);
            this.lv_Borrow.TabIndex = 0;
            this.lv_Borrow.UseCompatibleStateImageBehavior = false;
            this.lv_Borrow.View = System.Windows.Forms.View.Details;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 58;
            // 
            // BName
            // 
            this.BName.Text = "书名";
            this.BName.Width = 70;
            // 
            // BAuthor
            // 
            this.BAuthor.Text = "作者";
            this.BAuthor.Width = 70;
            // 
            // PID
            // 
            this.PID.Text = "出版社编号";
            this.PID.Width = 88;
            // 
            // PublishNum
            // 
            this.PublishNum.Text = "版次";
            // 
            // PublishDate
            // 
            this.PublishDate.Text = "出版日期";
            this.PublishDate.Width = 108;
            // 
            // Price
            // 
            this.Price.Text = "价格";
            // 
            // BriefIntroduction
            // 
            this.BriefIntroduction.Text = "简介";
            // 
            // CurrNum
            // 
            this.CurrNum.Text = "在库数量";
            this.CurrNum.Width = 87;
            // 
            // TotalNum
            // 
            this.TotalNum.Text = "总库存量";
            this.TotalNum.Width = 77;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Borrow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Borrow.Location = new System.Drawing.Point(12, 172);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(177, 40);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "图书借阅";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Return.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Return.Location = new System.Drawing.Point(12, 233);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(177, 40);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "图书归还";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Info.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Info.Location = new System.Drawing.Point(12, 294);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(177, 40);
            this.btn_Info.TabIndex = 4;
            this.btn_Info.Text = "个人信息";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Exit.Location = new System.Drawing.Point(12, 354);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(177, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "退出登录";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_function
            // 
            this.btn_function.Location = new System.Drawing.Point(841, 527);
            this.btn_function.Name = "btn_function";
            this.btn_function.Size = new System.Drawing.Size(129, 40);
            this.btn_function.TabIndex = 6;
            this.btn_function.Text = "立即借阅？";
            this.btn_function.UseVisualStyleBackColor = true;
            this.btn_function.Click += new System.EventHandler(this.btn_function_Click);
            // 
            // cb_isBroken
            // 
            this.cb_isBroken.AutoSize = true;
            this.cb_isBroken.Location = new System.Drawing.Point(198, 540);
            this.cb_isBroken.Name = "cb_isBroken";
            this.cb_isBroken.Size = new System.Drawing.Size(142, 19);
            this.cb_isBroken.TabIndex = 7;
            this.cb_isBroken.Text = "是否损坏/丢失？";
            this.cb_isBroken.UseVisualStyleBackColor = true;
            // 
            // Frm_Win_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.ControlBox = false;
            this.Controls.Add(this.cb_isBroken);
            this.Controls.Add(this.btn_function);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.LPanel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_Win_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_User";
            this.Load += new System.EventHandler(this.Frm_Win_User_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome3;
        private System.Windows.Forms.FlowLayoutPanel LPanel;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListView lv_Borrow;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader BName;
        private System.Windows.Forms.ColumnHeader BAuthor;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader PublishNum;
        private System.Windows.Forms.ColumnHeader PublishDate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader BriefIntroduction;
        private System.Windows.Forms.ColumnHeader CurrNum;
        private System.Windows.Forms.ColumnHeader TotalNum;
        private System.Windows.Forms.Button btn_function;
        private System.Windows.Forms.CheckBox cb_isBroken;
    }
}