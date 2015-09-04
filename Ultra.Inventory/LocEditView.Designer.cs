namespace Ultra.Inventory {
    partial class LocEditView {
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chk = new DevExpress.XtraEditors.CheckEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.wareGridEdit1 = new Ultra.Controls.WareGridEdit();
            this.wareGridEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.areaGridEdit1 = new Ultra.Controls.AreaGridEdit();
            this.areaGridEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareGridEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareGridEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(311, 195);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.labelControl4);
            this.pnlFill.Controls.Add(this.labelControl3);
            this.pnlFill.Controls.Add(this.wareGridEdit1);
            this.pnlFill.Controls.Add(this.areaGridEdit1);
            this.pnlFill.Controls.Add(this.labelControl2);
            this.pnlFill.Controls.Add(this.labelControl1);
            this.pnlFill.Controls.Add(this.chk);
            this.pnlFill.Controls.Add(this.txtName);
            this.pnlFill.Controls.Add(this.txtCode);
            this.pnlFill.Size = new System.Drawing.Size(311, 143);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Location = new System.Drawing.Point(0, 143);
            this.pnlBottom.Size = new System.Drawing.Size(311, 52);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "库位编码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "库位名称";
            // 
            // chk
            // 
            this.chk.EditValue = true;
            this.chk.Location = new System.Drawing.Point(64, 114);
            this.chk.Name = "chk";
            this.chk.Properties.Caption = "启用";
            this.chk.Size = new System.Drawing.Size(51, 19);
            this.chk.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 33;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "必填";
            this.dxValidationProvider1.SetValidationRule(this.txtName, conditionValidationRule3);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(66, 88);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(220, 20);
            this.txtCode.TabIndex = 34;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(124, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(217, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "区域";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "仓库";
            // 
            // wareGridEdit1
            // 
            this.wareGridEdit1.ClearButtonText = "清除所选";
            this.wareGridEdit1.ColumnCaption = "仓库";
            this.wareGridEdit1.DisplayMember = "WareName";
            this.wareGridEdit1.EditValue = "";
            this.wareGridEdit1.Location = new System.Drawing.Point(66, 9);
            this.wareGridEdit1.Name = "wareGridEdit1";
            this.wareGridEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "清除所选", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "清除所选", null, null, true)});
            this.wareGridEdit1.Properties.DisplayMember = "WareName";
            this.wareGridEdit1.Properties.NullText = "";
            this.wareGridEdit1.Properties.ValueMember = "Guid";
            this.wareGridEdit1.Properties.View = this.wareGridEdit1View;
            this.wareGridEdit1.SelectedValue = null;
            this.wareGridEdit1.Size = new System.Drawing.Size(220, 20);
            this.wareGridEdit1.TabIndex = 40;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "必填";
            this.dxValidationProvider1.SetValidationRule(this.wareGridEdit1, conditionValidationRule1);
            this.wareGridEdit1.ValueMember = "Guid";
            // 
            // wareGridEdit1View
            // 
            this.wareGridEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.wareGridEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.wareGridEdit1View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.wareGridEdit1View.Appearance.SelectedRow.Options.UseBackColor = true;
            this.wareGridEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.wareGridEdit1View.Name = "wareGridEdit1View";
            this.wareGridEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.wareGridEdit1View.OptionsBehavior.Editable = false;
            this.wareGridEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.wareGridEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // areaGridEdit1
            // 
            this.areaGridEdit1.ClearButtonText = "清除所选";
            this.areaGridEdit1.ColumnCaption = "区域";
            this.areaGridEdit1.DisplayMember = "AreaName";
            this.areaGridEdit1.EditValue = "";
            this.areaGridEdit1.Location = new System.Drawing.Point(66, 36);
            this.areaGridEdit1.Name = "areaGridEdit1";
            this.areaGridEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "清除所选", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "清除所选", null, null, true)});
            this.areaGridEdit1.Properties.DisplayMember = "AreaName";
            this.areaGridEdit1.Properties.NullText = "";
            this.areaGridEdit1.Properties.ValueMember = "Guid";
            this.areaGridEdit1.Properties.View = this.areaGridEdit1View;
            this.areaGridEdit1.SelectedValue = null;
            this.areaGridEdit1.Size = new System.Drawing.Size(220, 20);
            this.areaGridEdit1.TabIndex = 39;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "必填";
            this.dxValidationProvider1.SetValidationRule(this.areaGridEdit1, conditionValidationRule2);
            this.areaGridEdit1.ValueMember = "Guid";
            // 
            // areaGridEdit1View
            // 
            this.areaGridEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.areaGridEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.areaGridEdit1View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.areaGridEdit1View.Appearance.SelectedRow.Options.UseBackColor = true;
            this.areaGridEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.areaGridEdit1View.Name = "areaGridEdit1View";
            this.areaGridEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.areaGridEdit1View.OptionsBehavior.Editable = false;
            this.areaGridEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.areaGridEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LocEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 195);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocEditView";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.LocEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareGridEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareGridEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaGridEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chk;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Controls.WareGridEdit wareGridEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView wareGridEdit1View;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private Controls.AreaGridEdit areaGridEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView areaGridEdit1View;
    }
}