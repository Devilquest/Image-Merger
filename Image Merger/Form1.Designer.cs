namespace Image_Merger
{
    partial class Form1
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
			System.Windows.Forms.Label image1Label;
			System.Windows.Forms.Label image2Label;
			System.Windows.Forms.Label image4Label;
			System.Windows.Forms.Label image3Label;
			System.Windows.Forms.Label thresholdLabel;
			System.Windows.Forms.Panel radioButtonsPanel;
			System.Windows.Forms.Label backgroundLabel;
			this.differentRadioButton = new System.Windows.Forms.RadioButton();
			this.similarRadioButton = new System.Windows.Forms.RadioButton();
			this.imageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.previewImagePictureBox = new System.Windows.Forms.PictureBox();
			this.previewImagePanel = new System.Windows.Forms.Panel();
			this.image1TextBox = new System.Windows.Forms.TextBox();
			this.image1BrowseButton = new System.Windows.Forms.Button();
			this.image1ClearButton = new System.Windows.Forms.Button();
			this.image1Panel = new System.Windows.Forms.Panel();
			this.image2Panel = new System.Windows.Forms.Panel();
			this.image2ClearButton = new System.Windows.Forms.Button();
			this.image2BrowseButton = new System.Windows.Forms.Button();
			this.image2TextBox = new System.Windows.Forms.TextBox();
			this.image4Panel = new System.Windows.Forms.Panel();
			this.image4ClearButton = new System.Windows.Forms.Button();
			this.image4BrowseButton = new System.Windows.Forms.Button();
			this.image4TextBox = new System.Windows.Forms.TextBox();
			this.image3Panel = new System.Windows.Forms.Panel();
			this.image3ClearButton = new System.Windows.Forms.Button();
			this.image3BrowseButton = new System.Windows.Forms.Button();
			this.image3TextBox = new System.Windows.Forms.TextBox();
			this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.previewButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.backgroundColorComboBox = new System.Windows.Forms.ComboBox();
			this.imageSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			image1Label = new System.Windows.Forms.Label();
			image2Label = new System.Windows.Forms.Label();
			image4Label = new System.Windows.Forms.Label();
			image3Label = new System.Windows.Forms.Label();
			thresholdLabel = new System.Windows.Forms.Label();
			radioButtonsPanel = new System.Windows.Forms.Panel();
			backgroundLabel = new System.Windows.Forms.Label();
			radioButtonsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewImagePictureBox)).BeginInit();
			this.previewImagePanel.SuspendLayout();
			this.image1Panel.SuspendLayout();
			this.image2Panel.SuspendLayout();
			this.image4Panel.SuspendLayout();
			this.image3Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// image1Label
			// 
			image1Label.AutoSize = true;
			image1Label.Location = new System.Drawing.Point(7, 8);
			image1Label.Name = "image1Label";
			image1Label.Size = new System.Drawing.Size(48, 13);
			image1Label.TabIndex = 5;
			image1Label.Text = "Image 1:";
			// 
			// image2Label
			// 
			image2Label.AutoSize = true;
			image2Label.Location = new System.Drawing.Point(7, 8);
			image2Label.Name = "image2Label";
			image2Label.Size = new System.Drawing.Size(48, 13);
			image2Label.TabIndex = 5;
			image2Label.Text = "Image 2:";
			// 
			// image4Label
			// 
			image4Label.AutoSize = true;
			image4Label.Location = new System.Drawing.Point(7, 8);
			image4Label.Name = "image4Label";
			image4Label.Size = new System.Drawing.Size(48, 13);
			image4Label.TabIndex = 5;
			image4Label.Text = "Image 4:";
			// 
			// image3Label
			// 
			image3Label.AutoSize = true;
			image3Label.Location = new System.Drawing.Point(7, 8);
			image3Label.Name = "image3Label";
			image3Label.Size = new System.Drawing.Size(48, 13);
			image3Label.TabIndex = 5;
			image3Label.Text = "Image 3:";
			// 
			// thresholdLabel
			// 
			thresholdLabel.AutoSize = true;
			thresholdLabel.Location = new System.Drawing.Point(12, 204);
			thresholdLabel.Name = "thresholdLabel";
			thresholdLabel.Size = new System.Drawing.Size(57, 13);
			thresholdLabel.TabIndex = 47;
			thresholdLabel.Text = "Threshold:";
			// 
			// radioButtonsPanel
			// 
			radioButtonsPanel.Controls.Add(this.differentRadioButton);
			radioButtonsPanel.Controls.Add(this.similarRadioButton);
			radioButtonsPanel.Location = new System.Drawing.Point(12, 254);
			radioButtonsPanel.Name = "radioButtonsPanel";
			radioButtonsPanel.Size = new System.Drawing.Size(130, 27);
			radioButtonsPanel.TabIndex = 50;
			// 
			// differentRadioButton
			// 
			this.differentRadioButton.AutoSize = true;
			this.differentRadioButton.Location = new System.Drawing.Point(65, 4);
			this.differentRadioButton.Name = "differentRadioButton";
			this.differentRadioButton.Size = new System.Drawing.Size(65, 17);
			this.differentRadioButton.TabIndex = 1;
			this.differentRadioButton.Text = "Different";
			this.differentRadioButton.UseVisualStyleBackColor = true;
			// 
			// similarRadioButton
			// 
			this.similarRadioButton.AutoSize = true;
			this.similarRadioButton.Checked = true;
			this.similarRadioButton.Location = new System.Drawing.Point(4, 4);
			this.similarRadioButton.Name = "similarRadioButton";
			this.similarRadioButton.Size = new System.Drawing.Size(55, 17);
			this.similarRadioButton.TabIndex = 0;
			this.similarRadioButton.TabStop = true;
			this.similarRadioButton.Text = "Similar";
			this.similarRadioButton.UseVisualStyleBackColor = true;
			this.similarRadioButton.CheckedChanged += new System.EventHandler(this.SimilarDifferentRadioButton_CheckedChanged);
			// 
			// backgroundLabel
			// 
			backgroundLabel.AutoSize = true;
			backgroundLabel.Location = new System.Drawing.Point(124, 204);
			backgroundLabel.Name = "backgroundLabel";
			backgroundLabel.Size = new System.Drawing.Size(136, 13);
			backgroundLabel.TabIndex = 51;
			backgroundLabel.Text = "Preview Background Color:";
			// 
			// imageOpenFileDialog
			// 
			this.imageOpenFileDialog.FileName = "Image File";
			this.imageOpenFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.jpe;*.jfif|PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.j" +
    "fif";
			this.imageOpenFileDialog.Title = "Choose image file";
			// 
			// previewImagePictureBox
			// 
			this.previewImagePictureBox.Location = new System.Drawing.Point(0, 0);
			this.previewImagePictureBox.Name = "previewImagePictureBox";
			this.previewImagePictureBox.Size = new System.Drawing.Size(100, 100);
			this.previewImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.previewImagePictureBox.TabIndex = 2;
			this.previewImagePictureBox.TabStop = false;
			this.previewImagePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewImagePictureBox_MouseDown);
			this.previewImagePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PreviewImagePictureBox_MouseMove);
			this.previewImagePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PreviewImagePictureBox_MouseUp);
			// 
			// previewImagePanel
			// 
			this.previewImagePanel.BackColor = System.Drawing.SystemColors.Control;
			this.previewImagePanel.Controls.Add(this.previewImagePictureBox);
			this.previewImagePanel.Location = new System.Drawing.Point(13, 290);
			this.previewImagePanel.Name = "previewImagePanel";
			this.previewImagePanel.Size = new System.Drawing.Size(355, 200);
			this.previewImagePanel.TabIndex = 40;
			// 
			// image1TextBox
			// 
			this.image1TextBox.Enabled = false;
			this.image1TextBox.Location = new System.Drawing.Point(10, 24);
			this.image1TextBox.Name = "image1TextBox";
			this.image1TextBox.Size = new System.Drawing.Size(263, 20);
			this.image1TextBox.TabIndex = 1;
			this.image1TextBox.Tag = "Image1TextBox";
			this.image1TextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
			// 
			// image1BrowseButton
			// 
			this.image1BrowseButton.Location = new System.Drawing.Point(279, 23);
			this.image1BrowseButton.Name = "image1BrowseButton";
			this.image1BrowseButton.Size = new System.Drawing.Size(35, 22);
			this.image1BrowseButton.TabIndex = 0;
			this.image1BrowseButton.TabStop = false;
			this.image1BrowseButton.Tag = "image1Browse";
			this.image1BrowseButton.Text = "...";
			this.image1BrowseButton.UseVisualStyleBackColor = true;
			this.image1BrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
			// 
			// image1ClearButton
			// 
			this.image1ClearButton.Enabled = false;
			this.image1ClearButton.Location = new System.Drawing.Point(320, 23);
			this.image1ClearButton.Name = "image1ClearButton";
			this.image1ClearButton.Size = new System.Drawing.Size(45, 22);
			this.image1ClearButton.TabIndex = 1;
			this.image1ClearButton.TabStop = false;
			this.image1ClearButton.Tag = "Clear1";
			this.image1ClearButton.Text = "Clear";
			this.image1ClearButton.UseVisualStyleBackColor = true;
			this.image1ClearButton.Click += new System.EventHandler(this.ImageClearButton_Click);
			// 
			// image1Panel
			// 
			this.image1Panel.Controls.Add(this.image1ClearButton);
			this.image1Panel.Controls.Add(this.image1BrowseButton);
			this.image1Panel.Controls.Add(image1Label);
			this.image1Panel.Controls.Add(this.image1TextBox);
			this.image1Panel.Location = new System.Drawing.Point(3, 2);
			this.image1Panel.Name = "image1Panel";
			this.image1Panel.Size = new System.Drawing.Size(374, 49);
			this.image1Panel.TabIndex = 41;
			// 
			// image2Panel
			// 
			this.image2Panel.Controls.Add(this.image2ClearButton);
			this.image2Panel.Controls.Add(this.image2BrowseButton);
			this.image2Panel.Controls.Add(image2Label);
			this.image2Panel.Controls.Add(this.image2TextBox);
			this.image2Panel.Enabled = false;
			this.image2Panel.Location = new System.Drawing.Point(3, 49);
			this.image2Panel.Name = "image2Panel";
			this.image2Panel.Size = new System.Drawing.Size(374, 49);
			this.image2Panel.TabIndex = 42;
			// 
			// image2ClearButton
			// 
			this.image2ClearButton.Enabled = false;
			this.image2ClearButton.Location = new System.Drawing.Point(320, 23);
			this.image2ClearButton.Name = "image2ClearButton";
			this.image2ClearButton.Size = new System.Drawing.Size(45, 22);
			this.image2ClearButton.TabIndex = 1;
			this.image2ClearButton.TabStop = false;
			this.image2ClearButton.Tag = "Clear2";
			this.image2ClearButton.Text = "Clear";
			this.image2ClearButton.UseVisualStyleBackColor = true;
			this.image2ClearButton.Click += new System.EventHandler(this.ImageClearButton_Click);
			// 
			// image2BrowseButton
			// 
			this.image2BrowseButton.Location = new System.Drawing.Point(279, 23);
			this.image2BrowseButton.Name = "image2BrowseButton";
			this.image2BrowseButton.Size = new System.Drawing.Size(35, 22);
			this.image2BrowseButton.TabIndex = 0;
			this.image2BrowseButton.TabStop = false;
			this.image2BrowseButton.Tag = "image2Browse";
			this.image2BrowseButton.Text = "...";
			this.image2BrowseButton.UseVisualStyleBackColor = true;
			this.image2BrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
			// 
			// image2TextBox
			// 
			this.image2TextBox.Enabled = false;
			this.image2TextBox.Location = new System.Drawing.Point(10, 24);
			this.image2TextBox.Name = "image2TextBox";
			this.image2TextBox.Size = new System.Drawing.Size(263, 20);
			this.image2TextBox.TabIndex = 2;
			this.image2TextBox.Tag = "Image2TextBox";
			this.image2TextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
			// 
			// image4Panel
			// 
			this.image4Panel.Controls.Add(this.image4ClearButton);
			this.image4Panel.Controls.Add(this.image4BrowseButton);
			this.image4Panel.Controls.Add(image4Label);
			this.image4Panel.Controls.Add(this.image4TextBox);
			this.image4Panel.Enabled = false;
			this.image4Panel.Location = new System.Drawing.Point(3, 143);
			this.image4Panel.Name = "image4Panel";
			this.image4Panel.Size = new System.Drawing.Size(374, 49);
			this.image4Panel.TabIndex = 44;
			// 
			// image4ClearButton
			// 
			this.image4ClearButton.Enabled = false;
			this.image4ClearButton.Location = new System.Drawing.Point(320, 23);
			this.image4ClearButton.Name = "image4ClearButton";
			this.image4ClearButton.Size = new System.Drawing.Size(45, 22);
			this.image4ClearButton.TabIndex = 1;
			this.image4ClearButton.TabStop = false;
			this.image4ClearButton.Tag = "Clear4";
			this.image4ClearButton.Text = "Clear";
			this.image4ClearButton.UseVisualStyleBackColor = true;
			this.image4ClearButton.Click += new System.EventHandler(this.ImageClearButton_Click);
			// 
			// image4BrowseButton
			// 
			this.image4BrowseButton.Location = new System.Drawing.Point(279, 23);
			this.image4BrowseButton.Name = "image4BrowseButton";
			this.image4BrowseButton.Size = new System.Drawing.Size(35, 22);
			this.image4BrowseButton.TabIndex = 0;
			this.image4BrowseButton.TabStop = false;
			this.image4BrowseButton.Tag = "image4Browse";
			this.image4BrowseButton.Text = "...";
			this.image4BrowseButton.UseVisualStyleBackColor = true;
			this.image4BrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
			// 
			// image4TextBox
			// 
			this.image4TextBox.Enabled = false;
			this.image4TextBox.Location = new System.Drawing.Point(10, 24);
			this.image4TextBox.Name = "image4TextBox";
			this.image4TextBox.Size = new System.Drawing.Size(263, 20);
			this.image4TextBox.TabIndex = 4;
			this.image4TextBox.Tag = "Image4TextBox";
			this.image4TextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
			// 
			// image3Panel
			// 
			this.image3Panel.Controls.Add(this.image3ClearButton);
			this.image3Panel.Controls.Add(this.image3BrowseButton);
			this.image3Panel.Controls.Add(image3Label);
			this.image3Panel.Controls.Add(this.image3TextBox);
			this.image3Panel.Enabled = false;
			this.image3Panel.Location = new System.Drawing.Point(3, 96);
			this.image3Panel.Name = "image3Panel";
			this.image3Panel.Size = new System.Drawing.Size(374, 49);
			this.image3Panel.TabIndex = 43;
			// 
			// image3ClearButton
			// 
			this.image3ClearButton.Enabled = false;
			this.image3ClearButton.Location = new System.Drawing.Point(320, 23);
			this.image3ClearButton.Name = "image3ClearButton";
			this.image3ClearButton.Size = new System.Drawing.Size(45, 22);
			this.image3ClearButton.TabIndex = 1;
			this.image3ClearButton.TabStop = false;
			this.image3ClearButton.Tag = "Clear3";
			this.image3ClearButton.Text = "Clear";
			this.image3ClearButton.UseVisualStyleBackColor = true;
			this.image3ClearButton.Click += new System.EventHandler(this.ImageClearButton_Click);
			// 
			// image3BrowseButton
			// 
			this.image3BrowseButton.Location = new System.Drawing.Point(279, 23);
			this.image3BrowseButton.Name = "image3BrowseButton";
			this.image3BrowseButton.Size = new System.Drawing.Size(35, 22);
			this.image3BrowseButton.TabIndex = 0;
			this.image3BrowseButton.TabStop = false;
			this.image3BrowseButton.Tag = "image3Browse";
			this.image3BrowseButton.Text = "...";
			this.image3BrowseButton.UseVisualStyleBackColor = true;
			this.image3BrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
			// 
			// image3TextBox
			// 
			this.image3TextBox.Enabled = false;
			this.image3TextBox.Location = new System.Drawing.Point(10, 24);
			this.image3TextBox.Name = "image3TextBox";
			this.image3TextBox.Size = new System.Drawing.Size(263, 20);
			this.image3TextBox.TabIndex = 3;
			this.image3TextBox.Tag = "Image3TextBox";
			this.image3TextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
			// 
			// thresholdNumericUpDown
			// 
			this.thresholdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thresholdNumericUpDown.Location = new System.Drawing.Point(15, 220);
			this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
			this.thresholdNumericUpDown.Size = new System.Drawing.Size(84, 22);
			this.thresholdNumericUpDown.TabIndex = 46;
			this.thresholdNumericUpDown.TabStop = false;
			this.thresholdNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// previewButton
			// 
			this.previewButton.Enabled = false;
			this.previewButton.Location = new System.Drawing.Point(151, 250);
			this.previewButton.Name = "previewButton";
			this.previewButton.Size = new System.Drawing.Size(108, 34);
			this.previewButton.TabIndex = 6;
			this.previewButton.TabStop = false;
			this.previewButton.Tag = "";
			this.previewButton.Text = "Preview";
			this.previewButton.UseVisualStyleBackColor = true;
			this.previewButton.Click += new System.EventHandler(this.PreviewButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(260, 250);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(108, 34);
			this.saveButton.TabIndex = 48;
			this.saveButton.TabStop = false;
			this.saveButton.Tag = "";
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// backgroundColorComboBox
			// 
			this.backgroundColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.backgroundColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.backgroundColorComboBox.FormattingEnabled = true;
			this.backgroundColorComboBox.ItemHeight = 16;
			this.backgroundColorComboBox.Location = new System.Drawing.Point(127, 220);
			this.backgroundColorComboBox.MaxDropDownItems = 30;
			this.backgroundColorComboBox.Name = "backgroundColorComboBox";
			this.backgroundColorComboBox.Size = new System.Drawing.Size(241, 24);
			this.backgroundColorComboBox.TabIndex = 49;
			this.backgroundColorComboBox.TabStop = false;
			this.backgroundColorComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.BackgroundColorComboBox_DrawItem);
			this.backgroundColorComboBox.SelectedIndexChanged += new System.EventHandler(this.BackgroundColorComboBox_SelectedIndexChanged);
			// 
			// imageSaveFileDialog
			// 
			this.imageSaveFileDialog.FileName = "Result image";
			this.imageSaveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
			this.imageSaveFileDialog.Title = "Save result image";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 503);
			this.Controls.Add(backgroundLabel);
			this.Controls.Add(radioButtonsPanel);
			this.Controls.Add(this.backgroundColorComboBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.previewButton);
			this.Controls.Add(thresholdLabel);
			this.Controls.Add(this.thresholdNumericUpDown);
			this.Controls.Add(this.image4Panel);
			this.Controls.Add(this.image2Panel);
			this.Controls.Add(this.image3Panel);
			this.Controls.Add(this.previewImagePanel);
			this.Controls.Add(this.image1Panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Image Merger";
			radioButtonsPanel.ResumeLayout(false);
			radioButtonsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewImagePictureBox)).EndInit();
			this.previewImagePanel.ResumeLayout(false);
			this.previewImagePanel.PerformLayout();
			this.image1Panel.ResumeLayout(false);
			this.image1Panel.PerformLayout();
			this.image2Panel.ResumeLayout(false);
			this.image2Panel.PerformLayout();
			this.image4Panel.ResumeLayout(false);
			this.image4Panel.PerformLayout();
			this.image3Panel.ResumeLayout(false);
			this.image3Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog imageOpenFileDialog;
        private System.Windows.Forms.PictureBox previewImagePictureBox;
        private System.Windows.Forms.Panel previewImagePanel;
        private System.Windows.Forms.TextBox image1TextBox;
        private System.Windows.Forms.Button image1BrowseButton;
        private System.Windows.Forms.Button image1ClearButton;
        private System.Windows.Forms.Panel image1Panel;
        private System.Windows.Forms.Panel image2Panel;
        private System.Windows.Forms.Button image2ClearButton;
        private System.Windows.Forms.Button image2BrowseButton;
        private System.Windows.Forms.TextBox image2TextBox;
        private System.Windows.Forms.Panel image4Panel;
        private System.Windows.Forms.Button image4ClearButton;
        private System.Windows.Forms.Button image4BrowseButton;
        private System.Windows.Forms.TextBox image4TextBox;
        private System.Windows.Forms.Panel image3Panel;
        private System.Windows.Forms.Button image3ClearButton;
        private System.Windows.Forms.Button image3BrowseButton;
        private System.Windows.Forms.TextBox image3TextBox;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox backgroundColorComboBox;
        private System.Windows.Forms.SaveFileDialog imageSaveFileDialog;
        private System.Windows.Forms.RadioButton differentRadioButton;
        private System.Windows.Forms.RadioButton similarRadioButton;
    }
}

