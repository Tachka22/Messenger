using mauiClient.ViewModel;

namespace mauiClient.View;

public partial class CreateNewChat : ContentPage
{
	public CreateNewChat(ChatViewModel chatViewModel)
	{
		InitializeComponent();
		BindingContext = chatViewModel;
	}
}