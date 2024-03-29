﻿namespace Ultra.ReturnGoods {
    partial class MainView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlItem = new DevExpress.XtraEditors.PanelControl();
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gcOrder = new Ultra.Surface.Controls.GridControlEx();
            this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collapsibleSplitter1 = new Ultra.Surface.Controls.CollapsibleSplitter();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcUnAudit = new Ultra.Surface.Controls.GridControlEx();
            this.gvUnAudit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcAudit = new Ultra.Surface.Controls.GridControlEx();
            this.gvAudit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gcInvalid = new Ultra.Surface.Controls.GridControlEx();
            this.gvInvalid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlItem)).BeginInit();
            this.pnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUnAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnAudit)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAudit)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvalid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvalid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.tabDetail);
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItem.Location = new System.Drawing.Point(0, 339);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(955, 163);
            this.pnlItem.TabIndex = 1;
            // 
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.Location = new System.Drawing.Point(2, 2);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.xtraTabPage3;
            this.tabDetail.Size = new System.Drawing.Size(951, 159);
            this.tabDetail.TabIndex = 7;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gcOrder);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(945, 130);
            this.xtraTabPage3.Text = "商品信息";
            // 
            // gcOrder
            // 
            this.gcOrder.ColorFieldName = null;
            this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrder.Location = new System.Drawing.Point(0, 0);
            this.gcOrder.MainView = this.gvOrder;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.ShowIndicator = true;
            this.gcOrder.ShowRowNumber = true;
            this.gcOrder.Size = new System.Drawing.Size(945, 130);
            this.gcOrder.TabIndex = 5;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
            // 
            // gvOrder
            // 
            this.gvOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvOrder.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvOrder.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn6,
            this.gridColumn18,
            this.gridColumn23,
            this.gridColumn22,
            this.gridColumn20});
            this.gvOrder.GridControl = this.gcOrder;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.OptionsBehavior.Editable = false;
            this.gvOrder.OptionsView.ColumnAutoWidth = false;
            this.gvOrder.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOrder.OptionsView.EnableAppearanceOddRow = true;
            this.gvOrder.OptionsView.ShowAutoFilterRow = true;
            this.gvOrder.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "商品名称";
            this.gridColumn16.FieldName = "ItemName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "商品编码";
            this.gridColumn17.FieldName = "ItemNo";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "成本";
            this.gridColumn6.FieldName = "CostPrice";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "售价";
            this.gridColumn18.FieldName = "Price";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 3;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "数量";
            this.gridColumn23.FieldName = "Num";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 4;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "总金额";
            this.gridColumn22.FieldName = "OrderPrice";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 5;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "创建时间";
            this.gridColumn20.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn20.FieldName = "CreateDate";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 6;
            // 
            // collapsibleSplitter1
            // 
            this.collapsibleSplitter1.AnimationDelay = 20;
            this.collapsibleSplitter1.AnimationStep = 20;
            this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter1.ControlToHide = this.pnlItem;
            this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.collapsibleSplitter1.ExpandParentForm = false;
            this.collapsibleSplitter1.Location = new System.Drawing.Point(0, 331);
            this.collapsibleSplitter1.Name = "collapsibleSplitter1";
            this.collapsibleSplitter1.Size = new System.Drawing.Size(955, 8);
            this.collapsibleSplitter1.TabIndex = 2;
            this.collapsibleSplitter1.TabStop = false;
            this.collapsibleSplitter1.UseAnimations = false;
            this.collapsibleSplitter1.VisualStyle = Ultra.Surface.Controls.VisualStyles.Mozilla;
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.xtraTabPage1;
            this.tabMain.Size = new System.Drawing.Size(955, 271);
            this.tabMain.TabIndex = 6;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcUnAudit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabPage1.Size = new System.Drawing.Size(949, 242);
            this.xtraTabPage1.Text = "待审核";
            // 
            // gcUnAudit
            // 
            this.gcUnAudit.ColorFieldName = null;
            this.gcUnAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUnAudit.Location = new System.Drawing.Point(0, 0);
            this.gcUnAudit.MainView = this.gvUnAudit;
            this.gcUnAudit.Name = "gcUnAudit";
            this.gcUnAudit.ShowIndicator = true;
            this.gcUnAudit.ShowRowNumber = true;
            this.gcUnAudit.Size = new System.Drawing.Size(949, 242);
            this.gcUnAudit.TabIndex = 4;
            this.gcUnAudit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnAudit});
            // 
            // gvUnAudit
            // 
            this.gvUnAudit.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvUnAudit.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUnAudit.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvUnAudit.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUnAudit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn24,
            this.gridColumn4});
            this.gvUnAudit.GridControl = this.gcUnAudit;
            this.gvUnAudit.Name = "gvUnAudit";
            this.gvUnAudit.OptionsBehavior.Editable = false;
            this.gvUnAudit.OptionsView.ColumnAutoWidth = false;
            this.gvUnAudit.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUnAudit.OptionsView.EnableAppearanceOddRow = true;
            this.gvUnAudit.OptionsView.ShowAutoFilterRow = true;
            this.gvUnAudit.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "顾客姓名";
            this.gridColumn1.FieldName = "ReceiverName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "顾客电话";
            this.gridColumn2.FieldName = "ReceiverMobile";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "顾客地址";
            this.gridColumn3.FieldName = "ReceiverAddress";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "创建人";
            this.gridColumn24.FieldName = "Creator";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "创建时间";
            this.gridColumn4.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "CreateDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcAudit);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(949, 242);
            this.xtraTabPage2.Text = "已审核";
            // 
            // gcAudit
            // 
            this.gcAudit.ColorFieldName = null;
            this.gcAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAudit.Location = new System.Drawing.Point(0, 0);
            this.gcAudit.MainView = this.gvAudit;
            this.gcAudit.Name = "gcAudit";
            this.gcAudit.ShowRowNumber = true;
            this.gcAudit.Size = new System.Drawing.Size(949, 242);
            this.gcAudit.TabIndex = 5;
            this.gcAudit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAudit});
            // 
            // gvAudit
            // 
            this.gvAudit.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvAudit.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAudit.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvAudit.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAudit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn25,
            this.gridColumn10});
            this.gvAudit.GridControl = this.gcAudit;
            this.gvAudit.Name = "gvAudit";
            this.gvAudit.OptionsBehavior.Editable = false;
            this.gvAudit.OptionsView.ColumnAutoWidth = false;
            this.gvAudit.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAudit.OptionsView.EnableAppearanceOddRow = true;
            this.gvAudit.OptionsView.ShowAutoFilterRow = true;
            this.gvAudit.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "顾客姓名";
            this.gridColumn5.FieldName = "ReceiverName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "顾客电话";
            this.gridColumn7.FieldName = "ReceiverMobile";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "顾客地址";
            this.gridColumn9.FieldName = "ReceiverAddress";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "创建人";
            this.gridColumn25.FieldName = "Creator";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "创建时间";
            this.gridColumn10.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn10.FieldName = "CreateDate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gcInvalid);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(949, 242);
            this.xtraTabPage4.Text = "已作废";
            // 
            // gcInvalid
            // 
            this.gcInvalid.ColorFieldName = null;
            this.gcInvalid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvalid.Location = new System.Drawing.Point(0, 0);
            this.gcInvalid.MainView = this.gvInvalid;
            this.gcInvalid.Name = "gcInvalid";
            this.gcInvalid.ShowRowNumber = true;
            this.gcInvalid.Size = new System.Drawing.Size(949, 242);
            this.gcInvalid.TabIndex = 6;
            this.gcInvalid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvalid});
            // 
            // gvInvalid
            // 
            this.gvInvalid.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvInvalid.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInvalid.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvInvalid.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInvalid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn14,
            this.gridColumn26,
            this.gridColumn15,
            this.gridColumn27});
            this.gvInvalid.GridControl = this.gcInvalid;
            this.gvInvalid.Name = "gvInvalid";
            this.gvInvalid.OptionsBehavior.Editable = false;
            this.gvInvalid.OptionsView.ColumnAutoWidth = false;
            this.gvInvalid.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvalid.OptionsView.EnableAppearanceOddRow = true;
            this.gvInvalid.OptionsView.ShowAutoFilterRow = true;
            this.gvInvalid.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "顾客姓名";
            this.gridColumn11.FieldName = "ReceiverName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "顾客电话";
            this.gridColumn12.FieldName = "ReceiverMobile";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "顾客地址";
            this.gridColumn14.FieldName = "ReceiverAddress";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "创建人";
            this.gridColumn26.FieldName = "Creator";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 3;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "创建时间";
            this.gridColumn15.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn15.FieldName = "CreateDate";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "打印次数";
            this.gridColumn27.FieldName = "PrintCnt";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 502);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.collapsibleSplitter1);
            this.Controls.Add(this.pnlItem);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Controls.SetChildIndex(this.myBar, 0);
            this.Controls.SetChildIndex(this.pnlItem, 0);
            this.Controls.SetChildIndex(this.collapsibleSplitter1, 0);
            this.Controls.SetChildIndex(this.tabMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlItem)).EndInit();
            this.pnlItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUnAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnAudit)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAudit)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvalid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvalid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlItem;
        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Surface.Controls.GridControlEx gcOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private Surface.Controls.CollapsibleSplitter collapsibleSplitter1;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Surface.Controls.GridControlEx gcUnAudit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnAudit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Surface.Controls.GridControlEx gcAudit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAudit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Surface.Controls.GridControlEx gcInvalid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvalid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
    }
}