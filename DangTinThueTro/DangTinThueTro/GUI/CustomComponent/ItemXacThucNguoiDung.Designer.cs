namespace DangTinThueTro.GUI.CustomComponent
{
    partial class ItemXacThucNguoiDung
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.flowLayoutPanelInfo.SuspendLayout();
            this.flowLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelInfo
            // 
            this.flowLayoutPanelInfo.Controls.Add(this.lbId);
            this.flowLayoutPanelInfo.Controls.Add(this.lbHoTen);
            this.flowLayoutPanelInfo.Controls.Add(this.lbSoDT);
            this.flowLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelInfo.Name = "flowLayoutPanelInfo";
            this.flowLayoutPanelInfo.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.flowLayoutPanelInfo.Size = new System.Drawing.Size(1054, 125);
            this.flowLayoutPanelInfo.TabIndex = 3;
            this.flowLayoutPanelInfo.WrapContents = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.lbId.Location = new System.Drawing.Point(12, 11);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(132, 41);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "#Id: xxx";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHoTen.ForeColor = System.Drawing.Color.Gray;
            this.lbHoTen.Location = new System.Drawing.Point(12, 52);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(329, 28);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "Họ tên người dùng: Nguyễn Văn Xxx";
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSoDT.ForeColor = System.Drawing.Color.Gray;
            this.lbSoDT.Location = new System.Drawing.Point(12, 80);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(186, 28);
            this.lbSoDT.TabIndex = 4;
            this.lbSoDT.Text = "Số điện thoại: 09xxx";
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnDongY);
            this.flowLayoutPanelButton.Controls.Add(this.btnTuChoi);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.flowLayoutPanelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(1054, 64);
            this.flowLayoutPanelButton.TabIndex = 4;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDongY.Location = new System.Drawing.Point(922, 4);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(125, 56);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTuChoi.Location = new System.Drawing.Point(789, 4);
            this.btnTuChoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(127, 56);
            this.btnTuChoi.TabIndex = 3;
            this.btnTuChoi.Text = "Từ chối";
            this.btnTuChoi.UseVisualStyleBackColor = true;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
            // 
            // ItemXacThucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanelButton);
            this.Controls.Add(this.flowLayoutPanelInfo);
            this.Name = "ItemXacThucNguoiDung";
            this.Size = new System.Drawing.Size(1054, 189);
            this.flowLayoutPanelInfo.ResumeLayout(false);
            this.flowLayoutPanelInfo.PerformLayout();
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelInfo;
        private Label lbId;
        private Label lbHoTen;
        private Label lbSoDT;
        private FlowLayoutPanel flowLayoutPanelButton;
        private Button btnTuChoi;
        private Button btnDongY;
    }
}
