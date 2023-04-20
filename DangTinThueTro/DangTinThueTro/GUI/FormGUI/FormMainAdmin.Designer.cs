namespace DangTinThueTro.GUI.FormGUI
{
    partial class FormMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnDuyetTinDang = new System.Windows.Forms.Button();
            this.btnXacThucNguoiDung = new System.Windows.Forms.Button();
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
            this.panelNav.Location = new System.Drawing.Point(2, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(350, 881);
            this.panelNav.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.panelMenu.Controls.Add(this.btnQLTaiKhoan);
            this.panelMenu.Controls.Add(this.btnDuyetTinDang);
            this.panelMenu.Controls.Add(this.btnXacThucNguoiDung);
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
            // btnDuyetTinDang
            // 
            this.btnDuyetTinDang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuyetTinDang.FlatAppearance.BorderSize = 0;
            this.btnDuyetTinDang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetTinDang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDuyetTinDang.ForeColor = System.Drawing.Color.White;
            this.btnDuyetTinDang.Image = global::DangTinThueTro.Properties.Resources.task_checked_24px;
            this.btnDuyetTinDang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyetTinDang.Location = new System.Drawing.Point(8, 75);
            this.btnDuyetTinDang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuyetTinDang.Name = "btnDuyetTinDang";
            this.btnDuyetTinDang.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDuyetTinDang.Size = new System.Drawing.Size(334, 67);
            this.btnDuyetTinDang.TabIndex = 2;
            this.btnDuyetTinDang.Text = "  Duyệt tin đăng trọ";
            this.btnDuyetTinDang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyetTinDang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuyetTinDang.UseVisualStyleBackColor = true;
            this.btnDuyetTinDang.Click += new System.EventHandler(this.btnDuyetTinDang_Click);
            // 
            // btnXacThucNguoiDung
            // 
            this.btnXacThucNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXacThucNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnXacThucNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacThucNguoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXacThucNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnXacThucNguoiDung.Image = global::DangTinThueTro.Properties.Resources.user_actived_white_24px;
            this.btnXacThucNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacThucNguoiDung.Location = new System.Drawing.Point(8, 8);
            this.btnXacThucNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXacThucNguoiDung.Name = "btnXacThucNguoiDung";
            this.btnXacThucNguoiDung.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnXacThucNguoiDung.Size = new System.Drawing.Size(334, 67);
            this.btnXacThucNguoiDung.TabIndex = 1;
            this.btnXacThucNguoiDung.Text = "  Xác thực người dùng";
            this.btnXacThucNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacThucNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacThucNguoiDung.UseVisualStyleBackColor = true;
            this.btnXacThucNguoiDung.Click += new System.EventHandler(this.btnXacThucNguoiDung_Click);
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
            this.panelContainer.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 881);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 881);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.splitter2);
            this.MaximizeBox = false;
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng tin thuê trọ - Admin";
            this.panelNav.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNav;
        private Panel panelMenu;
        private Button btnQLTaiKhoan;
        private Button btnDuyetTinDang;
        private Button btnXacThucNguoiDung;
        private Panel panelUser;
        private PictureBox imgAvatar;
        private Panel panelContainer;
        private Splitter splitter2;
    }
}