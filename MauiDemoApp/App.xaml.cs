namespace MauiDemoApp;
using Services;

public partial class App : Application
{
    private SDKBasicService basicService = new SDKBasicService();

	public Boolean HasStartedLocationMonitoring { get; set; }

	private MobileMessageHandler mobileMessageHandler;

    public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
        HasStartedLocationMonitoring = false;
		mobileMessageHandler = new MobileMessageHandler();
    }

	public async Task CheckLocationPermissionAndStartLocationService()
	{
		
        PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.LocationAlways>();
		if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
		{
			return;
		}
		if (Permissions.ShouldShowRationale<Permissions.LocationAlways>())
		{
			await Shell.Current.DisplayAlert("Needs location permission",
				"Location permission always is needed for enabling geofencing and bluetooth functionality. \nPlease go to app settings to set the permission."
				, "OK");
			return;
		}
	
		status = await Permissions.RequestAsync<Permissions.LocationAlways>();

		if (status == PermissionStatus.Granted)
		{
			BasicService.StartMonitoringLocation();
			HasStartedLocationMonitoring = true;
		}
    }

	public SDKBasicService BasicService
	{
		get { return basicService; }
	}


	public void HandleMobileMessageDismissed()
	{
		mobileMessageHandler.OnMessageDismissed();
	}

	public void HandleMobileMessageLinkClicked(string msgLink)
	{
		mobileMessageHandler.OnMessageLinkClicked(msgLink);
	}
}
