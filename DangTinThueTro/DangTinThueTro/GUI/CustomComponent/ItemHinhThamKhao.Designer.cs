namespace DangTinThueTro.GUI.CustomComponent
{
    partial class ItemHinhThamKhao
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
            this.picHinhThamKhao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhThamKhao)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinhThamKhao
            // 
            this.picHinhThamKhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHinhThamKhao.Location = new System.Drawing.Point(0, 0);
            this.picHinhThamKhao.MaximumSize = new System.Drawing.Size(960, 0);
            this.picHinhThamKhao.Name = "picHinhThamKhao";
            this.picHinhThamKhao.Size = new System.Drawing.Size(277, 195);
            this.picHinhThamKhao.TabIndex = 0;
            this.picHinhThamKhao.TabStop = false;
            // 
            // ItemHinhThamKhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picHinhThamKhao);
            this.MaximumSize = new System.Drawing.Size(0, 494);
            this.Name = "ItemHinhThamKhao";
            this.Size = new System.Drawing.Size(277, 195);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhThamKhao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picHinhThamKhao;
    }
}
