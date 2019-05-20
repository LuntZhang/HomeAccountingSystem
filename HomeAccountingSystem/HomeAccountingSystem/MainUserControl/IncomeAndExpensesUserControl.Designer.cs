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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelYesterday = new System.Windows.Forms.Label();
            this.labelBeforeOneDay = new System.Windows.Forms.Label();
            this.panelIncome = new System.Windows.Forms.Panel();
            this.pictureBoxExpend = new System.Windows.Forms.PictureBox();
            this.labelExpendWriteABill = new System.Windows.Forms.Label();
            this.labelExpendInfo = new System.Windows.Forms.Label();
            this.linkLabelExpendMoney = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelExpend = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIncome = new System.Windows.Forms.PictureBox();
            this.labelIncomeWriteABill = new System.Windows.Forms.Label();
            this.labelIncomeInfo = new System.Windows.Forms.Label();
            this.linkLabelIncomeMoney = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpend)).BeginInit();
            this.panelExpend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncome)).BeginInit();
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(66)))));
            this.labelToday.Location = new System.Drawing.Point(411, 5);
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
            this.labelYesterday.Location = new System.Drawing.Point(270, 5);
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
            this.labelBeforeOneDay.Location = new System.Drawing.Point(122, 5);
            this.labelBeforeOneDay.Name = "labelBeforeOneDay";
            this.labelBeforeOneDay.Size = new System.Drawing.Size(54, 21);
            this.labelBeforeOneDay.TabIndex = 3;
            this.labelBeforeOneDay.Text = "前天";
            this.labelBeforeOneDay.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // panelIncome
            // 
            this.panelIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panelIncome.Controls.Add(this.pictureBoxExpend);
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
            // pictureBoxExpend
            // 
            this.pictureBoxExpend.Location = new System.Drawing.Point(486, 20);
            this.pictureBoxExpend.Name = "pictureBoxExpend";
            this.pictureBoxExpend.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxExpend.TabIndex = 3;
            this.pictureBoxExpend.TabStop = false;
            // 
            // labelExpendWriteABill
            // 
            this.labelExpendWriteABill.AutoSize = true;
            this.labelExpendWriteABill.Font = new System.Drawing.Font("楷体", 14F);
            this.labelExpendWriteABill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.labelExpendWriteABill.Location = new System.Drawing.Point(411, 21);
            this.labelExpendWriteABill.Name = "labelExpendWriteABill";
            this.labelExpendWriteABill.Size = new System.Drawing.Size(69, 19);
            this.labelExpendWriteABill.TabIndex = 2;
            this.labelExpendWriteABill.Text = "记一笔";
            this.labelExpendWriteABill.Click += new System.EventHandler(this.labelExpendWriteABill_Click);
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
            this.panelExpend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panelExpend.Controls.Add(this.groupBox1);
            this.panelExpend.Controls.Add(this.pictureBoxIncome);
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
            // pictureBoxIncome
            // 
            this.pictureBoxIncome.Location = new System.Drawing.Point(486, 26);
            this.pictureBoxIncome.Name = "pictureBoxIncome";
            this.pictureBoxIncome.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxIncome.TabIndex = 4;
            this.pictureBoxIncome.TabStop = false;
            // 
            // labelIncomeWriteABill
            // 
            this.labelIncomeWriteABill.AutoSize = true;
            this.labelIncomeWriteABill.Font = new System.Drawing.Font("楷体", 14F);
            this.labelIncomeWriteABill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.labelIncomeWriteABill.Location = new System.Drawing.Point(411, 26);
            this.labelIncomeWriteABill.Name = "labelIncomeWriteABill";
            this.labelIncomeWriteABill.Size = new System.Drawing.Size(69, 19);
            this.labelIncomeWriteABill.TabIndex = 3;
            this.labelIncomeWriteABill.Text = "记一笔";
            this.labelIncomeWriteABill.Click += new System.EventHandler(this.labelIncomeWriteABill_Click);
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
            this.BackColor = System.Drawing.Color.White;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpend)).EndInit();
            this.panelExpend.ResumeLayout(false);
            this.panelExpend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncome)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxExpend;
        private System.Windows.Forms.PictureBox pictureBoxIncome;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
