using Microsoft.AspNetCore.Mvc;

namespace DoAnNam3.Utilities
{
    public class Function : Controller
    {
        public static string TitleSlugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}
