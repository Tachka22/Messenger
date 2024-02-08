using mauiClient.ViewModel;

namespace mauiClient.View;

public partial class AuthorizationPage : ContentPage
{

    public AuthorizationPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
        BindingContext = loginViewModel;
        
    }
}