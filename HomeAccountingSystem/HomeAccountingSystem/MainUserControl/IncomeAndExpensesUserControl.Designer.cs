namespace HomeAccountingSystem.MainUserControl
{
    partial class IncomeAndExpensesUserControl
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
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelYesterday = new System.Windows.Forms.Label();
            this.labelBeforeOneDay = new System.Windows.Forms.Label();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.labelExpendWriteABill = new System.Windows.Forms.Label();
            this.labelExpendInfo = new System.Windows.Forms.Label();
            this.linkLabelExpendMoney = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelExpend = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIncomeWriteABill = new System.Windows.Forms.Label();
            this.labelIncomeInfo = new System.Windows.Forms.Label();
            this.linkLabelIncomeMoney = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelIncome.SuspendLayout();
            this.panelExpend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelTime);
            this.panelAll.Controls.Add(this.panelIncome);
            this.panelAll.Controls.Add(this.panelExpend);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(10);
            this.panelAll.Size = new System.Drawing.Size(560, 250);
            this.panelAll.TabIndex = 0;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.panelTime.Controls.Add(this.label);
            this.panelTime.Controls.Add(this.pictureBox3);
            this.panelTime.Controls.Add(this.labelToday);
            this.panelTime.Controls.Add(this.labelYesterday);
            this.panelTime.Controls.Add(this.labelBeforeOneDay);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTime.Location = new System.Drawing.Point(10, 10);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(540, 34);
            this.panelTime.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 12F);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(33, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 16);
            this.label.TabIndex = 6;
            this.label.Text = "记一笔";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HomeAccountingSystem.Properties.Resources.记一笔_3_;
            this.pictureBox3.Location = new System.Drawing.Point(3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelToday.ForeColor = System.Drawing.Color.Red;
            this.labelToday.Location = new System.Drawing.Point(411, 6);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(54, 21);
            this.labelToday.TabIndex = 5;
            this.labelToday.Text = "今天";
            this.labelToday.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // labelYesterday
            // 
            this.labelYesterday.AutoSize = true;
            this.labelYesterday.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelYesterday.ForeColor = System.Drawing.Color.White;
            this.labelYesterday.Location = new System.Drawing.Point(290, 6);
            this.labelYesterday.Name = "labelYesterday";
            this.labelYesterday.Size = new System.Drawing.Size(54, 21);
            this.labelYesterday.TabIndex = 4;
            this.labelYesterday.Text = "昨天";
            this.labelYesterday.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // labelBeforeOneDay
            // 
            this.labelBeforeOneDay.AutoSize = true;
            this.labelBeforeOneDay.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBeforeOneDay.ForeColor = System.Drawing.Color.White;
            this.labelBeforeOneDay.Location = new System.Drawing.Point(178, 6);
            this.labelBeforeOneDay.Name = "labelBeforeOneDay";
            this.labelBeforeOneDay.Size = new System.Drawing.Size(54, 21);
            this.labelBeforeOneDay.TabIndex = 3;
            this.labelBeforeOneDay.Text = "前天";
            this.labelBeforeOneDay.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // panelIncome
            // 
            this.panelIncome.BackColor = System.Drawing.Color.White;
            this.panelIncome.Controls.Add(this.labelExpendWriteABill);
            this.panelIncome.Controls.Add(this.labelExpendInfo);
            this.panelIncome.Controls.Add(this.linkLabelExpendMoney);
            this.panelIncome.Controls.Add(this.label1);
            this.panelIncome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIncome.Location = new System.Drawing.Point(10, 44);
            this.panelIncome.Name = "panelIncome";
            this.panelIncome.Size = new System.Drawing.Size(540, 98);
            this.panelIncome.TabIndex = 1;
            // 
            // labelExpendWriteABill
            // 
            this.labelExpendWriteABill.AutoSize = true;
            this.labelExpendWriteABill.Font = new System.Drawing.Font("楷体", 14F);
            this.labelExpendWriteABill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.labelExpendWriteABill.Location = new System.Drawing.Point(411, 21);
            this.labelExpendWriteABill.Name = "labelExpendWriteABill";
            this.labelExpendWriteABill.Size = new System.Drawing.Size(89, 19);
            this.labelExpendWriteABill.TabIndex = 2;
            this.labelExpendWriteABill.Text = "记一笔>>";
            this.labelExpendWriteABill.Click += new System.EventHandler(this.pictureBoxExpend_Click);
            this.labelExpendWriteABill.MouseEnter += new System.EventHandler(this.labelWriteABill_MouseEnter);
            this.labelExpendWriteABill.MouseLeave += new System.EventHandler(this.labelWriteABill_MouseLeave);
            // 
            // labelExpendInfo
            // 
            this.labelExpendInfo.AutoSize = true;
            this.labelExpendInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExpendInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelExpendInfo.Location = new System.Drawing.Point(123, 54);
            this.labelExpendInfo.Name = "labelExpendInfo";
            this.labelExpendInfo.Size = new System.Drawing.Size(120, 16);
            this.labelExpendInfo.TabIndex = 1;
            this.labelExpendInfo.Text = "今天还没记账！";
            // 
            // linkLabelExpendMoney
            // 
            this.linkLabelExpendMoney.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelExpendMoney.AutoSize = true;
            this.linkLabelExpendMoney.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelExpendMoney.LinkColor = System.Drawing.Color.Green;
            this.linkLabelExpendMoney.Location = new System.Drawing.Point(122, 21);
            this.linkLabelExpendMoney.Name = "linkLabelExpendMoney";
            this.linkLabelExpendMoney.Size = new System.Drawing.Size(49, 19);
            this.linkLabelExpendMoney.TabIndex = 0;
            this.linkLabelExpendMoney.TabStop = true;
            this.linkLabelExpendMoney.Text = "0.00";
            this.linkLabelExpendMoney.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExpendMoney_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "支";
            // 
            // panelExpend
            // 
            this.panelExpend.BackColor = System.Drawing.Color.White;
            this.panelExpend.Controls.Add(this.groupBox1);
            this.panelExpend.Controls.Add(this.labelIncomeWriteABill);
            this.panelExpend.Controls.Add(this.labelIncomeInfo);
            this.panelExpend.Controls.Add(this.linkLabelIncomeMoney);
            this.panelExpend.Controls.Add(this.label2);
            this.panelExpend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExpend.Location = new System.Drawing.Point(10, 142);
            this.panelExpend.Name = "panelExpend";
            this.panelExpend.Size = new System.Drawing.Size(540, 98);
            this.panelExpend.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 1);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelIncomeWriteABill
            // 
            this.labelIncomeWriteABill.AutoSize = true;
            this.labelIncomeWriteABill.Font = new System.Drawing.Font("楷体", 14F);
            this.labelIncomeWriteABill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.labelIncomeWriteABill.Location = new System.Drawing.Point(411, 26);
            this.labelIncomeWriteABill.Name = "labelIncomeWriteABill";
            this.labelIncomeWriteABill.Size = new System.Drawing.Size(89, 19);
            this.labelIncomeWriteABill.TabIndex = 3;
            this.labelIncomeWriteABill.Text = "记一笔>>";
            this.labelIncomeWriteABill.Click += new System.EventHandler(this.pictureBoxIncome_Click);
            this.labelIncomeWriteABill.MouseEnter += new System.EventHandler(this.labelWriteABill_MouseEnter);
            this.labelIncomeWriteABill.MouseLeave += new System.EventHandler(this.labelWriteABill_MouseLeave);
            // 
            // labelIncomeInfo
            // 
            this.labelIncomeInfo.AutoSize = true;
            this.labelIncomeInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIncomeInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelIncomeInfo.Location = new System.Drawing.Point(123, 59);
            this.labelIncomeInfo.Name = "labelIncomeInfo";
            this.labelIncomeInfo.Size = new System.Drawing.Size(120, 16);
            this.labelIncomeInfo.TabIndex = 2;
            this.labelIncomeInfo.Text = "今天还没记账！";
            // 
            // linkLabelIncomeMoney
            // 
            this.linkLabelIncomeMoney.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelIncomeMoney.AutoSize = true;
            this.linkLabelIncomeMoney.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelIncomeMoney.LinkColor = System.Drawing.Color.Red;
            this.linkLabelIncomeMoney.Location = new System.Drawing.Point(122, 26);
            this.linkLabelIncomeMoney.Name = "linkLabelIncomeMoney";
            this.linkLabelIncomeMoney.Size = new System.Drawing.Size(49, 19);
            this.linkLabelIncomeMoney.TabIndex = 1;
            this.linkLabelIncomeMoney.TabStop = true;
            this.linkLabelIncomeMoney.Text = "0.00";
            this.linkLabelIncomeMoney.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelIncomeMoney_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 30F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "收";
            // 
            // IncomeAndExpensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelAll);
            this.Name = "IncomeAndExpensesUserControl";
            this.Size = new System.Drawing.Size(560, 250);
            this.Load += new System.EventHandler(this.IncomeAndExpensesUserControl_Load);
            this.panelAll.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelIncome.ResumeLayout(false);
            this.panelIncome.PerformLayout();
            this.panelExpend.ResumeLayout(false);
            this.panelExpend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelIncome;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Panel panelExpend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelExpendMoney;
        private System.Windows.Forms.LinkLabel linkLabelIncomeMoney;
        private System.Windows.Forms.Label labelExpendWriteABill;
        private System.Windows.Forms.Label labelExpendInfo;
        private System.Windows.Forms.Label labelIncomeWriteABill;
        private System.Windows.Forms.Label labelIncomeInfo;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelYesterday;
        private System.Windows.Forms.Label labelBeforeOneDay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
    }
}
