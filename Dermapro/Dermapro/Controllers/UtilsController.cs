using System.Text.RegularExpressions;

namespace Dermapro.Controllers
{
    internal class UtilsController:MiddleController
    {
        public static string StripHtml(string text)
        {
            if (!string.IsNullOrEmpty(text))
                return Regex.Replace(text, "<.*?>", string.Empty);
            else return text;
        }

        public static string ReplaceSpecialChar(string title)
        {
            title = title.Replace("<br>", "-").Replace("<br/>", "-").Replace("<br />", "-");
            title = StripHtml(title);
            title = (title + "").Trim().ToLower();
            if (!string.IsNullOrEmpty(title))
            {
                title = title.Replace("’", "-");
                title = title.Replace("'", "-");
                title = title.Replace(",", "-");
                title = title.Replace(":", "-");
                title = title.Replace("/", "-");
                title = title.Replace(".", "-");
                title = title.Replace("_", "-");
                title = title.Replace("?", "-");
                title = title.Replace("»", "");
                title = title.Replace("«", "");
                title = title.Replace("\"", "");
                title = title.Replace("\\", "");
                title = title.Replace("|", "");
                title = title.Replace(" ", "-");
                title = title.Replace("?", " ");
                title = title.Replace("%", "-");
                title = title.Replace("؟", "");
                title = title.Replace("<", "");
                title = title.Replace(">", "");
                title = title.Replace("&", "");
                title = title.Replace(":", "");
                title = title.Replace(" ", "-");
                title = title.Replace("%20", "-");
                title = title.Replace("----", "-");
                title = title.Replace("---", "-");
                title = title.Replace("--", "-");
                title = title.Trim();
                return title;
            }
            else
                return "";
        }
    }
}