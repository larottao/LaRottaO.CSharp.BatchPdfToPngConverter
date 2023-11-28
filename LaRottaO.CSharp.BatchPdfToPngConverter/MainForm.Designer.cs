namespace LaRottaO.CSharp.BatchPdfToPngConverter
{
    partial class MainForm
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
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.textBoxRequiredDpi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(28, 26);
            this.buttonSelectFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(139, 46);
            this.buttonSelectFolder.TabIndex = 0;
            this.buttonSelectFolder.Text = "Select folder with PDFs";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 15;
            this.listBoxStatus.Location = new System.Drawing.Point(191, 26);
            this.listBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(453, 109);
            this.listBoxStatus.TabIndex = 1;
            this.listBoxStatus.SelectedIndexChanged += new System.EventHandler(this.listBoxStatus_SelectedIndexChanged);
            // 
            // textBoxRequiredDpi
            // 
            this.textBoxRequiredDpi.Location = new System.Drawing.Point(28, 112);
            this.textBoxRequiredDpi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRequiredDpi.Name = "textBoxRequiredDpi";
            this.textBoxRequiredDpi.Size = new System.Drawing.Size(116, 23);
            this.textBoxRequiredDpi.TabIndex = 2;
            this.textBoxRequiredDpi.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Required DPI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRequiredDpi);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.buttonSelectFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Batch Pdf to png converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.TextBox textBoxRequiredDpi;
        private System.Windows.Forms.Label label1;
    }
}

