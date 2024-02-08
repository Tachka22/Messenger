using mauiClient.View;

namespace mauiClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(AuthorizationPage), typeof(AuthorizationPage));
            Routing.RegisterRoute(nameof(HomeChatsPage), typeof(HomeChatsPage));
            Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
        }
    }
}
