using System.Windows.Forms;

namespace colorCorrection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic = new PictureBox();
            BtnSave = new Button();
            ImageLocation = new Label();
            label3 = new Label();
            paletteLocation = new Label();
            label5 = new Label();
            BtnImage = new Button();
            BtnPalette = new Button();
            palatepic = new PictureBox();
            BtnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palatepic).BeginInit();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.ImageLocation = "";
            pic.Location = new Point(27, 124);
            pic.Name = "pic";
            pic.Size = new Size(798, 367);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Click += pictureBox1_Click;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSave.Location = new Point(842, 511);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 34);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += Save_Click;
            // 
            // ImageLocation
            // 
            ImageLocation.AutoSize = true;
            ImageLocation.Location = new Point(98, 26);
            ImageLocation.Name = "ImageLocation";
            ImageLocation.Size = new Size(0, 25);
            ImageLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 26);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "image:";
            // 
            // paletteLocation
            // 
            paletteLocation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            paletteLocation.AutoSize = true;
            paletteLocation.Location = new Point(626, 26);
            paletteLocation.Name = "paletteLocation";
            paletteLocation.Size = new Size(0, 25);
            paletteLocation.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(511, 26);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 6;
            label5.Text = "color palette:";
            // 
            // BtnImage
            // 
            BtnImage.Location = new Point(27, 70);
            BtnImage.Name = "BtnImage";
            BtnImage.Size = new Size(112, 34);
            BtnImage.TabIndex = 8;
            BtnImage.Text = "upload";
            BtnImage.UseVisualStyleBackColor = true;
            BtnImage.Click += GetImage;
            // 
            // BtnPalette
            // 
            BtnPalette.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPalette.Location = new Point(511, 70);
            BtnPalette.Name = "BtnPalette";
            BtnPalette.Size = new Size(112, 34);
            BtnPalette.TabIndex = 9;
            BtnPalette.Text = "upload";
            BtnPalette.UseVisualStyleBackColor = true;
            BtnPalette.Click += GetPalette;
            // 
            // palatepic
            // 
            palatepic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            palatepic.Location = new Point(27, 501);
            palatepic.Name = "palatepic";
            palatepic.Size = new Size(798, 61);
            palatepic.TabIndex = 10;
            palatepic.TabStop = false;
            palatepic.Click += pictureBox1_Click;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClear.Location = new Point(842, 457);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(112, 34);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 574);
            Controls.Add(BtnClear);
            Controls.Add(palatepic);
            Controls.Add(BtnPalette);
            Controls.Add(BtnImage);
            Controls.Add(paletteLocation);
            Controls.Add(label5);
            Controls.Add(ImageLocation);
            Controls.Add(label3);
            Controls.Add(BtnSave);
            Controls.Add(pic);
            MinimumSize = new Size(687, 483);
            Name = "Form1";
            Text = "ColorCorrection";
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)palatepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic;
        private Button BtnSave;
        private Label ImageLocation;
        private Label label3;
        private Label paletteLocation;
        private Label label5;
        private Button BtnImage;
        private Button BtnPalette;
        private PictureBox palatepic;
        private Button BtnClear;
    }
}
