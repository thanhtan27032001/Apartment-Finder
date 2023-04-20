namespace DangTinThueTro
{
    partial class FormDangKy
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbQuayLai = new System.Windows.Forms.Label();
            this.picWarnTaiKhoan = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picWarnMatKhau = new System.Windows.Forms.PictureBox();
            this.picWarnMatKhau2 = new System.Windows.Forms.PictureBox();
            this.picWarnSDT = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnMatKhau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnSDT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label4.Location = new System.Drawing.Point(49, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 59);
            this.label4.TabIndex = 15;
            this.label4.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnDangKy.Location = new System.Drawing.Point(49, 525);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(465, 70);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.Location = new System.Drawing.Point(49, 272);
            this.txtMatKhau.MaxLength = 20;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '•';
            this.txtMatKhau.ShortcutsEnabled = false;
            this.txtMatKhau.Size = new System.Drawing.Size(463, 39);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaiKhoan.Location = new System.Drawing.Point(49, 169);
            this.txtTaiKhoan.MaxLength = 20;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ShortcutsEnabled = false;
            this.txtTaiKhoan.Size = new System.Drawing.Size(463, 39);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BackColor = System.Drawing.Color.White;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(49, 368);
            this.txtXacNhanMatKhau.MaxLength = 20;
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '•';
            this.txtXacNhanMatKhau.ShortcutsEnabled = false;
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(463, 39);
            this.txtXacNhanMatKhau.TabIndex = 3;
            this.txtXacNhanMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xác nhận lại mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.White;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoDienThoai.Location = new System.Drawing.Point(49, 463);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(463, 39);
            this.txtSoDienThoai.TabIndex = 4;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(49, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số điện thoại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQuayLai
            // 
            this.lbQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuayLai.ForeColor = System.Drawing.Color.Black;
            this.lbQuayLai.Location = new System.Drawing.Point(51, 598);
            this.lbQuayLai.Name = "lbQuayLai";
            this.lbQuayLai.Size = new System.Drawing.Size(462, 35);
            this.lbQuayLai.TabIndex = 6;
            this.lbQuayLai.Text = "Trở lại màn hình đăng nhập";
            this.lbQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuayLai.Click += new System.EventHandler(this.lbQuayLai_Click);
            // 
            // picWarnTaiKhoan
            // 
            this.picWarnTaiKhoan.Image = global::DangTinThueTro.Properties.Resources.info_24px;
            this.picWarnTaiKhoan.Location = new System.Drawing.Point(517, 177);
            this.picWarnTaiKhoan.Name = "picWarnTaiKhoan";
            this.picWarnTaiKhoan.Size = new System.Drawing.Size(24, 24);
            this.picWarnTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarnTaiKhoan.TabIndex = 19;
            this.picWarnTaiKhoan.TabStop = false;
            this.toolTip.SetToolTip(this.picWarnTaiKhoan, "Thiếu thông tin tài khoản");
            this.picWarnTaiKhoan.Visible = false;
            // 
            // picWarnMatKhau
            // 
            this.picWarnMatKhau.Image = global::DangTinThueTro.Properties.Resources.info_24px;
            this.picWarnMatKhau.Location = new System.Drawing.Point(518, 280);
            this.picWarnMatKhau.Name = "picWarnMatKhau";
            this.picWarnMatKhau.Size = new System.Drawing.Size(24, 24);
            this.picWarnMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarnMatKhau.TabIndex = 20;
            this.picWarnMatKhau.TabStop = false;
            this.toolTip.SetToolTip(this.picWarnMatKhau, "Chưa nhập mật khẩu");
            this.picWarnMatKhau.Visible = false;
            // 
            // picWarnMatKhau2
            // 
            this.picWarnMatKhau2.Image = global::DangTinThueTro.Properties.Resources.info_24px;
            this.picWarnMatKhau2.Location = new System.Drawing.Point(517, 376);
            this.picWarnMatKhau2.Name = "picWarnMatKhau2";
            this.picWarnMatKhau2.Size = new System.Drawing.Size(24, 24);
            this.picWarnMatKhau2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarnMatKhau2.TabIndex = 21;
            this.picWarnMatKhau2.TabStop = false;
            this.toolTip.SetToolTip(this.picWarnMatKhau2, "Mật khẩu không khớp");
            this.picWarnMatKhau2.Visible = false;
            // 
            // picWarnSDT
            // 
            this.picWarnSDT.Image = global::DangTinThueTro.Properties.Resources.info_24px;
            this.picWarnSDT.Location = new System.Drawing.Point(518, 470);
            this.picWarnSDT.Name = "picWarnSDT";
            this.picWarnSDT.Size = new System.Drawing.Size(24, 24);
            this.picWarnSDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarnSDT.TabIndex = 22;
            this.picWarnSDT.TabStop = false;
            this.toolTip.SetToolTip(this.picWarnSDT, "Số điện thoại phải đúng 10 ký số");
            this.picWarnSDT.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picWarnSDT);
            this.panel1.Controls.Add(this.picWarnMatKhau2);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.picWarnMatKhau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picWarnTaiKhoan);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.lbQuayLai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.txtXacNhanMatKhau);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(459, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 687);
            this.panel1.TabIndex = 23;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1467, 881);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.picWarnTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnMatKhau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnSDT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label4;
        private Button btnDangKy;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTaiKhoan;
        private Label label1;
        private TextBox txtXacNhanMatKhau;
        private Label label5;
        private TextBox txtSoDienThoai;
        private Label label6;
        private Label lbQuayLai;
        private PictureBox picWarnTaiKhoan;
        private ToolTip toolTip;
        private PictureBox picWarnMatKhau;
        private PictureBox picWarnMatKhau2;
        private PictureBox picWarnSDT;
        private Panel panel1;
    }
}