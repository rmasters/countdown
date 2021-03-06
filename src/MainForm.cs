﻿using System;
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

            timer.Interval = 1000;
            timer.Tick += new EventHandler(tick);

            targetDateLbl.Text = "";
            remTimeLbl.Text = "";
        }

        public void tick(object sender, EventArgs eArgs)
        {
            if (sender == timer)
            {
                DateTime dt = DateTime.Now;

                TimeSpan difference = dt.Subtract(target);
                string text;
                double days = Math.Ceiling(difference.TotalDays);

                if (days < 0)
                {
                    // Target is in the future
                    days = Math.Abs(days);
                    text = String.Format("{0} days", days);
                } else {
                    // in the past
                    text = String.Format("{0} days ago", days);
                }

                remTimeLbl.Text = text;
            }
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

            setStatus("Loading data from address.");
            
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

            setStatus(String.Format("Loaded data from {0}.", url));

            // Convert and show the label
            target = Convert.ToDateTime(date);
            targetDateLbl.Text = target.ToLongDateString();

            // Start the timer
            timer.Start();
        }
    }
}
