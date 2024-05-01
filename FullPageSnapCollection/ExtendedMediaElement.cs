using CommunityToolkit.Maui.Views;

namespace FullPageSnapCollection;

public class ExtendedMediaElement : MediaElement
{
    public bool IsPlaying
    {
        get => (bool)GetValue(IsPlayingProperty);
        set => SetValue(IsPlayingProperty, value);
    }

    public static readonly BindableProperty IsPlayingProperty = BindableProperty.Create(nameof(IsPlaying), typeof(bool), typeof(ExtendedMediaElement), false, propertyChanged: OnIsPlayingPropertyChanged);

    private static void OnIsPlayingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var mediaElement = (ExtendedMediaElement)bindable;

        if (newValue is true)
        {
            mediaElement.Play();
            Console.WriteLine("Play called");
        }
        else
        {
            mediaElement.Stop();
            Console.WriteLine("Stop called");
        }
    }
}