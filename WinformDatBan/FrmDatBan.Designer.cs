
namespace WinformDatBan
{
    partial class FrmDatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatBan));
            this.ilistBanAn = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lstBanAn = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateDay = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbLoaiBan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ilistBanAn
            // 
            this.ilistBanAn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistBanAn.ImageStream")));
            this.ilistBanAn.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistBanAn.Images.SetKeyName(0, "dinner.png");
            this.ilistBanAn.Images.SetKeyName(1, "dinner1.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "SƠ ĐỒ BÀN ĂN";
            // 
            // lstBanAn
            // 
            this.lstBanAn.HideSelection = false;
            this.lstBanAn.LargeImageList = this.ilistBanAn;
            this.lstBanAn.Location = new System.Drawing.Point(12, 182);
            this.lstBanAn.Name = "lstBanAn";
            this.lstBanAn.Size = new System.Drawing.Size(659, 360);
            this.lstBanAn.TabIndex = 27;
            this.lstBanAn.UseCompatibleStateImageBehavior = false;
            this.lstBanAn.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBanAn_ItemSelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(688, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Trạng Thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(688, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(688, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Giờ:";
            // 
            // btnDatBan
            // 
            this.btnDatBan.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnDatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatBan.Location = new System.Drawing.Point(1101, 186);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(143, 46);
            this.btnDatBan.TabIndex = 32;
            this.btnDatBan.Text = "ĐẶT BÀN";
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnHuyBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBan.Location = new System.Drawing.Point(1101, 327);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(143, 46);
            this.btnHuyBan.TabIndex = 33;
            this.btnHuyBan.Text = "HỦY BÀN";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinformDatBan.Properties.Resources.LogoTitTrenMay;
            this.pictureBox1.Location = new System.Drawing.Point(2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // dateDay
            // 
            this.dateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateDay.Location = new System.Drawing.Point(772, 318);
            this.dateDay.Name = "dateDay";
            this.dateDay.Size = new System.Drawing.Size(255, 23);
            this.dateDay.TabIndex = 36;
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(772, 378);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 23);
            this.dateTime.TabIndex = 37;
            this.dateTime.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(688, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Loại Bàn:";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(819, 182);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 25);
            this.lbTrangThai.TabIndex = 38;
            // 
            // lbLoaiBan
            // 
            this.lbLoaiBan.AutoSize = true;
            this.lbLoaiBan.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbLoaiBan.ForeColor = System.Drawing.Color.Red;
            this.lbLoaiBan.Location = new System.Drawing.Point(798, 240);
            this.lbLoaiBan.Name = "lbLoaiBan";
            this.lbLoaiBan.Size = new System.Drawing.Size(0, 25);
            this.lbLoaiBan.TabIndex = 38;
            this.lbLoaiBan.Click += new System.EventHandler(this.lbLoaiBan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(688, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(688, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(872, 446);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(189, 26);
            this.txtTenKH.TabIndex = 39;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(872, 504);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(189, 26);
            this.txtSDT.TabIndex = 40;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::WinformDatBan.Properties.Resources.test2;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(1101, 465);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 48);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformDatBan.Properties.Resources.backgroundtest;
            this.ClientSize = new System.Drawing.Size(1283, 563);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lbLoaiBan);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.lstBanAn);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.dateDay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHuyBan);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatBan";
            this.Load += new System.EventHandler(this.FrmDatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ilistBanAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstBanAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateDay;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbLoaiBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
    }
}