using System.Collections.ObjectModel;

namespace OpacitySample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public Color BlackWithAlpha => Colors.Black.WithAlpha(0.2f);
	public Color BlueWithAlpha => Colors.Blue.WithAlpha(0.2f);

    private ObservableCollection<string> _items = new ObservableCollection<string>()
    {
        "Item 1",
        "Item 2",
        "Item 3",
        "Item 4",
        "Item 5",
    };

    public ObservableCollection<string> Items
    {
        get => _items;
        set
        {
            _items = value;
            OnPropertyChanged();
        }
    }
}

