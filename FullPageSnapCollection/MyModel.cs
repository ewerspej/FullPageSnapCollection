using CommunityToolkit.Mvvm.ComponentModel;

namespace FullPageSnapCollection;

public partial class MyModel(string name, Color backgroundColor, string videoUri) : ObservableObject
{
    public string Name { get; } = name;

    public Color BackgroundColor { get; } = backgroundColor;

    public string VideoUri { get; } = videoUri;

    [ObservableProperty]
    private bool _isPlaying;
}