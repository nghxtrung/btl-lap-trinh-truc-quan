
namespace QuanLyThuVien
{
    partial class BookManageControl
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
            this.bookExitBtn = new FontAwesome.Sharp.IconButton();
            this.bookRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.bookSaveBtn = new FontAwesome.Sharp.IconButton();
            this.bookCancelBtn = new FontAwesome.Sharp.IconButton();
            this.bookEditBtn = new FontAwesome.Sharp.IconButton();
            this.bookAddBtn = new FontAwesome.Sharp.IconButton();
            this.bookRefreshBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.bookPriceTB = new System.Windows.Forms.TextBox();
            this.bookPriceLB = new System.Windows.Forms.Label();
            this.bookRemovePictureBtn = new FontAwesome.Sharp.IconButton();
            this.categoryCBB = new System.Windows.Forms.ComboBox();
            this.publishYearTB = new System.Windows.Forms.TextBox();
            this.publishYearLB = new System.Windows.Forms.Label();
            this.bookQuantityTB = new System.Windows.Forms.TextBox();
            this.bookQuantityLB = new System.Windows.Forms.Label();
            this.conditionCBB = new System.Windows.Forms.ComboBox();
            this.conditionLB = new System.Windows.Forms.Label();
            this.supplyLB = new System.Windows.Forms.Label();
            this.supplyCBB = new System.Windows.Forms.ComboBox();
            this.publishNameLB = new System.Windows.Forms.Label();
            this.categoryLB = new System.Windows.Forms.Label();
            this.publishNameCBB = new System.Windows.Forms.ComboBox();
            this.authorLB = new System.Windows.Forms.Label();
            this.bookNameTB = new System.Windows.Forms.TextBox();
            this.bookNameLB = new System.Windows.Forms.Label();
            this.bookCodeTB = new System.Windows.Forms.TextBox();
            this.bookCodeLB = new System.Windows.Forms.Label();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.bookSelectPictureBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchBookContentTB = new System.Windows.Forms.TextBox();
            this.categoryRadioBtn = new System.Windows.Forms.RadioButton();
            this.authorRadioBtn = new System.Windows.Forms.RadioButton();
            this.bookNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.bookCodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.bookDGV = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bookExitBtn
            // 
            this.bookExitBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.bookExitBtn.IconColor = System.Drawing.Color.Black;
            this.bookExitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookExitBtn.IconSize = 30;
            this.bookExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookExitBtn.Location = new System.Drawing.Point(795, 316);
            this.bookExitBtn.Name = "bookExitBtn";
            this.bookExitBtn.Size = new System.Drawing.Size(85, 39);
            this.bookExitBtn.TabIndex = 41;
            this.bookExitBtn.Text = "Thoát";
            this.bookExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookExitBtn.UseVisualStyleBackColor = true;
            this.bookExitBtn.Click += new System.EventHandler(this.bookExitBtn_Click);
            // 
            // bookRemoveBtn
            // 
            this.bookRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bookRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.bookRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookRemoveBtn.IconSize = 30;
            this.bookRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookRemoveBtn.Location = new System.Drawing.Point(557, 316);
            this.bookRemoveBtn.Name = "bookRemoveBtn";
            this.bookRemoveBtn.Size = new System.Drawing.Size(76, 39);
            this.bookRemoveBtn.TabIndex = 40;
            this.bookRemoveBtn.Text = "Xoá";
            this.bookRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookRemoveBtn.UseVisualStyleBackColor = true;
            this.bookRemoveBtn.Click += new System.EventHandler(this.bookRemoveBtn_Click);
            // 
            // bookSaveBtn
            // 
            this.bookSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.bookSaveBtn.IconColor = System.Drawing.Color.Black;
            this.bookSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookSaveBtn.IconSize = 30;
            this.bookSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookSaveBtn.Location = new System.Drawing.Point(639, 316);
            this.bookSaveBtn.Name = "bookSaveBtn";
            this.bookSaveBtn.Size = new System.Drawing.Size(71, 39);
            this.bookSaveBtn.TabIndex = 39;
            this.bookSaveBtn.Text = "Lưu";
            this.bookSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookSaveBtn.UseVisualStyleBackColor = true;
            this.bookSaveBtn.Click += new System.EventHandler(this.bookSaveBtn_Click);
            // 
            // bookCancelBtn
            // 
            this.bookCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bookCancelBtn.IconColor = System.Drawing.Color.Black;
            this.bookCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookCancelBtn.IconSize = 30;
            this.bookCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookCancelBtn.Location = new System.Drawing.Point(716, 316);
            this.bookCancelBtn.Name = "bookCancelBtn";
            this.bookCancelBtn.Size = new System.Drawing.Size(73, 39);
            this.bookCancelBtn.TabIndex = 38;
            this.bookCancelBtn.Text = "Huỷ";
            this.bookCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookCancelBtn.UseVisualStyleBackColor = true;
            this.bookCancelBtn.Click += new System.EventHandler(this.bookCancelBtn_Click);
            // 
            // bookEditBtn
            // 
            this.bookEditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bookEditBtn.IconColor = System.Drawing.Color.Black;
            this.bookEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookEditBtn.IconSize = 30;
            this.bookEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookEditBtn.Location = new System.Drawing.Point(476, 316);
            this.bookEditBtn.Name = "bookEditBtn";
            this.bookEditBtn.Size = new System.Drawing.Size(75, 39);
            this.bookEditBtn.TabIndex = 37;
            this.bookEditBtn.Text = "Sửa";
            this.bookEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookEditBtn.UseVisualStyleBackColor = true;
            this.bookEditBtn.Click += new System.EventHandler(this.bookEditBtn_Click);
            // 
            // bookAddBtn
            // 
            this.bookAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bookAddBtn.IconColor = System.Drawing.Color.Black;
            this.bookAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookAddBtn.IconSize = 30;
            this.bookAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookAddBtn.Location = new System.Drawing.Point(383, 316);
            this.bookAddBtn.Name = "bookAddBtn";
            this.bookAddBtn.Size = new System.Drawing.Size(87, 39);
            this.bookAddBtn.TabIndex = 36;
            this.bookAddBtn.Text = "Thêm";
            this.bookAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookAddBtn.UseVisualStyleBackColor = true;
            this.bookAddBtn.Click += new System.EventHandler(this.bookAddBtn_Click);
            // 
            // bookRefreshBtn
            // 
            this.bookRefreshBtn.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.bookRefreshBtn.IconColor = System.Drawing.Color.Black;
            this.bookRefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookRefreshBtn.IconSize = 30;
            this.bookRefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookRefreshBtn.Location = new System.Drawing.Point(269, 316);
            this.bookRefreshBtn.Name = "bookRefreshBtn";
            this.bookRefreshBtn.Size = new System.Drawing.Size(108, 39);
            this.bookRefreshBtn.TabIndex = 35;
            this.bookRefreshBtn.Text = "Làm mới";
            this.bookRefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookRefreshBtn.UseVisualStyleBackColor = true;
            this.bookRefreshBtn.Click += new System.EventHandler(this.bookRefreshBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.authorListBox);
            this.groupBox6.Controls.Add(this.bookPriceTB);
            this.groupBox6.Controls.Add(this.bookPriceLB);
            this.groupBox6.Controls.Add(this.bookRemovePictureBtn);
            this.groupBox6.Controls.Add(this.categoryCBB);
            this.groupBox6.Controls.Add(this.publishYearTB);
            this.groupBox6.Controls.Add(this.publishYearLB);
            this.groupBox6.Controls.Add(this.bookQuantityTB);
            this.groupBox6.Controls.Add(this.bookQuantityLB);
            this.groupBox6.Controls.Add(this.conditionCBB);
            this.groupBox6.Controls.Add(this.conditionLB);
            this.groupBox6.Controls.Add(this.supplyLB);
            this.groupBox6.Controls.Add(this.supplyCBB);
            this.groupBox6.Controls.Add(this.publishNameLB);
            this.groupBox6.Controls.Add(this.categoryLB);
            this.groupBox6.Controls.Add(this.publishNameCBB);
            this.groupBox6.Controls.Add(this.authorLB);
            this.groupBox6.Controls.Add(this.bookNameTB);
            this.groupBox6.Controls.Add(this.bookNameLB);
            this.groupBox6.Controls.Add(this.bookCodeTB);
            this.groupBox6.Controls.Add(this.bookCodeLB);
            this.groupBox6.Controls.Add(this.bookPictureBox);
            this.groupBox6.Controls.Add(this.bookSelectPictureBtn);
            this.groupBox6.Location = new System.Drawing.Point(275, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1083, 295);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin tài liệu";
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.ItemHeight = 16;
            this.authorListBox.Location = new System.Drawing.Point(405, 93);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.authorListBox.Size = new System.Drawing.Size(218, 68);
            this.authorListBox.TabIndex = 37;
            this.authorListBox.TabStop = false;
            // 
            // bookPriceTB
            // 
            this.bookPriceTB.Location = new System.Drawing.Point(770, 167);
            this.bookPriceTB.Name = "bookPriceTB";
            this.bookPriceTB.Size = new System.Drawing.Size(218, 22);
            this.bookPriceTB.TabIndex = 35;
            // 
            // bookPriceLB
            // 
            this.bookPriceLB.AutoSize = true;
            this.bookPriceLB.Location = new System.Drawing.Point(729, 170);
            this.bookPriceLB.Name = "bookPriceLB";
            this.bookPriceLB.Size = new System.Drawing.Size(30, 17);
            this.bookPriceLB.TabIndex = 34;
            this.bookPriceLB.Text = "Giá";
            // 
            // bookRemovePictureBtn
            // 
            this.bookRemovePictureBtn.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.bookRemovePictureBtn.IconColor = System.Drawing.Color.Black;
            this.bookRemovePictureBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookRemovePictureBtn.IconSize = 30;
            this.bookRemovePictureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookRemovePictureBtn.Location = new System.Drawing.Point(139, 232);
            this.bookRemovePictureBtn.Name = "bookRemovePictureBtn";
            this.bookRemovePictureBtn.Size = new System.Drawing.Size(115, 47);
            this.bookRemovePictureBtn.TabIndex = 24;
            this.bookRemovePictureBtn.Text = "Xoá ảnh";
            this.bookRemovePictureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookRemovePictureBtn.UseVisualStyleBackColor = true;
            this.bookRemovePictureBtn.Click += new System.EventHandler(this.bookRemovePictureBtn_Click);
            // 
            // categoryCBB
            // 
            this.categoryCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCBB.FormattingEnabled = true;
            this.categoryCBB.Location = new System.Drawing.Point(405, 163);
            this.categoryCBB.Name = "categoryCBB";
            this.categoryCBB.Size = new System.Drawing.Size(218, 24);
            this.categoryCBB.TabIndex = 23;
            // 
            // publishYearTB
            // 
            this.publishYearTB.Location = new System.Drawing.Point(405, 197);
            this.publishYearTB.Name = "publishYearTB";
            this.publishYearTB.Size = new System.Drawing.Size(218, 22);
            this.publishYearTB.TabIndex = 22;
            // 
            // publishYearLB
            // 
            this.publishYearLB.AutoSize = true;
            this.publishYearLB.Location = new System.Drawing.Point(287, 200);
            this.publishYearLB.Name = "publishYearLB";
            this.publishYearLB.Size = new System.Drawing.Size(95, 17);
            this.publishYearLB.TabIndex = 21;
            this.publishYearLB.Text = "Năm xuất bản";
            // 
            // bookQuantityTB
            // 
            this.bookQuantityTB.Location = new System.Drawing.Point(770, 134);
            this.bookQuantityTB.Name = "bookQuantityTB";
            this.bookQuantityTB.Size = new System.Drawing.Size(218, 22);
            this.bookQuantityTB.TabIndex = 20;
            // 
            // bookQuantityLB
            // 
            this.bookQuantityLB.AutoSize = true;
            this.bookQuantityLB.Location = new System.Drawing.Point(690, 137);
            this.bookQuantityLB.Name = "bookQuantityLB";
            this.bookQuantityLB.Size = new System.Drawing.Size(64, 17);
            this.bookQuantityLB.TabIndex = 19;
            this.bookQuantityLB.Text = "Số lượng";
            // 
            // conditionCBB
            // 
            this.conditionCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionCBB.FormattingEnabled = true;
            this.conditionCBB.Location = new System.Drawing.Point(770, 100);
            this.conditionCBB.Name = "conditionCBB";
            this.conditionCBB.Size = new System.Drawing.Size(218, 24);
            this.conditionCBB.TabIndex = 18;
            // 
            // conditionLB
            // 
            this.conditionLB.AutoSize = true;
            this.conditionLB.Location = new System.Drawing.Point(680, 103);
            this.conditionLB.Name = "conditionLB";
            this.conditionLB.Size = new System.Drawing.Size(73, 17);
            this.conditionLB.TabIndex = 17;
            this.conditionLB.Text = "Tình trạng";
            // 
            // supplyLB
            // 
            this.supplyLB.AutoSize = true;
            this.supplyLB.Location = new System.Drawing.Point(652, 66);
            this.supplyLB.Name = "supplyLB";
            this.supplyLB.Size = new System.Drawing.Size(96, 17);
            this.supplyLB.TabIndex = 15;
            this.supplyLB.Text = "Nhà cung cấp";
            // 
            // supplyCBB
            // 
            this.supplyCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplyCBB.FormattingEnabled = true;
            this.supplyCBB.Location = new System.Drawing.Point(770, 63);
            this.supplyCBB.Name = "supplyCBB";
            this.supplyCBB.Size = new System.Drawing.Size(218, 24);
            this.supplyCBB.TabIndex = 14;
            // 
            // publishNameLB
            // 
            this.publishNameLB.AutoSize = true;
            this.publishNameLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publishNameLB.Location = new System.Drawing.Point(657, 32);
            this.publishNameLB.Name = "publishNameLB";
            this.publishNameLB.Size = new System.Drawing.Size(92, 17);
            this.publishNameLB.TabIndex = 13;
            this.publishNameLB.Text = "Nhà xuất bản";
            this.publishNameLB.Click += new System.EventHandler(this.publishNameLB_Click);
            // 
            // categoryLB
            // 
            this.categoryLB.AutoSize = true;
            this.categoryLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryLB.Location = new System.Drawing.Point(331, 166);
            this.categoryLB.Name = "categoryLB";
            this.categoryLB.Size = new System.Drawing.Size(59, 17);
            this.categoryLB.TabIndex = 11;
            this.categoryLB.Text = "Thể loại";
            this.categoryLB.Click += new System.EventHandler(this.categoryLB_Click);
            // 
            // publishNameCBB
            // 
            this.publishNameCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishNameCBB.FormattingEnabled = true;
            this.publishNameCBB.Location = new System.Drawing.Point(770, 29);
            this.publishNameCBB.Name = "publishNameCBB";
            this.publishNameCBB.Size = new System.Drawing.Size(218, 24);
            this.publishNameCBB.TabIndex = 3;
            // 
            // authorLB
            // 
            this.authorLB.AutoSize = true;
            this.authorLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorLB.Location = new System.Drawing.Point(335, 100);
            this.authorLB.Name = "authorLB";
            this.authorLB.Size = new System.Drawing.Size(55, 17);
            this.authorLB.TabIndex = 9;
            this.authorLB.Text = "Tác giả";
            this.authorLB.Click += new System.EventHandler(this.authorLB_Click);
            // 
            // bookNameTB
            // 
            this.bookNameTB.Location = new System.Drawing.Point(405, 60);
            this.bookNameTB.Name = "bookNameTB";
            this.bookNameTB.Size = new System.Drawing.Size(218, 22);
            this.bookNameTB.TabIndex = 8;
            // 
            // bookNameLB
            // 
            this.bookNameLB.AutoSize = true;
            this.bookNameLB.Location = new System.Drawing.Point(308, 63);
            this.bookNameLB.Name = "bookNameLB";
            this.bookNameLB.Size = new System.Drawing.Size(78, 17);
            this.bookNameLB.TabIndex = 7;
            this.bookNameLB.Text = "Tên tài liệu";
            // 
            // bookCodeTB
            // 
            this.bookCodeTB.Location = new System.Drawing.Point(405, 27);
            this.bookCodeTB.Name = "bookCodeTB";
            this.bookCodeTB.ReadOnly = true;
            this.bookCodeTB.Size = new System.Drawing.Size(218, 22);
            this.bookCodeTB.TabIndex = 6;
            // 
            // bookCodeLB
            // 
            this.bookCodeLB.AutoSize = true;
            this.bookCodeLB.Location = new System.Drawing.Point(313, 32);
            this.bookCodeLB.Name = "bookCodeLB";
            this.bookCodeLB.Size = new System.Drawing.Size(72, 17);
            this.bookCodeLB.TabIndex = 3;
            this.bookCodeLB.Text = "Mã tài liệu";
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPictureBox.Location = new System.Drawing.Point(35, 26);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(200, 200);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPictureBox.TabIndex = 1;
            this.bookPictureBox.TabStop = false;
            // 
            // bookSelectPictureBtn
            // 
            this.bookSelectPictureBtn.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.bookSelectPictureBtn.IconColor = System.Drawing.Color.Black;
            this.bookSelectPictureBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookSelectPictureBtn.IconSize = 30;
            this.bookSelectPictureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookSelectPictureBtn.Location = new System.Drawing.Point(18, 232);
            this.bookSelectPictureBtn.Name = "bookSelectPictureBtn";
            this.bookSelectPictureBtn.Size = new System.Drawing.Size(115, 47);
            this.bookSelectPictureBtn.TabIndex = 2;
            this.bookSelectPictureBtn.Text = "Chọn ảnh";
            this.bookSelectPictureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookSelectPictureBtn.UseVisualStyleBackColor = true;
            this.bookSelectPictureBtn.Click += new System.EventHandler(this.bookSelectPictureBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchBookContentTB);
            this.groupBox5.Controls.Add(this.categoryRadioBtn);
            this.groupBox5.Controls.Add(this.authorRadioBtn);
            this.groupBox5.Controls.Add(this.bookNameRadioBtn);
            this.groupBox5.Controls.Add(this.bookCodeRadioBtn);
            this.groupBox5.Location = new System.Drawing.Point(18, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 295);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // searchBookContentTB
            // 
            this.searchBookContentTB.Location = new System.Drawing.Point(19, 111);
            this.searchBookContentTB.Name = "searchBookContentTB";
            this.searchBookContentTB.Size = new System.Drawing.Size(218, 22);
            this.searchBookContentTB.TabIndex = 5;
            this.searchBookContentTB.TabStop = false;
            this.searchBookContentTB.TextChanged += new System.EventHandler(this.searchBookContentTB_TextChanged);
            // 
            // categoryRadioBtn
            // 
            this.categoryRadioBtn.AutoSize = true;
            this.categoryRadioBtn.Location = new System.Drawing.Point(152, 71);
            this.categoryRadioBtn.Name = "categoryRadioBtn";
            this.categoryRadioBtn.Size = new System.Drawing.Size(80, 21);
            this.categoryRadioBtn.TabIndex = 3;
            this.categoryRadioBtn.Text = "Thể loại";
            this.categoryRadioBtn.UseVisualStyleBackColor = true;
            this.categoryRadioBtn.CheckedChanged += new System.EventHandler(this.categoryRadioBtn_CheckedChanged);
            // 
            // authorRadioBtn
            // 
            this.authorRadioBtn.AutoSize = true;
            this.authorRadioBtn.Location = new System.Drawing.Point(152, 41);
            this.authorRadioBtn.Name = "authorRadioBtn";
            this.authorRadioBtn.Size = new System.Drawing.Size(76, 21);
            this.authorRadioBtn.TabIndex = 2;
            this.authorRadioBtn.Text = "Tác giả";
            this.authorRadioBtn.UseVisualStyleBackColor = true;
            this.authorRadioBtn.CheckedChanged += new System.EventHandler(this.authorRadioBtn_CheckedChanged);
            // 
            // bookNameRadioBtn
            // 
            this.bookNameRadioBtn.AutoSize = true;
            this.bookNameRadioBtn.Location = new System.Drawing.Point(19, 71);
            this.bookNameRadioBtn.Name = "bookNameRadioBtn";
            this.bookNameRadioBtn.Size = new System.Drawing.Size(99, 21);
            this.bookNameRadioBtn.TabIndex = 1;
            this.bookNameRadioBtn.Text = "Tên tài liệu";
            this.bookNameRadioBtn.UseVisualStyleBackColor = true;
            this.bookNameRadioBtn.CheckedChanged += new System.EventHandler(this.bookNameRadioBtn_CheckedChanged);
            // 
            // bookCodeRadioBtn
            // 
            this.bookCodeRadioBtn.AutoSize = true;
            this.bookCodeRadioBtn.Location = new System.Drawing.Point(19, 41);
            this.bookCodeRadioBtn.Name = "bookCodeRadioBtn";
            this.bookCodeRadioBtn.Size = new System.Drawing.Size(93, 21);
            this.bookCodeRadioBtn.TabIndex = 0;
            this.bookCodeRadioBtn.Text = "Mã tài liệu";
            this.bookCodeRadioBtn.UseVisualStyleBackColor = true;
            this.bookCodeRadioBtn.CheckedChanged += new System.EventHandler(this.bookCodeRadioBtn_CheckedChanged);
            // 
            // bookDGV
            // 
            this.bookDGV.AllowUserToAddRows = false;
            this.bookDGV.AllowUserToDeleteRows = false;
            this.bookDGV.AllowUserToResizeColumns = false;
            this.bookDGV.AllowUserToResizeRows = false;
            this.bookDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDGV.Location = new System.Drawing.Point(18, 373);
            this.bookDGV.Name = "bookDGV";
            this.bookDGV.RowHeadersWidth = 51;
            this.bookDGV.RowTemplate.Height = 24;
            this.bookDGV.Size = new System.Drawing.Size(1340, 227);
            this.bookDGV.TabIndex = 42;
            this.bookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDGV_CellClick);
            this.bookDGV.Sorted += new System.EventHandler(this.bookDGV_Sorted);
            // 
            // BookManageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bookDGV);
            this.Controls.Add(this.bookExitBtn);
            this.Controls.Add(this.bookRemoveBtn);
            this.Controls.Add(this.bookSaveBtn);
            this.Controls.Add(this.bookCancelBtn);
            this.Controls.Add(this.bookEditBtn);
            this.Controls.Add(this.bookAddBtn);
            this.Controls.Add(this.bookRefreshBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "BookManageControl";
            this.Size = new System.Drawing.Size(1376, 619);
            this.Load += new System.EventHandler(this.BookManageControl_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton bookExitBtn;
        private FontAwesome.Sharp.IconButton bookRemoveBtn;
        private FontAwesome.Sharp.IconButton bookSaveBtn;
        private FontAwesome.Sharp.IconButton bookCancelBtn;
        private FontAwesome.Sharp.IconButton bookEditBtn;
        private FontAwesome.Sharp.IconButton bookAddBtn;
        private FontAwesome.Sharp.IconButton bookRefreshBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox bookPriceTB;
        private System.Windows.Forms.Label bookPriceLB;
        private FontAwesome.Sharp.IconButton bookRemovePictureBtn;
        private System.Windows.Forms.ComboBox categoryCBB;
        private System.Windows.Forms.TextBox publishYearTB;
        private System.Windows.Forms.Label publishYearLB;
        private System.Windows.Forms.TextBox bookQuantityTB;
        private System.Windows.Forms.Label bookQuantityLB;
        private System.Windows.Forms.ComboBox conditionCBB;
        private System.Windows.Forms.Label conditionLB;
        private System.Windows.Forms.Label supplyLB;
        private System.Windows.Forms.ComboBox supplyCBB;
        private System.Windows.Forms.Label publishNameLB;
        private System.Windows.Forms.Label categoryLB;
        private System.Windows.Forms.ComboBox publishNameCBB;
        private System.Windows.Forms.Label authorLB;
        private System.Windows.Forms.TextBox bookNameTB;
        private System.Windows.Forms.Label bookNameLB;
        private System.Windows.Forms.TextBox bookCodeTB;
        private System.Windows.Forms.Label bookCodeLB;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private FontAwesome.Sharp.IconButton bookSelectPictureBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox searchBookContentTB;
        private System.Windows.Forms.RadioButton categoryRadioBtn;
        private System.Windows.Forms.RadioButton authorRadioBtn;
        private System.Windows.Forms.RadioButton bookNameRadioBtn;
        private System.Windows.Forms.RadioButton bookCodeRadioBtn;
        private System.Windows.Forms.DataGridView bookDGV;
        private System.Windows.Forms.ListBox authorListBox;
    }
}
