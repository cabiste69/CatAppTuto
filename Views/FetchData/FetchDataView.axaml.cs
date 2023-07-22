using Avalonia.Controls;
using CatApp.Controllers;

namespace CatApp.Views.FetchData;

public partial class FetchDataView : UserControl
{
    private readonly FetchDataController _ctrl;
    public FetchDataView()
    {
        InitializeComponent();
        _ctrl = new(this);
    }
}