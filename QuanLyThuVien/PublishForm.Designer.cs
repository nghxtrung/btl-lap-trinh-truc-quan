
namespace QuanLyThuVien
{
    partial class PublishForm
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
            this.publishCodeLB = new System.Windows.Forms.Label();
            this.publishCodeTB = new System.Windows.Forms.TextBox();
            this.publishAddBtn = new FontAwesome.Sharp.IconButton();
            this.publishDGV = new System.Windows.Forms.DataGridView();
            this.publishNameTB = new System.Windows.Forms.TextBox();
            this.publishNameLB = new System.Windows.Forms.Label();
            this.publishEditBtn = new FontAwesome.Sharp.IconButton();
            this.publishRemoveBtn = new FontAwesome.Sharp.IconButton();
            this.publishSaveBtn = new FontAwesome.Sharp.IconButton();
            this.publishCancelBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.publishDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // publishCodeLB
            // 
            this.publishCodeLB.AutoSize = true;
            this.publishCodeLB.Location = new System.Drawing.Point(46, 48);
            this.publishCodeLB.Name = "publishCodeLB";
            this.publishCodeLB.Size = new System.Drawing.Size(132, 20);
            this.publishCodeLB.TabIndex = 0;
            this.publishCodeLB.Text = "Mã nhà xuất bản";
            // 
            // publishCodeTB
            // 
            this.publishCodeTB.Location = new System.Drawing.Point(184, 45);
            this.publishCodeTB.Name = "publishCodeTB";
            this.publishCodeTB.ReadOnly = true;
            this.publishCodeTB.Size = new System.Drawing.Size(285, 27);
            this.publishCodeTB.TabIndex = 1;
            this.publishCodeTB.TabStop = false;
            // 
            // publishAddBtn
            // 
            this.publishAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.publishAddBtn.IconColor = System.Drawing.Color.Black;
            this.publishAddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publishAddBtn.IconSize = 30;
            this.publishAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishAddBtn.Location = new System.Drawing.Point(83, 111);
            this.publishAddBtn.Name = "publishAddBtn";
            this.publishAddBtn.Size = new System.Drawing.Size(86, 45);
            this.publishAddBtn.TabIndex = 2;
            this.publishAddBtn.Text = "Thêm";
            this.publishAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.publishAddBtn.UseVisualStyleBackColor = true;
            this.publishAddBtn.Click += new System.EventHandler(this.publishAddBtn_Click);
            // 
            // publishDGV
            // 
            this.publishDGV.AllowUserToAddRows = false;
            this.publishDGV.AllowUserToDeleteRows = false;
            this.publishDGV.AllowUserToResizeColumns = false;
            this.publishDGV.AllowUserToResizeRows = false;
            this.publishDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.publishDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishDGV.Location = new System.Drawing.Point(12, 162);
            this.publishDGV.Name = "publishDGV";
            this.publishDGV.ReadOnly = true;
            this.publishDGV.RowHeadersWidth = 51;
            this.publishDGV.RowTemplate.Height = 24;
            this.publishDGV.Size = new System.Drawing.Size(681, 244);
            this.publishDGV.TabIndex = 3;
            this.publishDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.publishDGV_CellClick);
            // 
            // publishNameTB
            // 
            this.publishNameTB.Location = new System.Drawing.Point(184, 78);
            this.publishNameTB.Name = "publishNameTB";
            this.publishNameTB.ReadOnly = true;
            this.publishNameTB.Size = new System.Drawing.Size(285, 27);
            this.publishNameTB.TabIndex = 5;
            this.publishNameTB.TabStop = false;
            // 
            // publishNameLB
            // 
            this.publishNameLB.AutoSize = true;
            this.publishNameLB.Location = new System.Drawing.Point(41, 81);
            this.publishNameLB.Name = "publishNameLB";
            this.publishNameLB.Size = new System.Drawing.Size(137, 20);
            this.publishNameLB.TabIndex = 4;
            this.publishNameLB.Text = "Tên nhà xuất bản";
            // 
            // publishEditBtn
            // 
            this.publishEditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.publishEditBtn.IconColor = System.Drawing.Color.Black;
            this.publishEditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publishEditBtn.IconSize = 30;
            this.publishEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishEditBtn.Location = new System.Drawing.Point(175, 111);
            this.publishEditBtn.Name = "publishEditBtn";
            this.publishEditBtn.Size = new System.Drawing.Size(70, 45);
            this.publishEditBtn.TabIndex = 6;
            this.publishEditBtn.Text = "Sửa";
            this.publishEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.publishEditBtn.UseVisualStyleBackColor = true;
            this.publishEditBtn.Click += new System.EventHandler(this.publishEditBtn_Click);
            // 
            // publishRemoveBtn
            // 
            this.publishRemoveBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.publishRemoveBtn.IconColor = System.Drawing.Color.Black;
            this.publishRemoveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publishRemoveBtn.IconSize = 30;
            this.publishRemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishRemoveBtn.Location = new System.Drawing.Point(251, 111);
            this.publishRemoveBtn.Name = "publishRemoveBtn";
            this.publishRemoveBtn.Size = new System.Drawing.Size(76, 45);
            this.publishRemoveBtn.TabIndex = 7;
            this.publishRemoveBtn.Text = "Xoá";
            this.publishRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.publishRemoveBtn.UseVisualStyleBackColor = true;
            this.publishRemoveBtn.Click += new System.EventHandler(this.publishRemoveBtn_Click);
            // 
            // publishSaveBtn
            // 
            this.publishSaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.publishSaveBtn.IconColor = System.Drawing.Color.Black;
            this.publishSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publishSaveBtn.IconSize = 30;
            this.publishSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishSaveBtn.Location = new System.Drawing.Point(333, 111);
            this.publishSaveBtn.Name = "publishSaveBtn";
            this.publishSaveBtn.Size = new System.Drawing.Size(72, 45);
            this.publishSaveBtn.TabIndex = 8;
            this.publishSaveBtn.Text = "Lưu";
            this.publishSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.publishSaveBtn.UseVisualStyleBackColor = true;
            this.publishSaveBtn.Click += new System.EventHandler(this.publishSaveBtn_Click);
            // 
            // publishCancelBtn
            // 
            this.publishCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.publishCancelBtn.IconColor = System.Drawing.Color.Black;
            this.publishCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publishCancelBtn.IconSize = 30;
            this.publishCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishCancelBtn.Location = new System.Drawing.Point(411, 111);
            this.publishCancelBtn.Name = "publishCancelBtn";
            this.publishCancelBtn.Size = new System.Drawing.Size(73, 45);
            this.publishCancelBtn.TabIndex = 9;
            this.publishCancelBtn.Text = "Huỷ";
            this.publishCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.publishCancelBtn.UseVisualStyleBackColor = true;
            this.publishCancelBtn.Click += new System.EventHandler(this.publishCancelBtn_Click);
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 422);
            this.Controls.Add(this.publishCancelBtn);
            this.Controls.Add(this.publishSaveBtn);
            this.Controls.Add(this.publishRemoveBtn);
            this.Controls.Add(this.publishEditBtn);
            this.Controls.Add(this.publishNameTB);
            this.Controls.Add(this.publishNameLB);
            this.Controls.Add(this.publishDGV);
            this.Controls.Add(this.publishAddBtn);
            this.Controls.Add(this.publishCodeTB);
            this.Controls.Add(this.publishCodeLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PublishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.PublishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label publishCodeLB;
        private System.Windows.Forms.TextBox publishCodeTB;
        private FontAwesome.Sharp.IconButton publishAddBtn;
        private System.Windows.Forms.DataGridView publishDGV;
        private System.Windows.Forms.TextBox publishNameTB;
        private System.Windows.Forms.Label publishNameLB;
        private FontAwesome.Sharp.IconButton publishEditBtn;
        private FontAwesome.Sharp.IconButton publishRemoveBtn;
        private FontAwesome.Sharp.IconButton publishSaveBtn;
        private FontAwesome.Sharp.IconButton publishCancelBtn;
    }
}