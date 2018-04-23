using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WcfService2
{
    public class gallery
    {
        private int Imagecode;

        public int Imagecode1
        {
            get { return Imagecode; }
            set { Imagecode = value; }
        }
        private string ImgCategory;

        public string ImgCategory1
        {
            get { return ImgCategory; }
            set { ImgCategory = value; }
        }
        private Image img;

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}