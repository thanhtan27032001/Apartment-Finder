namespace DangTinThueTro.GUI.FormGUI
{
    partial class FormThemNhaTro
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxXaPhuong = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxQuanHuyen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaNuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaDien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTinhThanh = new System.Windows.Forms.ComboBox();
            this.btnThemTro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(86, 485);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(534, 34);
            this.txtDiaChi.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(86, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "Số nhà và tên đường:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(86, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 28);
            this.label12.TabIndex = 45;
            this.label12.Text = "Xã/Phường/Thị trấn";
            // 
            // cboxXaPhuong
            // 
            this.cboxXaPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxXaPhuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxXaPhuong.FormattingEnabled = true;
            this.cboxXaPhuong.Location = new System.Drawing.Point(86, 406);
            this.cboxXaPhuong.Name = "cboxXaPhuong";
            this.cboxXaPhuong.Size = new System.Drawing.Size(534, 36);
            this.cboxXaPhuong.TabIndex = 9;
            this.cboxXaPhuong.SelectedValueChanged += new System.EventHandler(this.cboxXaPhuong_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(86, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 28);
            this.label11.TabIndex = 43;
            this.label11.Text = "Quận/Huyện/Thị xã";
            // 
            // cboxQuanHuyen
            // 
            this.cboxQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQuanHuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxQuanHuyen.FormattingEnabled = true;
            this.cboxQuanHuyen.Location = new System.Drawing.Point(86, 327);
            this.cboxQuanHuyen.Name = "cboxQuanHuyen";
            this.cboxQuanHuyen.Size = new System.Drawing.Size(534, 36);
            this.cboxQuanHuyen.TabIndex = 8;
            this.cboxQuanHuyen.SelectedValueChanged += new System.EventHandler(this.cboxQuanHuyen_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tỉnh/Thành phố";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label10.Location = new System.Drawing.Point(38, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 28);
            this.label10.TabIndex = 40;
            this.label10.Text = "Địa chỉ";
            // 
            // txtGiaNuoc
            // 
            this.txtGiaNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaNuoc.Location = new System.Drawing.Point(264, 112);
            this.txtGiaNuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNuoc.Name = "txtGiaNuoc";
            this.txtGiaNuoc.Size = new System.Drawing.Size(214, 34);
            this.txtGiaNuoc.TabIndex = 4;
            this.txtGiaNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNuoc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giá nước 1 khối:";
            // 
            // txtGiaDien
            // 
            this.txtGiaDien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaDien.Location = new System.Drawing.Point(264, 67);
            this.txtGiaDien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaDien.Name = "txtGiaDien";
            this.txtGiaDien.Size = new System.Drawing.Size(214, 34);
            this.txtGiaDien.TabIndex = 3;
            this.txtGiaDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDien_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(89, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Giá điện 1kw:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Thông tin nhà trọ";
            // 
            // cboxTinhThanh
            // 
            this.cboxTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTinhThanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxTinhThanh.FormattingEnabled = true;
            this.cboxTinhThanh.Location = new System.Drawing.Point(86, 248);
            this.cboxTinhThanh.Name = "cboxTinhThanh";
            this.cboxTinhThanh.Size = new System.Drawing.Size(534, 36);
            this.cboxTinhThanh.TabIndex = 7;
            this.cboxTinhThanh.SelectedValueChanged += new System.EventHandler(this.cboxTinhThanhPho_SelectedValueChanged);
            // 
            // btnThemTro
            // 
            this.btnThemTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnThemTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTro.ForeColor = System.Drawing.Color.White;
            this.btnThemTro.Location = new System.Drawing.Point(38, 560);
            this.btnThemTro.Name = "btnThemTro";
            this.btnThemTro.Size = new System.Drawing.Size(639, 54);
            this.btnThemTro.TabIndex = 11;
            this.btnThemTro.Text = "Thêm nhà trọ";
            this.btnThemTro.UseVisualStyleBackColor = false;
            this.btnThemTro.Click += new System.EventHandler(this.btnThemTro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cboxXaPhuong);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboxQuanHuyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtGiaNuoc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtGiaDien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxTinhThanh);
            this.panel1.Controls.Add(this.btnThemTro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 655);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(484, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(484, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "VNĐ";
            // 
            // FormThemNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 655);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormThemNhaTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhà trọ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtDiaChi;
        private Label label13;
        private Label label12;
        private ComboBox cboxXaPhuong;
        private Label label11;
        private ComboBox cboxQuanHuyen;
        private Label label2;
        private Label label10;
        private TextBox txtGiaNuoc;
        private Label label8;
        private TextBox txtGiaDien;
        private Label label7;
        private Label label1;
        private ComboBox cboxTinhThanh;
        private Button btnThemTro;
        private Panel panel1;
        private Label label3;
        private Label label5;
    }
}