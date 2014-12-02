using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mcash;

namespace POSDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var settings = Properties.Settings.Default;
            McashClient client = new McashClient(
                settings.baseUri,
                settings.merchantId,
                settings.merchantUserId,
                settings.posId,
                settings.merchantSecret,
                "SECRET",
                settings.testbedToken
            );
            var shortlinkId = client.CreateShortlink(serial_number:"9910000000010");
            Application.Run(new MainForm(client, shortlinkId));
        }
    }
}
