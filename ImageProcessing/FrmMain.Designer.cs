namespace ImageProcessing
{
    partial class FrmMain
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
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMedianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.convertToSEPIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picOrigin
            // 
            this.picOrigin.Location = new System.Drawing.Point(40, 61);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(540, 420);
            this.picOrigin.TabIndex = 0;
            this.picOrigin.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(701, 61);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(540, 420);
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.openImageToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openImageToolStripMenuItem.Text = "Choose Image..";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToGrayToolStripMenuItem,
            this.convertToSEPIAToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.toolsToolStripMenuItem.Text = "Tool";
            // 
            // convertToGrayToolStripMenuItem
            // 
            this.convertToGrayToolStripMenuItem.Name = "convertToGrayToolStripMenuItem";
            this.convertToGrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToGrayToolStripMenuItem.Text = "Convert To Gray";
            this.convertToGrayToolStripMenuItem.Click += new System.EventHandler(this.convertToGrayToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterMedianToolStripMenuItem,
            this.filterAvToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // filterMedianToolStripMenuItem
            // 
            this.filterMedianToolStripMenuItem.Name = "filterMedianToolStripMenuItem";
            this.filterMedianToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.filterMedianToolStripMenuItem.Text = "Filter Median";
            this.filterMedianToolStripMenuItem.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // filterAvToolStripMenuItem
            // 
            this.filterAvToolStripMenuItem.Name = "filterAvToolStripMenuItem";
            this.filterAvToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.filterAvToolStripMenuItem.Text = "Filter Average";
            this.filterAvToolStripMenuItem.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btn3x3
            // 
            this.btn3x3.Location = new System.Drawing.Point(604, 148);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(75, 23);
            this.btn3x3.TabIndex = 6;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // btn5x5
            // 
            this.btn5x5.Location = new System.Drawing.Point(604, 242);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(75, 23);
            this.btn5x5.TabIndex = 7;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = true;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // convertToSEPIAToolStripMenuItem
            // 
            this.convertToSEPIAToolStripMenuItem.Name = "convertToSEPIAToolStripMenuItem";
            this.convertToSEPIAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToSEPIAToolStripMenuItem.Text = "Convert To SEPIA";
            this.convertToSEPIAToolStripMenuItem.Click += new System.EventHandler(this.convertToSEPIAToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1282, 507);
            this.Controls.Add(this.btn5x5);
            this.Controls.Add(this.btn3x3);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOrigin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMedianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGrayToolStripMenuItem;
        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.ToolStripMenuItem convertToSEPIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

