using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Remote_Countdown
{
    public partial class MainForm : Form
    {
        DateTime target;
        Timer timer = new Timer();
        
        public MainForm()
        {
            InitializeComponent();

            targetDateLbl.Text = "";
            remTimeLbl.Text = "";
        }

        public void setCountdown()
        {

        }

        public void tick(object sender, EventArgs eArgs)
        {
        }

        private void lookupUrl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                LoadDataFrom(dataUrlTxt.Text);
            }
        }

        private void lookupUrl(object sender, EventArgs e)
        {
            LoadDataFrom(dataUrlTxt.Text);
        }

        public void setStatus(string message, bool error = false)
        {
            statusLabel.Text = message;

            if (error)
            {
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                statusLabel.ForeColor = Color.Black;
            }
        }

        public void LoadDataFrom(string url) {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            
            // Check URI is well-formed
            try {
                request = (HttpWebRequest)WebRequest.Create(url);
            } catch (UriFormatException) {
                setStatus("The address you entered was malformed, please correct it.", true);
                return;
            }

            // Check for HTTP status code errors
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            } catch(Exception ex) {
                setStatus(ex.Message, true);
                return;
            }

            // Read the stream
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream);
            string date = sr.ReadLine();
            sr.Close();

            // Convert and show the label
            target = Convert.ToDateTime(date);
            targetDateLbl.Text = target.ToLongDateString();
        }
    }
}
