using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _filename = @"C:\Users\MarkJPesimo\Downloads\Lifetime Member.jpg";
                FileInfo file = new FileInfo(_filename);
                Bitmap img = new Bitmap(_filename);

                var imageHeight = img.Height;
                var imageWidth = img.Width;

                image_height.Text = imageHeight.ToString();
                image_width.Text = imageWidth.ToString();


                var photo = new Bitmap(_filename);
                var _bitmap = new Bitmap(_filename);

                using (var graphics = Graphics.FromImage(_bitmap))
                {
                    // specify the desired quality of the render and text, if you wish
                    //graphics.CompositingQuality = CompositingQuality.HighQuality;
                    //graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                    // set background color
                    graphics.Clear(Color.White);
                    // place photo on image in desired location
                    graphics.DrawImageUnscaled(photo, 0, 0);
                    
                    //alumni name
                    using (var font = new Font(txtFontStyle.Text, int.Parse(txtalumni_name_font_size.Text)))
                    {
                        // draw some text on image
                        StringFormat _sf = new StringFormat();
                        _sf.LineAlignment = StringAlignment.Center;

                        int _alumni_x = int.Parse(txtalumni_name_x_loc.Text);
                        int _alumni_y = int.Parse(txtalumni_name_y_loc.Text);

                        graphics.DrawString(txtalumni_name.Text, font, Brushes.Black, _alumni_x, _alumni_y,  _sf);
                        
                        //graphics.DrawString("Age: 19", font, Brushes.Black, 0, 230);
                        // etc
                    }

                    //cOURSE
                    using (var font = new Font(txtFontStyle.Text, int.Parse(txtalumni_name_font_size.Text)))
                    {
                        // draw some text on image
                        StringFormat _sf = new StringFormat();
                        _sf.LineAlignment = StringAlignment.Center;

                        int _alumni_x = int.Parse(txtalumni_name_x_loc.Text);
                        int _alumni_y = int.Parse(txtalumni_name_y_loc.Text);

                        graphics.DrawString(txtalumni_name.Text, font, Brushes.Black, _alumni_x, _alumni_y, _sf);

                        //graphics.DrawString("Age: 19", font, Brushes.Black, 0, 230);
                        // etc
                    }

                    //alumni number
                    using (var font = new Font(txtFontStyle.Text, int.Parse(txt_alumni_font_size.Text)))
                    {
                        // draw some text on image
                        
                        
                        int _alumni_x = int.Parse(alumni_x_loc.Text);
                        int _alumni_y= int.Parse( alumni_y_loc.Text);
                        graphics.DrawString(txtalumni_no.Text, font, Brushes.Black, _alumni_x, _alumni_y);
                        //graphics.DrawString("Age: 19", font, Brushes.Black, 0, 230);
                        // etc
                    }
                }

                // save image to file or stream
                _bitmap.Save("Image " + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-") + ".png", ImageFormat.Png);
                MessageBox.Show("Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtalumni_name_y_loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Bitmap _bmp = new Bitmap(panel3.Width, panel3.Height);
                Bitmap _bmp = new Bitmap(int.Parse( txtbmp_width.Text), int.Parse( txtbmp_height.Text));
                Rectangle _rec = new Rectangle();
                _rec.Height = int.Parse(txtbmp_height.Text);
                _rec.Width = int.Parse(txtbmp_width.Text);

                panCard.DrawToBitmap(_bmp, _rec);
                _bmp.Save(@"C:\Users\MarkJPesimo\Downloads\" + "bmp " + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-") + ".png");

                MessageBox.Show("complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = DrawControlToBitmap(panel3);
            //pictureBox1.Image = bitmap;
        }

        private static Bitmap DrawControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }
       
    }
}
