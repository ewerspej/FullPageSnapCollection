using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace FullPageSnapCollection;

public partial class MainViewModel : ObservableObject
{
    private const string FrogVideo = "https://github.com/ewerspej/FullPageSnapCollection/blob/master/Assets/frog.mp4?raw=true";
    private const string LakeVideo = "https://github.com/ewerspej/FullPageSnapCollection/blob/master/Assets/lake.mp4?raw=true";

    [ObservableProperty]
    private ObservableCollection<MyModel> _items;
    
    public MainViewModel()
    {
        Items =
        [
            new MyModel("First", Colors.Red, FrogVideo),
            new MyModel("Second", Colors.Blue, LakeVideo),
            new MyModel("Third", Colors.Green, FrogVideo),
            new MyModel("Fourth", Colors.Yellow, LakeVideo),
            new MyModel("Fifth", Colors.Purple, FrogVideo),
            new MyModel("Sixth", Colors.Orange, LakeVideo),
            new MyModel("Seventh", Colors.Pink, FrogVideo),
            new MyModel("Eighth", Colors.Brown, LakeVideo),
            new MyModel("Ninth", Colors.Teal, FrogVideo),
            new MyModel("Tenth", Colors.LightBlue, LakeVideo)
        ];
    }
}