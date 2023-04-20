namespace DangTinThueTro.GUI.CustomComponent
{
    partial class PanelXacThucNguoiDung
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
            this.btnReload = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1115, 824);
            this.flowLayoutPanelMain.TabIndex = 4;
            this.flowLayoutPanelMain.WrapContents = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(1115, 60);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.btnReload);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 821);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1115, 60);
            this.panelButton.TabIndex = 3;
            // 
            // PanelXacThucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panelButton);
            this.Name = "PanelXacThucNguoiDung";
            this.Size = new System.Drawing.Size(1115, 881);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMain;
        private Button btnReload;
        private Panel panelButton;
    }
}
