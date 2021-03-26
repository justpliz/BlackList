using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackList.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "extremecode_bot";

        public static string Key { get; set; } = "1691907950:AAF0CaE4D9QSNzVlH-TBXhdtmsJGIZ36cSM";
    }
}