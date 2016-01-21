using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace LogoPlacer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbIconPosition.Items.Add(Position.Center);
            cbIconPosition.Items.Add(Position.TopLeft);
            cbIconPosition.Items.Add(Position.TopRight);
            cbIconPosition.Items.Add(Position.BottomLeft);
            cbIconPosition.Items.Add(Position.BottomRight);
            cbIconPosition.Items.Add(Position.TopCenter);
            cbIconPosition.Items.Add(Position.RightCenter);
            cbIconPosition.Items.Add(Position.BottomCenter);
            cbIconPosition.Items.Add(Position.LeftCenter);
            cbIconPosition.Items.Add(Position.LeftBar);
            cbIconPosition.Items.Add(Position.RightBar);
            cbIconPosition.Items.Add(Position.TopBar);
            cbIconPosition.Items.Add(Position.BottomBar);
        }

        private void InsetImage(string imageUrl, string pdfUrl, string outPutUrl, Position position)
        {
            using (Stream inputPdfStream = new FileStream(pdfUrl, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(imageUrl, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(outPutUrl, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new PdfReader(inputPdfStream);
                var stamper = new PdfStamper(reader, outputPdfStream);
                int pagenum = reader.NumberOfPages;
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);

                float oldHeight= image.ScaledHeight, oldWidth= image.ScaledHeight;
                if (txtimgH.Text != "0")
                {
                    if (txtimgH.Text == "-1")
                    {
                        float ratio = float.Parse(txtimgW.Text) / oldWidth;
                        image.ScaleAbsoluteHeight(image.ScaledHeight * ratio);
                    }
                    else
                        image.ScaleAbsoluteHeight(float.Parse(txtimgH.Text));
                }
                if (txtimgW.Text != "0")
                {
                    if (txtimgW.Text == "-1")
                    {
                        float ratio = float.Parse(txtimgH.Text) / oldHeight;
                        image.ScaleAbsoluteWidth(image.ScaledWidth * ratio);
                    }
                    else
                        image.ScaleAbsoluteWidth(float.Parse(txtimgW.Text));
                }

                for (int i = 1; i <= pagenum; i++)
                {
                    var pdfContentByte = stamper.GetOverContent(i);
                    iTextSharp.text.Rectangle rect = reader.GetPageSize(i);
                    


                    switch (position)
                    {
                        case Position.TopLeft:
                            image.SetAbsolutePosition(mleft, rect.Height - image.ScaledHeight-mtop);
                            break;
                        case Position.TopRight:
                            image.SetAbsolutePosition(rect.Width-mright-image.ScaledWidth, rect.Height - image.ScaledHeight-mtop);
                            break;
                        case Position.BottomLeft:
                            image.SetAbsolutePosition(mleft, mbottom);
                            break;
                        case Position.BottomRight:
                            image.SetAbsolutePosition(rect.Width-mright-image.ScaledWidth, mbottom);
                            break;
                        case Position.Center:
                            image.SetAbsolutePosition(rect.Width/2 + mleft - image.ScaledWidth/2, rect.Height / 2 - mbottom - image.ScaledHeight / 2);
                            break;
                        case Position.LeftCenter:
                            image.SetAbsolutePosition(mleft, rect.Height / 2 - image.ScaledHeight / 2);
                            break;
                        case Position.RightCenter:
                            image.SetAbsolutePosition(rect.Width - mright - image.ScaledWidth, rect.Height / 2 - image.ScaledHeight / 2);
                            break;
                        case Position.TopCenter:
                            image.SetAbsolutePosition(rect.Width / 2 - (image.ScaledWidth / 2)+mleft, rect.Height - image.ScaledHeight - mtop);
                            break;
                        case Position.BottomCenter:
                            image.SetAbsolutePosition(rect.Width / 2 - (image.ScaledWidth / 2)+mleft, mbottom);
                            break;
                        case Position.TopBar:
                            image.ScaleAbsoluteWidth(rect.Width);
                            image.SetAbsolutePosition(0, rect.Height - image.ScaledHeight - mtop);
                            break;
                        case Position.BottomBar:
                            image.ScaleAbsoluteWidth(rect.Width);
                            image.SetAbsolutePosition(0, mbottom);
                            break;
                        case Position.LeftBar:
                            image.ScaleAbsoluteHeight(rect.Height);
                            image.SetAbsolutePosition(mleft, rect.Height - image.ScaledHeight);
                            break;
                        case Position.RightBar:
                            image.ScaleAbsoluteHeight(rect.Height);
                            image.SetAbsolutePosition(rect.Width-image.ScaledWidth-mright, 0);
                            break;
                        default:
                            break;
                    }


                    pdfContentByte.AddImage(image);
                }

                stamper.Close();
            }
        }

        public enum Position
        {
            TopRight,TopLeft,BottomRight,BottomLeft,Center,TopCenter,RightCenter,BottomCenter,LeftCenter,
            TopBar,LeftBar,RightBar,BottomBar
        }
        int mleft, mright, mtop, mbottom;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPdfFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnBrowseSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSaveAddr.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtImageAddress.Text = openFileDialog1.FileName;
        }

        private void btnStamp_Click(object sender, EventArgs e)
        {
            mleft = int.Parse(txtLeft.Text);
            mright = int.Parse(txtRight.Text);
            mtop = int.Parse(txtTop.Text);
            mbottom = int.Parse(txtBottom.Text);
            FileInfo[] Files = new DirectoryInfo(txtPdfFolder.Text).GetFiles();

            foreach (var item in Files)
            {
                if (item.Extension.Contains("pdf"))
                    InsetImage(txtImageAddress.Text, item.FullName, Path.Combine(txtSaveAddr.Text , item.Name.Substring(0, item.Name.LastIndexOf(".")) + ".pdf"), (Position)cbIconPosition.SelectedItem);
            }
            MessageBox.Show("Stamping Completed!");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
