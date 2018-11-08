namespace QSL_Print_Manager
{
    partial class QSODetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQRZ = new System.Windows.Forms.Button();
            this.txtVia = new System.Windows.Forms.TextBox();
            this.lblVia = new System.Windows.Forms.Label();
            this.txtToRadio = new System.Windows.Forms.TextBox();
            this.lblToRadio = new System.Windows.Forms.Label();
            this.txtBand = new System.Windows.Forms.TextBox();
            this.lblBand = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtTrx = new System.Windows.Forms.TextBox();
            this.lblTrx = new System.Windows.Forms.Label();
            this.txtPwr = new System.Windows.Forms.TextBox();
            this.lblPwr = new System.Windows.Forms.Label();
            this.txtAntenna = new System.Windows.Forms.TextBox();
            this.lblAntenna = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblQsoDate = new System.Windows.Forms.Label();
            this.txtTimeOn = new System.Windows.Forms.TextBox();
            this.lblTimeOn = new System.Windows.Forms.Label();
            this.txtTimeOff = new System.Windows.Forms.TextBox();
            this.lblTimeOff = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtSufix = new System.Windows.Forms.TextBox();
            this.lblSufix = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQRZ
            // 
            this.btnQRZ.Enabled = false;
            this.btnQRZ.Location = new System.Drawing.Point(328, 0);
            this.btnQRZ.Name = "btnQRZ";
            this.btnQRZ.Size = new System.Drawing.Size(38, 20);
            this.btnQRZ.TabIndex = 12;
            this.btnQRZ.Text = "QRZ";
            this.btnQRZ.UseVisualStyleBackColor = true;
            this.btnQRZ.Click += new System.EventHandler(this.btnQRZ_Click);
            // 
            // txtVia
            // 
            this.txtVia.Location = new System.Drawing.Point(220, 1);
            this.txtVia.Name = "txtVia";
            this.txtVia.Size = new System.Drawing.Size(102, 20);
            this.txtVia.TabIndex = 11;
            this.txtVia.TextChanged += new System.EventHandler(this.txtVia_TextChanged);
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.Location = new System.Drawing.Point(187, 0);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(36, 13);
            this.lblVia.TabIndex = 10;
            this.lblVia.Text = "VIA  : ";
            // 
            // txtToRadio
            // 
            this.txtToRadio.Location = new System.Drawing.Point(58, 1);
            this.txtToRadio.Name = "txtToRadio";
            this.txtToRadio.ReadOnly = true;
            this.txtToRadio.Size = new System.Drawing.Size(123, 20);
            this.txtToRadio.TabIndex = 9;
            // 
            // lblToRadio
            // 
            this.lblToRadio.AutoSize = true;
            this.lblToRadio.Location = new System.Drawing.Point(-2, 0);
            this.lblToRadio.Name = "lblToRadio";
            this.lblToRadio.Size = new System.Drawing.Size(63, 13);
            this.lblToRadio.TabIndex = 8;
            this.lblToRadio.Text = "To Radio  : ";
            // 
            // txtBand
            // 
            this.txtBand.Location = new System.Drawing.Point(404, 1);
            this.txtBand.Name = "txtBand";
            this.txtBand.Size = new System.Drawing.Size(42, 20);
            this.txtBand.TabIndex = 14;
            this.txtBand.TextChanged += new System.EventHandler(this.txtBand_TextChanged);
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Location = new System.Drawing.Point(370, 4);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(41, 13);
            this.lblBand.TabIndex = 13;
            this.lblBand.Text = "Band : ";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(482, 1);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(52, 20);
            this.txtFreq.TabIndex = 16;
            this.txtFreq.TextChanged += new System.EventHandler(this.txtFreq_TextChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(451, 2);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(37, 13);
            this.lblFreq.TabIndex = 15;
            this.lblFreq.Text = "Freq : ";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(-2, 52);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(63, 13);
            this.lblComment.TabIndex = 17;
            this.lblComment.Text = "Comment  : ";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(234, 55);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(55, 13);
            this.lblRemarks.TabIndex = 19;
            this.lblRemarks.Text = "Remarks :";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(58, 52);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(170, 42);
            this.txtComment.TabIndex = 18;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(370, 52);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(286, 20);
            this.txtRemarks.TabIndex = 20;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // txtTrx
            // 
            this.txtTrx.Location = new System.Drawing.Point(30, 26);
            this.txtTrx.Name = "txtTrx";
            this.txtTrx.Size = new System.Drawing.Size(108, 20);
            this.txtTrx.TabIndex = 22;
            this.txtTrx.TextChanged += new System.EventHandler(this.txtTrx_TextChanged);
            // 
            // lblTrx
            // 
            this.lblTrx.AutoSize = true;
            this.lblTrx.Location = new System.Drawing.Point(-2, 29);
            this.lblTrx.Name = "lblTrx";
            this.lblTrx.Size = new System.Drawing.Size(38, 13);
            this.lblTrx.TabIndex = 21;
            this.lblTrx.Text = "TRX : ";
            // 
            // txtPwr
            // 
            this.txtPwr.Location = new System.Drawing.Point(278, 73);
            this.txtPwr.Name = "txtPwr";
            this.txtPwr.Size = new System.Drawing.Size(53, 20);
            this.txtPwr.TabIndex = 24;
            this.txtPwr.TextChanged += new System.EventHandler(this.txtPwr_TextChanged);
            // 
            // lblPwr
            // 
            this.lblPwr.AutoSize = true;
            this.lblPwr.Location = new System.Drawing.Point(236, 77);
            this.lblPwr.Name = "lblPwr";
            this.lblPwr.Size = new System.Drawing.Size(46, 13);
            this.lblPwr.TabIndex = 23;
            this.lblPwr.Text = "Power : ";
            // 
            // txtAntenna
            // 
            this.txtAntenna.Location = new System.Drawing.Point(195, 26);
            this.txtAntenna.Name = "txtAntenna";
            this.txtAntenna.Size = new System.Drawing.Size(193, 20);
            this.txtAntenna.TabIndex = 26;
            this.txtAntenna.TextChanged += new System.EventHandler(this.txtAntenna_TextChanged);
            // 
            // lblAntenna
            // 
            this.lblAntenna.AutoSize = true;
            this.lblAntenna.Location = new System.Drawing.Point(143, 29);
            this.lblAntenna.Name = "lblAntenna";
            this.lblAntenna.Size = new System.Drawing.Size(56, 13);
            this.lblAntenna.TabIndex = 25;
            this.lblAntenna.Text = "Antenna : ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(426, 25);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(61, 20);
            this.txtDate.TabIndex = 28;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lblQsoDate
            // 
            this.lblQsoDate.AutoSize = true;
            this.lblQsoDate.Location = new System.Drawing.Point(394, 29);
            this.lblQsoDate.Name = "lblQsoDate";
            this.lblQsoDate.Size = new System.Drawing.Size(39, 13);
            this.lblQsoDate.TabIndex = 27;
            this.lblQsoDate.Text = "Date : ";
            // 
            // txtTimeOn
            // 
            this.txtTimeOn.Location = new System.Drawing.Point(527, 25);
            this.txtTimeOn.Name = "txtTimeOn";
            this.txtTimeOn.Size = new System.Drawing.Size(48, 20);
            this.txtTimeOn.TabIndex = 30;
            this.txtTimeOn.TextChanged += new System.EventHandler(this.txtTimeOn_TextChanged);
            // 
            // lblTimeOn
            // 
            this.lblTimeOn.AutoSize = true;
            this.lblTimeOn.Location = new System.Drawing.Point(494, 28);
            this.lblTimeOn.Name = "lblTimeOn";
            this.lblTimeOn.Size = new System.Drawing.Size(40, 13);
            this.lblTimeOn.TabIndex = 29;
            this.lblTimeOn.Text = "T-On : ";
            // 
            // txtTimeOff
            // 
            this.txtTimeOff.Location = new System.Drawing.Point(613, 25);
            this.txtTimeOff.Name = "txtTimeOff";
            this.txtTimeOff.Size = new System.Drawing.Size(46, 20);
            this.txtTimeOff.TabIndex = 32;
            this.txtTimeOff.TextChanged += new System.EventHandler(this.txtTimeOff_TextChanged);
            // 
            // lblTimeOff
            // 
            this.lblTimeOff.AutoSize = true;
            this.lblTimeOff.Location = new System.Drawing.Point(581, 28);
            this.lblTimeOff.Name = "lblTimeOff";
            this.lblTimeOff.Size = new System.Drawing.Size(40, 13);
            this.lblTimeOff.TabIndex = 31;
            this.lblTimeOff.Text = "T-Off : ";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(455, 74);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(61, 20);
            this.txtPrefix.TabIndex = 34;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(403, 77);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(42, 13);
            this.lblPrefix.TabIndex = 33;
            this.lblPrefix.Text = "Prefix : ";
            // 
            // txtSufix
            // 
            this.txtSufix.Location = new System.Drawing.Point(593, 74);
            this.txtSufix.Name = "txtSufix";
            this.txtSufix.Size = new System.Drawing.Size(64, 20);
            this.txtSufix.TabIndex = 36;
            this.txtSufix.TextChanged += new System.EventHandler(this.txtSufix_TextChanged);
            // 
            // lblSufix
            // 
            this.lblSufix.AutoSize = true;
            this.lblSufix.Location = new System.Drawing.Point(536, 77);
            this.lblSufix.Name = "lblSufix";
            this.lblSufix.Size = new System.Drawing.Size(39, 13);
            this.lblSufix.TabIndex = 35;
            this.lblSufix.Text = "Sufix : ";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(581, 1);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(75, 20);
            this.txtMode.TabIndex = 38;
            this.txtMode.TextChanged += new System.EventHandler(this.txtMode_TextChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(540, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(43, 13);
            this.lblMode.TabIndex = 37;
            this.lblMode.Text = "Mode : ";
            // 
            // QSODetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.txtSufix);
            this.Controls.Add(this.lblSufix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.txtTimeOff);
            this.Controls.Add(this.lblTimeOff);
            this.Controls.Add(this.txtTimeOn);
            this.Controls.Add(this.lblTimeOn);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblQsoDate);
            this.Controls.Add(this.txtAntenna);
            this.Controls.Add(this.lblAntenna);
            this.Controls.Add(this.txtPwr);
            this.Controls.Add(this.lblPwr);
            this.Controls.Add(this.txtTrx);
            this.Controls.Add(this.lblTrx);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.txtBand);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.btnQRZ);
            this.Controls.Add(this.txtVia);
            this.Controls.Add(this.lblVia);
            this.Controls.Add(this.txtToRadio);
            this.Controls.Add(this.lblToRadio);
            this.Name = "QSODetail";
            this.Size = new System.Drawing.Size(659, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQRZ;
        private System.Windows.Forms.TextBox txtVia;
        private System.Windows.Forms.Label lblVia;
        private System.Windows.Forms.TextBox txtToRadio;
        private System.Windows.Forms.Label lblToRadio;
        private System.Windows.Forms.TextBox txtBand;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtTrx;
        private System.Windows.Forms.Label lblTrx;
        private System.Windows.Forms.TextBox txtPwr;
        private System.Windows.Forms.Label lblPwr;
        private System.Windows.Forms.TextBox txtAntenna;
        private System.Windows.Forms.Label lblAntenna;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblQsoDate;
        private System.Windows.Forms.TextBox txtTimeOn;
        private System.Windows.Forms.Label lblTimeOn;
        private System.Windows.Forms.TextBox txtTimeOff;
        private System.Windows.Forms.Label lblTimeOff;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtSufix;
        private System.Windows.Forms.Label lblSufix;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label lblMode;
    }
}
