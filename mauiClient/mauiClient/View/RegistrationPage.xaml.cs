using mauiClient.ViewModel;

namespace mauiClient.View;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage(RegisterViewModel registerViewModel)
	{
		InitializeComponent();
        BindingContext = registerViewModel;
    }
}