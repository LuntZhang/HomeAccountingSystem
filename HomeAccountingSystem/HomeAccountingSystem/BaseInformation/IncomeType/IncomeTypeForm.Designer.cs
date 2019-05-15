namespace HomeAccountingSystem.BaseInformation.IncomeType
{
    partial class IncomeTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeTypeForm));
            this.VStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrigianlPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PayType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TakeoutType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ddNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RowIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridProductList = new DevExpress.XtraGrid.GridControl();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_top = new DevComponents.DotNetBar.PanelEx();
            this.buttonXExit = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXRefresh = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXModify = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXDelete = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXAdd = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VStatus
            // 
            this.VStatus.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VStatus.AppearanceCell.Options.UseFont = true;
            this.VStatus.AppearanceCell.Options.UseTextOptions = true;
            this.VStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VStatus.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VStatus.AppearanceHeader.Options.UseFont = true;
            this.VStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.VStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VStatus.Caption = "订单状态";
            this.VStatus.FieldName = "v_status";
            this.VStatus.Name = "VStatus";
            this.VStatus.OptionsColumn.AllowEdit = false;
            this.VStatus.OptionsColumn.AllowFocus = false;
            this.VStatus.OptionsColumn.AllowMove = false;
            this.VStatus.OptionsColumn.FixedWidth = true;
            this.VStatus.OptionsColumn.ReadOnly = true;
            this.VStatus.Width = 80;
            // 
            // pk
            // 
            this.pk.Caption = "pk";
            this.pk.FieldName = "pk";
            this.pk.Name = "pk";
            this.pk.Width = 20;
            // 
            // OrigianlPrice
            // 
            this.OrigianlPrice.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrigianlPrice.AppearanceCell.Options.UseFont = true;
            this.OrigianlPrice.AppearanceCell.Options.UseTextOptions = true;
            this.OrigianlPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OrigianlPrice.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrigianlPrice.AppearanceHeader.Options.UseFont = true;
            this.OrigianlPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.OrigianlPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OrigianlPrice.Caption = "订单原价";
            this.OrigianlPrice.DisplayFormat.FormatString = "0.00";
            this.OrigianlPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.OrigianlPrice.FieldName = "f_original_money";
            this.OrigianlPrice.Name = "OrigianlPrice";
            this.OrigianlPrice.OptionsColumn.AllowEdit = false;
            this.OrigianlPrice.OptionsColumn.AllowFocus = false;
            this.OrigianlPrice.Width = 70;
            // 
            // PayType
            // 
            this.PayType.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayType.AppearanceCell.Options.UseFont = true;
            this.PayType.AppearanceCell.Options.UseTextOptions = true;
            this.PayType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PayType.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayType.AppearanceHeader.Options.UseFont = true;
            this.PayType.AppearanceHeader.Options.UseTextOptions = true;
            this.PayType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PayType.Caption = "支付类型";
            this.PayType.FieldName = "v_type";
            this.PayType.Name = "PayType";
            this.PayType.OptionsColumn.AllowEdit = false;
            this.PayType.OptionsColumn.AllowFocus = false;
            this.PayType.Width = 100;
            // 
            // TakeoutType
            // 
            this.TakeoutType.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TakeoutType.AppearanceCell.Options.UseFont = true;
            this.TakeoutType.AppearanceCell.Options.UseTextOptions = true;
            this.TakeoutType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TakeoutType.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TakeoutType.AppearanceHeader.Options.UseFont = true;
            this.TakeoutType.AppearanceHeader.Options.UseTextOptions = true;
            this.TakeoutType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TakeoutType.Caption = "收入来源名";
            this.TakeoutType.FieldName = "v_zffs_no";
            this.TakeoutType.Name = "TakeoutType";
            this.TakeoutType.OptionsColumn.AllowEdit = false;
            this.TakeoutType.OptionsColumn.AllowFocus = false;
            this.TakeoutType.OptionsFilter.AllowAutoFilter = false;
            this.TakeoutType.OptionsFilter.AllowFilter = false;
            this.TakeoutType.Visible = true;
            this.TakeoutType.VisibleIndex = 2;
            this.TakeoutType.Width = 100;
            // 
            // ddNo
            // 
            this.ddNo.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddNo.AppearanceCell.Options.UseFont = true;
            this.ddNo.AppearanceCell.Options.UseTextOptions = true;
            this.ddNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ddNo.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddNo.AppearanceHeader.Options.UseFont = true;
            this.ddNo.AppearanceHeader.Options.UseTextOptions = true;
            this.ddNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ddNo.Caption = "编号";
            this.ddNo.FieldName = "v_zffs_no";
            this.ddNo.Name = "ddNo";
            this.ddNo.OptionsColumn.AllowEdit = false;
            this.ddNo.OptionsColumn.AllowFocus = false;
            this.ddNo.Visible = true;
            this.ddNo.VisibleIndex = 1;
            this.ddNo.Width = 100;
            // 
            // RowIndex
            // 
            this.RowIndex.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RowIndex.AppearanceCell.Options.UseFont = true;
            this.RowIndex.AppearanceCell.Options.UseTextOptions = true;
            this.RowIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RowIndex.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RowIndex.AppearanceHeader.Options.UseFont = true;
            this.RowIndex.AppearanceHeader.Options.UseTextOptions = true;
            this.RowIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RowIndex.Caption = "行号";
            this.RowIndex.FieldName = "row";
            this.RowIndex.Name = "RowIndex";
            this.RowIndex.OptionsColumn.AllowEdit = false;
            this.RowIndex.OptionsColumn.AllowFocus = false;
            this.RowIndex.Visible = true;
            this.RowIndex.VisibleIndex = 0;
            this.RowIndex.Width = 60;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Total.AppearanceCell.Options.UseFont = true;
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Total.AppearanceHeader.Options.UseFont = true;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.Caption = "订单总额";
            this.Total.DisplayFormat.FormatString = "0.00";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Total.FieldName = "f_total_money";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.AllowFocus = false;
            this.Total.OptionsColumn.AllowMove = false;
            this.Total.OptionsColumn.AllowSize = false;
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "f_total_money", "{0:f2}")});
            this.Total.Width = 80;
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(231)))));
            this.gridViewProductList.Appearance.FocusedRow.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewProductList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewProductList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewProductList.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewProductList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewProductList.Appearance.FooterPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridViewProductList.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewProductList.Appearance.GroupFooter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridViewProductList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridViewProductList.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewProductList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewProductList.Appearance.GroupPanel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridViewProductList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewProductList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewProductList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewProductList.Appearance.GroupRow.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewProductList.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewProductList.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewProductList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewProductList.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewProductList.Appearance.Row.Options.UseFont = true;
            this.gridViewProductList.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewProductList.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewProductList.AppearancePrint.GroupRow.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewProductList.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewProductList.AppearancePrint.Preview.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewProductList.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowIndex,
            this.ddNo,
            this.TakeoutType,
            this.PayType,
            this.OrigianlPrice,
            this.pk,
            this.Total,
            this.VStatus});
            this.gridViewProductList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewProductList.GridControl = this.gridProductList;
            this.gridViewProductList.GroupPanelText = "会员列表";
            this.gridViewProductList.HorzScrollStep = 25;
            this.gridViewProductList.IndicatorWidth = 30;
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.OptionsBehavior.ReadOnly = true;
            this.gridViewProductList.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewProductList.OptionsCustomization.AllowFilter = false;
            this.gridViewProductList.OptionsCustomization.AllowGroup = false;
            this.gridViewProductList.OptionsPrint.AutoWidth = false;
            this.gridViewProductList.OptionsView.AllowHtmlDrawGroups = false;
            this.gridViewProductList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridViewProductList.OptionsView.ColumnAutoWidth = false;
            this.gridViewProductList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewProductList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewProductList.OptionsView.ShowFooter = true;
            this.gridViewProductList.OptionsView.ShowGroupPanel = false;
            this.gridViewProductList.OptionsView.ShowIndicator = false;
            this.gridViewProductList.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewProductList.RowHeight = 30;
            // 
            // gridProductList
            // 
            this.gridProductList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridProductList.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridProductList.Location = new System.Drawing.Point(0, 193);
            this.gridProductList.LookAndFeel.SkinName = "Office 2010 Silver";
            this.gridProductList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridProductList.MainView = this.gridViewProductList;
            this.gridProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.Size = new System.Drawing.Size(471, 157);
            this.gridProductList.TabIndex = 36;
            this.gridProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductList});
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.gridControl1);
            this.panelEx1.Controls.Add(this.gridProductList);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx1.Location = new System.Drawing.Point(0, 61);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(564, 350);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 11;
            // 
            // panelEx_top
            // 
            this.panelEx_top.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx_top.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx_top.Controls.Add(this.buttonXExit);
            this.panelEx_top.Controls.Add(this.buttonXRefresh);
            this.panelEx_top.Controls.Add(this.buttonXModify);
            this.panelEx_top.Controls.Add(this.buttonXDelete);
            this.panelEx_top.Controls.Add(this.buttonXAdd);
            this.panelEx_top.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx_top.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx_top.Location = new System.Drawing.Point(0, 0);
            this.panelEx_top.Name = "panelEx_top";
            this.panelEx_top.Size = new System.Drawing.Size(564, 61);
            this.panelEx_top.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_top.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx_top.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx_top.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_top.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_top.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_top.Style.GradientAngle = 90;
            this.panelEx_top.TabIndex = 10;
            // 
            // buttonXExit
            // 
            this.buttonXExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonXExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXExit.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXExit.ForeColor = System.Drawing.Color.White;
            this.buttonXExit.Image = global::HomeAccountingSystem.Properties.Resources.退出2;
            this.buttonXExit.ImageTextSpace = 5;
            this.buttonXExit.Location = new System.Drawing.Point(350, 10);
            this.buttonXExit.Name = "buttonXExit";
            this.buttonXExit.Size = new System.Drawing.Size(80, 40);
            this.buttonXExit.TabIndex = 8;
            this.buttonXExit.Text = "退出";
            // 
            // buttonXRefresh
            // 
            this.buttonXRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXRefresh.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonXRefresh.Image = global::HomeAccountingSystem.Properties.Resources.刷新;
            this.buttonXRefresh.ImageTextSpace = 5;
            this.buttonXRefresh.Location = new System.Drawing.Point(264, 10);
            this.buttonXRefresh.Name = "buttonXRefresh";
            this.buttonXRefresh.Size = new System.Drawing.Size(80, 40);
            this.buttonXRefresh.TabIndex = 6;
            this.buttonXRefresh.Text = "刷新";
            // 
            // buttonXModify
            // 
            this.buttonXModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXModify.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXModify.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXModify.ForeColor = System.Drawing.Color.White;
            this.buttonXModify.Image = global::HomeAccountingSystem.Properties.Resources.修改;
            this.buttonXModify.ImageTextSpace = 5;
            this.buttonXModify.Location = new System.Drawing.Point(92, 10);
            this.buttonXModify.Name = "buttonXModify";
            this.buttonXModify.Size = new System.Drawing.Size(80, 40);
            this.buttonXModify.TabIndex = 4;
            this.buttonXModify.Text = "修改";
            // 
            // buttonXDelete
            // 
            this.buttonXDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXDelete.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXDelete.ForeColor = System.Drawing.Color.White;
            this.buttonXDelete.Image = global::HomeAccountingSystem.Properties.Resources.删除;
            this.buttonXDelete.ImageTextSpace = 5;
            this.buttonXDelete.Location = new System.Drawing.Point(178, 10);
            this.buttonXDelete.Name = "buttonXDelete";
            this.buttonXDelete.Size = new System.Drawing.Size(80, 40);
            this.buttonXDelete.TabIndex = 3;
            this.buttonXDelete.Text = "删除";
            // 
            // buttonXAdd
            // 
            this.buttonXAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXAdd.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXAdd.ForeColor = System.Drawing.Color.White;
            this.buttonXAdd.Image = global::HomeAccountingSystem.Properties.Resources.新增;
            this.buttonXAdd.ImageTextSpace = 5;
            this.buttonXAdd.Location = new System.Drawing.Point(6, 10);
            this.buttonXAdd.Name = "buttonXAdd";
            this.buttonXAdd.Size = new System.Drawing.Size(80, 40);
            this.buttonXAdd.TabIndex = 0;
            this.buttonXAdd.Text = "新增";
            this.buttonXAdd.Click += new System.EventHandler(this.buttonXAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(59, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 37;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "a";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // IncomeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncomeTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收入类型";
            this.Load += new System.EventHandler(this.IncomeTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn VStatus;
        private DevExpress.XtraGrid.Columns.GridColumn pk;
        private DevExpress.XtraGrid.Columns.GridColumn OrigianlPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PayType;
        private DevExpress.XtraGrid.Columns.GridColumn TakeoutType;
        private DevExpress.XtraGrid.Columns.GridColumn ddNo;
        private DevExpress.XtraGrid.Columns.GridColumn RowIndex;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductList;
        private DevExpress.XtraGrid.GridControl gridProductList;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx_top;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXExit;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXRefresh;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXModify;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXDelete;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}