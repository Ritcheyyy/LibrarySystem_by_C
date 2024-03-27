namespace LibrarySystem
{
    partial class Frm_Win_Admin
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
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Penalty = new System.Windows.Forms.Button();
            this.btn_Publisher = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_BookAdd = new System.Windows.Forms.Button();
            this.btn_Reader = new System.Windows.Forms.Button();
            this.btn_ReaderClass = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.btn_function = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.TabIndex = 1;
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
            this.lbl_Welcome3.Size = new System.Drawing.Size(120, 25);
            this.lbl_Welcome3.Text = "管理员！";
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Borrow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Borrow.Location = new System.Drawing.Point(12, 62);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(180, 40);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "借阅记录管理";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Return.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Return.Location = new System.Drawing.Point(12, 127);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(180, 40);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "归还记录管理";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Penalty
            // 
            this.btn_Penalty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Penalty.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Penalty.Location = new System.Drawing.Point(12, 192);
            this.btn_Penalty.Name = "btn_Penalty";
            this.btn_Penalty.Size = new System.Drawing.Size(180, 40);
            this.btn_Penalty.TabIndex = 4;
            this.btn_Penalty.Text = "罚款记录管理";
            this.btn_Penalty.UseVisualStyleBackColor = true;
            this.btn_Penalty.Click += new System.EventHandler(this.btn_Penalty_Click);
            // 
            // btn_Publisher
            // 
            this.btn_Publisher.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Publisher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Publisher.Location = new System.Drawing.Point(12, 517);
            this.btn_Publisher.Name = "btn_Publisher";
            this.btn_Publisher.Size = new System.Drawing.Size(180, 40);
            this.btn_Publisher.TabIndex = 5;
            this.btn_Publisher.Text = "出版社信息管理";
            this.btn_Publisher.UseVisualStyleBackColor = true;
            this.btn_Publisher.Click += new System.EventHandler(this.btn_Publisher_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Book.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Book.Location = new System.Drawing.Point(12, 257);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(180, 40);
            this.btn_Book.TabIndex = 6;
            this.btn_Book.Text = "图书信息管理";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_BookAdd
            // 
            this.btn_BookAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_BookAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_BookAdd.Location = new System.Drawing.Point(12, 387);
            this.btn_BookAdd.Name = "btn_BookAdd";
            this.btn_BookAdd.Size = new System.Drawing.Size(180, 40);
            this.btn_BookAdd.TabIndex = 7;
            this.btn_BookAdd.Text = "图书添加管理";
            this.btn_BookAdd.UseVisualStyleBackColor = true;
            this.btn_BookAdd.Click += new System.EventHandler(this.btn_BookAdd_Click);
            // 
            // btn_Reader
            // 
            this.btn_Reader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Reader.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Reader.Location = new System.Drawing.Point(12, 322);
            this.btn_Reader.Name = "btn_Reader";
            this.btn_Reader.Size = new System.Drawing.Size(180, 40);
            this.btn_Reader.TabIndex = 8;
            this.btn_Reader.Text = "读者信息管理";
            this.btn_Reader.UseVisualStyleBackColor = true;
            this.btn_Reader.Click += new System.EventHandler(this.btn_Reader_Click);
            // 
            // btn_ReaderClass
            // 
            this.btn_ReaderClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ReaderClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ReaderClass.Location = new System.Drawing.Point(12, 452);
            this.btn_ReaderClass.Name = "btn_ReaderClass";
            this.btn_ReaderClass.Size = new System.Drawing.Size(180, 40);
            this.btn_ReaderClass.TabIndex = 9;
            this.btn_ReaderClass.Text = "读者类别管理";
            this.btn_ReaderClass.UseVisualStyleBackColor = true;
            this.btn_ReaderClass.Click += new System.EventHandler(this.btn_ReaderClass_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(882, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 30);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "退出登录";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ListView
            // 
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(198, 37);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(772, 492);
            this.ListView.TabIndex = 12;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // btn_function
            // 
            this.btn_function.Location = new System.Drawing.Point(776, 535);
            this.btn_function.Name = "btn_function";
            this.btn_function.Size = new System.Drawing.Size(194, 30);
            this.btn_function.TabIndex = 13;
            this.btn_function.Text = "修改信息";
            this.btn_function.UseVisualStyleBackColor = true;
            this.btn_function.Click += new System.EventHandler(this.btn_function_Click);
            // 
            // Frm_Win_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btn_function);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ReaderClass);
            this.Controls.Add(this.btn_Reader);
            this.Controls.Add(this.btn_BookAdd);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.btn_Publisher);
            this.Controls.Add(this.btn_Penalty);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_Win_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_Admin";
            this.Load += new System.EventHandler(this.Frm_Win_Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Welcome3;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Penalty;
        private System.Windows.Forms.Button btn_Publisher;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_BookAdd;
        private System.Windows.Forms.Button btn_Reader;
        private System.Windows.Forms.Button btn_ReaderClass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button btn_function;
    }
}