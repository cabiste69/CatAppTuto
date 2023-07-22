using System;
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
        ConfigureSideBar();
    }

    /// <summary>
    /// subscribes the link buttons to the OpenLink function
    /// </summary>
    private void ConfigureMainHeader()
    {
        _view.GithubButton.Click += OpenLink;
        _view.AboutButton.Click += OpenLink;
    }

    /// <summary>
    /// subscribes all the side bar buttons to the ChangeView function
    /// </summary>
    private void ConfigureSideBar()
    {
        // look through all the children of the sidebar
        foreach (var child in _view.SideBar.Children)
        {
            // we only need buttons
            if (child is Button)
                // cast the variable to a button to get intelliSense
                ((Button)child).Click += ChangeView;
        }
    }

    /// <summary>
    /// Changes the content of the main area
    /// </summary>
    private void ChangeView(object? sender, RoutedEventArgs e)
    {
        // get the tag of the button
        string ViewName = ((Button)sender).Tag.ToString();

        // we'll add the logic to switch views after we create them
        switch (ViewName)
        {
            case "Home":
                Console.WriteLine("Clicked on the 'home' button.");
                break;

            case "Counter":
                Console.WriteLine("Clicked on the 'counter' button.");
                break;

            case "FetchData":
                Console.WriteLine("Clicked on the 'fetch data' button.");
                break;

            default:
                Console.WriteLine($"The view {ViewName} does not exist!");
                break;
        }
    }

    /// <summary>
    /// opens a link in the default browser
    /// </summary>
    private void OpenLink(object? sender, RoutedEventArgs e)
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