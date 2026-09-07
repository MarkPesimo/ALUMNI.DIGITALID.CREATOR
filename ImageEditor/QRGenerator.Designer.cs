namespace AlumniDigitalIDCreator
{
    partial class QRGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRGenerator));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxQRCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.btn_itemtype = new System.Windows.Forms.Button();
            this.iconPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPreviewBackgroundColor = new System.Windows.Forms.Panel();
            this.panelPreviewPrimaryColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1094;
            this.label3.Text = "Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1093;
            this.label2.Text = "Link :";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtColor.Location = new System.Drawing.Point(67, 77);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(325, 21);
            this.txtColor.TabIndex = 1097;
            this.txtColor.Text = "#0c4496";
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxQRCode.Border.Class = "TextBoxBorder";
            this.textBoxQRCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxQRCode.Location = new System.Drawing.Point(67, 50);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(325, 21);
            this.textBoxQRCode.TabIndex = 1096;
            this.textBoxQRCode.Text = "http://www.zips.wardhowell.com.ph/Tool/ids?guid=";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.BackColor = System.Drawing.Color.White;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(76, 104);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(301, 297);
            this.pictureBoxQRCode.TabIndex = 1095;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // btn_itemtype
            // 
            this.btn_itemtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_itemtype.BackColor = System.Drawing.Color.White;
            this.btn_itemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemtype.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_itemtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_itemtype.Image")));
            this.btn_itemtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.Location = new System.Drawing.Point(247, 430);
            this.btn_itemtype.Name = "btn_itemtype";
            this.btn_itemtype.Size = new System.Drawing.Size(145, 37);
            this.btn_itemtype.TabIndex = 1098;
            this.btn_itemtype.Text = "           Generate QR code";
            this.btn_itemtype.UseVisualStyleBackColor = false;
            this.btn_itemtype.Click += new System.EventHandler(this.btn_itemtype_Click);
            // 
            // iconPath
            // 
            this.iconPath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.iconPath.Border.Class = "TextBoxBorder";
            this.iconPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iconPath.Location = new System.Drawing.Point(67, 23);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(325, 21);
            this.iconPath.TabIndex = 1100;
            this.iconPath.Text = "http://www.zips.wardhowell.com.ph/Tool/ids?guid=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1099;
            this.label1.Text = "Link :";
            // 
            // panelPreviewBackgroundColor
            // 
            this.panelPreviewBackgroundColor.BackColor = System.Drawing.Color.Silver;
            this.panelPreviewBackgroundColor.Location = new System.Drawing.Point(23, 494);
            this.panelPreviewBackgroundColor.Name = "panelPreviewBackgroundColor";
            this.panelPreviewBackgroundColor.Size = new System.Drawing.Size(200, 100);
            this.panelPreviewBackgroundColor.TabIndex = 1101;
            // 
            // panelPreviewPrimaryColor
            // 
            this.panelPreviewPrimaryColor.BackColor = System.Drawing.Color.DimGray;
            this.panelPreviewPrimaryColor.Location = new System.Drawing.Point(236, 494);
            this.panelPreviewPrimaryColor.Name = "panelPreviewPrimaryColor";
            this.panelPreviewPrimaryColor.Size = new System.Drawing.Size(200, 100);
            this.panelPreviewPrimaryColor.TabIndex = 1102;
            this.panelPreviewPrimaryColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPreviewPrimaryColor_Paint);
            // 
            // QRGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 618);
            this.Controls.Add(this.panelPreviewPrimaryColor);
            this.Controls.Add(this.panelPreviewBackgroundColor);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_itemtype);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.textBoxQRCode);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QRGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtColor;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Button btn_itemtype;
        private DevComponents.DotNetBar.Controls.TextBoxX iconPath;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPreviewBackgroundColor;
        private System.Windows.Forms.Panel panelPreviewPrimaryColor;
    }
}