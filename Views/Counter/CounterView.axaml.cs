using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CatApp.Views.Counter;

public partial class CounterView : UserControl
{
    public CounterView()
    {
        InitializeComponent();
    }

    private int _count = 0;

    private void IncrementCount(object? sender, RoutedEventArgs e)
    {
        _count++;
        CountMessage.Text = $"Current cats count: {_count}";
    }
}