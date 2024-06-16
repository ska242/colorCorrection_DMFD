using System.Drawing.Imaging;
using System.Windows.Forms;

namespace colorCorrection
{
    public partial class Form1 : Form
    {
        private Bitmap original;
        private Bitmap edited;
        private List<Color> paletteSet;
        private string path;
        private int pWidth;
        private int pHeight;
        public Form1()
        {
            InitializeComponent();
        }

        static List<Color> GetUniqueColors(string location)
        {
            List<Color> uniqueColor = new List<Color>();

            using (Bitmap bmp = new Bitmap(location))
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        uniqueColor.Add(pixelColor);
                    }
                }
            }


            return uniqueColor;
        }
        private void GetPalette(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    paletteLocation.Text = dialog.FileName;

                    paletteSet = new List<Color>();
                    paletteSet = GetUniqueColors(paletteLocation.Text);
                    

                    Bitmap originalBitmap = new Bitmap(paletteLocation.Text);
                    pWidth = originalBitmap.Width;
                    pHeight = originalBitmap.Height;
                    Bitmap resizedBitmap = ResizeBitmap(originalBitmap, palatepic.Width, palatepic.Height);
                    palatepic.Image = resizedBitmap;
                    UpdateImage();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Bitmap ResizeBitmap(Bitmap originalBitmap, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(originalBitmap, 0, 0, width, height);
            }
            return resizedBitmap;
        }


        private void GetImage(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = Path.GetDirectoryName(dialog.FileName);
                    ImageLocation.Text = dialog.FileName;
                    original = new Bitmap(ImageLocation.Text);

                    UpdateImage();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (edited != null)
            {
                try
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "PNG files(*.png)|*.png| All Files(*.*)|*.*";
                    dialog.FileName = Path.GetFileName(ImageLocation.Text);

                    string fileName = Path.Combine(path, dialog.FileName);
                    if (File.Exists(fileName))
                    {
                        string directory = Path.GetDirectoryName(fileName);
                        string originalFileName = Path.GetFileNameWithoutExtension(fileName);
                        string extension = Path.GetExtension(fileName);

                        int count = 1;
                        string newFileName = Path.Combine(directory, originalFileName + "_" + count + extension);

                        while (File.Exists(newFileName))
                        {
                            count++;
                            newFileName = Path.Combine(directory, originalFileName + "_" + count + extension);
                        }

                        dialog.FileName = Path.GetFileNameWithoutExtension(newFileName);
                    }
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        edited.Save(dialog.FileName, ImageFormat.Png);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UpdateImage()
        {

            if (!string.IsNullOrEmpty(ImageLocation.Text))
            {
                try
                {

                    edited = new Bitmap(original.Width, original.Height);
                    if (!string.IsNullOrEmpty(paletteLocation.Text))
                    {
                        for (int y = 0; y < original.Height; y++)
                        {
                            for (int x = 0; x < original.Width; x++)
                            {
                                Color originalColor = original.GetPixel(x, y);
                                if (originalColor.B > 0) 
                                {
                                    edited.SetPixel(x, y, originalColor);
                                    continue;
                                }
                                int index = originalColor.R + originalColor.G *pHeight; 
                                Color newColor = paletteSet[index];
                                edited.SetPixel(x, y, newColor);
                            }

                        }
                    }
                    else
                    {
                        edited = original;
                    }
                    pic.Image = edited;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (sender is PictureBox pic)
            {
                pic.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void OnlyRed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            paletteSet = new List<Color>();
            original = null;
            edited = null;
            pic.Image = null;
            palatepic.Image = null;
            ImageLocation.Text = "";
            paletteLocation.Text = "";

        }
    }
}
