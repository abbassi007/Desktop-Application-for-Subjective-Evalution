using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace PC_Test
{
    public partial class Form1 : Form
    {

        private Point startingPoint =new Point();
        private Point movingPoint = new Point();
        //private bool panning = false;

        Image imgOriginal_one, imgOriginal_two;
        Size originalSize;
        private List<Image> loadedImages1 = new List<Image>();
        private List<Image> loadedImages2 = new List<Image>();
        private int currentImageIndex = 0;
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

        string leftTMO_Name;
        string rightTMO_Name;
        string parentFolder;
        string comFolder;
        string tmoFolderA;
        string tmoFolderB;
        string tmoA_Name;
        string tmoB_Name;
        int combFolderIndex = 2;
        bool eltm = false;
        bool tmo = false;
        bool firstWriteResult = false;
        
        int eltmcnt = 0;
        int tmcnt = 0;
        int Nxtcnt = 0;
        int imgcnt = 0;
        int a;
        private double ZOOMFACTOR = 1.25;   // = 25% smaller or larger
        private int MINMAX = 15;             // 5 times bigger or smaller than the ctrl

        RadioButton RadioRight = new RadioButton();
        RadioButton RadioLeft = new RadioButton();
        public Form1()
        {

            InitializeComponent();
            MultiselectImage();
            LeftPanel.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            LeftPanel.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            RightPanel.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            RightPanel.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            LeftPanel.MouseWheel += new MouseEventHandler(imagemPictureBox_MouseWheel);
            RightPanel.MouseWheel += new MouseEventHandler(imagemPictureBox_MouseWheel);
            EvaluationPanel.Visible = false;
            //EvaluateResult.Enabled = false;
            //a = loadedImages1.Count;
            textBox1.Visible = false;
            //textBox1.Text = a.ToString() + " Images Left";
        }

       private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //panning = true;
            startingPoint = new Point(e.X,e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //panning = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                int X = (startingPoint.X - e.X);
                int Y = (startingPoint.Y - e.Y);

                LeftPanel.AutoScrollPosition =
                   new Point((X - LeftPanel.AutoScrollPosition.X),
                   (Y - LeftPanel.AutoScrollPosition.Y));

                RightPanel.AutoScrollPosition =
                   new Point((X - RightPanel.AutoScrollPosition.X),
                   (Y - RightPanel.AutoScrollPosition.Y));
                //movingPoint = new Point(e.Location.X - startingPoint.X,
                //                        e.Location.Y - startingPoint.Y);
                //LeftImage.Invalidate();
            }
        }
        private void MultiselectImage()
        {
            // Set the file dialog to filter for graphics files. 
            this.OpenFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images. 
            this.OpenFileDialog1.Multiselect = true;
            this.OpenFileDialog1.Title = "My Image Browser";
        }

        private void OpenOtherTMO_Click(object sender, EventArgs e)
        {
            tmo = true;
            DialogResult dr = this.OpenFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                loadedImages2.Clear();

                // Read the files 
                foreach (String file in OpenFileDialog1.FileNames)
                {
                    // Create a PictureBox. 
                    loadedImages2.Add(Image.FromFile(file));
                }

                if (loadedImages2.Count > 0)
                {
                    currentImageIndex = 0;

                    RightImage.Image = loadedImages2[currentImageIndex];
                    imgOriginal_two = RightImage.Image;
                }
                eltmcnt = 0;
                tmcnt = 0;
                imgcnt = 0;
                Nxtcnt = 0;
                OpenOtherTMO.Enabled = false;
                
                Start.Enabled = true;

                a = loadedImages1.Count;
                textBox1.Text = a.ToString() + " Images Left";
            }

            rightTMO_Name = Path.GetFileName(Path.GetDirectoryName(OpenFileDialog1.FileName));
            firstWriteResult = true;


        }

        private void NextImage_Click(object sender, EventArgs e)
        {
            if (eltm && tmo)
            {
                //trackBar1.Value = 0;
                if (currentImageIndex < loadedImages1.Count - 1 && currentImageIndex < loadedImages2.Count - 1)
                {
                    currentImageIndex = currentImageIndex + 1;
                    RightImage.Image = loadedImages2[currentImageIndex];
                    imgOriginal_two = RightImage.Image;

                    LeftImage.Image = loadedImages1[currentImageIndex];
                    imgOriginal_one = LeftImage.Image;
                }
                else
                {
                    currentImageIndex = 0;
                    RightImage.Image = loadedImages2[currentImageIndex];
                    imgOriginal_two = RightImage.Image;

                    LeftImage.Image = loadedImages1[currentImageIndex];
                    imgOriginal_one = LeftImage.Image;
                }
            }
        }

        private void PreImage_Click(object sender, EventArgs e)
        {
            if (eltm && tmo)
            {
                //trackBar1.Value = 0;
                if (currentImageIndex > 0)
                {

                    currentImageIndex = currentImageIndex - 1;
                    RightImage.Image = loadedImages2[currentImageIndex];
                    imgOriginal_two = RightImage.Image;

                    LeftImage.Image = loadedImages1[currentImageIndex];
                    imgOriginal_one = LeftImage.Image;
                }
                else
                {
                    currentImageIndex = loadedImages1.Count - 1;
                    RightImage.Image = loadedImages2[currentImageIndex];
                    imgOriginal_two = RightImage.Image;

                    LeftImage.Image = loadedImages1[currentImageIndex];
                    imgOriginal_one = LeftImage.Image;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (eltm && tmo)
            {
                
                textBox1.Visible = true;

                    if (RaLeft.Checked)
                    {
                        RaLeft.Checked = false;

                    }
                    else if (RaRight.Checked)
                    {
                        RaRight.Checked = false;
                    }
                    EvaluationPanel.Visible = true;
                    Label lbl = new Label();
                    lbl.Font = new Font("Times New Romen", 10, FontStyle.Regular);
                    lbl.ForeColor = Color.Black;
                    lbl.Size = new Size(15, 15);
                    lbl.AutoSize = true;
                    lbl.Padding = new System.Windows.Forms.Padding(20, 8, 0, 0);
                    lbl.Text = "Which One Image is Better Quality?";



                    EvaluationPanel.Controls.Add(lbl);

            }
        }
     
        private void imagemPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            LeftPanel.AutoScrollPosition = new Point(0, 0);
            RightPanel.AutoScrollPosition = new Point(0, 0);

            //_picbox2.Image = _imOriginal;
            //_picbox2.SizeMode = PictureBoxSizeMode.StretchImage;
            if (e.Delta < 0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }

        }
        private void ZoomIn()
        {
            LeftImage.Location = new System.Drawing.Point(0, 0);
            RightImage.Location = new System.Drawing.Point(0, 0);
            if ((LeftImage.Width < (MINMAX * LeftPanel.Width)) && (LeftImage.Height < (MINMAX * LeftPanel.Height))  || (RightImage.Width < (MINMAX * RightPanel.Width)) && (RightImage.Height < (MINMAX * RightPanel.Height)))
            {
                LeftImage.Width = Convert.ToInt32(LeftImage.Width * ZOOMFACTOR);
                LeftImage.Height = Convert.ToInt32(LeftImage.Height * ZOOMFACTOR);
                LeftImage.SizeMode = PictureBoxSizeMode.StretchImage;

                RightImage.Width = Convert.ToInt32(RightImage.Width * ZOOMFACTOR);
                RightImage.Height = Convert.ToInt32(RightImage.Height * ZOOMFACTOR);
                RightImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //_txtinfor.Text = "zoom in: " + _picbox.Width.ToString() + "x" + _picbox.Height.ToString() + " \t top/left" + _picbox.Top.ToString() + "x" + _picbox.Left.ToString() + "\t";

            }
        }
        private void ZoomOut()
        {
            LeftImage.Location = new System.Drawing.Point(0, 0);
            RightImage.Location = new System.Drawing.Point(0, 0);

            if ((LeftImage.Width > (LeftPanel.Width / MINMAX)) && (LeftImage.Height > (LeftPanel.Height / MINMAX))  || (RightImage.Width > (RightPanel.Width / MINMAX)) && (RightImage.Height > (RightPanel.Height / MINMAX)))
            {
                LeftImage.SizeMode = PictureBoxSizeMode.StretchImage;
                LeftImage.Width = Convert.ToInt32(LeftImage.Width / ZOOMFACTOR);
                LeftImage.Height = Convert.ToInt32(LeftImage.Height / ZOOMFACTOR);

                RightImage.SizeMode = PictureBoxSizeMode.StretchImage;
                RightImage.Width = Convert.ToInt32(RightImage.Width / ZOOMFACTOR);
                RightImage.Height = Convert.ToInt32(RightImage.Height / ZOOMFACTOR);
                //_txtinfor.Text = "zoom out: " + _picbox.Width.ToString() + "x" + _picbox.Height.ToString() + " \t top/left" + _picbox.Top.ToString() + "x" + _picbox.Left.ToString() + "\t";

            }
        }


        Image ZoomInOut(Image img, Size size)
        {
            LeftImage.SizeMode = PictureBoxSizeMode.AutoSize;
            RightImage.SizeMode = PictureBoxSizeMode.AutoSize;
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics graph = Graphics.FromImage(bmp);
            graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void RaLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (currentImageIndex != loadedImages1.Count && currentImageIndex != loadedImages2.Count)
            {

            Left: if (RaLeft.Checked)
                {
                    string message = "Are you sure?";
                    string title = "Window";
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        a = a - 1;
                        textBox1.Text = a.ToString() + " Images Left";
                        Nxtcnt++;
                        //imgcnt++;
                        eltmcnt++;
                        EvaluationPanel.Visible = false;
   
                    }
                    else
                    {

                        eltmcnt = eltmcnt;
                        //imgcnt = imgcnt;
                        Nxtcnt = Nxtcnt;
                        //RadioLeft.Checked = false;
                        RaLeft.Checked = false;

                        goto Left;

                    }
                    LeftImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    RightImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    //trackBar1.Value = 0;
                    if (currentImageIndex < loadedImages1.Count - 1 && currentImageIndex < loadedImages2.Count - 1)
                    {
                        currentImageIndex = currentImageIndex + 1;
                        RightImage.Image = loadedImages2[currentImageIndex];
                        imgOriginal_two = RightImage.Image;

                        LeftImage.Image = loadedImages1[currentImageIndex];
                        imgOriginal_one = LeftImage.Image;
                        Nxtcnt = 0;
                        imgcnt++;
                    }
                    else
                    {

                        //string path = @"C:\Users\902\Desktop\PC TEST\Result.txt";
                        string rsltpath = Path.GetFullPath(Path.GetDirectoryName(Path.GetDirectoryName(OpenFileDialog1.FileName)));
                        string path = Path.Combine(rsltpath, "Result.txt");
                        //EvaluateResult.Enabled = true;

                        string msg = "Congratulation You Finish Your Evaluation! Thank You";
                        string ti = "Window";
                        MessageBoxButtons btn = MessageBoxButtons.OK;
                        DialogResult rslt = MessageBox.Show(msg, ti, btn, MessageBoxIcon.Information);
                        if (rslt == DialogResult.OK)
                        {
          


                            //Write Result after evaluation of each combination 
                            if (firstWriteResult)
                            {
                                if (!File.Exists(path))
                                {

                                    System.IO.StreamWriter tw = new System.IO.StreamWriter(path, true); //writing txt file

                                    tw.WriteLine(eltmcnt + ":Images are Selected that " + leftTMO_Name + " is in good quality & \t" + tmcnt + ":Images are selected That " + rightTMO_Name + " is in good Quality");
                                    tw.Close();


                                }
                                else if (File.Exists(path))
                                {
                                    System.IO.StreamWriter tw = new System.IO.StreamWriter(path, true);

                                    tw.WriteLine(eltmcnt + ":Images are Selected that " + leftTMO_Name + " is in good quality & \t" + tmcnt + ":Images are selected That " + rightTMO_Name + " is in good Quality");
                                    tw.Close();
                                }

                                Dispose();
                            }

                        }

   

                    }
                }
            }
            else
            {
                
            }

         }

        private void RaRight_CheckedChanged(object sender, EventArgs e)
        {

            if (currentImageIndex != loadedImages1.Count  && currentImageIndex != loadedImages2.Count )
            {
            Right: if (RaRight.Checked)
                {
                    string message = "Are you sure?";
                    string title = "Window";
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        a = a - 1;
                        textBox1.Text = a.ToString() + " Images Left";
                        Nxtcnt++;
                        //imgcnt++;
                        tmcnt++;
                        EvaluationPanel.Visible = false;

                    }
                    else
                    {
                        tmcnt = tmcnt;
                        //imgcnt = imgcnt;
                        Nxtcnt = Nxtcnt;
                        RaRight.Checked = false;
                        goto Right;
                    
                    }

                    LeftImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    RightImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    //trackBar1.Value = 0;
                    if (currentImageIndex < loadedImages1.Count - 1 && currentImageIndex < loadedImages2.Count - 1)
                    {
                        currentImageIndex = currentImageIndex + 1;
                        RightImage.Image = loadedImages2[currentImageIndex];
                        imgOriginal_two = RightImage.Image;

                        LeftImage.Image = loadedImages1[currentImageIndex];
                        imgOriginal_one = LeftImage.Image;

                        Nxtcnt = 0;
                        imgcnt++;
                    }

                    else
                    {
                       
                        string rsltpath = Path.GetFullPath(Path.GetDirectoryName(Path.GetDirectoryName(OpenFileDialog1.FileName)));
                        string path = Path.Combine(rsltpath, "Result.txt");
                        

                        string msg = "Congratulation You Finish Your Evaluation! Thank You";
                        string ti = "Result Window";
                        MessageBoxButtons btn = MessageBoxButtons.OK;
                        DialogResult rslt = MessageBox.Show(msg, ti, btn, MessageBoxIcon.Information);
                        if (rslt == DialogResult.OK)
                        {

                            if (firstWriteResult)
                            {
                                if (!File.Exists(path))
                                {

                                    System.IO.StreamWriter tw = new System.IO.StreamWriter(path, true); //writing txt file

                                    tw.WriteLine(eltmcnt + ":Images are Selected that " + leftTMO_Name + " is in good quality & \t" + tmcnt + ":Images are selected That " + rightTMO_Name + " is in good Quality");
                                    tw.Close();


                                }
                                else if (File.Exists(path))
                                {
                                    System.IO.StreamWriter tw = new System.IO.StreamWriter(path, true);

                                    tw.WriteLine(eltmcnt + ":Images are Selected that " + leftTMO_Name + " is in good quality & \t" + tmcnt + ":Images are selected That " + rightTMO_Name + " is in good Quality");
                                    tw.Close();
                                }

                                Dispose();
                            }

                            tmcnt = 0;
                            eltmcnt = 0;
                            combFolderIndex++;
                            imgcnt = 0;
                            firstWriteResult = false;
                          

                        }
                        else
                        {

                        }


                    }
                }
            }
            else
            {
                //EvaluateResult.Enabled = true;
            }


        }

        private void EvaluationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftImage_Click(object sender, EventArgs e)
        {

        }

        private void OpenELTM_Click(object sender, EventArgs e)
        {
            eltm = true;
            DialogResult dr = this.OpenFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                loadedImages1.Clear();

                // Read the files 
                foreach (String file in OpenFileDialog1.FileNames)
                {
                    // Create a PictureBox. 
                    loadedImages1.Add(Image.FromFile(file));
  
                }
             
                if (loadedImages1.Count > 0)
                {
                    currentImageIndex = 0;
                    LeftImage.Image = loadedImages1[currentImageIndex];
                    imgOriginal_one = LeftImage.Image;
                }
                eltmcnt = 0;
                tmcnt = 0;
                imgcnt = 0;
                Nxtcnt = 0;
                OpenELTM.Enabled = false;
                Start.Enabled = true;
            }
            //leftTMO_Name = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName);
            
            leftTMO_Name = Path.GetFileName(Path.GetDirectoryName(OpenFileDialog1.FileName));
            firstWriteResult = true;
            //string name = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName);
            //string name = Path.GetFullPath(Path.GetDirectoryName(Path.GetDirectoryName(OpenFileDialog1.FileName)));
            //string path = Path.Combine(name, "Result.txt");
            //string ti = "Result Window";
            //MessageBoxButtons btn = MessageBoxButtons.OK;
            //MessageBox.Show(path, ti, btn, MessageBoxIcon.Question);


        }
    }
}
