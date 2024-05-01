namespace FullPageSnapCollection;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel _vm;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = _vm = new MainViewModel();
    }

    private void ItemsView_OnScrolled(object? sender, ItemsViewScrolledEventArgs e)
    {
        var itemIndex = e.CenterItemIndex;

        _vm.Items[itemIndex].IsPlaying = true;

        foreach (var myModel in _vm.Items)
        {
            if (myModel != _vm.Items[itemIndex])
            {
                myModel.IsPlaying = false;
            }
        }
    }
}