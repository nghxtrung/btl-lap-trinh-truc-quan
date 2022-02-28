
namespace QuanLyThuVien
{
    partial class CategoryForm
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
            this.categoryCodeLB = new System.Windows.Forms.Label();
            this.categoryCodeTB = new System.Windows.Forms.TextBox();
            this.categoryAddBtn = new FontAwesome.Sharp.IconButton();
            this.categoryDGV = new System.Windows.Forms.DataGridView();
            this.categoryNameTB = new System.Windows.Forms.TextBox();
            this.categoryNameLB = new System.Windows.Forms.Label();
            this.categoryEditBtn = new FontAwesome.Sharp.IconButton();
            this.categoryRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.categorySaveBtn = new FontAwesome.Sharp.IconButton();
            this.categoryCancelBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryCodeLB
            // 
            this.categoryCodeLB.AutoSize = true;
            this.categoryCodeLB.Location = new System.Drawing.Point(58, 57);
            this.categoryCodeLB.Name = "categoryCodeLB";
            this.categoryCodeLB.Size = new System.Drawing.Size(91, 20);
            this.categoryCodeLB.TabIndex = 0;
            this.categoryCodeLB.Text = "Mã thể loại";
            // 
            // categoryCodeTB
            // 
            this.categoryCodeTB.Location = new System.Drawing.Point(155, 54);
            this.categoryCodeTB.Name = "categoryCodeTB";
            this.categoryCodeTB.ReadOnly = true;
            this.categoryCodeTB.Size = new System.Drawing.Size(235, 27);
            this.categoryCodeTB.TabIndex = 1;
            this.categoryCodeTB.TabStop = false;
            // 
            // categoryAddBtn
            // 
            this.categoryAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.categoryAddBtn.IconColor = System.Drawing.Color.Black;
            this.categoryAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoryAddBtn.IconSize = 30;
            this.categoryAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryAddBtn.Location = new System.Drawing.Point(62, 120);
            this.categoryAddBtn.Name = "categoryAddBtn";
            this.categoryAddBtn.Size = new System.Drawing.Size(87, 47);
            this.categoryAddBtn.TabIndex = 2;
            this.categoryAddBtn.Text = "Thêm";
            this.categoryAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryAddBtn.UseVisualStyleBackColor = true;
            this.categoryAddBtn.Click += new System.EventHandler(this.categoryAddBtn_Click);
            // 
            // categoryDGV
            // 
            this.categoryDGV.AllowUserToAddRows = false;
            this.categoryDGV.AllowUserToDeleteRows = false;
            this.categoryDGV.AllowUserToResizeColumns = false;
            this.categoryDGV.AllowUserToResizeRows = false;
            this.categoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDGV.Location = new System.Drawing.Point(12, 173);
            this.categoryDGV.Name = "categoryDGV";
            this.categoryDGV.ReadOnly = true;
            this.categoryDGV.RowHeadersWidth = 51;
            this.categoryDGV.RowTemplate.Height = 24;
            this.categoryDGV.Size = new System.Drawing.Size(686, 237);
            this.categoryDGV.TabIndex = 3;
            this.categoryDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDGV_CellClick);
            // 
            // categoryNameTB
            // 
            this.categoryNameTB.Location = new System.Drawing.Point(155, 87);
            this.categoryNameTB.Name = "categoryNameTB";
            this.categoryNameTB.ReadOnly = true;
            this.categoryNameTB.Size = new System.Drawing.Size(235, 27);
            this.categoryNameTB.TabIndex = 5;
            this.categoryNameTB.TabStop = false;
            // 
            // categoryNameLB
            // 
            this.categoryNameLB.AutoSize = true;
            this.categoryNameLB.Location = new System.Drawing.Point(53, 90);
            this.categoryNameLB.Name = "categoryNameLB";
            this.categoryNameLB.Size = new System.Drawing.Size(96, 20);
            this.categoryNameLB.TabIndex = 4;
            this.categoryNameLB.Text = "Tên thể loại";
            // 
            // categoryEditBtn
            // 
            this.categoryEditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.categoryEditBtn.IconColor = System.Drawing.Color.Black;
            this.categoryEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoryEditBtn.IconSize = 30;
            this.categoryEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryEditBtn.Location = new System.Drawing.Point(153, 120);
            this.categoryEditBtn.Name = "categoryEditBtn";
            this.categoryEditBtn.Size = new System.Drawing.Size(74, 47);
            this.categoryEditBtn.TabIndex = 6;
            this.categoryEditBtn.Text = "Sửa";
            this.categoryEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryEditBtn.UseVisualStyleBackColor = true;
            this.categoryEditBtn.Click += new System.EventHandler(this.categoryEditBtn_Click);
            // 
            // categoryRemoveBtn
            // 
            this.categoryRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.categoryRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.categoryRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoryRemoveBtn.IconSize = 30;
            this.categoryRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryRemoveBtn.Location = new System.Drawing.Point(233, 120);
            this.categoryRemoveBtn.Name = "categoryRemoveBtn";
            this.categoryRemoveBtn.Size = new System.Drawing.Size(74, 47);
            this.categoryRemoveBtn.TabIndex = 7;
            this.categoryRemoveBtn.Text = "Xoá";
            this.categoryRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryRemoveBtn.UseVisualStyleBackColor = true;
            this.categoryRemoveBtn.Click += new System.EventHandler(this.categoryRemoveBtn_Click);
            // 
            // categorySaveBtn
            // 
            this.categorySaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.categorySaveBtn.IconColor = System.Drawing.Color.Black;
            this.categorySaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categorySaveBtn.IconSize = 30;
            this.categorySaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorySaveBtn.Location = new System.Drawing.Point(313, 120);
            this.categorySaveBtn.Name = "categorySaveBtn";
            this.categorySaveBtn.Size = new System.Drawing.Size(75, 47);
            this.categorySaveBtn.TabIndex = 8;
            this.categorySaveBtn.Text = "Lưu";
            this.categorySaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categorySaveBtn.UseVisualStyleBackColor = true;
            this.categorySaveBtn.Click += new System.EventHandler(this.categorySaveBtn_Click);
            // 
            // categoryCancelBtn
            // 
            this.categoryCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.categoryCancelBtn.IconColor = System.Drawing.Color.Black;
            this.categoryCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoryCancelBtn.IconSize = 30;
            this.categoryCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryCancelBtn.Location = new System.Drawing.Point(394, 120);
            this.categoryCancelBtn.Name = "categoryCancelBtn";
            this.categoryCancelBtn.Size = new System.Drawing.Size(73, 47);
            this.categoryCancelBtn.TabIndex = 9;
            this.categoryCancelBtn.Text = "Huỷ";
            this.categoryCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryCancelBtn.UseVisualStyleBackColor = true;
            this.categoryCancelBtn.Click += new System.EventHandler(this.categoryCancelBtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 422);
            this.Controls.Add(this.categoryCancelBtn);
            this.Controls.Add(this.categorySaveBtn);
            this.Controls.Add(this.categoryRemoveBtn);
            this.Controls.Add(this.categoryEditBtn);
            this.Controls.Add(this.categoryNameTB);
            this.Controls.Add(this.categoryNameLB);
            this.Controls.Add(this.categoryDGV);
            this.Controls.Add(this.categoryAddBtn);
            this.Controls.Add(this.categoryCodeTB);
            this.Controls.Add(this.categoryCodeLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryCodeLB;
        private System.Windows.Forms.TextBox categoryCodeTB;
        private FontAwesome.Sharp.IconButton categoryAddBtn;
        private System.Windows.Forms.DataGridView categoryDGV;
        private System.Windows.Forms.TextBox categoryNameTB;
        private System.Windows.Forms.Label categoryNameLB;
        private FontAwesome.Sharp.IconButton categoryEditBtn;
        private FontAwesome.Sharp.IconButton categoryRemoveBtn;
        private FontAwesome.Sharp.IconButton categorySaveBtn;
        private FontAwesome.Sharp.IconButton categoryCancelBtn;
    }
}