using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WcfService2
{
    public class Gallerydl
    {
        public static List<gallery> users = new List<gallery>();
        void DellImg(int code);
        void AddImg(Image img);
    }
}