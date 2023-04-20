namespace DangTinThueTro.GUI.FormGUI
{
    partial class FormXemAnh
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
            this.flowLayoutPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContainer
            // 
            this.flowLayoutPanelContainer.AutoScroll = true;
            this.flowLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContainer.Name = "flowLayoutPanelContainer";
            this.flowLayoutPanelContainer.Size = new System.Drawing.Size(992, 653);
            this.flowLayoutPanelContainer.TabIndex = 0;
            this.flowLayoutPanelContainer.WrapContents = false;
            // 
            // FormXemAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 653);
            this.Controls.Add(this.flowLayoutPanelContainer);
            this.Name = "FormXemAnh";
            this.Text = "FormXemAnh";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContainer;
    }
}