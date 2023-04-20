using System.Drawing.Drawing2D;

namespace DangTinThueTro
{
    partial class FormMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUser));
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnQLLichHen = new System.Windows.Forms.Button();
            this.btnQLTin = new System.Windows.Forms.Button();
            this.btnQLTro = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnLichHen = new System.Windows.Forms.Button();
            this.btnYeuThich = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelNav.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNav.Controls.Add(this.panelMenu);
            this.panelNav.Controls.Add(this.panelUser);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(350, 881);
            this.panelNav.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.panelMenu.Controls.Add(this.btnQLTaiKhoan);
            this.panelMenu.Controls.Add(this.btnQLLichHen);
            this.panelMenu.Controls.Add(this.btnQLTin);
            this.panelMenu.Controls.Add(this.btnQLTro);
            this.panelMenu.Controls.Add(this.splitter1);
            this.panelMenu.Controls.Add(this.btnLichHen);
            this.panelMenu.Controls.Add(this.btnYeuThich);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 200);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(8);
            this.panelMenu.Size = new System.Drawing.Size(350, 681);
            this.panelMenu.TabIndex = 7;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTaiKhoan.Image")));
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(8, 624);
            this.btnQLTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(334, 49);
            this.btnQLTaiKhoan.TabIndex = 7;
            this.btnQLTaiKhoan.Text = "  Tài khoản";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnQLLichHen
            // 
            this.btnQLLichHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLichHen.FlatAppearance.BorderSize = 0;
            this.btnQLLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLichHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLLichHen.ForeColor = System.Drawing.Color.White;
            this.btnQLLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLichHen.Image")));
            this.btnQLLichHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLichHen.Location = new System.Drawing.Point(8, 344);
            this.btnQLLichHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLLichHen.Name = "btnQLLichHen";
            this.btnQLLichHen.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnQLLichHen.Size = new System.Drawing.Size(334, 67);
            this.btnQLLichHen.TabIndex = 6;
            this.btnQLLichHen.Text = "  Quản lý lịch hẹn";
            this.btnQLLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLichHen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLLichHen.UseVisualStyleBackColor = true;
            this.btnQLLichHen.Click += new System.EventHandler(this.btnQLLichHen_Click);
            // 
            // btnQLTin
            // 
            this.btnQLTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTin.FlatAppearance.BorderSize = 0;
            this.btnQLTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLTin.ForeColor = System.Drawing.Color.White;
            this.btnQLTin.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTin.Image")));
            this.btnQLTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTin.Location = new System.Drawing.Point(8, 277);
            this.btnQLTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLTin.Name = "btnQLTin";
            this.btnQLTin.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnQLTin.Size = new System.Drawing.Size(334, 67);
            this.btnQLTin.TabIndex = 5;
            this.btnQLTin.Text = "  Quản lý tin";
            this.btnQLTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTin.UseVisualStyleBackColor = true;
            this.btnQLTin.Click += new System.EventHandler(this.btnQLTin_Click);
            // 
            // btnQLTro
            // 
            this.btnQLTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTro.FlatAppearance.BorderSize = 0;
            this.btnQLTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLTro.ForeColor = System.Drawing.Color.White;
            this.btnQLTro.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTro.Image")));
            this.btnQLTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTro.Location = new System.Drawing.Point(8, 210);
            this.btnQLTro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLTro.Name = "btnQLTro";
            this.btnQLTro.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnQLTro.Size = new System.Drawing.Size(334, 67);
            this.btnQLTro.TabIndex = 4;
            this.btnQLTro.Text = "  Nhà trọ của tôi";
            this.btnQLTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTro.UseVisualStyleBackColor = true;
            this.btnQLTro.Click += new System.EventHandler(this.btnQLTro_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(8, 209);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(334, 1);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // btnLichHen
            // 
            this.btnLichHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichHen.FlatAppearance.BorderSize = 0;
            this.btnLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLichHen.ForeColor = System.Drawing.Color.White;
            this.btnLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHen.Image")));
            this.btnLichHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHen.Location = new System.Drawing.Point(8, 142);
            this.btnLichHen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLichHen.Size = new System.Drawing.Size(334, 67);
            this.btnLichHen.TabIndex = 3;
            this.btnLichHen.Text = "  Phòng trọ đã đặt lịch hẹn";
            this.btnLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichHen.UseVisualStyleBackColor = true;
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // btnYeuThich
            // 
            this.btnYeuThich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYeuThich.FlatAppearance.BorderSize = 0;
            this.btnYeuThich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeuThich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYeuThich.ForeColor = System.Drawing.Color.White;
            this.btnYeuThich.Image = ((System.Drawing.Image)(resources.GetObject("btnYeuThich.Image")));
            this.btnYeuThich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeuThich.Location = new System.Drawing.Point(8, 75);
            this.btnYeuThich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeuThich.Name = "btnYeuThich";
            this.btnYeuThich.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnYeuThich.Size = new System.Drawing.Size(334, 67);
            this.btnYeuThich.TabIndex = 2;
            this.btnYeuThich.Text = "  Nhà trọ yêu thích";
            this.btnYeuThich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeuThich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeuThich.UseVisualStyleBackColor = true;
            this.btnYeuThich.Click += new System.EventHandler(this.btnYeuThich_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(334, 67);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUser.Controls.Add(this.imgAvatar);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(350, 200);
            this.panelUser.TabIndex = 0;
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(122, 44);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(101, 100);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 0;
            this.imgAvatar.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(352, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1115, 881);
            this.panelContainer.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter2.Location = new System.Drawing.Point(350, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 881);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 881);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panelNav);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng tin thuê trọ";
            this.panelNav.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNav;
        private Button btnHome;
        private Panel panelUser;
        private Button btnQLTro;
        private Button btnQLTin;
        private Panel panelContainer;
        private Button btnQLLichHen;
        private PictureBox imgAvatar;
        private Button btnQLTaiKhoan;
        private Splitter splitter2;
        private Panel panelMenu;
        private Button btnYeuThich;
        private Splitter splitter1;
        private Button btnLichHen;
    }
}