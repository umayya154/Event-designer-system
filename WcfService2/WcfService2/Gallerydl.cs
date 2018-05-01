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
       //void DellImg(int code);
       public void AddImg(string cata, int code, Image img)
       {
           gallery g = new gallery();
           g.Imagecode = code;
           g.ImgCategory = cata;
           g.Img = img;
           users.Add(g);
       }
    }
}