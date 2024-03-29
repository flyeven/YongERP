﻿namespace Ultra.Trade
{
    partial class MainView
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
            this.gcUnSub = new Ultra.Surface.Controls.GridControlEx();
            this.gvUnSub = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcSubed = new Ultra.Surface.Controls.GridControlEx();
            this.gvSubed = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gcPrinted = new Ultra.Surface.Controls.GridControlEx();
            this.gvPrinted = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDetail = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gcOrder = new Ultra.Surface.Controls.GridControlEx();
            this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.collapsibleSplitter1 = new Ultra.Surface.Controls.CollapsibleSplitter();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcUnSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubed)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // myBar
            // 
            this.myBar.Size = new System.Drawing.Size(630, 60);
            // 
            // gcUnSub
            // 
            this.gcUnSub.ColorFieldName = null;
            this.gcUnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUnSub.Location = new System.Drawing.Point(0, 0);
            this.gcUnSub.MainView = this.gvUnSub;
            this.gcUnSub.Name = "gcUnSub";
            this.gcUnSub.ShowIndicator = true;
            this.gcUnSub.ShowRowNumber = true;
            this.gcUnSub.Size = new System.Drawing.Size(624, 227);
            this.gcUnSub.TabIndex = 4;
            this.gcUnSub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnSub});
            this.gcUnSub.RowCellDoubleClick += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.gridControlEx1_RowCellDoubleClick);
            // 
            // gvUnSub
            // 
            this.gvUnSub.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvUnSub.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUnSub.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvUnSub.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUnSub.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn24,
            this.gridColumn4});
            this.gvUnSub.GridControl = this.gcUnSub;
            this.gvUnSub.Name = "gvUnSub";
            this.gvUnSub.OptionsBehavior.Editable = false;
            this.gvUnSub.OptionsView.ColumnAutoWidth = false;
            this.gvUnSub.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUnSub.OptionsView.EnableAppearanceOddRow = true;
            this.gvUnSub.OptionsView.ShowAutoFilterRow = true;
            this.gvUnSub.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn24.Caption = "出单人";
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
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.xtraTabPage1;
            this.tabMain.Size = new System.Drawing.Size(630, 256);
            this.tabMain.TabIndex = 5;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4});
            this.tabMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabMain_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcUnSub);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabPage1.Size = new System.Drawing.Size(624, 227);
            this.xtraTabPage1.Text = "待审核";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcSubed);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(624, 227);
            this.xtraTabPage2.Text = "已审核";
            // 
            // gcSubed
            // 
            this.gcSubed.ColorFieldName = null;
            this.gcSubed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSubed.Location = new System.Drawing.Point(0, 0);
            this.gcSubed.MainView = this.gvSubed;
            this.gcSubed.Name = "gcSubed";
            this.gcSubed.ShowRowNumber = true;
            this.gcSubed.Size = new System.Drawing.Size(624, 227);
            this.gcSubed.TabIndex = 5;
            this.gcSubed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubed});
            // 
            // gvSubed
            // 
            this.gvSubed.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvSubed.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSubed.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvSubed.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSubed.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn25,
            this.gridColumn10});
            this.gvSubed.GridControl = this.gcSubed;
            this.gvSubed.Name = "gvSubed";
            this.gvSubed.OptionsBehavior.Editable = false;
            this.gvSubed.OptionsView.ColumnAutoWidth = false;
            this.gvSubed.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSubed.OptionsView.EnableAppearanceOddRow = true;
            this.gvSubed.OptionsView.ShowAutoFilterRow = true;
            this.gvSubed.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn25.Caption = "出单人";
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
            this.xtraTabPage4.Controls.Add(this.gcPrinted);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(624, 227);
            this.xtraTabPage4.Text = "已打印";
            // 
            // gcPrinted
            // 
            this.gcPrinted.ColorFieldName = null;
            this.gcPrinted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrinted.Location = new System.Drawing.Point(0, 0);
            this.gcPrinted.MainView = this.gvPrinted;
            this.gcPrinted.Name = "gcPrinted";
            this.gcPrinted.ShowRowNumber = true;
            this.gcPrinted.Size = new System.Drawing.Size(624, 227);
            this.gcPrinted.TabIndex = 6;
            this.gcPrinted.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrinted});
            // 
            // gvPrinted
            // 
            this.gvPrinted.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvPrinted.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPrinted.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gvPrinted.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPrinted.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn14,
            this.gridColumn26,
            this.gridColumn15,
            this.gridColumn27});
            this.gvPrinted.GridControl = this.gcPrinted;
            this.gvPrinted.Name = "gvPrinted";
            this.gvPrinted.OptionsBehavior.Editable = false;
            this.gvPrinted.OptionsView.ColumnAutoWidth = false;
            this.gvPrinted.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrinted.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrinted.OptionsView.ShowAutoFilterRow = true;
            this.gvPrinted.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn26.Caption = "出单人";
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
            // tabDetail
            // 
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetail.Location = new System.Drawing.Point(2, 2);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedTabPage = this.xtraTabPage3;
            this.tabDetail.Size = new System.Drawing.Size(626, 157);
            this.tabDetail.TabIndex = 6;
            this.tabDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gcOrder);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(620, 128);
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
            this.gcOrder.Size = new System.Drawing.Size(620, 128);
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
            this.gridColumn20.VisibleIndex = 7;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.tabDetail);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Location = new System.Drawing.Point(0, 324);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(630, 161);
            this.pnlDetail.TabIndex = 8;
            // 
            // collapsibleSplitter1
            // 
            this.collapsibleSplitter1.AnimationDelay = 20;
            this.collapsibleSplitter1.AnimationStep = 20;
            this.collapsibleSplitter1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
            this.collapsibleSplitter1.ControlToHide = this.pnlDetail;
            this.collapsibleSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.collapsibleSplitter1.ExpandParentForm = true;
            this.collapsibleSplitter1.Location = new System.Drawing.Point(0, 316);
            this.collapsibleSplitter1.Name = "collapsibleSplitter1";
            this.collapsibleSplitter1.Size = new System.Drawing.Size(630, 8);
            this.collapsibleSplitter1.TabIndex = 9;
            this.collapsibleSplitter1.TabStop = false;
            this.collapsibleSplitter1.UseAnimations = false;
            this.collapsibleSplitter1.VisualStyle = Ultra.Surface.Controls.VisualStyles.Mozilla;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "成本";
            this.gridColumn6.FieldName = "CostPrice";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 485);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.collapsibleSplitter1);
            this.Controls.Add(this.pnlDetail);
            this.Name = "MainView";
            this.Text = "收款";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Controls.SetChildIndex(this.myBar, 0);
            this.Controls.SetChildIndex(this.pnlDetail, 0);
            this.Controls.SetChildIndex(this.collapsibleSplitter1, 0);
            this.Controls.SetChildIndex(this.tabMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcUnSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSubed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubed)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ultra.Surface.Controls.GridControlEx gcUnSub;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnSub;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabControl tabDetail;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private Surface.Controls.CollapsibleSplitter collapsibleSplitter1;
        private Surface.Controls.GridControlEx gcSubed;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubed;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private Surface.Controls.GridControlEx gcPrinted;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrinted;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private Surface.Controls.GridControlEx gcOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;

    }
}