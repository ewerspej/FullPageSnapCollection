using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FullPageSnapCollection;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<MyModel> _items;

    public MainViewModel()
    {
        Items =
        [
            new MyModel("First", Colors.Red),
            new MyModel("Second", Colors.Blue),
            new MyModel("Third", Colors.Green),
            new MyModel("Fourth", Colors.Yellow),
            new MyModel("Fifth", Colors.Purple),
            new MyModel("Sixth", Colors.Orange),
            new MyModel("Seventh", Colors.Pink),
            new MyModel("Eighth", Colors.Brown),
            new MyModel("Ninth", Colors.Teal),
            new MyModel("Tenth", Colors.LightBlue)
        ];
    }
}