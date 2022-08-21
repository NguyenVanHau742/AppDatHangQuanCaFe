
namespace WinformDatBan
{
    partial class FrmDatMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatMon));
            this.lstViewDatMon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnHuyMon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.lstBanAn = new System.Windows.Forms.ListView();
            this.ilistBanAn = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbLoaiBan = new System.Windows.Forms.Label();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDay = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewDatMon
            // 
            this.lstViewDatMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewDatMon.FullRowSelect = true;
            this.lstViewDatMon.GridLines = true;
            this.lstViewDatMon.HideSelection = false;
            this.lstViewDatMon.Location = new System.Drawing.Point(1016, 316);
            this.lstViewDatMon.Name = "lstViewDatMon";
            this.lstViewDatMon.Size = new System.Drawing.Size(518, 395);
            this.lstViewDatMon.TabIndex = 1;
            this.lstViewDatMon.UseCompatibleStateImageBehavior = false;
            this.lstViewDatMon.View = System.Windows.Forms.View.Details;
            this.lstViewDatMon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewDatMon_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi Chú";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(486, 220);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(134, 71);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "THÊM MÓN";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnHuyMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyMon.Location = new System.Drawing.Point(676, 220);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(134, 71);
            this.btnHuyMon.TabIndex = 3;
            this.btnHuyMon.Text = "BỚT MÓN";
            this.btnHuyMon.UseVisualStyleBackColor = true;
            this.btnHuyMon.Click += new System.EventHandler(this.btnHuyMon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(482, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(605, 116);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 22);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WinformDatBan.Properties.Resources.search1;
            this.pictureBox3.Location = new System.Drawing.Point(1016, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WinformDatBan.Properties.Resources.dinner;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinformDatBan.Properties.Resources.LogoTitTrenMay;
            this.pictureBox1.Location = new System.Drawing.Point(1317, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(620, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "DANH SÁCH MÓN ĂN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1178, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "ĐƠN ĐẶT MÓN ĂN";
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(876, 220);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(134, 71);
            this.btnDatHang.TabIndex = 4;
            this.btnDatHang.Text = "ĐẶT HÀNG";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(486, 316);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.RowTemplate.Height = 24;
            this.dgvMonAn.Size = new System.Drawing.Size(524, 395);
            this.dgvMonAn.TabIndex = 14;
            this.dgvMonAn.Click += new System.EventHandler(this.dgvMonAn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(456, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên Loại SP:";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(605, 164);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(405, 24);
            this.cbLoai.TabIndex = 15;
            this.cbLoai.SelectionChangeCommitted += new System.EventHandler(this.cbLoai_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1028, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số Lượng:";
            // 
            // btnTang
            // 
            this.btnTang.BackColor = System.Drawing.SystemColors.Control;
            this.btnTang.BackgroundImage = global::WinformDatBan.Properties.Resources.backgroundDangNhap;
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnTang.Location = new System.Drawing.Point(1128, 248);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(69, 23);
            this.btnTang.TabIndex = 18;
            this.btnTang.Text = "TĂNG";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.BackgroundImage = global::WinformDatBan.Properties.Resources.backgroundDangNhap;
            this.btnGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnGiam.Location = new System.Drawing.Point(1128, 284);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(69, 23);
            this.btnGiam.TabIndex = 19;
            this.btnGiam.Text = "GIẢM";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // lstBanAn
            // 
            this.lstBanAn.HideSelection = false;
            this.lstBanAn.LargeImageList = this.ilistBanAn;
            this.lstBanAn.Location = new System.Drawing.Point(21, 316);
            this.lstBanAn.Name = "lstBanAn";
            this.lstBanAn.Size = new System.Drawing.Size(459, 395);
            this.lstBanAn.TabIndex = 28;
            this.lstBanAn.UseCompatibleStateImageBehavior = false;
            this.lstBanAn.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBanAn_ItemSelectionChanged);
            // 
            // ilistBanAn
            // 
            this.ilistBanAn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistBanAn.ImageStream")));
            this.ilistBanAn.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistBanAn.Images.SetKeyName(0, "dinner.png");
            this.ilistBanAn.Images.SetKeyName(1, "dinner1.png");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "SƠ ĐỒ BÀN ĂN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Trạng Thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(263, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Loại Bàn:";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbTrangThai.Location = new System.Drawing.Point(138, 220);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 20);
            this.lbTrangThai.TabIndex = 32;
            // 
            // lbLoaiBan
            // 
            this.lbLoaiBan.AutoSize = true;
            this.lbLoaiBan.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbLoaiBan.Location = new System.Drawing.Point(359, 220);
            this.lbLoaiBan.Name = "lbLoaiBan";
            this.lbLoaiBan.Size = new System.Drawing.Size(0, 20);
            this.lbLoaiBan.TabIndex = 33;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(20, 248);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(143, 62);
            this.btnChuyenBan.TabIndex = 35;
            this.btnChuyenBan.Text = "CHUYỂN BÀN";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(175, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ngày:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(188, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Giờ:";
            // 
            // dateDay
            // 
            this.dateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateDay.Location = new System.Drawing.Point(238, 257);
            this.dateDay.Name = "dateDay";
            this.dateDay.Size = new System.Drawing.Size(243, 23);
            this.dateDay.TabIndex = 38;
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(238, 285);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(242, 23);
            this.dateTime.TabIndex = 39;
            this.dateTime.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1219, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1309, 245);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(225, 65);
            this.txtGhiChu.TabIndex = 40;
            // 
            // FrmDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformDatBan.Properties.Resources.backgroundtest;
            this.ClientSize = new System.Drawing.Size(1546, 721);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.dateDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.lbLoaiBan);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstBanAn);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnHuyMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.lstViewDatMon);
            this.Name = "FrmDatMon";
            this.Text = "FrmDatMon";
            this.Load += new System.EventHandler(this.FrmDatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstViewDatMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnHuyMon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.ListView lstBanAn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ilistBanAn;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbLoaiBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDay;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}