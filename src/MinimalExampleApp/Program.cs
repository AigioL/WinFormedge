﻿using System.Runtime.InteropServices;

using WinFormedge;

namespace MinimalExampleApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    internal static void Main(string[] args)
    {

        ApplicationConfiguration.Initialize();

        var app = WinFormedgeApp.CreateAppBuilder()
            .UseCulture(Application.CurrentCulture.Name)
            .UseDevTools()
            .UseModernStyleScrollbar()
            .UseWinFormedgeApp<MyFormedgeApp>()
            .Build();

        app.Run();
    }
}
