using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WcfService2
{
    public class gallery
    {
        private int imagecode;

        public int Imagecode
        {
            get { return imagecode; }
            set { imagecode = value; }
        }


        private string imgCategory;

        public string ImgCategory
        {
            get { return imgCategory; }
            set { imgCategory = value; }
        }

       
        private Image img;

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}