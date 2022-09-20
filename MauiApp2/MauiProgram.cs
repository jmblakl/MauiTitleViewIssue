using CommunityToolkit.Maui;

namespace MauiApp2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "IconFontTypes");
            })
            .UseMauiCommunityToolkit();


		//all ViewModels and Pages are registered as transient
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageModel>();
		builder.Services.AddTransient<Child>();
		builder.Services.AddTransient<ChildModel>();
		return builder.Build();
	}
}
