namespace FacebookApp
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class SnippingTool : Form
    {
        private Rectangle m_Rectangle;
        private Point m_StartingPoing;
        private Point m_EndingPoint;
        private bool m_IsMouseDown = false;

        public SnippingTool(string i_PhotoToCropAndSave)
        {
            InitializeComponent();
            picFromFacebook.LoadAsync(i_PhotoToCropAndSave);
        }

        private void picFromFacebook_MouseDown(object sender, MouseEventArgs e)
        {
            m_IsMouseDown = true;

            m_StartingPoing = e.Location;
        }

        private void picFromFacebook_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_IsMouseDown == true)
            {
                m_EndingPoint = e.Location;

                Refresh();
            }
        }

        private void picFromFacebook_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_IsMouseDown == true)
            {
                m_EndingPoint = e.Location;

                m_IsMouseDown = false;

                if (m_Rectangle != null)
                {
                    Bitmap bit = new Bitmap(picFromFacebook.Image, picFromFacebook.Width, picFromFacebook.Height);
                    Bitmap cropImg = new Bitmap(m_Rectangle.Width, m_Rectangle.Height);
                    Graphics g = Graphics.FromImage(cropImg);
                    g.DrawImage(bit, 0, 0, m_Rectangle, GraphicsUnit.Pixel);
                    picTargetImg.Image = cropImg;
                }
            }
        }

        private void picFromFacebook_Paint(object sender, PaintEventArgs e)
        {
            if (m_Rectangle != null)
            {
                e.Graphics.DrawRectangle(Pens.Blue, getRectangle());
            }
        }

        private Rectangle getRectangle()
        {
            m_Rectangle = new Rectangle();

            m_Rectangle.X = Math.Min(m_StartingPoing.X, m_EndingPoint.X);
            m_Rectangle.Y = Math.Min(m_StartingPoing.Y, m_EndingPoint.Y);
            m_Rectangle.Width = Math.Abs(m_StartingPoing.X - m_EndingPoint.X);
            m_Rectangle.Height = Math.Abs(m_StartingPoing.Y - m_EndingPoint.Y);

            return m_Rectangle;
        }

        private void buttonSaveToPC_Click(object sender, EventArgs e)
        {
            if (picTargetImg.Image != null)
            {
                SaveFileDialog saveImg = new SaveFileDialog();
                saveImg.Filter = "Image Files(*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif";

                if (saveImg.ShowDialog() == DialogResult.OK)
                {
                    if (saveImg.FileName.EndsWith(".jpg"))
                    {
                        picTargetImg.Image.Save(saveImg.FileName, ImageFormat.Jpeg);
                    }
                    else if (saveImg.FileName.EndsWith(".bmp"))
                    {
                        picTargetImg.Image.Save(saveImg.FileName, ImageFormat.Bmp);
                    }
                    else if (saveImg.FileName.EndsWith(".gif"))
                    {
                        picTargetImg.Image.Save(saveImg.FileName, ImageFormat.Gif);
                    }

                    MessageBox.Show("Picture saved successfully!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No Image to save...");
            }
        }

        private void picFromFacebook_Click(object sender, EventArgs e)
        {
        }
    }
}