using CatApp.Services;
using CatApp.Views.FetchData;

namespace CatApp.Controllers;

public class FetchDataController
{
    // to modify the view from the controller
    private readonly FetchDataView _view;

    public FetchDataController(FetchDataView view)
    {
        _view = view;
        InitializeDataGrid();
    }

    // populates the DataGrid with cats on class initialization
    private void InitializeDataGrid()
    {
        var cats = CatsService.GetCatsAsync();
        _view.CatsGrid.ItemsSource = cats;

        // set a custom row height in pixels (default is 35)
        _view.CatsGrid.RowHeight = 40;

        // calculate the height of the dataGrid
        // this is not necessary but without it the external scroll will break
        _view.CatsGrid.Height = (cats.Length + 2) * _view.CatsGrid.RowHeight;
    }
}