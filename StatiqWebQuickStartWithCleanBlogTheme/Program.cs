using System;
using System.Threading.Tasks;
using Devlead.Statiq.Themes;
using Statiq.App;
using Statiq.Web;

namespace StatiqWebQuickStartWithCleanBlogTheme
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
          await Bootstrapper
            .Factory
            .CreateDefault(args)
            .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/archive/71b37ce47fd5b47dbc993e7591ef8cda6c930e44.zip"))
            .AddWeb()
            .RunAsync();
    }
}
