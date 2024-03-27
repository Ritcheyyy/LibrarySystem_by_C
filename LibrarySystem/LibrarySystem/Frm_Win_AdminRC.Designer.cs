namespace LibrarySystem
{
    partial class Frm_Win_AdminRC
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
            this.nudown_RCDay = new System.Windows.Forms.NumericUpDown();
            this.nudown_RCNum = new System.Windows.Forms.NumericUpDown();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_RCDay = new System.Windows.Forms.Label();
            this.lbl_RCNum = new System.Windows.Forms.Label();
            this.txt_RCName = new System.Windows.Forms.TextBox();
            this.lbl_RCName = new System.Windows.Forms.Label();
            this.txt_RCID = new System.Windows.Forms.TextBox();
            this.lbl_RCID = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_State = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_ReaderClass = new System.Windows.Forms.ListView();
            this.RCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RCName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RCNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RCDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_RCDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_RCNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudown_RCDay);
            this.groupBox1.Controls.Add(this.nudown_RCNum);
            this.groupBox1.Controls.Add(this.lbl_tip);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_RCDay);
            this.groupBox1.Controls.Add(this.lbl_RCNum);
            this.groupBox1.Controls.Add(this.txt_RCName);
            this.groupBox1.Controls.Add(this.lbl_RCName);
            this.groupBox1.Controls.Add(this.txt_RCID);
            this.groupBox1.Controls.Add(this.lbl_RCID);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑读者类别信息  状态：";
            // 
            // nudown_RCDay
            // 
            this.nudown_RCDay.Location = new System.Drawing.Point(309, 88);
            this.nudown_RCDay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudown_RCDay.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudown_RCDay.Name = "nudown_RCDay";
            this.nudown_RCDay.Size = new System.Drawing.Size(125, 25);
            this.nudown_RCDay.TabIndex = 14;
            this.nudown_RCDay.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudown_RCNum
            // 
            this.nudown_RCNum.Location = new System.Drawing.Point(309, 37);
            this.nudown_RCNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudown_RCNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudown_RCNum.Name = "nudown_RCNum";
            this.nudown_RCNum.Size = new System.Drawing.Size(125, 25);
            this.nudown_RCNum.TabIndex = 13;
            this.nudown_RCNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(247, 0);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(0, 15);
            this.lbl_tip.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(477, 100);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(477, 22);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_RCDay
            // 
            this.lbl_RCDay.AutoSize = true;
            this.lbl_RCDay.Location = new System.Drawing.Point(230, 93);
            this.lbl_RCDay.Name = "lbl_RCDay";
            this.lbl_RCDay.Size = new System.Drawing.Size(82, 15);
            this.lbl_RCDay.TabIndex = 9;
            this.lbl_RCDay.Text = "可借天数：";
            // 
            // lbl_RCNum
            // 
            this.lbl_RCNum.AutoSize = true;
            this.lbl_RCNum.Location = new System.Drawing.Point(230, 42);
            this.lbl_RCNum.Name = "lbl_RCNum";
            this.lbl_RCNum.Size = new System.Drawing.Size(82, 15);
            this.lbl_RCNum.TabIndex = 7;
            this.lbl_RCNum.Text = "可借数量：";
            // 
            // txt_RCName
            // 
            this.txt_RCName.Location = new System.Drawing.Point(86, 88);
            this.txt_RCName.Name = "txt_RCName";
            this.txt_RCName.Size = new System.Drawing.Size(125, 25);
            this.txt_RCName.TabIndex = 6;
            // 
            // lbl_RCName
            // 
            this.lbl_RCName.AutoSize = true;
            this.lbl_RCName.Location = new System.Drawing.Point(7, 93);
            this.lbl_RCName.Name = "lbl_RCName";
            this.lbl_RCName.Size = new System.Drawing.Size(82, 15);
            this.lbl_RCName.TabIndex = 5;
            this.lbl_RCName.Text = "类别名称：";
            // 
            // txt_RCID
            // 
            this.txt_RCID.Location = new System.Drawing.Point(86, 37);
            this.txt_RCID.Name = "txt_RCID";
            this.txt_RCID.ReadOnly = true;
            this.txt_RCID.Size = new System.Drawing.Size(125, 25);
            this.txt_RCID.TabIndex = 4;
            // 
            // lbl_RCID
            // 
            this.lbl_RCID.AutoSize = true;
            this.lbl_RCID.Location = new System.Drawing.Point(7, 42);
            this.lbl_RCID.Name = "lbl_RCID";
            this.lbl_RCID.Size = new System.Drawing.Size(82, 15);
            this.lbl_RCID.TabIndex = 3;
            this.lbl_RCID.Text = "类别编号：";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(477, 61);
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
            this.lbl_State.Location = new System.Drawing.Point(192, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 15);
            this.lbl_State.TabIndex = 0;
            this.lbl_State.Text = "添加";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_ReaderClass);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 182);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者类别列表";
            // 
            // lv_ReaderClass
            // 
            this.lv_ReaderClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RCID,
            this.RCName,
            this.RCNum,
            this.RCDay});
            this.lv_ReaderClass.FullRowSelect = true;
            this.lv_ReaderClass.GridLines = true;
            this.lv_ReaderClass.HideSelection = false;
            this.lv_ReaderClass.Location = new System.Drawing.Point(7, 25);
            this.lv_ReaderClass.MultiSelect = false;
            this.lv_ReaderClass.Name = "lv_ReaderClass";
            this.lv_ReaderClass.Size = new System.Drawing.Size(551, 151);
            this.lv_ReaderClass.TabIndex = 0;
            this.lv_ReaderClass.UseCompatibleStateImageBehavior = false;
            this.lv_ReaderClass.View = System.Windows.Forms.View.Details;
            this.lv_ReaderClass.SelectedIndexChanged += new System.EventHandler(this.lv_ReaderClass_SelectedIndexChanged);
            // 
            // RCID
            // 
            this.RCID.Text = "读者类别编号";
            this.RCID.Width = 120;
            // 
            // RCName
            // 
            this.RCName.Text = "读者类别名称";
            this.RCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RCName.Width = 120;
            // 
            // RCNum
            // 
            this.RCNum.Text = "可借数量";
            this.RCNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RCNum.Width = 120;
            // 
            // RCDay
            // 
            this.RCDay.Text = "可借天数";
            this.RCDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RCDay.Width = 120;
            // 
            // Frm_Win_AdminRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Win_AdminRC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_AdminRC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_RCDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_RCNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_ReaderClass;
        private System.Windows.Forms.ColumnHeader RCID;
        private System.Windows.Forms.ColumnHeader RCName;
        private System.Windows.Forms.ColumnHeader RCNum;
        private System.Windows.Forms.ColumnHeader RCDay;
        private System.Windows.Forms.TextBox txt_RCID;
        private System.Windows.Forms.Label lbl_RCID;
        private System.Windows.Forms.Label lbl_RCDay;
        private System.Windows.Forms.Label lbl_RCNum;
        private System.Windows.Forms.TextBox txt_RCName;
        private System.Windows.Forms.Label lbl_RCName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.NumericUpDown nudown_RCDay;
        private System.Windows.Forms.NumericUpDown nudown_RCNum;
    }
}