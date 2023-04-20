namespace DangTinThueTro.CustomComponent
{
    partial class PanelHome
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
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnTimTro = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.ckboxDungLoc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienTichDen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienTichTu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxXaPhuong = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxQuanHuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxTinhThanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1115, 609);
            this.flowLayoutPanelMain.TabIndex = 1;
            this.flowLayoutPanelMain.WrapContents = false;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.btnTimTro);
            this.panelButton.Controls.Add(this.btnFilter);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 825);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1115, 56);
            this.panelButton.TabIndex = 2;
            // 
            // btnTimTro
            // 
            this.btnTimTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnTimTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimTro.ForeColor = System.Drawing.Color.White;
            this.btnTimTro.Location = new System.Drawing.Point(56, 0);
            this.btnTimTro.Name = "btnTimTro";
            this.btnTimTro.Size = new System.Drawing.Size(1059, 56);
            this.btnTimTro.TabIndex = 1;
            this.btnTimTro.Text = "Tìm trọ";
            this.btnTimTro.UseVisualStyleBackColor = false;
            this.btnTimTro.Click += new System.EventHandler(this.btnTimTro_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::DangTinThueTro.Properties.Resources.setting_white_24px;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(56, 56);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanelMain);
            this.panel1.Controls.Add(this.panelFilter);
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 881);
            this.panel1.TabIndex = 3;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.panelFilter.Controls.Add(this.ckboxDungLoc);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.txtDienTichDen);
            this.panelFilter.Controls.Add(this.label7);
            this.panelFilter.Controls.Add(this.txtDienTichTu);
            this.panelFilter.Controls.Add(this.label8);
            this.panelFilter.Controls.Add(this.txtGiaDen);
            this.panelFilter.Controls.Add(this.label6);
            this.panelFilter.Controls.Add(this.txtGiaTu);
            this.panelFilter.Controls.Add(this.label5);
            this.panelFilter.Controls.Add(this.label12);
            this.panelFilter.Controls.Add(this.cboxXaPhuong);
            this.panelFilter.Controls.Add(this.label11);
            this.panelFilter.Controls.Add(this.cboxQuanHuyen);
            this.panelFilter.Controls.Add(this.label4);
            this.panelFilter.Controls.Add(this.cboxTinhThanh);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFilter.ForeColor = System.Drawing.Color.Black;
            this.panelFilter.Location = new System.Drawing.Point(0, 609);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1115, 216);
            this.panelFilter.TabIndex = 3;
            this.panelFilter.Visible = false;
            // 
            // ckboxDungLoc
            // 
            this.ckboxDungLoc.AutoSize = true;
            this.ckboxDungLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckboxDungLoc.Location = new System.Drawing.Point(517, 164);
            this.ckboxDungLoc.Name = "ckboxDungLoc";
            this.ckboxDungLoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckboxDungLoc.Size = new System.Drawing.Size(142, 32);
            this.ckboxDungLoc.TabIndex = 73;
            this.ckboxDungLoc.Text = "Dùng bộ lọc";
            this.ckboxDungLoc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(517, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 72;
            this.label2.Text = "Giá và Diện tích";
            // 
            // txtDienTichDen
            // 
            this.txtDienTichDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDienTichDen.Location = new System.Drawing.Point(911, 108);
            this.txtDienTichDen.Name = "txtDienTichDen";
            this.txtDienTichDen.Size = new System.Drawing.Size(155, 34);
            this.txtDienTichDen.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(860, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "đến";
            // 
            // txtDienTichTu
            // 
            this.txtDienTichTu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDienTichTu.Location = new System.Drawing.Point(699, 108);
            this.txtDienTichTu.Name = "txtDienTichTu";
            this.txtDienTichTu.Size = new System.Drawing.Size(155, 34);
            this.txtDienTichTu.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(517, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 28);
            this.label8.TabIndex = 67;
            this.label8.Text = "Diện tích phòng từ";
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaDen.Location = new System.Drawing.Point(911, 55);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(155, 34);
            this.txtGiaDen.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(860, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 65;
            this.label6.Text = "đến";
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTu.Location = new System.Drawing.Point(699, 55);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(155, 34);
            this.txtGiaTu.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(517, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 63;
            this.label5.Text = "Giá phòng từ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(33, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 28);
            this.label12.TabIndex = 58;
            this.label12.Text = "Xã/Phường/Thị trấn";
            // 
            // cboxXaPhuong
            // 
            this.cboxXaPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxXaPhuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxXaPhuong.FormattingEnabled = true;
            this.cboxXaPhuong.Location = new System.Drawing.Point(224, 162);
            this.cboxXaPhuong.Name = "cboxXaPhuong";
            this.cboxXaPhuong.Size = new System.Drawing.Size(257, 36);
            this.cboxXaPhuong.TabIndex = 55;
            this.cboxXaPhuong.SelectedIndexChanged += new System.EventHandler(this.cboxXaPhuong_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(33, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 28);
            this.label11.TabIndex = 57;
            this.label11.Text = "Quận/Huyện/Thị xã";
            // 
            // cboxQuanHuyen
            // 
            this.cboxQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQuanHuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxQuanHuyen.FormattingEnabled = true;
            this.cboxQuanHuyen.Location = new System.Drawing.Point(224, 108);
            this.cboxQuanHuyen.Name = "cboxQuanHuyen";
            this.cboxQuanHuyen.Size = new System.Drawing.Size(257, 36);
            this.cboxQuanHuyen.TabIndex = 54;
            this.cboxQuanHuyen.SelectedValueChanged += new System.EventHandler(this.cboxQuanHuyen_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tỉnh/Thành phố";
            // 
            // cboxTinhThanh
            // 
            this.cboxTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTinhThanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxTinhThanh.FormattingEnabled = true;
            this.cboxTinhThanh.Location = new System.Drawing.Point(224, 55);
            this.cboxTinhThanh.Name = "cboxTinhThanh";
            this.cboxTinhThanh.Size = new System.Drawing.Size(257, 36);
            this.cboxTinhThanh.TabIndex = 53;
            this.cboxTinhThanh.SelectedValueChanged += new System.EventHandler(this.cboxTinhThanhPho_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Khu vực";
            // 
            // PanelHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "PanelHome";
            this.Size = new System.Drawing.Size(1115, 881);
            this.panelButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelMain;
        private Panel panelButton;
        private Button btnTimTro;
        private Button btnFilter;
        private Panel panel1;
        private Panel panelFilter;
        private Label label12;
        private ComboBox cboxXaPhuong;
        private Label label11;
        private ComboBox cboxQuanHuyen;
        private Label label4;
        private ComboBox cboxTinhThanh;
        private Label label1;
        private Label label2;
        private TextBox txtDienTichDen;
        private Label label7;
        private TextBox txtDienTichTu;
        private Label label8;
        private TextBox txtGiaDen;
        private Label label6;
        private TextBox txtGiaTu;
        private Label label5;
        private CheckBox ckboxDungLoc;
    }
}
