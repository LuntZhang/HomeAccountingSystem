namespace HomeAccountingSystem.BaseInformation.ExpendType
{
    partial class ExpendTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpendTypeForm));
            this.VStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrigianlPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PayType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_zclx_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_zc_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewDataList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDataList = new DevExpress.XtraGrid.GridControl();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx_top = new DevComponents.DotNetBar.PanelEx();
            this.tzxButtonExRefresh = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXExit = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXSave = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXDelete = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            this.buttonXAdd = new TZXControlLibrary.ButtonEx.TzxButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataList)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx_top.SuspendLayout();
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
            // v_zclx_name
            // 
            this.v_zclx_name.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v_zclx_name.AppearanceCell.Options.UseFont = true;
            this.v_zclx_name.AppearanceCell.Options.UseTextOptions = true;
            this.v_zclx_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.v_zclx_name.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v_zclx_name.AppearanceHeader.Options.UseFont = true;
            this.v_zclx_name.AppearanceHeader.Options.UseTextOptions = true;
            this.v_zclx_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.v_zclx_name.Caption = "支出用途名";
            this.v_zclx_name.FieldName = "v_zclx_name";
            this.v_zclx_name.Name = "v_zclx_name";
            this.v_zclx_name.Visible = true;
            this.v_zclx_name.VisibleIndex = 2;
            this.v_zclx_name.Width = 100;
            // 
            // v_zc_no
            // 
            this.v_zc_no.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v_zc_no.AppearanceCell.Options.UseFont = true;
            this.v_zc_no.AppearanceCell.Options.UseTextOptions = true;
            this.v_zc_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.v_zc_no.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v_zc_no.AppearanceHeader.Options.UseFont = true;
            this.v_zc_no.AppearanceHeader.Options.UseTextOptions = true;
            this.v_zc_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.v_zc_no.Caption = "编号";
            this.v_zc_no.FieldName = "v_zc_no";
            this.v_zc_no.Name = "v_zc_no";
            this.v_zc_no.OptionsColumn.AllowEdit = false;
            this.v_zc_no.OptionsColumn.AllowFocus = false;
            this.v_zc_no.Visible = true;
            this.v_zc_no.VisibleIndex = 1;
            this.v_zc_no.Width = 100;
            // 
            // row
            // 
            this.row.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.row.AppearanceCell.Options.UseFont = true;
            this.row.AppearanceCell.Options.UseTextOptions = true;
            this.row.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.row.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.row.AppearanceHeader.Options.UseFont = true;
            this.row.AppearanceHeader.Options.UseTextOptions = true;
            this.row.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.row.Caption = "行号";
            this.row.FieldName = "row";
            this.row.Name = "row";
            this.row.OptionsColumn.AllowEdit = false;
            this.row.OptionsColumn.AllowFocus = false;
            this.row.Visible = true;
            this.row.VisibleIndex = 0;
            this.row.Width = 60;
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
            // gridViewDataList
            // 
            this.gridViewDataList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.gridViewDataList.Appearance.FocusedRow.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewDataList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDataList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDataList.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewDataList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDataList.Appearance.FooterPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridViewDataList.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDataList.Appearance.GroupFooter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.gridViewDataList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridViewDataList.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewDataList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewDataList.Appearance.GroupPanel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridViewDataList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewDataList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewDataList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDataList.Appearance.GroupRow.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewDataList.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewDataList.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewDataList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDataList.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gridViewDataList.Appearance.Row.Options.UseFont = true;
            this.gridViewDataList.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewDataList.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewDataList.AppearancePrint.GroupRow.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewDataList.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewDataList.AppearancePrint.Preview.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridViewDataList.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewDataList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.row,
            this.v_zc_no,
            this.v_zclx_name,
            this.PayType,
            this.OrigianlPrice,
            this.pk,
            this.Total,
            this.VStatus});
            this.gridViewDataList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewDataList.GridControl = this.gridControlDataList;
            this.gridViewDataList.GroupPanelText = "会员列表";
            this.gridViewDataList.HorzScrollStep = 25;
            this.gridViewDataList.IndicatorWidth = 30;
            this.gridViewDataList.Name = "gridViewDataList";
            this.gridViewDataList.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewDataList.OptionsCustomization.AllowFilter = false;
            this.gridViewDataList.OptionsCustomization.AllowGroup = false;
            this.gridViewDataList.OptionsPrint.AutoWidth = false;
            this.gridViewDataList.OptionsView.AllowHtmlDrawGroups = false;
            this.gridViewDataList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridViewDataList.OptionsView.ColumnAutoWidth = false;
            this.gridViewDataList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewDataList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDataList.OptionsView.ShowFooter = true;
            this.gridViewDataList.OptionsView.ShowGroupPanel = false;
            this.gridViewDataList.OptionsView.ShowIndicator = false;
            this.gridViewDataList.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDataList.RowHeight = 30;
            // 
            // gridControlDataList
            // 
            this.gridControlDataList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDataList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlDataList.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.gridControlDataList.Location = new System.Drawing.Point(0, 0);
            this.gridControlDataList.LookAndFeel.SkinName = "Office 2010 Silver";
            this.gridControlDataList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlDataList.MainView = this.gridViewDataList;
            this.gridControlDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlDataList.Name = "gridControlDataList";
            this.gridControlDataList.Size = new System.Drawing.Size(445, 350);
            this.gridControlDataList.TabIndex = 36;
            this.gridControlDataList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataList});
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.gridControlDataList);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx1.Location = new System.Drawing.Point(0, 61);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(445, 350);
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
            this.panelEx_top.Controls.Add(this.tzxButtonExRefresh);
            this.panelEx_top.Controls.Add(this.buttonXExit);
            this.panelEx_top.Controls.Add(this.buttonXSave);
            this.panelEx_top.Controls.Add(this.buttonXDelete);
            this.panelEx_top.Controls.Add(this.buttonXAdd);
            this.panelEx_top.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx_top.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx_top.Location = new System.Drawing.Point(0, 0);
            this.panelEx_top.Name = "panelEx_top";
            this.panelEx_top.Size = new System.Drawing.Size(445, 61);
            this.panelEx_top.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_top.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx_top.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelEx_top.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_top.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx_top.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_top.Style.GradientAngle = 90;
            this.panelEx_top.TabIndex = 10;
            // 
            // tzxButtonExRefresh
            // 
            this.tzxButtonExRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tzxButtonExRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.tzxButtonExRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.tzxButtonExRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.tzxButtonExRefresh.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tzxButtonExRefresh.ForeColor = System.Drawing.Color.White;
            this.tzxButtonExRefresh.Image = global::HomeAccountingSystem.Properties.Resources.刷新;
            this.tzxButtonExRefresh.ImageTextSpace = 5;
            this.tzxButtonExRefresh.Location = new System.Drawing.Point(264, 10);
            this.tzxButtonExRefresh.Name = "tzxButtonExRefresh";
            this.tzxButtonExRefresh.Size = new System.Drawing.Size(80, 40);
            this.tzxButtonExRefresh.TabIndex = 9;
            this.tzxButtonExRefresh.Text = "刷新";
            this.tzxButtonExRefresh.Click += new System.EventHandler(this.tzxButtonExRefresh_Click);
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
            this.buttonXExit.Click += new System.EventHandler(this.buttonXExit_Click);
            // 
            // buttonXSave
            // 
            this.buttonXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(152)))), ((int)(((byte)(96)))));
            this.buttonXSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(34)))));
            this.buttonXSave.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonXSave.ForeColor = System.Drawing.Color.White;
            this.buttonXSave.Image = global::HomeAccountingSystem.Properties.Resources.确定;
            this.buttonXSave.ImageTextSpace = 5;
            this.buttonXSave.Location = new System.Drawing.Point(178, 10);
            this.buttonXSave.Name = "buttonXSave";
            this.buttonXSave.Size = new System.Drawing.Size(80, 40);
            this.buttonXSave.TabIndex = 6;
            this.buttonXSave.Text = "保存";
            this.buttonXSave.Click += new System.EventHandler(this.buttonXSave_Click);
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
            this.buttonXDelete.Location = new System.Drawing.Point(92, 10);
            this.buttonXDelete.Name = "buttonXDelete";
            this.buttonXDelete.Size = new System.Drawing.Size(80, 40);
            this.buttonXDelete.TabIndex = 3;
            this.buttonXDelete.Text = "删除";
            this.buttonXDelete.Click += new System.EventHandler(this.buttonXDelete_Click);
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
            // ExpendTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 411);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpendTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出类型";
            this.Load += new System.EventHandler(this.ExpendTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataList)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn VStatus;
        private DevExpress.XtraGrid.Columns.GridColumn pk;
        private DevExpress.XtraGrid.Columns.GridColumn OrigianlPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PayType;
        private DevExpress.XtraGrid.Columns.GridColumn v_zclx_name;
        private DevExpress.XtraGrid.Columns.GridColumn v_zc_no;
        private DevExpress.XtraGrid.Columns.GridColumn row;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataList;
        private DevExpress.XtraGrid.GridControl gridControlDataList;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx_top;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXDelete;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXAdd;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXExit;
        private TZXControlLibrary.ButtonEx.TzxButtonEx buttonXSave;
        private TZXControlLibrary.ButtonEx.TzxButtonEx tzxButtonExRefresh;
    }
}