namespace HomeAccountingSystem.MainUserControl
{
    partial class TopUserInfoUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.linkLabelChangePhoto = new System.Windows.Forms.LinkLabel();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPhoto
            // 
            this.panelPhoto.BackColor = System.Drawing.Color.White;
            this.panelPhoto.Controls.Add(this.pictureBoxPhoto);
            this.panelPhoto.Location = new System.Drawing.Point(12, 3);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(64, 64);
            this.panelPhoto.TabIndex = 0;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Image = global::HomeAccountingSystem.Properties.Resources.账号;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.labelUserName.Location = new System.Drawing.Point(88, 6);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(122, 21);
            this.labelUserName.TabIndex = 80;
            this.labelUserName.Text = "管理员，你好！";
            // 
            // linkLabelChangePhoto
            // 
            this.linkLabelChangePhoto.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelChangePhoto.AutoSize = true;
            this.linkLabelChangePhoto.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelChangePhoto.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.linkLabelChangePhoto.Location = new System.Drawing.Point(89, 42);
            this.linkLabelChangePhoto.Name = "linkLabelChangePhoto";
            this.linkLabelChangePhoto.Size = new System.Drawing.Size(67, 15);
            this.linkLabelChangePhoto.TabIndex = 83;
            this.linkLabelChangePhoto.TabStop = true;
            this.linkLabelChangePhoto.Text = "更换头像";
            this.linkLabelChangePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePhoto_LinkClicked);
            // 
            // TopUserInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.linkLabelChangePhoto);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.panelPhoto);
            this.Name = "TopUserInfoUserControl";
            this.Size = new System.Drawing.Size(659, 70);
            this.Load += new System.EventHandler(this.TopUserInfoUserControl_Load);
            this.panelPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.LinkLabel linkLabelChangePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}
