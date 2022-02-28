
namespace QuanLyThuVien
{
    partial class SearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.searchDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.readerCodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.borrowCodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryRadioBtn = new System.Windows.Forms.RadioButton();
            this.bookNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.authorRadioBtn = new System.Windows.Forms.RadioButton();
            this.bookCodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchContentTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.searchDGV);
            this.groupBox18.Location = new System.Drawing.Point(21, 270);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1338, 332);
            this.groupBox18.TabIndex = 4;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Danh sách tìm kiếm";
            // 
            // searchDGV
            // 
            this.searchDGV.AllowUserToAddRows = false;
            this.searchDGV.AllowUserToDeleteRows = false;
            this.searchDGV.AllowUserToResizeRows = false;
            this.searchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDGV.Location = new System.Drawing.Point(3, 18);
            this.searchDGV.Name = "searchDGV";
            this.searchDGV.RowHeadersWidth = 51;
            this.searchDGV.RowTemplate.Height = 24;
            this.searchDGV.Size = new System.Drawing.Size(1332, 311);
            this.searchDGV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.readerCodeRadioBtn);
            this.panel1.Controls.Add(this.borrowCodeRadioBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.categoryRadioBtn);
            this.panel1.Controls.Add(this.bookNameRadioBtn);
            this.panel1.Controls.Add(this.authorRadioBtn);
            this.panel1.Controls.Add(this.bookCodeRadioBtn);
            this.panel1.Controls.Add(this.searchContentTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 246);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập nội dung tìm kiếm";
            // 
            // readerCodeRadioBtn
            // 
            this.readerCodeRadioBtn.AutoSize = true;
            this.readerCodeRadioBtn.Location = new System.Drawing.Point(228, 141);
            this.readerCodeRadioBtn.Name = "readerCodeRadioBtn";
            this.readerCodeRadioBtn.Size = new System.Drawing.Size(103, 21);
            this.readerCodeRadioBtn.TabIndex = 9;
            this.readerCodeRadioBtn.TabStop = true;
            this.readerCodeRadioBtn.Text = "Mã bạn đọc";
            this.readerCodeRadioBtn.UseVisualStyleBackColor = true;
            this.readerCodeRadioBtn.CheckedChanged += new System.EventHandler(this.readerCodeRadioBtn_CheckedChanged);
            // 
            // borrowCodeRadioBtn
            // 
            this.borrowCodeRadioBtn.AutoSize = true;
            this.borrowCodeRadioBtn.Location = new System.Drawing.Point(65, 141);
            this.borrowCodeRadioBtn.Name = "borrowCodeRadioBtn";
            this.borrowCodeRadioBtn.Size = new System.Drawing.Size(87, 21);
            this.borrowCodeRadioBtn.TabIndex = 8;
            this.borrowCodeRadioBtn.TabStop = true;
            this.borrowCodeRadioBtn.Text = "Mã mượn";
            this.borrowCodeRadioBtn.UseVisualStyleBackColor = true;
            this.borrowCodeRadioBtn.CheckedChanged += new System.EventHandler(this.borrowCodeRadioBtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm thông tin mượn trả";
            // 
            // categoryRadioBtn
            // 
            this.categoryRadioBtn.AutoSize = true;
            this.categoryRadioBtn.Location = new System.Drawing.Point(228, 76);
            this.categoryRadioBtn.Name = "categoryRadioBtn";
            this.categoryRadioBtn.Size = new System.Drawing.Size(80, 21);
            this.categoryRadioBtn.TabIndex = 6;
            this.categoryRadioBtn.TabStop = true;
            this.categoryRadioBtn.Text = "Thể loại";
            this.categoryRadioBtn.UseVisualStyleBackColor = true;
            this.categoryRadioBtn.CheckedChanged += new System.EventHandler(this.categoryRadioBtn_CheckedChanged);
            // 
            // bookNameRadioBtn
            // 
            this.bookNameRadioBtn.AutoSize = true;
            this.bookNameRadioBtn.Location = new System.Drawing.Point(65, 76);
            this.bookNameRadioBtn.Name = "bookNameRadioBtn";
            this.bookNameRadioBtn.Size = new System.Drawing.Size(99, 21);
            this.bookNameRadioBtn.TabIndex = 5;
            this.bookNameRadioBtn.TabStop = true;
            this.bookNameRadioBtn.Text = "Tên tài liệu";
            this.bookNameRadioBtn.UseVisualStyleBackColor = true;
            this.bookNameRadioBtn.CheckedChanged += new System.EventHandler(this.bookNameRadioBtn_CheckedChanged);
            // 
            // authorRadioBtn
            // 
            this.authorRadioBtn.AutoSize = true;
            this.authorRadioBtn.Location = new System.Drawing.Point(228, 46);
            this.authorRadioBtn.Name = "authorRadioBtn";
            this.authorRadioBtn.Size = new System.Drawing.Size(76, 21);
            this.authorRadioBtn.TabIndex = 4;
            this.authorRadioBtn.TabStop = true;
            this.authorRadioBtn.Text = "Tác giả";
            this.authorRadioBtn.UseVisualStyleBackColor = true;
            this.authorRadioBtn.CheckedChanged += new System.EventHandler(this.authorRadioBtn_CheckedChanged);
            // 
            // bookCodeRadioBtn
            // 
            this.bookCodeRadioBtn.AutoSize = true;
            this.bookCodeRadioBtn.Location = new System.Drawing.Point(65, 46);
            this.bookCodeRadioBtn.Name = "bookCodeRadioBtn";
            this.bookCodeRadioBtn.Size = new System.Drawing.Size(93, 21);
            this.bookCodeRadioBtn.TabIndex = 3;
            this.bookCodeRadioBtn.TabStop = true;
            this.bookCodeRadioBtn.Text = "Mã tài liệu";
            this.bookCodeRadioBtn.UseVisualStyleBackColor = true;
            this.bookCodeRadioBtn.CheckedChanged += new System.EventHandler(this.bookCodeRadioBtn_CheckedChanged);
            // 
            // searchContentTB
            // 
            this.searchContentTB.Location = new System.Drawing.Point(31, 201);
            this.searchContentTB.Name = "searchContentTB";
            this.searchContentTB.Size = new System.Drawing.Size(452, 22);
            this.searchContentTB.TabIndex = 2;
            this.searchContentTB.TabStop = false;
            this.searchContentTB.TextChanged += new System.EventHandler(this.searchContentTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm thông tin tài liệu";
            // 
            // SearchControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.panel1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(1376, 619);
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.DataGridView searchDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton readerCodeRadioBtn;
        private System.Windows.Forms.RadioButton borrowCodeRadioBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton categoryRadioBtn;
        private System.Windows.Forms.RadioButton bookNameRadioBtn;
        private System.Windows.Forms.RadioButton authorRadioBtn;
        private System.Windows.Forms.RadioButton bookCodeRadioBtn;
        private System.Windows.Forms.TextBox searchContentTB;
        private System.Windows.Forms.Label label2;
    }
}
