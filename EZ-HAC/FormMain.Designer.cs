namespace EZ_HAC
{
    partial class FormMain
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HactoolVersion = new System.Windows.Forms.Label();
            this.HacTab = new System.Windows.Forms.TabControl();
            this.XciExtractionTab = new System.Windows.Forms.TabPage();
            this.XciOutputLabel = new System.Windows.Forms.Label();
            this.XciOutputBrowse = new System.Windows.Forms.Button();
            this.XciOutputPath = new System.Windows.Forms.TextBox();
            this.XciExtract = new System.Windows.Forms.Button();
            this.XciBrowse = new System.Windows.Forms.Button();
            this.XciFileLabel = new System.Windows.Forms.Label();
            this.XciPath = new System.Windows.Forms.TextBox();
            this.NcaExtractionTab = new System.Windows.Forms.TabPage();
            this.NcaTitleKey = new System.Windows.Forms.TextBox();
            this.NcaTitleKeyLabel = new System.Windows.Forms.Label();
            this.NcaOutputLabel = new System.Windows.Forms.Label();
            this.NcaOutputBrowse = new System.Windows.Forms.Button();
            this.NcaOutputPath = new System.Windows.Forms.TextBox();
            this.NcaBrowse = new System.Windows.Forms.Button();
            this.NcaFileLabel = new System.Windows.Forms.Label();
            this.NcaPath = new System.Windows.Forms.TextBox();
            this.NcaEmulatorExtract = new System.Windows.Forms.CheckBox();
            this.NcaExtract = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.HacTab.SuspendLayout();
            this.XciExtractionTab.SuspendLayout();
            this.NcaExtractionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(24, 17);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 73);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "EZ-HAC";
            // 
            // HactoolVersion
            // 
            this.HactoolVersion.AutoSize = true;
            this.HactoolVersion.Location = new System.Drawing.Point(476, 52);
            this.HactoolVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HactoolVersion.Name = "HactoolVersion";
            this.HactoolVersion.Size = new System.Drawing.Size(173, 25);
            this.HactoolVersion.TabIndex = 3;
            this.HactoolVersion.Text = "hactool Version: ";
            // 
            // HacTab
            // 
            this.HacTab.Controls.Add(this.XciExtractionTab);
            this.HacTab.Controls.Add(this.NcaExtractionTab);
            this.HacTab.Location = new System.Drawing.Point(24, 94);
            this.HacTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HacTab.Name = "HacTab";
            this.HacTab.SelectedIndex = 0;
            this.HacTab.Size = new System.Drawing.Size(702, 750);
            this.HacTab.TabIndex = 5;
            // 
            // XciExtractionTab
            // 
            this.XciExtractionTab.Controls.Add(this.XciOutputLabel);
            this.XciExtractionTab.Controls.Add(this.XciOutputBrowse);
            this.XciExtractionTab.Controls.Add(this.XciOutputPath);
            this.XciExtractionTab.Controls.Add(this.XciExtract);
            this.XciExtractionTab.Controls.Add(this.XciBrowse);
            this.XciExtractionTab.Controls.Add(this.XciFileLabel);
            this.XciExtractionTab.Controls.Add(this.XciPath);
            this.XciExtractionTab.Location = new System.Drawing.Point(8, 39);
            this.XciExtractionTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciExtractionTab.Name = "XciExtractionTab";
            this.XciExtractionTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciExtractionTab.Size = new System.Drawing.Size(686, 703);
            this.XciExtractionTab.TabIndex = 0;
            this.XciExtractionTab.Text = "Extract XCI";
            this.XciExtractionTab.UseVisualStyleBackColor = true;
            this.XciExtractionTab.Enter += new System.EventHandler(this.XciExtractionTab_Enter);
            // 
            // XciOutputLabel
            // 
            this.XciOutputLabel.AutoSize = true;
            this.XciOutputLabel.Location = new System.Drawing.Point(12, 67);
            this.XciOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.XciOutputLabel.Name = "XciOutputLabel";
            this.XciOutputLabel.Size = new System.Drawing.Size(132, 25);
            this.XciOutputLabel.TabIndex = 6;
            this.XciOutputLabel.Text = "Output Path:";
            // 
            // XciOutputBrowse
            // 
            this.XciOutputBrowse.Location = new System.Drawing.Point(532, 62);
            this.XciOutputBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciOutputBrowse.Name = "XciOutputBrowse";
            this.XciOutputBrowse.Size = new System.Drawing.Size(142, 38);
            this.XciOutputBrowse.TabIndex = 5;
            this.XciOutputBrowse.Text = "Browse";
            this.XciOutputBrowse.UseVisualStyleBackColor = true;
            this.XciOutputBrowse.Click += new System.EventHandler(this.XciOutputBrowse_Click);
            // 
            // XciOutputPath
            // 
            this.XciOutputPath.Location = new System.Drawing.Point(158, 62);
            this.XciOutputPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciOutputPath.Name = "XciOutputPath";
            this.XciOutputPath.Size = new System.Drawing.Size(358, 31);
            this.XciOutputPath.TabIndex = 4;
            // 
            // XciExtract
            // 
            this.XciExtract.Location = new System.Drawing.Point(6, 621);
            this.XciExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciExtract.Name = "XciExtract";
            this.XciExtract.Size = new System.Drawing.Size(674, 67);
            this.XciExtract.TabIndex = 3;
            this.XciExtract.Text = "Extract";
            this.XciExtract.UseVisualStyleBackColor = true;
            this.XciExtract.Click += new System.EventHandler(this.XciExtract_Click);
            // 
            // XciBrowse
            // 
            this.XciBrowse.Location = new System.Drawing.Point(532, 12);
            this.XciBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciBrowse.Name = "XciBrowse";
            this.XciBrowse.Size = new System.Drawing.Size(142, 38);
            this.XciBrowse.TabIndex = 2;
            this.XciBrowse.Text = "Browse";
            this.XciBrowse.UseVisualStyleBackColor = true;
            this.XciBrowse.Click += new System.EventHandler(this.XciBrowse_Click);
            // 
            // XciFileLabel
            // 
            this.XciFileLabel.AutoSize = true;
            this.XciFileLabel.Location = new System.Drawing.Point(12, 15);
            this.XciFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.XciFileLabel.Name = "XciFileLabel";
            this.XciFileLabel.Size = new System.Drawing.Size(93, 25);
            this.XciFileLabel.TabIndex = 1;
            this.XciFileLabel.Text = "XCI File:";
            // 
            // XciPath
            // 
            this.XciPath.Location = new System.Drawing.Point(116, 12);
            this.XciPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.XciPath.Name = "XciPath";
            this.XciPath.Size = new System.Drawing.Size(400, 31);
            this.XciPath.TabIndex = 0;
            // 
            // NcaExtractionTab
            // 
            this.NcaExtractionTab.Controls.Add(this.NcaTitleKey);
            this.NcaExtractionTab.Controls.Add(this.NcaTitleKeyLabel);
            this.NcaExtractionTab.Controls.Add(this.NcaOutputLabel);
            this.NcaExtractionTab.Controls.Add(this.NcaOutputBrowse);
            this.NcaExtractionTab.Controls.Add(this.NcaOutputPath);
            this.NcaExtractionTab.Controls.Add(this.NcaBrowse);
            this.NcaExtractionTab.Controls.Add(this.NcaFileLabel);
            this.NcaExtractionTab.Controls.Add(this.NcaPath);
            this.NcaExtractionTab.Controls.Add(this.NcaEmulatorExtract);
            this.NcaExtractionTab.Controls.Add(this.NcaExtract);
            this.NcaExtractionTab.Location = new System.Drawing.Point(8, 39);
            this.NcaExtractionTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaExtractionTab.Name = "NcaExtractionTab";
            this.NcaExtractionTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaExtractionTab.Size = new System.Drawing.Size(686, 703);
            this.NcaExtractionTab.TabIndex = 1;
            this.NcaExtractionTab.Text = "Extract NCA";
            this.NcaExtractionTab.UseVisualStyleBackColor = true;
            this.NcaExtractionTab.Enter += new System.EventHandler(this.NcaExtractionTab_Enter);
            // 
            // NcaTitleKey
            // 
            this.NcaTitleKey.Location = new System.Drawing.Point(222, 112);
            this.NcaTitleKey.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaTitleKey.Name = "NcaTitleKey";
            this.NcaTitleKey.Size = new System.Drawing.Size(448, 31);
            this.NcaTitleKey.TabIndex = 14;
            // 
            // NcaTitleKeyLabel
            // 
            this.NcaTitleKeyLabel.AutoSize = true;
            this.NcaTitleKeyLabel.Location = new System.Drawing.Point(12, 117);
            this.NcaTitleKeyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NcaTitleKeyLabel.Name = "NcaTitleKeyLabel";
            this.NcaTitleKeyLabel.Size = new System.Drawing.Size(202, 25);
            this.NcaTitleKeyLabel.TabIndex = 13;
            this.NcaTitleKeyLabel.Text = "Title Key (Optional):";
            // 
            // NcaOutputLabel
            // 
            this.NcaOutputLabel.AutoSize = true;
            this.NcaOutputLabel.Location = new System.Drawing.Point(12, 67);
            this.NcaOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NcaOutputLabel.Name = "NcaOutputLabel";
            this.NcaOutputLabel.Size = new System.Drawing.Size(132, 25);
            this.NcaOutputLabel.TabIndex = 12;
            this.NcaOutputLabel.Text = "Output Path:";
            // 
            // NcaOutputBrowse
            // 
            this.NcaOutputBrowse.Location = new System.Drawing.Point(532, 62);
            this.NcaOutputBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaOutputBrowse.Name = "NcaOutputBrowse";
            this.NcaOutputBrowse.Size = new System.Drawing.Size(142, 38);
            this.NcaOutputBrowse.TabIndex = 11;
            this.NcaOutputBrowse.Text = "Browse";
            this.NcaOutputBrowse.UseVisualStyleBackColor = true;
            this.NcaOutputBrowse.Click += new System.EventHandler(this.NcaOutputBrowse_Click);
            // 
            // NcaOutputPath
            // 
            this.NcaOutputPath.Location = new System.Drawing.Point(158, 62);
            this.NcaOutputPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaOutputPath.Name = "NcaOutputPath";
            this.NcaOutputPath.Size = new System.Drawing.Size(358, 31);
            this.NcaOutputPath.TabIndex = 10;
            // 
            // NcaBrowse
            // 
            this.NcaBrowse.Location = new System.Drawing.Point(532, 12);
            this.NcaBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaBrowse.Name = "NcaBrowse";
            this.NcaBrowse.Size = new System.Drawing.Size(142, 38);
            this.NcaBrowse.TabIndex = 9;
            this.NcaBrowse.Text = "Browse";
            this.NcaBrowse.UseVisualStyleBackColor = true;
            this.NcaBrowse.Click += new System.EventHandler(this.NcaBrowse_Click);
            // 
            // NcaFileLabel
            // 
            this.NcaFileLabel.AutoSize = true;
            this.NcaFileLabel.Location = new System.Drawing.Point(12, 15);
            this.NcaFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NcaFileLabel.Name = "NcaFileLabel";
            this.NcaFileLabel.Size = new System.Drawing.Size(103, 25);
            this.NcaFileLabel.TabIndex = 8;
            this.NcaFileLabel.Text = "NCA File:";
            // 
            // NcaPath
            // 
            this.NcaPath.Location = new System.Drawing.Point(126, 12);
            this.NcaPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaPath.Name = "NcaPath";
            this.NcaPath.Size = new System.Drawing.Size(390, 31);
            this.NcaPath.TabIndex = 7;
            // 
            // NcaEmulatorExtract
            // 
            this.NcaEmulatorExtract.AutoSize = true;
            this.NcaEmulatorExtract.Location = new System.Drawing.Point(12, 577);
            this.NcaEmulatorExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaEmulatorExtract.Name = "NcaEmulatorExtract";
            this.NcaEmulatorExtract.Size = new System.Drawing.Size(233, 29);
            this.NcaEmulatorExtract.TabIndex = 5;
            this.NcaEmulatorExtract.Text = "Extract for Emulator";
            this.NcaEmulatorExtract.UseVisualStyleBackColor = true;
            // 
            // NcaExtract
            // 
            this.NcaExtract.Location = new System.Drawing.Point(6, 621);
            this.NcaExtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NcaExtract.Name = "NcaExtract";
            this.NcaExtract.Size = new System.Drawing.Size(674, 67);
            this.NcaExtract.TabIndex = 4;
            this.NcaExtract.Text = "Extract";
            this.NcaExtract.UseVisualStyleBackColor = true;
            this.NcaExtract.Click += new System.EventHandler(this.NcaExtract_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(18, 852);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(132, 25);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 890);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.HacTab);
            this.Controls.Add(this.HactoolVersion);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "EZ-HAC - Another hactool GUI!";
            this.HacTab.ResumeLayout(false);
            this.XciExtractionTab.ResumeLayout(false);
            this.XciExtractionTab.PerformLayout();
            this.NcaExtractionTab.ResumeLayout(false);
            this.NcaExtractionTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label HactoolVersion;
        private System.Windows.Forms.TabControl HacTab;
        private System.Windows.Forms.TabPage XciExtractionTab;
        private System.Windows.Forms.TabPage NcaExtractionTab;
        private System.Windows.Forms.Label XciFileLabel;
        private System.Windows.Forms.TextBox XciPath;
        private System.Windows.Forms.Button XciBrowse;
        private System.Windows.Forms.Button XciExtract;
        private System.Windows.Forms.Label XciOutputLabel;
        private System.Windows.Forms.Button XciOutputBrowse;
        private System.Windows.Forms.TextBox XciOutputPath;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.CheckBox NcaEmulatorExtract;
        private System.Windows.Forms.Button NcaExtract;
        private System.Windows.Forms.Label NcaOutputLabel;
        private System.Windows.Forms.Button NcaOutputBrowse;
        private System.Windows.Forms.TextBox NcaOutputPath;
        private System.Windows.Forms.Button NcaBrowse;
        private System.Windows.Forms.Label NcaFileLabel;
        private System.Windows.Forms.TextBox NcaPath;
        private System.Windows.Forms.TextBox NcaTitleKey;
        private System.Windows.Forms.Label NcaTitleKeyLabel;
    }
}

