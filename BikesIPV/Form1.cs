﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu;


namespace BikesIPV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BikeIPV bIPV= new BikeIPV();

            // Dummy data
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(BikesIPV.Properties.Resources.bike_white1);//.Resize(500, 400, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, true );
            Image<Gray, Byte> imageReady = bIPV.init(image, imageBox1);
            imageBox1.Image = imageReady;

            
          //  this.Width = bIPV.Width;
            imageBox1.Width = bIPV.Width;
          //  this.Height = bIPV.Height;
            imageBox1.Height = bIPV.Height;
           // this.Width = bIPV.Width;
            imageBox2.Width = bIPV.Width;
           // this.Height = bIPV.Height;
            imageBox2.Height = bIPV.Height;
            
            
           



            imageBox1.Image = bIPV.findWheels(imageReady);
            imageBox2.Image = imageReady;


           // Image<Bgr, Byte> imageTest1 = new Image<Bgr, Byte>(BikesIPV.Properties.Resources.Test_With);
           // Image<Bgr, Byte> imageTest2 = new Image<Bgr, Byte>(BikesIPV.Properties.Resources.Test_Without);
           // Image<Bgr, Byte> processed;
           // Image<Gray, Byte> grayProcessed;
          //  processed = bIPV.FindDifference(imageTest1, imageTest2);
          //  grayProcessed = processed.Convert<Gray, Byte>();

           // imageBox2.Image = processed;
         //   imageBox1.Image = bIPV.findWheels(grayProcessed);
            





        }








        }

    }

