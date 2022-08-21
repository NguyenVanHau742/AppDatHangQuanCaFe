
namespace WinformDatBan
{
    partial class FrmNhaBep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaBep));
            this.lstBanAn = new System.Windows.Forms.ListView();
            this.ilistBanAn = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lstViewDatMon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbChuahoanthanh = new System.Windows.Forms.RadioButton();
            this.RbDaHoanThanh = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBanAn
            // 
            this.lstBanAn.HideSelection = false;
            this.lstBanAn.LargeImageList = this.ilistBanAn;
            this.lstBanAn.Location = new System.Drawing.Point(12, 102);
            this.lstBanAn.Name = "lstBanAn";
            this.lstBanAn.Size = new System.Drawing.Size(459, 395);
            this.lstBanAn.TabIndex = 29;
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
            this.label7.Location = new System.Drawing.Point(130, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "SƠ ĐỒ BÀN ĂN";
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
            this.lstViewDatMon.Location = new System.Drawing.Point(477, 102);
            this.lstViewDatMon.Name = "lstViewDatMon";
            this.lstViewDatMon.Size = new System.Drawing.Size(518, 395);
            this.lstViewDatMon.TabIndex = 31;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(638, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "ĐƠN ĐẶT MÓN ĂN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinformDatBan.Properties.Resources.LogoTitTrenMay;
            this.pictureBox1.Location = new System.Drawing.Point(1001, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // RbChuahoanthanh
            // 
            this.RbChuahoanthanh.AutoSize = true;
            this.RbChuahoanthanh.BackColor = System.Drawing.Color.Transparent;
            this.RbChuahoanthanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbChuahoanthanh.Location = new System.Drawing.Point(1016, 230);
            this.RbChuahoanthanh.Name = "RbChuahoanthanh";
            this.RbChuahoanthanh.Size = new System.Drawing.Size(184, 29);
            this.RbChuahoanthanh.TabIndex = 34;
            this.RbChuahoanthanh.TabStop = true;
            this.RbChuahoanthanh.Text = "Chưa hoàn thành";
            this.RbChuahoanthanh.UseVisualStyleBackColor = false;
            // 
            // RbDaHoanThanh
            // 
            this.RbDaHoanThanh.AutoSize = true;
            this.RbDaHoanThanh.BackColor = System.Drawing.Color.Transparent;
            this.RbDaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDaHoanThanh.Location = new System.Drawing.Point(1016, 291);
            this.RbDaHoanThanh.Name = "RbDaHoanThanh";
            this.RbDaHoanThanh.Size = new System.Drawing.Size(161, 29);
            this.RbDaHoanThanh.TabIndex = 35;
            this.RbDaHoanThanh.TabStop = true;
            this.RbDaHoanThanh.Text = "Đã hoàn thành";
            this.RbDaHoanThanh.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(1016, 372);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(184, 56);
            this.btnXacNhan.TabIndex = 36;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FrmNhaBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformDatBan.Properties.Resources.backgroundtest;
            this.ClientSize = new System.Drawing.Size(1250, 514);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.RbDaHoanThanh);
            this.Controls.Add(this.RbChuahoanthanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstViewDatMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstBanAn);
            this.Name = "FrmNhaBep";
            this.Text = "FrmNhaBep";
            this.Load += new System.EventHandler(this.FrmNhaBep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstBanAn;
        private System.Windows.Forms.ImageList ilistBanAn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstViewDatMon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbChuahoanthanh;
        private System.Windows.Forms.RadioButton RbDaHoanThanh;
        private System.Windows.Forms.Button btnXacNhan;
    }
}