namespace mauiClient.View;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
		btn_back.Clicked += async (s, e) => await Shell.Current.GoToAsync($"//{nameof(View.HomeChatsPage)}");
    }
}