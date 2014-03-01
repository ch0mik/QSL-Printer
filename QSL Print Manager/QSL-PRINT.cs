using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SQ7MRU.Utils.ADIF;
using SQ7MRU.Utils.PDF;
using System.Text.RegularExpressions;
using System.Net;
using System.Configuration;

namespace QSL_Print_Manager
{
    public partial class QSLPrint : Form
    {
        public List<ADIFRowExtended> QSOs;
        private static int currentQSO = 0;
        private string xsd, xslt, background, tempXML, tempXSLFO,tempPDF;

        public QSLPrint()
        {
            InitializeComponent();
            QSOs = new List<ADIFRowExtended>();
            xsd = ConfigurationManager.AppSettings["XSD"] ?? "validate.xsd";
            xslt = ConfigurationManager.AppSettings["XSLT"] ?? "SQ7MRU.xslt";
            background = ConfigurationManager.AppSettings["BackGround"] ?? "SQ7MRU.jpg";
            tempXML = ConfigurationManager.AppSettings["TempXML"] ?? "temp.xml";
            tempXSLFO = ConfigurationManager.AppSettings["TempXSLFO"] ?? "temp.fo";
            tempPDF = ConfigurationManager.AppSettings["TempPDF"] ?? "temp.pdf";
        }

      

       

        private void loadADIFFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "(.ADI*)|*.ADI*";
                ofd.ShowDialog();
                string ADIFfilename = ofd.FileName;
                if (!string.IsNullOrEmpty(ADIFfilename))
                {
                   
                    using (PDF pdf = new PDF())
                    {
                        QSOs = pdf.loadQSOs(ADIFfilename).Where(S => S.qsl_sent.Trim() != "Y").ToList<ADIFRowExtended>(); ;

                        if (QSOs.Count > 0)
                        {
                            LoadDetails(0);
                            btnNext.Enabled = true;
                        }
                        else
                        {
                            btnPrint.Enabled = false;
                            btnPreview.Enabled = false;
                        }

                    }
                }
            }
           
        }

        private void LoadDetails(int qsoIndex)
        {
            DetailsQSO.qso = QSOs[qsoIndex];
            currentQSO = qsoIndex;
            lblCounter.Text = qsoIndex + 1 + "/" + QSOs.Count;
            DetailsQSO.Refresh();
            btnPrint.Enabled = true;
            btnPreview.Enabled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            navigateQSOs(+1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigateQSOs(-1);
        }

        private void navigateQSOs(int step)
        {
            if (QSOs.Count > 0)
            {
                if (!(currentQSO + step == -1 || currentQSO + step == QSOs.Count))
                {
                    LoadDetails(currentQSO + step);
                }

                if (currentQSO + step == QSOs.Count)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }

                if (currentQSO + step == -1)
                {
                    btnPrevious.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                }

            }
        }

        private void PreviewPrint(ADIFRowExtended qso, bool preview = true)
        {

            using (PDF pdf = new PDF())
            {
                try
                {
                    btnPrint.Enabled = false;
                    btnPreview.Enabled = false;
                    pdf.GenerateXML(qso, tempXML, preview);

                    pdf.GeneratePDF(tempXML, xslt, tempXSLFO, tempPDF);

                    AcrobatViewer.LoadFile(tempPDF);
                    AcrobatViewer.setShowToolbar(false);
                    AcrobatViewer.Update();
                    AcrobatViewer.Show();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    btnPreview.Enabled = true;
                    btnPrint.Enabled = true;
                }

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewPrint(QSOs[currentQSO]);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PreviewPrint(QSOs[currentQSO], false);
        }

        private void btnToPrinter_Click(object sender, EventArgs e)
        {
                 AcrobatViewer.Print();
        }

        
  
    }
}
