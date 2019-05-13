namespace HomeAccountingSystem.AboutUserInfo
{
    partial class ChangePasswordForm
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
            this.tzxPanelBotton = new TZXControlLibrary.PanelEx.TzxPanel();
            this.btnCancel = new TZXControlLibrary.ButtonEx.TzxRoundedButton();
            this.btnOK = new TZXControlLibrary.ButtonEx.TzxRoundedButton();
            this.tzxPanelPhoto = new TZXControlLibrary.PanelEx.TzxPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPwd = new System.Windows.Forms.TextBox();
            this.textBoxNewPwd = new System.Windows.Forms.TextBox();
            this.textBoxAgainInput = new System.Windows.Forms.TextBox();
            this.tzxPanelBotton.SuspendLayout();
            this.tzxPanelPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tzxPanelBotton
            // 
            this.tzxPanelBotton.BorderColor = System.Drawing.Color.Empty;
            this.tzxPanelBotton.BorderSize = 0;
            this.tzxPanelBotton.Controls.Add(this.btnCancel);
            this.tzxPanelBotton.Controls.Add(this.btnOK);
            this.tzxPanelBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tzxPanelBotton.HasBottomBorder = false;
            this.tzxPanelBotton.HasLeftBorder = false;
            this.tzxPanelBotton.HasRightBorder = false;
            this.tzxPanelBotton.HasTopBorder = false;
            this.tzxPanelBotton.Location = new System.Drawing.Point(0, 169);
            this.tzxPanelBotton.Name = "tzxPanelBotton";
            this.tzxPanelBotton.Size = new System.Drawing.Size(461, 52);
            this.tzxPanelBotton.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "2-1100";
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HasArrow = false;
            this.btnCancel.ImageTextSpace = 5;
            this.btnCancel.Location = new System.Drawing.Point(369, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 5;
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "取消";
            this.btnCancel.Tip = "";
            this.btnCancel.TipColor = System.Drawing.Color.Red;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleName = "2-1100";
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HasArrow = false;
            this.btnOK.ImageTextSpace = 5;
            this.btnOK.Location = new System.Drawing.Point(286, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 5;
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 72;
            this.btnOK.Text = "确定";
            this.btnOK.Tip = "";
            this.btnOK.TipColor = System.Drawing.Color.Red;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tzxPanelPhoto
            // 
            this.tzxPanelPhoto.BackColor = System.Drawing.Color.MintCream;
            this.tzxPanelPhoto.BorderColor = System.Drawing.Color.Empty;
            this.tzxPanelPhoto.BorderSize = 0;
            this.tzxPanelPhoto.Controls.Add(this.textBoxAgainInput);
            this.tzxPanelPhoto.Controls.Add(this.textBoxNewPwd);
            this.tzxPanelPhoto.Controls.Add(this.textBoxOldPwd);
            this.tzxPanelPhoto.Controls.Add(this.label3);
            this.tzxPanelPhoto.Controls.Add(this.label2);
            this.tzxPanelPhoto.Controls.Add(this.label1);
            this.tzxPanelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tzxPanelPhoto.HasBottomBorder = false;
            this.tzxPanelPhoto.HasLeftBorder = false;
            this.tzxPanelPhoto.HasRightBorder = false;
            this.tzxPanelPhoto.HasTopBorder = false;
            this.tzxPanelPhoto.Location = new System.Drawing.Point(0, 0);
            this.tzxPanelPhoto.Name = "tzxPanelPhoto";
            this.tzxPanelPhoto.Size = new System.Drawing.Size(461, 221);
            this.tzxPanelPhoto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入：";
            // 
            // textBoxOldPwd
            // 
            this.textBoxOldPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxOldPwd.Location = new System.Drawing.Point(160, 34);
            this.textBoxOldPwd.Name = "textBoxOldPwd";
            this.textBoxOldPwd.PasswordChar = '*';
            this.textBoxOldPwd.Size = new System.Drawing.Size(169, 29);
            this.textBoxOldPwd.TabIndex = 3;
            // 
            // textBoxNewPwd
            // 
            this.textBoxNewPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxNewPwd.Location = new System.Drawing.Point(160, 69);
            this.textBoxNewPwd.Name = "textBoxNewPwd";
            this.textBoxNewPwd.PasswordChar = '*';
            this.textBoxNewPwd.Size = new System.Drawing.Size(169, 29);
            this.textBoxNewPwd.TabIndex = 4;
            // 
            // textBoxAgainInput
            // 
            this.textBoxAgainInput.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxAgainInput.Location = new System.Drawing.Point(160, 104);
            this.textBoxAgainInput.Name = "textBoxAgainInput";
            this.textBoxAgainInput.PasswordChar = '*';
            this.textBoxAgainInput.Size = new System.Drawing.Size(169, 29);
            this.textBoxAgainInput.TabIndex = 5;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 221);
            this.Controls.Add(this.tzxPanelBotton);
            this.Controls.Add(this.tzxPanelPhoto);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.tzxPanelBotton.ResumeLayout(false);
            this.tzxPanelPhoto.ResumeLayout(false);
            this.tzxPanelPhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TZXControlLibrary.PanelEx.TzxPanel tzxPanelBotton;
        private TZXControlLibrary.ButtonEx.TzxRoundedButton btnCancel;
        private TZXControlLibrary.ButtonEx.TzxRoundedButton btnOK;
        private TZXControlLibrary.PanelEx.TzxPanel tzxPanelPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAgainInput;
        private System.Windows.Forms.TextBox textBoxNewPwd;
        private System.Windows.Forms.TextBox textBoxOldPwd;
    }
}