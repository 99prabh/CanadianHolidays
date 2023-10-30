using CanadianHolidays.Services;

namespace CanadianHolidays;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        DependencyService.Register<WebClientService>();
        DependencyService.Register<HolidayDataStoreAPI>();
        MainPage = new AppShell();
	}
}
