using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MaApp;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    public MainPage()
    {
        InitializeComponent();
      
    }

    public bool IsLayoutVisible { get; set; } = true;

    private void ToggleVisibility(object sender, EventArgs e)
    {
        IsLayoutVisible = !IsLayoutVisible;
    }
}
