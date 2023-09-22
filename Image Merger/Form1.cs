using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_Merger
{
    public partial class Form1 : Form
    {
        //Options Variables
        bool similar = true;
        private Color[] backgroundColors = {
            Color.Transparent,
            Color.Black,
            Color.White,
            Color.Gray,
            Color.DarkGray,
            Color.LightGray,
            Color.DarkRed,
            Color.Red,
            Color.OrangeRed,
            Color.Orange,
            Color.Gold,
            Color.Yellow,
            Color.YellowGreen,
            Color.Green,
            Color.LimeGreen,
            Color.Lime,
            Color.SpringGreen,
            Color.Turquoise,
            Color.Teal,
            Color.Cyan,
            Color.DeepSkyBlue,
            Color.RoyalBlue,
            Color.Blue,
            Color.BlueViolet,
            Color.Purple,
            Color.Violet,
            Color.Magenta
        };

        //Image Variables
        private Bitmap[] imagesArray = new Bitmap[4] { null, null, null, null };
        private Bitmap resultImage;
        private int resultImageWidth = 0;
        private int resultImageHeight = 0;

        //Drag Image Variables
        private bool Dragging;
        private int xPos;
        private int yPos;

        public Form1()
        {
            InitializeComponent();

            InitializeBackgroundColorComboBox();
        }

        #region Compare Pixels
        void CompareAllPixels()
        {
            resultImage = new Bitmap(resultImageWidth, resultImageHeight);

            for (int i = 0; i < resultImageWidth; i++)
            {
                for (int j = 0; j < resultImageHeight; j++)
                {
                    bool similarPixel = true;

                    for (int k = 1; k < imagesArray.Length; k++)
                    {
                        if (imagesArray[k] == null) continue;

                        if (!ColorThreshold(imagesArray[0].GetPixel(i, j), imagesArray[k].GetPixel(i, j), (int)thresholdNumericUpDown.Value))
                            similarPixel = false;
                    }

                    if (similar)
                    {
                        if (similarPixel)
                            resultImage.SetPixel(i, j, imagesArray[0].GetPixel(i, j));
                        else
                            resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));
                    }
                    else
                    {
                        if (similarPixel)
                            resultImage.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));
                        else
                            resultImage.SetPixel(i, j, imagesArray[0].GetPixel(i, j));
                    }
                }
            }
            previewImagePictureBox.Image = resultImage;
        }

        private bool ColorThreshold(Color c1, Color c2, int tolerance)
        {
            return Math.Abs(c1.R - c2.R) <= tolerance &&
                   Math.Abs(c1.G - c2.G) <= tolerance &&
                   Math.Abs(c1.B - c2.B) <= tolerance;
        }
        #endregion

        #region UI Options
        private void ImageTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Tag)
            {
                case "Image1TextBox":
                    image1ClearButton.Enabled = true;
                    break;
                case "Image2TextBox":
                    image2ClearButton.Enabled = true;
                    break;
                case "Image3TextBox":
                    image3ClearButton.Enabled = true;
                    break;
                case "Image4TextBox":
                    image4ClearButton.Enabled = true;
                    break;
            }
        }

        private void BackgroundColorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            e.DrawBackground();

            ComboboxItem comboItem = (ComboboxItem)comboBox.Items[e.Index];

            Rectangle rect = new Rectangle
            {
                X = e.Bounds.X + 2,
                Y = e.Bounds.Y + 2,
                Width = 25,
                Height = e.Bounds.Height - 5
            };

            e.Graphics.FillRectangle(new SolidBrush(comboItem.BrushColor), rect);
            e.Graphics.DrawRectangle(SystemPens.WindowText, rect);

            e.Graphics.DrawString(comboItem.ColorName, comboBox.Font, Brushes.Black, e.Bounds.X + rect.Width + 5, e.Bounds.Y);
        }

        private void BackgroundColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue is Color color)
            {
                previewImagePanel.BackColor = color;
            }
        }

        private void SimilarDifferentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (similarRadioButton.Checked)
                similar = true;
            else
                similar = false;
        }

        /// <summary>
        /// Populate Preview Background ComboBox
        /// </summary>
        private void InitializeBackgroundColorComboBox()
        {
            List<ComboboxItem> itemList = new List<ComboboxItem>();
            foreach (Color c in backgroundColors)
            {
                ComboboxItem comboItem = new ComboboxItem
                {
                    ColorName = c.Name,
                    BrushColor = c
                };
                itemList.Add(comboItem);
            }
            backgroundColorComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            backgroundColorComboBox.DataSource = itemList;
            backgroundColorComboBox.ValueMember = "BrushColor";
        }
        #endregion

        #region Buttons Click
        private void ImageClearButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Clear1":
                    ClearTextbox1();
                    break;
                case "Clear2":
                    ClearTextbox2();
                    break;
                case "Clear3":
                    ClearTextbox3();
                    break;
                case "Clear4":
                    ClearTextbox4();
                    break;
            }
            previewButton.Enabled = CheckImageArray();

            void ClearTextbox1()
            {
                image1TextBox.Text = null;
                imagesArray[0] = null;
                image1ClearButton.Enabled = false;

                ClearTextbox2();
                image2Panel.Enabled = false;
                ClearTextbox3();
                ClearTextbox4();
            }

            void ClearTextbox2()
            {
                image2TextBox.Text = null;
                imagesArray[1] = null;
                image2ClearButton.Enabled = false;

                ClearTextbox3();
                image3Panel.Enabled = false;
                ClearTextbox4();
            }

            void ClearTextbox3()
            {
                image3TextBox.Text = null;
                imagesArray[2] = null;
                image3ClearButton.Enabled = false;

                ClearTextbox4();
                image4Panel.Enabled = false;
            }

            void ClearTextbox4()
            {
                image4TextBox.Text = null;
                imagesArray[3] = null;
                image4ClearButton.Enabled = false;
            }
        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            if (imageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (((Button)sender).Tag)
                {
                    case "image1Browse":
                        image1TextBox.Text = imageOpenFileDialog.FileName;
                        imagesArray[0] = new Bitmap(imageOpenFileDialog.FileName);
                        GetImageSizeOnSetImage(imagesArray[0]);
                        image2Panel.Enabled = true;
                        break;
                    case "image2Browse":
                        if (CheckImageSize(new Bitmap(imageOpenFileDialog.FileName)))
                        {
                            image2TextBox.Text = imageOpenFileDialog.FileName;
                            imagesArray[1] = new Bitmap(imageOpenFileDialog.FileName);
                            image3Panel.Enabled = true;
                        }
                        else
                            MessageBox.Show("Images don't match in size. Please use images of the same size.", "Image size error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "image3Browse":
                        if (CheckImageSize(new Bitmap(imageOpenFileDialog.FileName)))
                        {
                            image3TextBox.Text = imageOpenFileDialog.FileName;
                            imagesArray[2] = new Bitmap(imageOpenFileDialog.FileName);
                            image4Panel.Enabled = true;
                        }
                        else
                            MessageBox.Show("Images don't match in size. Please use images of the same size.", "Image size error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "image4Browse":
                        if (CheckImageSize(new Bitmap(imageOpenFileDialog.FileName)))
                        {
                            image4TextBox.Text = imageOpenFileDialog.FileName;
                            imagesArray[3] = new Bitmap(imageOpenFileDialog.FileName);
                        }
                        else
                            MessageBox.Show("Images don't match in size. Please use images of the same size.", "Image size error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                previewButton.Enabled = CheckImageArray();
            }
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            CompareAllPixels();
            saveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (resultImage != null)
            {
                if (imageSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (imageSaveFileDialog.FilterIndex)
                    {
                        case 1:
                            resultImage.Save(imageSaveFileDialog.FileName, ImageFormat.Png);
                            break;
                        case 2:
                            resultImage.Save(imageSaveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                    }
                }
            }
            else
                MessageBox.Show("There is no image to save.", "No image to save!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Drag Preview Image Controls
        private void PreviewImagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (previewImagePictureBox.Image == null || previewImagePictureBox.Width <= previewImagePanel.Width || previewImagePictureBox.Height <= previewImagePanel.Height) return;

            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
                Cursor.Current = Cursors.SizeAll;
            }
        }

        private void PreviewImagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
            Cursor.Current = Cursors.Default;
        }

        private void PreviewImagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            if (Dragging && c != null)
            {
                c.Top = Clamp(e.Y + c.Top - yPos, previewImagePanel.Height - previewImagePictureBox.Height, 0);
                c.Left = Clamp(e.X + c.Left - xPos, previewImagePanel.Width - previewImagePictureBox.Width, 0);
            }
        }
        #endregion

        #region Helpers
        private bool CheckImageArray()
        {
            int count = 0;

            for (int i = 0; i < imagesArray.Length; i++)
                if (imagesArray[i] != null)
                    count++;

            return count >= 2;
        }

        private bool CheckImageSize(Bitmap img)
        {
            return img.Width == resultImageWidth && img.Height == resultImageHeight;
        }

        private void GetImageSizeOnSetImage(Bitmap img)
        {
            resultImageWidth = img.Width;
            resultImageHeight = img.Height;
        }

        private int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
        #endregion
    }
}