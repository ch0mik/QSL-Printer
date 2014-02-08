using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQ7MRU.Utils.ADIF;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;
using System.Globalization;
using org.apache.fop;
using org.apache.fop.apps;
using org.apache.fop.tools;
using org.apache.fop.util;
using org.xml.sax;
using java.io;
using ikvm.lang;
using javax.xml.transform;
using javax.xml.transform.sax;
using javax.xml.transform.dom;
using javax.xml.transform.stream;

namespace SQ7MRU.Utils.PDF
{
    public class PDF : IDisposable
    {
        public bool IsDisposed { get; protected set; }
        public bool isInitialized;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Do actual Dispose.
        /// </summary>
        /// <remarks>See MSDN doc for implementing the Dispose pattern: Implementing a Dispose Method</remarks>
        /// <param name="disposing">if true, called from managed user code; if false, called from within GC finalizer.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                // if true, dispose managed AND unmanaged resources
                if (disposing)
                {
                    // kod
                }
                IsDisposed = true;
            }
        }


        //private void GenerateXML(List<ADIFRow> QSOs, string xmlFile)
        //{

        //    using (XmlWriter writer = XmlWriter.Create(xmlFile))
        //    {
        //        writer.WriteStartDocument();
        //        writer.WriteStartElement("ADIF");

        //        foreach (ADIFRow qso in QSOs)
        //        {

        //            writer.WriteStartElement("QSO");

        //            writer.WriteElementString("CALL", qso.call.ToUpper().Trim());
        //            if (!String.IsNullOrEmpty(qso.qsl_via))
        //            {
        //                writer.WriteElementString("QSL_VIA", qso.qsl_via.ToUpper().Trim());
        //            }

        //            DateTime qsoTime;

        //            if ((!String.IsNullOrEmpty(qso.time_off)) && (!String.IsNullOrEmpty(qso.time_on)))
        //            {
        //                DateTime time_off = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_off.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
        //                DateTime time_on = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_on.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
        //                qsoTime = new DateTime(time_on.Ticks + (time_off.Ticks - time_on.Ticks) / 2);
        //            }
        //            else if (!String.IsNullOrEmpty(qso.time_on))
        //            {
        //                qsoTime = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_on.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
        //            }
        //            else
        //            {
        //                qsoTime = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_off.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
        //            }

        //            writer.WriteElementString("DATE_DD", qsoTime.ToString("dd"));
        //            writer.WriteElementString("DATE_MM", qsoTime.ToString("MM"));
        //            writer.WriteElementString("DATE_YYYY", qsoTime.ToString("yyyy"));
        //            writer.WriteElementString("TIME", qsoTime.ToString("HH:mm"));

        //            if (!String.IsNullOrEmpty(qso.name))
        //            {
        //                writer.WriteElementString("REMARKS", "Tnx for nice QSO DR " + qso.name + " !");
        //            }
        //            else
        //            {
        //                writer.WriteElementString("REMARKS", "Tnx for nice QSO !");
        //            }
        //            writer.WriteElementString("BAND", qso.band);

        //            if (!String.IsNullOrEmpty(qso.freq))
        //            {
        //                decimal freq;
        //                if (Decimal.TryParse(qso.freq.Replace(".", ","), out freq))
        //                {
        //                    writer.WriteElementString("FREQ", Math.Round(freq, 2).ToString());
        //                }
        //            }

        //            if (!String.IsNullOrEmpty(qso.comment))
        //            {
        //                writer.WriteElementString("COMMENT", qso.comment);

        //                if (qso.comment.ToUpper().Contains("QRP"))
        //                {
        //                    writer.WriteElementString("SUFIX", "QRP");
        //                }
        //                else
        //                {
        //                    writer.WriteElementString("SUFIX", "");
        //                }
        //            }

        //            if (!String.IsNullOrEmpty(qso.qsl_rcvd))
        //            {
        //                writer.WriteElementString("QSL_RCVD", qso.qsl_rcvd.Trim());
        //            }

        //            if (!String.IsNullOrEmpty(qso.tx_pwr))
        //            {
        //                writer.WriteElementString("TX_PWR", qso.tx_pwr);
        //            }

        //            if (!String.IsNullOrEmpty(qso.rst_sent))
        //            {
        //                writer.WriteElementString("RST_SENT", qso.rst_sent.Trim());
        //            }

        //            if (!String.IsNullOrEmpty(qso.mode))
        //            {
        //                writer.WriteElementString("MODE", qso.mode.Trim());
        //            }

        //            writer.WriteElementString("PREFIX", "");

        //            if (!String.IsNullOrEmpty(qso.swl))
        //            {
        //                writer.WriteElementString("SWL", qso.swl.Trim());
        //            }


        //            if (!String.IsNullOrEmpty(qso.qsl_via))
        //            {
        //                writer.WriteElementString("QSL_VIA", qso.qsl_via.Trim());
        //            }




        //            writer.WriteEndElement();



        //        }

        //        writer.WriteEndElement();

        //    }
        //}


        public List<ADIFRowExtended> loadQSOs(string ADIFFile)
        {
            List<ADIFRowExtended> QSOsExt = new List<ADIFRowExtended>();
            PropertyInfo[] ADIFRowProps = (new ADIFRow()).GetType().GetProperties();
            PropertyInfo[] ADIFRowExtendedProps = (new ADIFRowExtended()).GetType().GetProperties();

            using (ADIFReader adif = new ADIFReader(ADIFFile))
            {
                List<ADIFRow> QSOs = adif.GetADIFRows();
                foreach (ADIFRow adifrow in QSOs)
                {
                    ADIFRowExtended qso = new ADIFRowExtended();
                    foreach (PropertyInfo prp in ADIFRowProps)
                    {
                        PropertyInfo pi = typeof(ADIFRowExtended).GetProperty(prp.Name);
                        var value = adifrow.GetType().GetProperty(prp.Name).GetValue(adifrow, null);

                        if (prp.Name=="name")
                        {
                            
                            if (!String.IsNullOrEmpty(adifrow.name))
                            {
                                qso.remarks = "Tnx for nice QSO DR " + adifrow.name  + " !";
                            }
                            else
                            {
                                qso.remarks = "Tnx for nice QSO !";
                            }
                        }

                        pi.SetValue(qso, value , null);
                        
                    }
                    QSOsExt.Add(qso);
                }

            }

            return QSOsExt;
        }

        public void GenerateXML(ADIFRowExtended qso, string xmlFile, bool isPreview = false)
        {

            using (XmlWriter writer = XmlWriter.Create(xmlFile))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ADIF");

                    writer.WriteStartElement("QSO");

                    if (isPreview)
                    {
                         writer.WriteElementString("PRINT_PREVIEW", "Y");
                    }

                    writer.WriteElementString("CALL", qso.call.ToUpper().Trim());
                    if (!String.IsNullOrEmpty(qso.qsl_via))
                    {
                        writer.WriteElementString("QSL_VIA", qso.qsl_via.ToUpper().Trim());
                    }

                    DateTime qsoTime;

                    if ((!String.IsNullOrEmpty(qso.time_off)) && (!String.IsNullOrEmpty(qso.time_on)))
                    {
                        DateTime time_off = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_off.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
                        DateTime time_on = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_on.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
                        qsoTime = new DateTime(time_on.Ticks + (time_off.Ticks - time_on.Ticks) / 2);
                    }
                    else if (!String.IsNullOrEmpty(qso.time_on))
                    {
                        qsoTime = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_on.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
                    }
                    else
                    {
                        qsoTime = DateTime.Parse(Extensions.ConvertStringToFormattedDateTime(qso.qso_date.Trim() + qso.time_off.Trim(), "yyyyMMddHHmmss", "yyyy-MM-dd HH:mm:ss"));
                    }

                    writer.WriteElementString("DATE_DD", qsoTime.ToString("dd"));
                    writer.WriteElementString("DATE_MM", qsoTime.ToString("MM"));
                    writer.WriteElementString("DATE_YYYY", qsoTime.ToString("yyyy"));
                    writer.WriteElementString("TIME", qsoTime.ToString("HH:mm"));
                    writer.WriteElementString("REMARKS", qso.remarks);
                    writer.WriteElementString("BAND", qso.band);

                    if (!String.IsNullOrEmpty(qso.freq))
                    {
                        decimal freq;
                        if (Decimal.TryParse(qso.freq.Replace(".", ","), out freq))
                        {
                            writer.WriteElementString("FREQ", Math.Round(freq, 2).ToString());
                        }
                    }

                    if (!String.IsNullOrEmpty(qso.qsl_rcvd))
                    {
                        writer.WriteElementString("QSL_RCVD", qso.qsl_rcvd.Trim());
                    }

                    if (!String.IsNullOrEmpty(qso.tx_pwr))
                    {
                        writer.WriteElementString("TX_PWR", qso.tx_pwr);
                    }

                    if (!String.IsNullOrEmpty(qso.rst_sent))
                    {
                        writer.WriteElementString("RST_SENT", qso.rst_sent.Trim());
                    }

                    if (!String.IsNullOrEmpty(qso.mode))
                    {
                        writer.WriteElementString("MODE", qso.mode.Trim());
                    }

                    if (!String.IsNullOrEmpty(qso.swl))
                    {
                        writer.WriteElementString("SWL", qso.swl.Trim());
                    }

                    if (!String.IsNullOrEmpty(qso.prefix))
                    {
                        writer.WriteElementString("PREFIX", qso.prefix.ToUpper());
                    }

                    if (!String.IsNullOrEmpty(qso.sufix))
                    {
                        writer.WriteElementString("SUFIX", qso.sufix.ToUpper());
                    }

                    if (!String.IsNullOrEmpty(qso.trx))
                    {
                        writer.WriteElementString("TRX", qso.trx);
                    }

                    if (!String.IsNullOrEmpty(qso.ant))
                    {
                        writer.WriteElementString("ANT", qso.ant);
                    }

                    if (!String.IsNullOrEmpty(qso.qsl_via))
                    {
                        writer.WriteElementString("QSL_VIA", qso.qsl_via.Trim());
                    }

                    


                    writer.WriteEndElement();



                writer.WriteEndElement();

            }
        }

        public void GeneratePDF(string xmlFile, string xsltFile, string xslfoFile, string pdfFile)
        {
            //Generate (Transform) XSL-FO File from XSLT + XML
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltFile);
            xslt.Transform(xmlFile,xslfoFile);

            //Generate PDF from XSL-FO File
            FopFactory fopFactory = FopFactory.newInstance();
            OutputStream o = new DotNetOutputMemoryStream();

            try
            {
                Fop fop = fopFactory.newFop("application/pdf", o);

                TransformerFactory factory = TransformerFactory.newInstance();
                Transformer transformer = factory.newTransformer();

                Result res = new SAXResult(fop.getDefaultHandler());
                transformer.transform(new StreamSource(new java.io.File(xslfoFile)), res);
            }

            finally
            {
                o.close();
            }

            using (System.IO.FileStream fs = System.IO.File.Create(pdfFile))
            {
                var data = ((DotNetOutputMemoryStream)o).Stream.GetBuffer();
                fs.Write(data, 0, data.Length);
            }
        }
    }

    class DotNetOutputMemoryStream : OutputStream
    {

        private System.IO.MemoryStream ms = new System.IO.MemoryStream();

        public System.IO.MemoryStream Stream
        {

            get
            {

                return ms;

            }

        }

        public override void write(int i)
        {

            ms.WriteByte((byte)i);

        }

        public override void write(byte[] b, int off, int len)
        {

            ms.Write(b, off, len);

        }

        public override void write(byte[] b)
        {

            ms.Write(b, 0, b.Length);

        }

        public override void close()
        {

            ms.Close();

        }

        public override void flush()
        {

            ms.Flush();

        }

    }

    public class ADIFRowExtended : ADIFRow
    {
        public string sufix { get; set; }
        public string prefix { get; set; }
        public string ant { get; set; }
        public string trx { get; set; }
        public string remarks { get; set; }
    }
}
