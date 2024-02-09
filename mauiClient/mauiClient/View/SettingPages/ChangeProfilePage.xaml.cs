using mauiClient.ViewModel;

namespace mauiClient.View.SettingPages;

public partial class ChangeProfilePage : ContentPage
{
	public ChangeProfilePage(SettingProfileViewModel settingProfileViewModel)
	{
		InitializeComponent();
		BindingContext = settingProfileViewModel;
	}
}