using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using SQ7MRU.Utils.PDF;

namespace QSL_Print_Manager
{
    
    public partial class QSODetail : UserControl
    {

        public ADIFRowExtended qso;

        public QSODetail()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            if (qso != null)
            {
                txtToRadio.Text = qso.call;
                txtVia.Text = qso.qsl_via;
                txtBand.Text = qso.band;
                txtFreq.Text = qso.freq;
                txtMode.Text = qso.mode;
                txtComment.Text = qso.comment;
                txtRemarks.Text = qso.remarks;
                txtTrx.Text = qso.trx;
                txtPwr.Text = qso.tx_pwr;
                txtAntenna.Text = qso.ant;
                txtDate.Text = qso.qso_date;
                txtTimeOn.Text = qso.time_on;
                txtTimeOff.Text = qso.time_off;
                txtPrefix.Text = qso.prefix;
                txtSufix.Text = qso.sufix;
                btnQRZ.Enabled = true;                
            }
            else
            {
                btnQRZ.Enabled = false;
            }
        }

        private void btnQRZ_Click(object sender, EventArgs e)
        {
            if (qso != null)
            {
                if (!String.IsNullOrEmpty(qso.call))
                {
                    btnQRZ.Enabled = false;
                    txtVia.Text = qslViaFromQRZ(qso.call.Trim());
                    btnQRZ.Enabled = true;
                }
            }
        }

        private string qslViaFromQRZ(string call)
        {
            string ret = "";

            using (WebClient wc = new WebClient())
            {
                wc.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                try
                {
                    string response = wc.DownloadString("http://qrz.com/db/" + call);

                    Match match = Regex.Match(response, "<b>QSL:</b>(.)+?</span>");
                    if (match.Success)
                    {
                        ret = match.Value.Replace("<b>QSL:</b>", "").Replace("</span>", "").Trim();
                    }
                }
                catch (Exception exc) { }
            }
             return ret;
        }

        private void txtVia_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.qsl_via = txtVia.Text;
            }
        }

        private void txtAntenna_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.ant = txtAntenna.Text;
            }
        }

        private void txtBand_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.band = txtBand.Text;
            }
        }

        private void txtFreq_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.freq = txtFreq.Text;
            }
        }

        private void txtPwr_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.tx_pwr = txtPwr.Text;
            }
        }

        private void txtTrx_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.trx = txtTrx.Text;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.qso_date = txtDate.Text;
            }
        }

        private void txtTimeOn_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.time_on = txtTimeOn.Text;
            }
        }

        private void txtTimeOff_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.time_off = txtTimeOff.Text;
            }
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.prefix = txtPrefix.Text;
            }
        }

        private void txtSufix_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.sufix = txtSufix.Text;
            }
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.remarks = txtRemarks.Text;
            }
        }

        private void txtMode_TextChanged(object sender, EventArgs e)
        {
            if (qso != null)
            {
                qso.mode = txtMode.Text;
            }
        }


           
    }
}
