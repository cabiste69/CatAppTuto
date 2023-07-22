using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CatApp.Views.Main;

namespace CatApp.Controllers;

class MainController
{
    // get a reference to the main view
    private readonly MainWindow _view;

    public MainController(MainWindow view)
    {
        _view = view;
        ConfigureMainHeader();
    }

    // subscribe to the OpenLink function on click
    private void ConfigureMainHeader()
    {
        _view.GithubButton.Click += OpenLink;
        _view.AboutButton.Click += OpenLink;
    }

    // opens a link in the default browser
    public void OpenLink(object? sender, RoutedEventArgs e)
    {
        // cast the sender to a button and get the Tag as a string
        string url = ((Button)sender).Tag.ToString();

        // Define a process with the url as the file name
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        };

        // start a process with the defined info
        Process.Start(startInfo);
    }
}