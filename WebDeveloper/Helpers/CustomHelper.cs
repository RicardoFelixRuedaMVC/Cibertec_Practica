using System;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {

        private static string Resultphoto(byte[] photo)
        {
            return photo == null ? "<span>not photo!!!</span>" : $"<span>{photo}</span>";
        }
        public static IHtmlString DisplayPhotoStatic(byte[] photo)
        {
            return new HtmlString(Resultphoto(photo));
        }
        public static IHtmlString DisplayPhotoExtension(this HtmlHelper helper, byte[] photo)
        {
            return new HtmlString(Resultphoto(photo));
        }

    }
}
