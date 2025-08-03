using System.Collections.Specialized;

using WinFormedge;

namespace MinimalExampleApp;

internal class MyFormedgeApp : AppStartup
{
    protected internal override AppCreationAction? OnApplicationStartup(StartupSettings options)
    {
        var t = new StartupWindow();
        t.ShowDialog();
        return options.UseMainWindow(new MainWindow());
    }

    protected internal override void ConfigureAdditionalBrowserArgs(NameValueCollection additionalBrowserArgs)
    {
        additionalBrowserArgs.Add("autoplay-policy", "no-user-gesture-required");
        base.ConfigureAdditionalBrowserArgs(additionalBrowserArgs);
    }
}