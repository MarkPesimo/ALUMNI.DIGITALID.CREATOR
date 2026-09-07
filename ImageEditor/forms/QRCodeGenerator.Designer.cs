namespace AlumniDigitalIDTool.forms
{
    partial class QRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGenerator));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BranchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.lblrecord = new System.Windows.Forms.Label();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(70, 44);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(674, 21);
            this.txtURL.TabIndex = 14;
            this.txtURL.Text = "https://alumni.digitalid.ph/account/pin?_guid=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "URL :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(958, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1094;
            this.label3.Text = "Color :";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtColor.Location = new System.Drawing.Point(70, 71);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(89, 21);
            this.txtColor.TabIndex = 1093;
            this.txtColor.Text = "#910124";
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(70, 17);
            this.txtpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(674, 21);
            this.txtpath.TabIndex = 1096;
            this.txtpath.Text = "C:\\Users\\MarkJPesimo\\Documents\\AlumniDigitalID\\QR Codes\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1095;
            this.label1.Text = "Path :";
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.White;
            this.picQR.Location = new System.Drawing.Point(751, 98);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(301, 297);
            this.picQR.TabIndex = 1084;
            this.picQR.TabStop = false;
            // 
            // lsvList
            // 
            this.lsvList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.BranchName,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.HideSelection = false;
            this.lsvList.Location = new System.Drawing.Point(6, 98);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(738, 491);
            this.lsvList.TabIndex = 1097;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Alumni No.";
            this.id.Width = 185;
            // 
            // BranchName
            // 
            this.BranchName.Text = "Alumni Name";
            this.BranchName.Width = 384;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course/Degree";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Batch";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Member Type";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Expiration";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Remarks";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "userid";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Guid";
            this.columnHeader7.Width = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(958, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 1098;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb.Location = new System.Drawing.Point(0, 598);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(1063, 8);
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 1099;
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Location = new System.Drawing.Point(922, 44);
            this.lblrecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(84, 13);
            this.lblrecord.TabIndex = 1100;
            this.lblrecord.Text = "Record count :  ";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "id";
            this.columnHeader8.Width = 0;
            // 
            // QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 606);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QRCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCodeGenerator";
            this.Load += new System.EventHandler(this.QRCodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picQR;
        internal System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtColor;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader BranchName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}