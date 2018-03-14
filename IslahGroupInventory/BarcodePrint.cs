using DevExpress.XtraReports.UI;

namespace IslahGroupInventory
{
    public partial class BarcodePrint : XtraReport
    {
        private string barcode = "12345678";
        private int numberRow = 1;
        public BarcodePrint(string barcodeText, int numberOfRow)
        {
            InitializeComponent();
            barcode = barcodeText;
            numberRow = numberOfRow;
        }
        private void BarcodePrint_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = numberRow;
            xrBarCode1.Text = barcode;
            xrBarCode2.Text = barcode;
            xrBarCode3.Text = barcode;
        }
    }
}
