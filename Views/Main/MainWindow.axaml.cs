using Avalonia.Controls;
using CatApp.Controllers;

namespace CatApp.Views.Main;

public partial class MainWindow : Window
{
    private readonly MainController _ctrl;
    public MainWindow()
    {
        InitializeComponent();
        _ctrl = new(this);
    }
}