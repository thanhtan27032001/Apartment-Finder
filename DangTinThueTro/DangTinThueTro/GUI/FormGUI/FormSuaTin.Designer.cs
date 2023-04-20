namespace DangTinThueTro.GUI.FormGUI
{
    partial class FormSuaTin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbThongTinGoiQCKhaDung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThongTinGoiQC = new System.Windows.Forms.Label();
            this.coboxGoiQuangCao = new System.Windows.Forms.ComboBox();
            this.ckboxChonQuangCao = new System.Windows.Forms.CheckBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbThongTinGoiQCKhaDung);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbThongTinGoiQC);
            this.panel1.Controls.Add(this.coboxGoiQuangCao);
            this.panel1.Controls.Add(this.ckboxChonQuangCao);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTieuDe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(193, -20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 921);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 779);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1080, 28);
            this.label6.TabIndex = 57;
            this.label6.Text = "(Nếu có gói quảng cáo đang khả dụng không thể đăng ký thêm)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThongTinGoiQCKhaDung
            // 
            this.lbThongTinGoiQCKhaDung.AutoSize = true;
            this.lbThongTinGoiQCKhaDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbThongTinGoiQCKhaDung.Location = new System.Drawing.Point(296, 660);
            this.lbThongTinGoiQCKhaDung.Name = "lbThongTinGoiQCKhaDung";
            this.lbThongTinGoiQCKhaDung.Size = new System.Drawing.Size(231, 28);
            this.lbThongTinGoiQCKhaDung.TabIndex = 56;
            this.lbThongTinGoiQCKhaDung.Text = "QC15 - HSD: 05/05/2022";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(31, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "Thông tin quảng cáo:";
            // 
            // lbThongTinGoiQC
            // 
            this.lbThongTinGoiQC.AutoSize = true;
            this.lbThongTinGoiQC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbThongTinGoiQC.Location = new System.Drawing.Point(365, 732);
            this.lbThongTinGoiQC.Name = "lbThongTinGoiQC";
            this.lbThongTinGoiQC.Size = new System.Drawing.Size(378, 28);
            this.lbThongTinGoiQC.TabIndex = 54;
            this.lbThongTinGoiQC.Text = "Giá gói: 100.000 VNĐ - Thời gian: 90 ngày";
            this.lbThongTinGoiQC.Visible = false;
            // 
            // coboxGoiQuangCao
            // 
            this.coboxGoiQuangCao.Enabled = false;
            this.coboxGoiQuangCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coboxGoiQuangCao.FormattingEnabled = true;
            this.coboxGoiQuangCao.Location = new System.Drawing.Point(42, 729);
            this.coboxGoiQuangCao.Name = "coboxGoiQuangCao";
            this.coboxGoiQuangCao.Size = new System.Drawing.Size(317, 36);
            this.coboxGoiQuangCao.TabIndex = 53;
            this.coboxGoiQuangCao.SelectedValueChanged += new System.EventHandler(this.coboxGoiQuangCao_SelectedValueChanged);
            // 
            // ckboxChonQuangCao
            // 
            this.ckboxChonQuangCao.AutoSize = true;
            this.ckboxChonQuangCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckboxChonQuangCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ckboxChonQuangCao.Location = new System.Drawing.Point(33, 691);
            this.ckboxChonQuangCao.Name = "ckboxChonQuangCao";
            this.ckboxChonQuangCao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckboxChonQuangCao.Size = new System.Drawing.Size(326, 32);
            this.ckboxChonQuangCao.TabIndex = 52;
            this.ckboxChonQuangCao.Text = "Tôi muốn quảng cáo tin đăng này";
            this.ckboxChonQuangCao.UseVisualStyleBackColor = true;
            this.ckboxChonQuangCao.CheckedChanged += new System.EventHandler(this.ckboxChonQuangCao_CheckedChanged);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.Location = new System.Drawing.Point(33, 160);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(1005, 483);
            this.txtMoTa.TabIndex = 51;
            this.txtMoTa.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mô tả chi tiết:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTieuDe.Location = new System.Drawing.Point(33, 75);
            this.txtTieuDe.MaxLength = 128;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(1005, 34);
            this.txtTieuDe.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tiêu đề:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(42, 820);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(991, 69);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormSuaTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1467, 881);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSuaTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa tin đăng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbThongTinGoiQC;
        private ComboBox coboxGoiQuangCao;
        private CheckBox ckboxChonQuangCao;
        private RichTextBox txtMoTa;
        private Label label3;
        private TextBox txtTieuDe;
        private Label label1;
        private Button btnSubmit;
        private Label lbThongTinGoiQCKhaDung;
        private Label label2;
        private Label label6;
    }
}