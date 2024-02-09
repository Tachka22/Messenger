using mauiClient.ViewModel;

namespace mauiClient.View;

public partial class SettingPage : ContentPage
{
	public SettingPage(SettingViewModel settingViewModel)
	{
		InitializeComponent();
		BindingContext = settingViewModel;
	}
}