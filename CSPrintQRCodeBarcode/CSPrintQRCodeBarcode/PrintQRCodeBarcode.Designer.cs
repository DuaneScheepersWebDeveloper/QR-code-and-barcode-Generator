namespace CSPrintQRCodeBarcode
{
    partial class PrintQRCodeBarcode
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
            this.themeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.backgroundPictureBox = new MaterialSkin.Controls.MaterialCard();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.barcodeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.qrcodeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveImageButton = new MaterialSkin.Controls.MaterialButton();
            this.barcodeButton = new MaterialSkin.Controls.MaterialButton();
            this.qrCodeButton = new MaterialSkin.Controls.MaterialButton();
            this.printButton = new MaterialSkin.Controls.MaterialButton();
            this.backgroundPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Depth = 0;
            this.themeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.themeLabel.Location = new System.Drawing.Point(57, 78);
            this.themeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(50, 19);
            this.themeLabel.TabIndex = 0;
            this.themeLabel.Text = "Theme";
            // 
            // themeSwitch
            // 
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.themeSwitch.Checked = true;
            this.themeSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.themeSwitch.Depth = 0;
            this.themeSwitch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.themeSwitch.Location = new System.Drawing.Point(127, 69);
            this.themeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Ripple = true;
            this.themeSwitch.Size = new System.Drawing.Size(138, 37);
            this.themeSwitch.TabIndex = 2;
            this.themeSwitch.Text = "Light mode";
            this.themeSwitch.UseVisualStyleBackColor = false;
            this.themeSwitch.CheckedChanged += new System.EventHandler(this.themeSwitch_CheckedChanged);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backgroundPictureBox.Controls.Add(this.qrBox);
            this.backgroundPictureBox.Depth = 0;
            this.backgroundPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backgroundPictureBox.Location = new System.Drawing.Point(31, 103);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(14);
            this.backgroundPictureBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Padding = new System.Windows.Forms.Padding(14);
            this.backgroundPictureBox.Size = new System.Drawing.Size(519, 326);
            this.backgroundPictureBox.TabIndex = 4;
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(158, 67);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(180, 180);
            this.qrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrBox.TabIndex = 0;
            this.qrBox.TabStop = false;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.AnimateReadOnly = false;
            this.barcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcodeTextBox.Depth = 0;
            this.barcodeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.barcodeTextBox.Hint = "Barcode";
            this.barcodeTextBox.LeadingIcon = null;
            this.barcodeTextBox.Location = new System.Drawing.Point(29, 446);
            this.barcodeTextBox.MaxLength = 50;
            this.barcodeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.barcodeTextBox.Multiline = false;
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(395, 36);
            this.barcodeTextBox.TabIndex = 5;
            this.barcodeTextBox.Text = "";
            this.barcodeTextBox.TrailingIcon = null;
            this.barcodeTextBox.UseTallSize = false;
            // 
            // qrcodeTextBox
            // 
            this.qrcodeTextBox.AnimateReadOnly = false;
            this.qrcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qrcodeTextBox.Depth = 0;
            this.qrcodeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.qrcodeTextBox.Hint = "QR Code";
            this.qrcodeTextBox.LeadingIcon = null;
            this.qrcodeTextBox.Location = new System.Drawing.Point(29, 488);
            this.qrcodeTextBox.MaxLength = 50;
            this.qrcodeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.qrcodeTextBox.Multiline = false;
            this.qrcodeTextBox.Name = "qrcodeTextBox";
            this.qrcodeTextBox.Size = new System.Drawing.Size(395, 36);
            this.qrcodeTextBox.TabIndex = 6;
            this.qrcodeTextBox.Text = "";
            this.qrcodeTextBox.TrailingIcon = null;
            this.qrcodeTextBox.UseTallSize = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.AutoSize = false;
            this.saveImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveImageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveImageButton.Depth = 0;
            this.saveImageButton.HighEmphasis = true;
            this.saveImageButton.Icon = null;
            this.saveImageButton.Location = new System.Drawing.Point(31, 533);
            this.saveImageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveImageButton.Size = new System.Drawing.Size(393, 36);
            this.saveImageButton.TabIndex = 7;
            this.saveImageButton.Text = "Save Image As JPG or PNG";
            this.saveImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveImageButton.UseAccentColor = true;
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // barcodeButton
            // 
            this.barcodeButton.AutoSize = false;
            this.barcodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barcodeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.barcodeButton.Depth = 0;
            this.barcodeButton.HighEmphasis = true;
            this.barcodeButton.Icon = null;
            this.barcodeButton.Location = new System.Drawing.Point(450, 446);
            this.barcodeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barcodeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.barcodeButton.Name = "barcodeButton";
            this.barcodeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.barcodeButton.Size = new System.Drawing.Size(100, 36);
            this.barcodeButton.TabIndex = 8;
            this.barcodeButton.Text = "Barcode";
            this.barcodeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.barcodeButton.UseAccentColor = false;
            this.barcodeButton.UseVisualStyleBackColor = true;
            this.barcodeButton.Click += new System.EventHandler(this.barcodeButton_Click);
            // 
            // qrCodeButton
            // 
            this.qrCodeButton.AutoSize = false;
            this.qrCodeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.qrCodeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.qrCodeButton.Depth = 0;
            this.qrCodeButton.HighEmphasis = true;
            this.qrCodeButton.Icon = null;
            this.qrCodeButton.Location = new System.Drawing.Point(450, 489);
            this.qrCodeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.qrCodeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.qrCodeButton.Name = "qrCodeButton";
            this.qrCodeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.qrCodeButton.Size = new System.Drawing.Size(100, 36);
            this.qrCodeButton.TabIndex = 9;
            this.qrCodeButton.Text = "QR Code";
            this.qrCodeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.qrCodeButton.UseAccentColor = false;
            this.qrCodeButton.UseVisualStyleBackColor = true;
            this.qrCodeButton.Click += new System.EventHandler(this.qrCodeButton_Click);
            // 
            // printButton
            // 
            this.printButton.AutoSize = false;
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.printButton.Depth = 0;
            this.printButton.HighEmphasis = true;
            this.printButton.Icon = null;
            this.printButton.Location = new System.Drawing.Point(450, 533);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.printButton.Name = "printButton";
            this.printButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.printButton.Size = new System.Drawing.Size(100, 36);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print";
            this.printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printButton.UseAccentColor = false;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // PrintQRCodeBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 601);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.qrCodeButton);
            this.Controls.Add(this.barcodeButton);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.qrcodeTextBox);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Controls.Add(this.themeSwitch);
            this.Controls.Add(this.themeLabel);
            this.Name = "PrintQRCodeBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print QR Code and Barcode Lables";
            this.backgroundPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel themeLabel;
        private MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private MaterialSkin.Controls.MaterialCard backgroundPictureBox;
        private System.Windows.Forms.PictureBox qrBox;
        private MaterialSkin.Controls.MaterialTextBox barcodeTextBox;
        private MaterialSkin.Controls.MaterialTextBox qrcodeTextBox;
        private MaterialSkin.Controls.MaterialButton saveImageButton;
        private MaterialSkin.Controls.MaterialButton barcodeButton;
        private MaterialSkin.Controls.MaterialButton qrCodeButton;
        private MaterialSkin.Controls.MaterialButton printButton;
    }
}