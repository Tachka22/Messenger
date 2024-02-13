using mauiClient.ViewModel;

namespace mauiClient.View.SettingPages;

public partial class StartupSettings : ContentPage
{
	public StartupSettings(RegisterViewModel registerViewModel)
	{
		InitializeComponent();
		BindingContext = registerViewModel;
	}
}