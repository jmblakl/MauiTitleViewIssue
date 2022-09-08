using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainPageModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}


}


public partial class MainPageModel  : ObservableObject
{
	[RelayCommand]
	public async Task Navigate()
	{
		await Shell.Current.GoToAsync(nameof(Child));
	}
}
