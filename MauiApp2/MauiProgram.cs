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

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageModel>();
		builder.Services.AddSingleton<Child>();
		builder.Services.AddSingleton<ChildModel>();
		return builder.Build();
	}
}
