

namespace mauiClient.View;

public partial class AuthorizationPage : ContentPage
{
	public AuthorizationPage()
	{
		InitializeComponent();
        btn_Registrations.Clicked += Btn_Registrations_Clicked;
        btn_Authorization.Clicked += Btn_Authorization_Clicked;

	}

    private async void Btn_Authorization_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async  void Btn_Registrations_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrationPage());
    }
}