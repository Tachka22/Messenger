using mauiClient.Services;

namespace mauiClient.View;

public partial class LoadingPage : ContentPage
{
	private readonly ClientService _authService;
	public LoadingPage( ClientService authService)
	{
		InitializeComponent();
		_authService = authService;
	}
    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

		if(await _authService.IsLoginAsync())
		{
            await Shell.Current.GoToAsync($"//{nameof(HomeChatsPage)}");
        }
		else
		{
			await Shell.Current.GoToAsync($"//{nameof(AuthorizationPage)}");
		}
    }
}