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
            this.tzxPanel1 = new TZXControlLibrary.PanelEx.TzxPanel();
            this.btnLogout = new TZXControlLibrary.ButtonEx.TzxRoundedButton();
            this.btnESC = new TZXControlLibrary.ButtonEx.TzxRoundedButton();
            this.btnSetting = new TZXControlLibrary.ButtonEx.TzxRoundedButton();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tzxPanel1.SuspendLayout();
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
            // tzxPanel1
            // 
            this.tzxPanel1.BorderColor = System.Drawing.Color.Empty;
            this.tzxPanel1.BorderSize = 0;
            this.tzxPanel1.Controls.Add(this.btnLogout);
            this.tzxPanel1.Controls.Add(this.btnESC);
            this.tzxPanel1.Controls.Add(this.btnSetting);
            this.tzxPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tzxPanel1.HasBottomBorder = false;
            this.tzxPanel1.HasLeftBorder = false;
            this.tzxPanel1.HasRightBorder = false;
            this.tzxPanel1.HasTopBorder = false;
            this.tzxPanel1.Location = new System.Drawing.Point(319, 0);
            this.tzxPanel1.Name = "tzxPanel1";
            this.tzxPanel1.Size = new System.Drawing.Size(340, 70);
            this.tzxPanel1.TabIndex = 87;
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleName = "2-1100";
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnLogout.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HasArrow = false;
            this.btnLogout.Image = global::HomeAccountingSystem.Properties.Resources.注销;
            this.btnLogout.ImageTextSpace = 5;
            this.btnLogout.Location = new System.Drawing.Point(203, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Radius = 5;
            this.btnLogout.Size = new System.Drawing.Size(61, 25);
            this.btnLogout.TabIndex = 84;
            this.btnLogout.Text = "注销";
            this.btnLogout.Tip = "";
            this.btnLogout.TipColor = System.Drawing.Color.Red;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnESC
            // 
            this.btnESC.AccessibleName = "2-1100";
            this.btnESC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnESC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnESC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnESC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnESC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnESC.ForeColor = System.Drawing.Color.White;
            this.btnESC.HasArrow = false;
            this.btnESC.Image = global::HomeAccountingSystem.Properties.Resources.退出_1_;
            this.btnESC.ImageTextSpace = 5;
            this.btnESC.Location = new System.Drawing.Point(270, 6);
            this.btnESC.Name = "btnESC";
            this.btnESC.Radius = 5;
            this.btnESC.Size = new System.Drawing.Size(61, 25);
            this.btnESC.TabIndex = 85;
            this.btnESC.Text = "退出";
            this.btnESC.Tip = "";
            this.btnESC.TipColor = System.Drawing.Color.Red;
            this.btnESC.Click += new System.EventHandler(this.btnESC_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.AccessibleName = "2-1100";
            this.btnSetting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetting.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HasArrow = false;
            this.btnSetting.Image = global::HomeAccountingSystem.Properties.Resources.设置1;
            this.btnSetting.ImageTextSpace = 5;
            this.btnSetting.Location = new System.Drawing.Point(136, 6);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Radius = 5;
            this.btnSetting.Size = new System.Drawing.Size(61, 25);
            this.btnSetting.TabIndex = 86;
            this.btnSetting.Text = "设置";
            this.btnSetting.Tip = "";
            this.btnSetting.TipColor = System.Drawing.Color.Red;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // TopUserInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tzxPanel1);
            this.Controls.Add(this.linkLabelChangePhoto);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.panelPhoto);
            this.Name = "TopUserInfoUserControl";
            this.Size = new System.Drawing.Size(659, 70);
            this.Load += new System.EventHandler(this.TopUserInfoUserControl_Load);
            this.panelPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tzxPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.LinkLabel linkLabelChangePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private TZXControlLibrary.ButtonEx.TzxRoundedButton btnESC;
        private TZXControlLibrary.ButtonEx.TzxRoundedButton btnLogout;
        private TZXControlLibrary.ButtonEx.TzxRoundedButton btnSetting;
        private TZXControlLibrary.PanelEx.TzxPanel tzxPanel1;
    }
}
