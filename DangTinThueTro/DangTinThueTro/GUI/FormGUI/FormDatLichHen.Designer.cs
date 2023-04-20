namespace DangTinThueTro.GUI.FormGUI
{
    partial class FormDatLichHen
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
            this.dateTimePickerNgayGioHen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.btnDatLichHen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerNgayGioHen
            // 
            this.dateTimePickerNgayGioHen.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayGioHen.CustomFormat = "dd/MM/yyyy - hh:mm";
            this.dateTimePickerNgayGioHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgayGioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayGioHen.Location = new System.Drawing.Point(152, 9);
            this.dateTimePickerNgayGioHen.Name = "dateTimePickerNgayGioHen";
            this.dateTimePickerNgayGioHen.Size = new System.Drawing.Size(255, 34);
            this.dateTimePickerNgayGioHen.TabIndex = 0;
            this.dateTimePickerNgayGioHen.Value = new System.DateTime(2022, 4, 29, 16, 25, 40, 227);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày giờ hẹn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi chú gửi chủ trọ:";
            // 
            // richTxtGhiChu
            // 
            this.richTxtGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTxtGhiChu.Location = new System.Drawing.Point(12, 89);
            this.richTxtGhiChu.Name = "richTxtGhiChu";
            this.richTxtGhiChu.Size = new System.Drawing.Size(776, 349);
            this.richTxtGhiChu.TabIndex = 3;
            this.richTxtGhiChu.Text = "";
            // 
            // btnDatLichHen
            // 
            this.btnDatLichHen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnDatLichHen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDatLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLichHen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatLichHen.ForeColor = System.Drawing.Color.White;
            this.btnDatLichHen.Location = new System.Drawing.Point(0, 444);
            this.btnDatLichHen.Name = "btnDatLichHen";
            this.btnDatLichHen.Size = new System.Drawing.Size(800, 57);
            this.btnDatLichHen.TabIndex = 24;
            this.btnDatLichHen.Text = "Gửi";
            this.btnDatLichHen.UseVisualStyleBackColor = false;
            this.btnDatLichHen.Click += new System.EventHandler(this.btnDatLichHen_Click);
            // 
            // FormDatLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnDatLichHen);
            this.Controls.Add(this.richTxtGhiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerNgayGioHen);
            this.Name = "FormDatLichHen";
            this.Text = "Đặt lịch hẹn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePickerNgayGioHen;
        private Label label1;
        private Label label2;
        private RichTextBox richTxtGhiChu;
        private Button btnDatLichHen;
    }
}