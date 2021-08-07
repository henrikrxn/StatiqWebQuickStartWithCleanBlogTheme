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
            .AddThemeFromUri(new Uri("https://github.com/henrikrxn/CleanBlog/archive/0826d56e1a335aada3a8382b9a1098275f76e34f.zip"))
            .AddWeb()
            .RunAsync();
    }
}
