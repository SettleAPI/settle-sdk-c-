using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mcash;

namespace POSDemo
{
    public partial class MainForm : Form
    {
        McashClient _client;
        string _shortlinkId;
        string _tid
        {
            get { return tidLabel.Text; }
            set { tidLabel.Text = value; }
        }

        public MainForm(McashClient client, string shortlinkId)
        {
            InitializeComponent();
            _client = client;
            _shortlinkId = shortlinkId;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var tid = _client.CreatePaymentRequest(
                posTidTextBox.Text,
                "SALE",
                customerTextBox.Text,
                currencyTextBox.Text,
                amountTextBox.Text
            );
            setNewTid(tid);
            RefreshStatus(tid);          
        }

        void setNewTid(string tid)
        {
            _tid = tid;
            statusLabel.Text = "N/A";
            captureButton.Enabled = false;
            abortButton.Enabled = true;
        }

        async Task<string> GetStatusAsync(string tid) {
            var res = await Task.Run(() => _client.GetPaymentRequestOutcome(tid));
            return res.status;
        }

        void RefreshStatus(string tid)
        {
            GetStatusAsync(tid).ContinueWith((t) => SetStatus(t.Result), TaskScheduler.FromCurrentSynchronizationContext());       
        }
        void SetStatus(string status) {
            switch (status.ToLower()) {
                case "pending":
                    captureButton.Enabled = false;
                    abortButton.Enabled = true;
                    break;
                case "auth":
                    captureButton.Enabled = true;
                    abortButton.Enabled = true;
                    break;
                case "ok":
                case "fail":
                    captureButton.Enabled = false;
                    abortButton.Enabled = false;
                    break;
            }
            statusLabel.Text = status;
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            RefreshStatus(_tid);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customerTextBox.Text = Properties.Settings.Default.merchantId + "-alice";  // Default to test customer
            randomizePosTid();
        }

        private void randomizePosTidButton_Click(object sender, EventArgs e)
        {
            randomizePosTid();
        }
        void randomizePosTid()
        {
            posTidTextBox.Text = Guid.NewGuid().ToString();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            _client.AbortPaymentRequest(_tid);
            RefreshStatus(_tid);
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            _client.CapturePaymentRequest(_tid);
            RefreshStatus(_tid);
        }

        private void getScanButton_Click(object sender, EventArgs e)
        {
            var scan_token = _client.GetLastScan(_shortlinkId);
            customerTextBox.Text = scan_token != null ? scan_token : "";
        }

        private void closeReportButton_Click(object sender, EventArgs e)
        {
            var reportUri = _client.GetLedger().open_report_uri;
            _client.CloseReport(reportUri);  // TODO: Implement retry loop for this call in case of failures.
            closedReportText.Text = String.Format("Closed {0}", reportUri);
            
        }

        private void closedReportText_Click(object sender, EventArgs e)
        {

        }
    }
}
