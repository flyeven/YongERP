using DevExpress.XtraEditors;
namespace Ultra.Member
{
    partial class NewView
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtReceiverNo = new DevExpress.XtraEditors.TextEdit();
            this.txtReceiverName = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.txtReceiverMobile = new DevExpress.XtraEditors.TextEdit();
            this.chk = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtReceiverAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(330, 217);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.txtRemark);
            this.pnlFill.Controls.Add(this.labelControl9);
            this.pnlFill.Controls.Add(this.labelControl5);
            this.pnlFill.Controls.Add(this.txtReceiverMobile);
            this.pnlFill.Controls.Add(this.txtReceiverAddress);
            this.pnlFill.Controls.Add(this.labelControl3);
            this.pnlFill.Controls.Add(this.labelControl2);
            this.pnlFill.Controls.Add(this.labelControl1);
            this.pnlFill.Controls.Add(this.chk);
            this.pnlFill.Controls.Add(this.txtReceiverNo);
            this.pnlFill.Controls.Add(this.txtReceiverName);
            this.pnlFill.Size = new System.Drawing.Size(330, 171);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Location = new System.Drawing.Point(0, 171);
            this.pnlBottom.Size = new System.Drawing.Size(330, 46);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(243, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(150, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtReceiverNo
            // 
            this.txtReceiverNo.Location = new System.Drawing.Point(67, 7);
            this.txtReceiverNo.Name = "txtReceiverNo";
            this.txtReceiverNo.Size = new System.Drawing.Size(242, 20);
            this.txtReceiverNo.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtReceiverNo, conditionValidationRule2);
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(67, 33);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(242, 20);
            this.txtReceiverName.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "不能为空";
            this.dxValidationProvider1.SetValidationRule(this.txtReceiverName, conditionValidationRule3);
            // 
            // txtReceiverMobile
            // 
            this.txtReceiverMobile.Location = new System.Drawing.Point(67, 59);
            this.txtReceiverMobile.Name = "txtReceiverMobile";
            this.txtReceiverMobile.Size = new System.Drawing.Size(242, 20);
            this.txtReceiverMobile.TabIndex = 31;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtReceiverMobile, conditionValidationRule1);
            // 
            // chk
            // 
            this.chk.EditValue = true;
            this.chk.Location = new System.Drawing.Point(65, 135);
            this.chk.Name = "chk";
            this.chk.Properties.Caption = "启用";
            this.chk.Size = new System.Drawing.Size(51, 19);
            this.chk.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "编号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "姓名";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "电话";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "地址";
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Location = new System.Drawing.Point(67, 85);
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(242, 20);
            this.txtReceiverAddress.TabIndex = 32;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(37, 115);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 14);
            this.labelControl9.TabIndex = 40;
            this.labelControl9.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(67, 109);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(242, 20);
            this.txtRemark.TabIndex = 41;
            // 
            // NewView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(330, 217);
            this.Name = "NewView";
            this.ShowIcon = false;
            this.Text = "添加顾客";
            this.Load += new System.EventHandler(this.NewView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private TextEdit txtReceiverName;
        private TextEdit txtReceiverNo;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.CheckEdit chk;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit txtRemark;
        private LabelControl labelControl9;
        private LabelControl labelControl5;
        private TextEdit txtReceiverMobile;
        private TextEdit txtReceiverAddress;
    }
}