using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp2;

public partial class Child : ContentPage
{
	public Child(ChildModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}

public partial class ChildModel : ObservableObject
{
	[RelayCommand]
	public async Task Navigate()
	{
		await Shell.Current.GoToAsync("//HomePage");
	}
}