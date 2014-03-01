namespace QSL_Print_Manager
{
    partial class QSLPrint
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QSLPrint));
            this.QSLPrintMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadADIFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.AcrobatViewer = new AxAcroPDFLib.AxAcroPDF();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnToPrinter = new System.Windows.Forms.Button();
            this.DetailsQSO = new QSL_Print_Manager.QSODetail();
            this.QSLPrintMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcrobatViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // QSLPrintMenu
            // 
            this.QSLPrintMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.QSLPrintMenu.Location = new System.Drawing.Point(0, 0);
            this.QSLPrintMenu.Name = "QSLPrintMenu";
            this.QSLPrintMenu.Size = new System.Drawing.Size(674, 24);
            this.QSLPrintMenu.TabIndex = 2;
            this.QSLPrintMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadADIFFileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadADIFFileToolStripMenuItem
            // 
            this.loadADIFFileToolStripMenuItem.Name = "loadADIFFileToolStripMenuItem";
            this.loadADIFFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadADIFFileToolStripMenuItem.Text = "Load ADIF file";
            this.loadADIFFileToolStripMenuItem.Click += new System.EventHandler(this.loadADIFFileToolStripMenuItem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(106, 445);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(12, 445);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(54, 451);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(24, 13);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0/0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AcrobatViewer
            // 
            this.AcrobatViewer.Enabled = true;
            this.AcrobatViewer.Location = new System.Drawing.Point(0, 28);
            this.AcrobatViewer.Name = "AcrobatViewer";
            this.AcrobatViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AcrobatViewer.OcxState")));
            this.AcrobatViewer.Size = new System.Drawing.Size(674, 410);
            this.AcrobatViewer.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(496, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(342, 445);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview with background";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnToPrinter
            // 
            this.btnToPrinter.Location = new System.Drawing.Point(598, 445);
            this.btnToPrinter.Name = "btnToPrinter";
            this.btnToPrinter.Size = new System.Drawing.Size(64, 23);
            this.btnToPrinter.TabIndex = 11;
            this.btnToPrinter.Text = "Print";
            this.btnToPrinter.UseVisualStyleBackColor = true;
            this.btnToPrinter.Click += new System.EventHandler(this.btnToPrinter_Click);
            // 
            // DetailsQSO
            // 
            this.DetailsQSO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsQSO.Location = new System.Drawing.Point(12, 482);
            this.DetailsQSO.Name = "DetailsQSO";
            this.DetailsQSO.Size = new System.Drawing.Size(662, 146);
            this.DetailsQSO.TabIndex = 3;
            // 
            // QSLPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 582);
            this.Controls.Add(this.btnToPrinter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.AcrobatViewer);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DetailsQSO);
            this.Controls.Add(this.QSLPrintMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.QSLPrintMenu;
            this.Name = "QSLPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQ7MRU QSL Print Manager";
            this.QSLPrintMenu.ResumeLayout(false);
            this.QSLPrintMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcrobatViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip QSLPrintMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadADIFFileToolStripMenuItem;
        private QSODetail DetailsQSO;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblCounter;
        private AxAcroPDFLib.AxAcroPDF AcrobatViewer;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnToPrinter;
    }
}

