using Microsoft.Extensions.Logging;
// using MauiDemoApp.MobileSpots;
using CommunityToolkit.Maui;

namespace MauiDemoApp;

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
			}).ConfigureMauiHandlers(handlers =>
        	{
				// handlers.AddHandler(typeof(InlineAdView), typeof(InlineAdViewHandler));
				// handlers.AddHandler(typeof(InterstitialAdView), typeof(InterstitialAdViewHandler));
        	}).UseMauiCommunityToolkit();;

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
