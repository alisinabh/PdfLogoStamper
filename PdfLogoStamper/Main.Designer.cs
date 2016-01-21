namespace LogoPlacer
{
    partial class Main
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
            this.txtPdfFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStamp = new System.Windows.Forms.Button();
            this.cbIconPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtImageAddress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtimgW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtimgH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrowseSave = new System.Windows.Forms.Button();
            this.txtSaveAddr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPdfFolder
            // 
            this.txtPdfFolder.Location = new System.Drawing.Point(101, 12);
            this.txtPdfFolder.Name = "txtPdfFolder";
            this.txtPdfFolder.Size = new System.Drawing.Size(307, 20);
            this.txtPdfFolder.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(405, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 22);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PDF Directory:";
            // 
            // btnStamp
            // 
            this.btnStamp.Location = new System.Drawing.Point(372, 206);
            this.btnStamp.Name = "btnStamp";
            this.btnStamp.Size = new System.Drawing.Size(117, 23);
            this.btnStamp.TabIndex = 3;
            this.btnStamp.Text = "Stamp All Directory";
            this.btnStamp.UseVisualStyleBackColor = true;
            this.btnStamp.Click += new System.EventHandler(this.btnStamp_Click);
            // 
            // cbIconPosition
            // 
            this.cbIconPosition.FormattingEnabled = true;
            this.cbIconPosition.Location = new System.Drawing.Point(101, 64);
            this.cbIconPosition.Name = "cbIconPosition";
            this.cbIconPosition.Size = new System.Drawing.Size(307, 21);
            this.cbIconPosition.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stamp Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "StampImage";
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Location = new System.Drawing.Point(405, 37);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(84, 22);
            this.btnBrowseIcon.TabIndex = 7;
            this.btnBrowseIcon.Text = "Browse...";
            this.btnBrowseIcon.UseVisualStyleBackColor = true;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtImageAddress
            // 
            this.txtImageAddress.Location = new System.Drawing.Point(101, 38);
            this.txtImageAddress.Name = "txtImageAddress";
            this.txtImageAddress.Size = new System.Drawing.Size(307, 20);
            this.txtImageAddress.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Image Address";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(101, 91);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(51, 20);
            this.txtLeft.TabIndex = 9;
            this.txtLeft.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Left Margin:";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(288, 91);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(51, 20);
            this.txtTop.TabIndex = 11;
            this.txtTop.Text = "0";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(199, 91);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(51, 20);
            this.txtRight.TabIndex = 12;
            this.txtRight.Text = "0";
            // 
            // txtBottom
            // 
            this.txtBottom.Location = new System.Drawing.Point(394, 91);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(51, 20);
            this.txtBottom.TabIndex = 13;
            this.txtBottom.Text = "0";
            this.txtBottom.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Right:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Top:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bottom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Image Size:";
            // 
            // txtimgW
            // 
            this.txtimgW.Location = new System.Drawing.Point(142, 126);
            this.txtimgW.Name = "txtimgW";
            this.txtimgW.Size = new System.Drawing.Size(51, 20);
            this.txtimgW.TabIndex = 18;
            this.txtimgW.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Height:";
            // 
            // txtimgH
            // 
            this.txtimgH.Location = new System.Drawing.Point(246, 126);
            this.txtimgH.Name = "txtimgH";
            this.txtimgH.Size = new System.Drawing.Size(51, 20);
            this.txtimgH.TabIndex = 20;
            this.txtimgH.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(370, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "(0 = imageDefault) (-1 = Scale with otherone) W or H will be used in bar mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Saving Directory:";
            // 
            // btnBrowseSave
            // 
            this.btnBrowseSave.Location = new System.Drawing.Point(405, 179);
            this.btnBrowseSave.Name = "btnBrowseSave";
            this.btnBrowseSave.Size = new System.Drawing.Size(84, 22);
            this.btnBrowseSave.TabIndex = 24;
            this.btnBrowseSave.Text = "Browse...";
            this.btnBrowseSave.UseVisualStyleBackColor = true;
            this.btnBrowseSave.Click += new System.EventHandler(this.btnBrowseSave_Click);
            // 
            // txtSaveAddr
            // 
            this.txtSaveAddr.Location = new System.Drawing.Point(101, 180);
            this.txtSaveAddr.Name = "txtSaveAddr";
            this.txtSaveAddr.Size = new System.Drawing.Size(307, 20);
            this.txtSaveAddr.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 241);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBrowseSave);
            this.Controls.Add(this.txtSaveAddr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtimgH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtimgW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseIcon);
            this.Controls.Add(this.txtImageAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIconPosition);
            this.Controls.Add(this.btnStamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPdfFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "PDF Stamper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPdfFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStamp;
        private System.Windows.Forms.ComboBox cbIconPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtImageAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtimgW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtimgH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrowseSave;
        private System.Windows.Forms.TextBox txtSaveAddr;
    }
}