using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DbEntity;

namespace Ultra.Trade {
    public partial class rptFH : DevExpress.XtraReports.UI.XtraReport {
        public rptFH() {
            InitializeComponent();
        }

        public void BindPrintData(PrintInfo prtinfo) {

            DataSource = prtinfo.Orders;
            //trade
            xrDelivery.DataBindings.Add("Text", prtinfo.Trade, "Delivery");
            xrReceiverName.DataBindings.Add("Text", prtinfo.Trade, "ReceiverName");
            xrReceiverAddress.DataBindings.Add("Text", prtinfo.Trade, "ReceiverAddress");
            xrMobile.DataBindings.Add("Text", prtinfo.Trade, "ReceiverMobile");
            xrUser.DataBindings.Add("Text", prtinfo.Trade, "Creator");
            xrDeliveryTime.DataBindings.Add("Text", prtinfo.Trade, "DeliveryDateStr");
            xrPeriods.DataBindings.Add("Text", prtinfo.Trade, "Periods");

            //order
            xrItemName.DataBindings.Add("Text", DataSource, "ItemName");
            xrPrice.DataBindings.Add("Text", DataSource, "Price");
            xrPointFee.DataBindings.Add("Text", DataSource, "PointFee");
            xrOrderPrice.DataBindings.Add("Text", DataSource, "OrderPrice");
            xrOrderPointFee.DataBindings.Add("Text", DataSource, "OrderPointFee");
            xrNum.DataBindings.Add("Text", DataSource, "Num");

            //sum
            xrTotalNum.DataBindings.Add("Text", prtinfo.Trade, "TotalNum");
            xrTotalPrice.DataBindings.Add("Text", prtinfo.Trade, "TotalPrice");
            xrTotalPointFee.DataBindings.Add("Text", prtinfo.Trade, "TotalPointFee");
        }

    }

    public class PrintInfo {
        public t_trade Trade { get; set; }
        public System.Collections.Generic.List<t_order> Orders { get; set; } 
    }
}
