﻿namespace LibrarySystem
{
    partial class Frm_Win_AdminBook
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
            this.txt_PublishNum = new System.Windows.Forms.TextBox();
            this.txt_PublishDate = new System.Windows.Forms.TextBox();
            this.lbl_PublishDate = new System.Windows.Forms.Label();
            this.lbl_PublishNum = new System.Windows.Forms.Label();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lbl_PID = new System.Windows.Forms.Label();
            this.txt_BAuthor = new System.Windows.Forms.TextBox();
            this.lbl_BAuthor = new System.Windows.Forms.Label();
            this.txt_BName = new System.Windows.Forms.TextBox();
            this.lbl_BName = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.txt_TotalNum = new System.Windows.Forms.TextBox();
            this.lbl_TotalNum = new System.Windows.Forms.Label();
            this.txt_CurrNum = new System.Windows.Forms.TextBox();
            this.lbl_CurrNum = new System.Windows.Forms.Label();
            this.txt_BriefIntroduction = new System.Windows.Forms.TextBox();
            this.lbl_BriefIntroduction = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_BookInfo = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PublishNum
            // 
            this.txt_PublishNum.Location = new System.Drawing.Point(172, 336);
            this.txt_PublishNum.Name = "txt_PublishNum";
            this.txt_PublishNum.Size = new System.Drawing.Size(200, 25);
            this.txt_PublishNum.TabIndex = 67;
            this.txt_PublishNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PublishDate
            // 
            this.txt_PublishDate.Location = new System.Drawing.Point(172, 392);
            this.txt_PublishDate.Name = "txt_PublishDate";
            this.txt_PublishDate.Size = new System.Drawing.Size(200, 25);
            this.txt_PublishDate.TabIndex = 66;
            this.txt_PublishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_PublishDate
            // 
            this.lbl_PublishDate.AutoSize = true;
            this.lbl_PublishDate.Location = new System.Drawing.Point(68, 397);
            this.lbl_PublishDate.Name = "lbl_PublishDate";
            this.lbl_PublishDate.Size = new System.Drawing.Size(67, 15);
            this.lbl_PublishDate.TabIndex = 65;
            this.lbl_PublishDate.Text = "出版日期";
            // 
            // lbl_PublishNum
            // 
            this.lbl_PublishNum.AutoSize = true;
            this.lbl_PublishNum.Location = new System.Drawing.Point(83, 341);
            this.lbl_PublishNum.Name = "lbl_PublishNum";
            this.lbl_PublishNum.Size = new System.Drawing.Size(37, 15);
            this.lbl_PublishNum.TabIndex = 64;
            this.lbl_PublishNum.Text = "版次";
            // 
            // txt_PID
            // 
            this.txt_PID.Location = new System.Drawing.Point(172, 280);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.Size = new System.Drawing.Size(200, 25);
            this.txt_PID.TabIndex = 63;
            this.txt_PID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_PID
            // 
            this.lbl_PID.AutoSize = true;
            this.lbl_PID.Location = new System.Drawing.Point(60, 285);
            this.lbl_PID.Name = "lbl_PID";
            this.lbl_PID.Size = new System.Drawing.Size(82, 15);
            this.lbl_PID.TabIndex = 62;
            this.lbl_PID.Text = "出版社编号";
            // 
            // txt_BAuthor
            // 
            this.txt_BAuthor.Location = new System.Drawing.Point(172, 224);
            this.txt_BAuthor.Name = "txt_BAuthor";
            this.txt_BAuthor.Size = new System.Drawing.Size(200, 25);
            this.txt_BAuthor.TabIndex = 61;
            this.txt_BAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BAuthor
            // 
            this.lbl_BAuthor.AutoSize = true;
            this.lbl_BAuthor.Location = new System.Drawing.Point(83, 229);
            this.lbl_BAuthor.Name = "lbl_BAuthor";
            this.lbl_BAuthor.Size = new System.Drawing.Size(37, 15);
            this.lbl_BAuthor.TabIndex = 60;
            this.lbl_BAuthor.Text = "作者";
            // 
            // txt_BName
            // 
            this.txt_BName.Location = new System.Drawing.Point(172, 168);
            this.txt_BName.Name = "txt_BName";
            this.txt_BName.Size = new System.Drawing.Size(200, 25);
            this.txt_BName.TabIndex = 59;
            this.txt_BName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BName
            // 
            this.lbl_BName.AutoSize = true;
            this.lbl_BName.Location = new System.Drawing.Point(83, 173);
            this.lbl_BName.Name = "lbl_BName";
            this.lbl_BName.Size = new System.Drawing.Size(37, 15);
            this.lbl_BName.TabIndex = 58;
            this.lbl_BName.Text = "书名";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(172, 112);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.ReadOnly = true;
            this.txt_ISBN.Size = new System.Drawing.Size(200, 25);
            this.txt_ISBN.TabIndex = 57;
            this.txt_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(82, 117);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(39, 15);
            this.lbl_ISBN.TabIndex = 56;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // txt_TotalNum
            // 
            this.txt_TotalNum.Location = new System.Drawing.Point(670, 392);
            this.txt_TotalNum.Name = "txt_TotalNum";
            this.txt_TotalNum.Size = new System.Drawing.Size(200, 25);
            this.txt_TotalNum.TabIndex = 52;
            this.txt_TotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TotalNum
            // 
            this.lbl_TotalNum.AutoSize = true;
            this.lbl_TotalNum.Location = new System.Drawing.Point(559, 397);
            this.lbl_TotalNum.Name = "lbl_TotalNum";
            this.lbl_TotalNum.Size = new System.Drawing.Size(67, 15);
            this.lbl_TotalNum.TabIndex = 51;
            this.lbl_TotalNum.Text = "总库存量";
            // 
            // txt_CurrNum
            // 
            this.txt_CurrNum.Location = new System.Drawing.Point(670, 336);
            this.txt_CurrNum.Name = "txt_CurrNum";
            this.txt_CurrNum.Size = new System.Drawing.Size(200, 25);
            this.txt_CurrNum.TabIndex = 50;
            this.txt_CurrNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CurrNum
            // 
            this.lbl_CurrNum.AutoSize = true;
            this.lbl_CurrNum.Location = new System.Drawing.Point(559, 341);
            this.lbl_CurrNum.Name = "lbl_CurrNum";
            this.lbl_CurrNum.Size = new System.Drawing.Size(67, 15);
            this.lbl_CurrNum.TabIndex = 49;
            this.lbl_CurrNum.Text = "在库数量";
            // 
            // txt_BriefIntroduction
            // 
            this.txt_BriefIntroduction.Location = new System.Drawing.Point(670, 168);
            this.txt_BriefIntroduction.Multiline = true;
            this.txt_BriefIntroduction.Name = "txt_BriefIntroduction";
            this.txt_BriefIntroduction.Size = new System.Drawing.Size(200, 137);
            this.txt_BriefIntroduction.TabIndex = 48;
            this.txt_BriefIntroduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BriefIntroduction
            // 
            this.lbl_BriefIntroduction.AutoSize = true;
            this.lbl_BriefIntroduction.Location = new System.Drawing.Point(574, 173);
            this.lbl_BriefIntroduction.Name = "lbl_BriefIntroduction";
            this.lbl_BriefIntroduction.Size = new System.Drawing.Size(37, 15);
            this.lbl_BriefIntroduction.TabIndex = 47;
            this.lbl_BriefIntroduction.Text = "简介";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(670, 112);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(200, 25);
            this.txt_Price.TabIndex = 46;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(574, 117);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(37, 15);
            this.lbl_Price.TabIndex = 45;
            this.lbl_Price.Text = "价格";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(425, 510);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 40);
            this.btn_Cancel.TabIndex = 44;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(230, 510);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 40);
            this.btn_Save.TabIndex = 43;
            this.btn_Save.Text = "确认";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_BookInfo
            // 
            this.lbl_BookInfo.AutoSize = true;
            this.lbl_BookInfo.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_BookInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_BookInfo.Location = new System.Drawing.Point(6, 6);
            this.lbl_BookInfo.Name = "lbl_BookInfo";
            this.lbl_BookInfo.Size = new System.Drawing.Size(174, 25);
            this.lbl_BookInfo.TabIndex = 42;
            this.lbl_BookInfo.Text = "图书信息修改";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(620, 510);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 40);
            this.btn_Delete.TabIndex = 68;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Frm_Win_AdminBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_PublishNum);
            this.Controls.Add(this.txt_PublishDate);
            this.Controls.Add(this.lbl_PublishDate);
            this.Controls.Add(this.lbl_PublishNum);
            this.Controls.Add(this.txt_PID);
            this.Controls.Add(this.lbl_PID);
            this.Controls.Add(this.txt_BAuthor);
            this.Controls.Add(this.lbl_BAuthor);
            this.Controls.Add(this.txt_BName);
            this.Controls.Add(this.lbl_BName);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.lbl_ISBN);
            this.Controls.Add(this.txt_TotalNum);
            this.Controls.Add(this.lbl_TotalNum);
            this.Controls.Add(this.txt_CurrNum);
            this.Controls.Add(this.lbl_CurrNum);
            this.Controls.Add(this.txt_BriefIntroduction);
            this.Controls.Add(this.lbl_BriefIntroduction);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_BookInfo);
            this.Name = "Frm_Win_AdminBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Win_AdminBook";
            this.Load += new System.EventHandler(this.Frm_Win_AdminBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_PublishNum;
        private System.Windows.Forms.TextBox txt_PublishDate;
        private System.Windows.Forms.Label lbl_PublishDate;
        private System.Windows.Forms.Label lbl_PublishNum;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lbl_PID;
        private System.Windows.Forms.TextBox txt_BAuthor;
        private System.Windows.Forms.Label lbl_BAuthor;
        private System.Windows.Forms.TextBox txt_BName;
        private System.Windows.Forms.Label lbl_BName;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.TextBox txt_TotalNum;
        private System.Windows.Forms.Label lbl_TotalNum;
        private System.Windows.Forms.TextBox txt_CurrNum;
        private System.Windows.Forms.Label lbl_CurrNum;
        private System.Windows.Forms.TextBox txt_BriefIntroduction;
        private System.Windows.Forms.Label lbl_BriefIntroduction;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_BookInfo;
        private System.Windows.Forms.Button btn_Delete;
    }
}