namespace HomeAccountingSystem.BaseInformation
{
    partial class BaseInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseInfoForm));
            this.metroTilePanelBaseInfo = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainerBaseSetting = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItemPayType = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItemExpendType = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItemIncomeType = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // metroTilePanelBaseInfo
            // 
            this.metroTilePanelBaseInfo.AutoScroll = false;
            this.metroTilePanelBaseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            // 
            // 
            // 
            this.metroTilePanelBaseInfo.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.metroTilePanelBaseInfo.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanelBaseInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanelBaseInfo.ContainerControlProcessDialogKey = true;
            this.metroTilePanelBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTilePanelBaseInfo.DragDropSupport = true;
            this.metroTilePanelBaseInfo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerBaseSetting});
            this.metroTilePanelBaseInfo.ItemSpacing = 12;
            this.metroTilePanelBaseInfo.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanelBaseInfo.MultiLine = true;
            this.metroTilePanelBaseInfo.Name = "metroTilePanelBaseInfo";
            this.metroTilePanelBaseInfo.Size = new System.Drawing.Size(550, 138);
            this.metroTilePanelBaseInfo.TabIndex = 97;
            this.metroTilePanelBaseInfo.Text = "metroTilePanelBaseInfo";
            // 
            // itemContainerBaseSetting
            // 
            // 
            // 
            // 
            this.itemContainerBaseSetting.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainerBaseSetting.BackgroundStyle.BorderBottomWidth = 1;
            this.itemContainerBaseSetting.BackgroundStyle.BorderColor = System.Drawing.Color.Silver;
            this.itemContainerBaseSetting.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainerBaseSetting.BackgroundStyle.BorderLeftWidth = 1;
            this.itemContainerBaseSetting.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainerBaseSetting.BackgroundStyle.BorderRightWidth = 1;
            this.itemContainerBaseSetting.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainerBaseSetting.BackgroundStyle.BorderTopWidth = 1;
            this.itemContainerBaseSetting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainerBaseSetting.BackgroundStyle.PaddingBottom = 4;
            this.itemContainerBaseSetting.BackgroundStyle.PaddingLeft = 4;
            this.itemContainerBaseSetting.BackgroundStyle.PaddingRight = 4;
            this.itemContainerBaseSetting.ItemSpacing = 8;
            this.itemContainerBaseSetting.MultiLine = true;
            this.itemContainerBaseSetting.Name = "itemContainerBaseSetting";
            this.itemContainerBaseSetting.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItemPayType,
            this.metroTileItemExpendType,
            this.metroTileItemIncomeType});
            this.itemContainerBaseSetting.Text = "基础设置";
            // 
            // 
            // 
            this.itemContainerBaseSetting.TitleStyle.Class = "RibbonGalleryContainer";
            this.itemContainerBaseSetting.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainerBaseSetting.TitleStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemContainerBaseSetting.TitleStyle.MarginBottom = 5;
            this.itemContainerBaseSetting.TitleStyle.MarginLeft = 5;
            this.itemContainerBaseSetting.TitleStyle.MarginRight = 5;
            this.itemContainerBaseSetting.TitleText = "基础设置";
            this.itemContainerBaseSetting.TitleVisible = false;
            // 
            // metroTileItemPayType
            // 
            this.metroTileItemPayType.AccessibleName = "1-1203";
            this.metroTileItemPayType.Image = global::HomeAccountingSystem.Properties.Resources.BaseInfo_收银方式;
            this.metroTileItemPayType.ImageIndent = new System.Drawing.Point(6, 15);
            this.metroTileItemPayType.Name = "metroTileItemPayType";
            this.metroTileItemPayType.Stretch = true;
            this.metroTileItemPayType.SymbolColor = System.Drawing.Color.White;
            this.metroTileItemPayType.Tag = "HomeAccountingSystem.BaseInformation.PaymentType.PaymentTypeForm";
            this.metroTileItemPayType.Text = "支付类型";
            this.metroTileItemPayType.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            this.metroTileItemPayType.TileSize = new System.Drawing.Size(160, 100);
            // 
            // 
            // 
            this.metroTileItemPayType.TileStyle.BackColor = System.Drawing.Color.White;
            this.metroTileItemPayType.TileStyle.BackColor2 = System.Drawing.Color.White;
            this.metroTileItemPayType.TileStyle.BorderColor = System.Drawing.Color.White;
            this.metroTileItemPayType.TileStyle.BorderColor2 = System.Drawing.Color.White;
            this.metroTileItemPayType.TileStyle.CornerDiameter = 5;
            this.metroTileItemPayType.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.metroTileItemPayType.TileStyle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTileItemPayType.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItemPayType.TileStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.metroTileItemPayType.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItemPayType.Click += new System.EventHandler(this.metroTileItem_Click);
            // 
            // metroTileItemExpendType
            // 
            this.metroTileItemExpendType.AccessibleName = "1-1201";
            this.metroTileItemExpendType.Image = global::HomeAccountingSystem.Properties.Resources.FrontManager_营业日结;
            this.metroTileItemExpendType.ImageIndent = new System.Drawing.Point(6, 15);
            this.metroTileItemExpendType.Name = "metroTileItemExpendType";
            this.metroTileItemExpendType.Stretch = true;
            this.metroTileItemExpendType.SymbolColor = System.Drawing.Color.White;
            this.metroTileItemExpendType.Tag = "HomeAccountingSystem.BaseInformation.ExpendType.ExpendTypeForm";
            this.metroTileItemExpendType.Text = "支出用途";
            this.metroTileItemExpendType.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            this.metroTileItemExpendType.TileSize = new System.Drawing.Size(160, 100);
            // 
            // 
            // 
            this.metroTileItemExpendType.TileStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTileItemExpendType.TileStyle.BackColor2 = System.Drawing.Color.White;
            this.metroTileItemExpendType.TileStyle.BorderColor = System.Drawing.Color.White;
            this.metroTileItemExpendType.TileStyle.BorderColor2 = System.Drawing.Color.White;
            this.metroTileItemExpendType.TileStyle.CornerDiameter = 5;
            this.metroTileItemExpendType.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.metroTileItemExpendType.TileStyle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTileItemExpendType.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItemExpendType.TileStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.metroTileItemExpendType.TitleText = "餐桌资料";
            this.metroTileItemExpendType.TitleTextColor = System.Drawing.Color.Transparent;
            this.metroTileItemExpendType.Click += new System.EventHandler(this.metroTileItem_Click);
            // 
            // metroTileItemIncomeType
            // 
            this.metroTileItemIncomeType.AccessibleName = "1-1202";
            this.metroTileItemIncomeType.Image = global::HomeAccountingSystem.Properties.Resources.InventoryCenter_供应商结算账款;
            this.metroTileItemIncomeType.ImageIndent = new System.Drawing.Point(6, 15);
            this.metroTileItemIncomeType.Name = "metroTileItemIncomeType";
            this.metroTileItemIncomeType.Stretch = true;
            this.metroTileItemIncomeType.SymbolColor = System.Drawing.Color.White;
            this.metroTileItemIncomeType.Tag = "HomeAccountingSystem.BaseInformation.IncomeType.IncomeTypeForm";
            this.metroTileItemIncomeType.Text = "收入来源";
            this.metroTileItemIncomeType.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            this.metroTileItemIncomeType.TileSize = new System.Drawing.Size(160, 100);
            // 
            // 
            // 
            this.metroTileItemIncomeType.TileStyle.BackColor = System.Drawing.Color.White;
            this.metroTileItemIncomeType.TileStyle.BackColor2 = System.Drawing.Color.White;
            this.metroTileItemIncomeType.TileStyle.BorderColor = System.Drawing.Color.White;
            this.metroTileItemIncomeType.TileStyle.BorderColor2 = System.Drawing.Color.White;
            this.metroTileItemIncomeType.TileStyle.CornerDiameter = 5;
            this.metroTileItemIncomeType.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.metroTileItemIncomeType.TileStyle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTileItemIncomeType.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.metroTileItemIncomeType.TileStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.metroTileItemIncomeType.TitleTextColor = System.Drawing.Color.Transparent;
            this.metroTileItemIncomeType.Click += new System.EventHandler(this.metroTileItem_Click);
            // 
            // BaseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 138);
            this.Controls.Add(this.metroTilePanelBaseInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基础资料";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanelBaseInfo;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemPayType;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemExpendType;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItemIncomeType;
        private DevComponents.DotNetBar.ItemContainer itemContainerBaseSetting;
    }
}