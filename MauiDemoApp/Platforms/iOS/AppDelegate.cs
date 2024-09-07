using Foundation;
using UIKit;
using Com.SAS.CI360;


namespace MauiDemoApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
	{
 		SASLogger.SetLevel(SASLoggerLevel.All);
		SASCollector.InitializeCollection();
		return base.FinishedLaunching(application, launchOptions);
	}
	
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
