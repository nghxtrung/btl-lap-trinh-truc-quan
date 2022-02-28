
namespace QuanLyThuVien
{
    partial class AuthorForm
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
            this.authorCodeLB = new System.Windows.Forms.Label();
            this.authorCodeTB = new System.Windows.Forms.TextBox();
            this.authorAddBtn = new FontAwesome.Sharp.IconButton();
            this.authorDGV = new System.Windows.Forms.DataGridView();
            this.authorEditBtn = new FontAwesome.Sharp.IconButton();
            this.authorRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.authorNameTB = new System.Windows.Forms.TextBox();
            this.authorNameLB = new System.Windows.Forms.Label();
            this.authorSelectedBtn = new FontAwesome.Sharp.IconButton();
            this.authorSaveBtn = new FontAwesome.Sharp.IconButton();
            this.authorCancelBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.authorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // authorCodeLB
            // 
            this.authorCodeLB.AutoSize = true;
            this.authorCodeLB.Location = new System.Drawing.Point(37, 41);
            this.authorCodeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorCodeLB.Name = "authorCodeLB";
            this.authorCodeLB.Size = new System.Drawing.Size(87, 20);
            this.authorCodeLB.TabIndex = 0;
            this.authorCodeLB.Text = "Mã tác giả";
            // 
            // authorCodeTB
            // 
            this.authorCodeTB.Location = new System.Drawing.Point(132, 38);
            this.authorCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.authorCodeTB.Name = "authorCodeTB";
            this.authorCodeTB.ReadOnly = true;
            this.authorCodeTB.Size = new System.Drawing.Size(249, 27);
            this.authorCodeTB.TabIndex = 1;
            this.authorCodeTB.TabStop = false;
            // 
            // authorAddBtn
            // 
            this.authorAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.authorAddBtn.IconColor = System.Drawing.Color.Black;
            this.authorAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorAddBtn.IconSize = 30;
            this.authorAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorAddBtn.Location = new System.Drawing.Point(55, 107);
            this.authorAddBtn.Name = "authorAddBtn";
            this.authorAddBtn.Size = new System.Drawing.Size(87, 46);
            this.authorAddBtn.TabIndex = 2;
            this.authorAddBtn.Text = "Thêm";
            this.authorAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorAddBtn.UseVisualStyleBackColor = true;
            this.authorAddBtn.Click += new System.EventHandler(this.authorAddBtn_Click);
            // 
            // authorDGV
            // 
            this.authorDGV.AllowUserToAddRows = false;
            this.authorDGV.AllowUserToDeleteRows = false;
            this.authorDGV.AllowUserToResizeColumns = false;
            this.authorDGV.AllowUserToResizeRows = false;
            this.authorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDGV.Location = new System.Drawing.Point(12, 159);
            this.authorDGV.Name = "authorDGV";
            this.authorDGV.RowHeadersWidth = 51;
            this.authorDGV.RowTemplate.Height = 24;
            this.authorDGV.Size = new System.Drawing.Size(686, 251);
            this.authorDGV.TabIndex = 3;
            this.authorDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorDGV_CellClick);
            this.authorDGV.Sorted += new System.EventHandler(this.authorDGV_Sorted);
            // 
            // authorEditBtn
            // 
            this.authorEditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.authorEditBtn.IconColor = System.Drawing.Color.Black;
            this.authorEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorEditBtn.IconSize = 30;
            this.authorEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorEditBtn.Location = new System.Drawing.Point(148, 107);
            this.authorEditBtn.Name = "authorEditBtn";
            this.authorEditBtn.Size = new System.Drawing.Size(74, 46);
            this.authorEditBtn.TabIndex = 4;
            this.authorEditBtn.Text = "Sửa";
            this.authorEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorEditBtn.UseVisualStyleBackColor = true;
            this.authorEditBtn.Click += new System.EventHandler(this.authorEditBtn_Click);
            // 
            // authorRemoveBtn
            // 
            this.authorRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.authorRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.authorRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorRemoveBtn.IconSize = 30;
            this.authorRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorRemoveBtn.Location = new System.Drawing.Point(228, 107);
            this.authorRemoveBtn.Name = "authorRemoveBtn";
            this.authorRemoveBtn.Size = new System.Drawing.Size(73, 46);
            this.authorRemoveBtn.TabIndex = 5;
            this.authorRemoveBtn.Text = "Xoá";
            this.authorRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorRemoveBtn.UseVisualStyleBackColor = true;
            this.authorRemoveBtn.Click += new System.EventHandler(this.authorRemoveBtn_Click);
            // 
            // authorNameTB
            // 
            this.authorNameTB.Location = new System.Drawing.Point(132, 73);
            this.authorNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.authorNameTB.Name = "authorNameTB";
            this.authorNameTB.Size = new System.Drawing.Size(249, 27);
            this.authorNameTB.TabIndex = 7;
            this.authorNameTB.TabStop = false;
            // 
            // authorNameLB
            // 
            this.authorNameLB.AutoSize = true;
            this.authorNameLB.Location = new System.Drawing.Point(32, 76);
            this.authorNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorNameLB.Name = "authorNameLB";
            this.authorNameLB.Size = new System.Drawing.Size(92, 20);
            this.authorNameLB.TabIndex = 6;
            this.authorNameLB.Text = "Tên tác giả";
            // 
            // authorSelectedBtn
            // 
            this.authorSelectedBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.authorSelectedBtn.IconColor = System.Drawing.Color.Black;
            this.authorSelectedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorSelectedBtn.IconSize = 30;
            this.authorSelectedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorSelectedBtn.Location = new System.Drawing.Point(465, 107);
            this.authorSelectedBtn.Name = "authorSelectedBtn";
            this.authorSelectedBtn.Size = new System.Drawing.Size(82, 46);
            this.authorSelectedBtn.TabIndex = 8;
            this.authorSelectedBtn.Text = "Chọn";
            this.authorSelectedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorSelectedBtn.UseVisualStyleBackColor = true;
            this.authorSelectedBtn.Click += new System.EventHandler(this.authorSelectedBtn_Click);
            // 
            // authorSaveBtn
            // 
            this.authorSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.authorSaveBtn.IconColor = System.Drawing.Color.Black;
            this.authorSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorSaveBtn.IconSize = 30;
            this.authorSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorSaveBtn.Location = new System.Drawing.Point(307, 107);
            this.authorSaveBtn.Name = "authorSaveBtn";
            this.authorSaveBtn.Size = new System.Drawing.Size(73, 46);
            this.authorSaveBtn.TabIndex = 9;
            this.authorSaveBtn.Text = "Lưu";
            this.authorSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorSaveBtn.UseVisualStyleBackColor = true;
            this.authorSaveBtn.Click += new System.EventHandler(this.authorSaveBtn_Click);
            // 
            // authorCancelBtn
            // 
            this.authorCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.authorCancelBtn.IconColor = System.Drawing.Color.Black;
            this.authorCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorCancelBtn.IconSize = 30;
            this.authorCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorCancelBtn.Location = new System.Drawing.Point(386, 107);
            this.authorCancelBtn.Name = "authorCancelBtn";
            this.authorCancelBtn.Size = new System.Drawing.Size(73, 46);
            this.authorCancelBtn.TabIndex = 10;
            this.authorCancelBtn.Text = "Huỷ";
            this.authorCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.authorCancelBtn.UseVisualStyleBackColor = true;
            this.authorCancelBtn.Click += new System.EventHandler(this.authorCancelBtn_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 422);
            this.Controls.Add(this.authorCancelBtn);
            this.Controls.Add(this.authorSaveBtn);
            this.Controls.Add(this.authorSelectedBtn);
            this.Controls.Add(this.authorNameTB);
            this.Controls.Add(this.authorNameLB);
            this.Controls.Add(this.authorRemoveBtn);
            this.Controls.Add(this.authorEditBtn);
            this.Controls.Add(this.authorDGV);
            this.Controls.Add(this.authorAddBtn);
            this.Controls.Add(this.authorCodeTB);
            this.Controls.Add(this.authorCodeLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorCodeLB;
        private System.Windows.Forms.TextBox authorCodeTB;
        private FontAwesome.Sharp.IconButton authorAddBtn;
        private System.Windows.Forms.DataGridView authorDGV;
        private FontAwesome.Sharp.IconButton authorEditBtn;
        private FontAwesome.Sharp.IconButton authorRemoveBtn;
        private System.Windows.Forms.TextBox authorNameTB;
        private System.Windows.Forms.Label authorNameLB;
        private FontAwesome.Sharp.IconButton authorSelectedBtn;
        private FontAwesome.Sharp.IconButton authorSaveBtn;
        private FontAwesome.Sharp.IconButton authorCancelBtn;
    }
}