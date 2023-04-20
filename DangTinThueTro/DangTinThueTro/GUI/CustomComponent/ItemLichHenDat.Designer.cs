﻿namespace DangTinThueTro.GUI.CustomComponent
{
    partial class ItemLichHenDat
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
            this.flowLayoutPanelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMaPhongTro = new System.Windows.Forms.Label();
            this.lbNgayGioHen = new System.Windows.Forms.Label();
            this.lbTrạngThai = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXemPhongTro = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.flowLayoutPanelInfo.SuspendLayout();
            this.flowLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelInfo
            // 
            this.flowLayoutPanelInfo.Controls.Add(this.lbMaPhongTro);
            this.flowLayoutPanelInfo.Controls.Add(this.lbNgayGioHen);
            this.flowLayoutPanelInfo.Controls.Add(this.lbTrạngThai);
            this.flowLayoutPanelInfo.Controls.Add(this.lbGhiChu);
            this.flowLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelInfo.Name = "flowLayoutPanelInfo";
            this.flowLayoutPanelInfo.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.flowLayoutPanelInfo.Size = new System.Drawing.Size(1054, 191);
            this.flowLayoutPanelInfo.TabIndex = 3;
            this.flowLayoutPanelInfo.WrapContents = false;
            // 
            // lbMaPhongTro
            // 
            this.lbMaPhongTro.AutoSize = true;
            this.lbMaPhongTro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaPhongTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.lbMaPhongTro.Location = new System.Drawing.Point(12, 11);
            this.lbMaPhongTro.Name = "lbMaPhongTro";
            this.lbMaPhongTro.Size = new System.Drawing.Size(458, 41);
            this.lbMaPhongTro.TabIndex = 0;
            this.lbMaPhongTro.Text = "Lịch hẹn với phòng trọ #Id: xxx";
            // 
            // lbNgayGioHen
            // 
            this.lbNgayGioHen.AutoSize = true;
            this.lbNgayGioHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNgayGioHen.ForeColor = System.Drawing.Color.Gray;
            this.lbNgayGioHen.Image = global::DangTinThueTro.Properties.Resources.calendar_gray_16px;
            this.lbNgayGioHen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbNgayGioHen.Location = new System.Drawing.Point(12, 52);
            this.lbNgayGioHen.Name = "lbNgayGioHen";
            this.lbNgayGioHen.Size = new System.Drawing.Size(292, 28);
            this.lbNgayGioHen.TabIndex = 3;
            this.lbNgayGioHen.Text = "    Ngày giờ hẹn: xx/xx/xxxx xx:xx";
            // 
            // lbTrạngThai
            // 
            this.lbTrạngThai.AutoSize = true;
            this.lbTrạngThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTrạngThai.ForeColor = System.Drawing.Color.Gray;
            this.lbTrạngThai.Image = global::DangTinThueTro.Properties.Resources.loading_gray_16px;
            this.lbTrạngThai.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbTrạngThai.Location = new System.Drawing.Point(12, 80);
            this.lbTrạngThai.Name = "lbTrạngThai";
            this.lbTrạngThai.Size = new System.Drawing.Size(145, 28);
            this.lbTrạngThai.TabIndex = 4;
            this.lbTrạngThai.Text = "    Trạng thái: xx";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lbGhiChu.Image = global::DangTinThueTro.Properties.Resources.check_list_gray_16px;
            this.lbGhiChu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbGhiChu.Location = new System.Drawing.Point(12, 108);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(134, 28);
            this.lbGhiChu.TabIndex = 5;
            this.lbGhiChu.Text = "    Ghi chú: xxx";
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnXemPhongTro);
            this.flowLayoutPanelButton.Controls.Add(this.btnHuy);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(0, 191);
            this.flowLayoutPanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.flowLayoutPanelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(1054, 63);
            this.flowLayoutPanelButton.TabIndex = 4;
            // 
            // btnXemPhongTro
            // 
            this.btnXemPhongTro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemPhongTro.Location = new System.Drawing.Point(791, 4);
            this.btnXemPhongTro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemPhongTro.Name = "btnXemPhongTro";
            this.btnXemPhongTro.Size = new System.Drawing.Size(256, 56);
            this.btnXemPhongTro.TabIndex = 3;
            this.btnXemPhongTro.Text = "Xem thông tin phòng trọ";
            this.btnXemPhongTro.UseVisualStyleBackColor = true;
            this.btnXemPhongTro.Click += new System.EventHandler(this.btnXemPhongTro_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(646, 4);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(139, 56);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy hẹn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ItemLichHenDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanelButton);
            this.Controls.Add(this.flowLayoutPanelInfo);
            this.Name = "ItemLichHenDat";
            this.Size = new System.Drawing.Size(1054, 254);
            this.flowLayoutPanelInfo.ResumeLayout(false);
            this.flowLayoutPanelInfo.PerformLayout();
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelInfo;
        private Label lbMaPhongTro;
        private Label lbNgayGioHen;
        private Label lbTrạngThai;
        private Label lbGhiChu;
        private FlowLayoutPanel flowLayoutPanelButton;
        private Button btnXemPhongTro;
        private Button btnHuy;
    }
}
