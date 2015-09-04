namespace Ultra.Item {
    partial class ImportView {
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
            this.gridControlEx1 = new Ultra.Surface.Controls.GridControlEx();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBrowser1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChk
            // 
            this.btnChk.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // btnImp
            // 
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // fileBrowser1
            // 
            this.fileBrowser1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fileBrowser1_ButtonClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(755, 5);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(670, 6);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.gridControlEx1);
            this.pnlFill.Controls.SetChildIndex(this.panelControl1, 0);
            this.pnlFill.Controls.SetChildIndex(this.gridControlEx1, 0);
            // 
            // gridControlEx1
            // 
            this.gridControlEx1.ColorFieldName = null;
            this.gridControlEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEx1.Location = new System.Drawing.Point(2, 41);
            this.gridControlEx1.MainView = this.gv;
            this.gridControlEx1.MenuManager = this.barManager1;
            this.gridControlEx1.Name = "gridControlEx1";
            this.gridControlEx1.ShowIndicator = true;
            this.gridControlEx1.ShowRowNumber = true;
            this.gridControlEx1.Size = new System.Drawing.Size(840, 334);
            this.gridControlEx1.TabIndex = 2;
            this.gridControlEx1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gv.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gv.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv.GridControl = this.gridControlEx1;
            this.gv.Name = "gv";
            this.gv.OptionsView.ColumnAutoWidth = false;
            this.gv.OptionsView.ShowAutoFilterRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "商品名称";
            this.gridColumn1.FieldName = "ItemName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "商品编码";
            this.gridColumn2.FieldName = "ItemNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "成本";
            this.gridColumn3.FieldName = "CostPrice";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "售价";
            this.gridColumn4.FieldName = "Price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "验证结果";
            this.gridColumn5.FieldName = "Remark";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // ImportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 423);
            this.GridControl = this.gridControlEx1;
            this.Name = "ImportView";
            this.Text = "导入";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBrowser1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Surface.Controls.GridControlEx gridControlEx1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}