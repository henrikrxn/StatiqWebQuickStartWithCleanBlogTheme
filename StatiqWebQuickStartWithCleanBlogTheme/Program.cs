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
            .AddThemeFromUri(new Uri("https://github.com/henrikrxn/CleanBlog/archive/6f00bf6d97dd8b4ead412da44880545d5df6ca75.zip"))
            .AddWeb()
            .RunAsync();
    }
}
