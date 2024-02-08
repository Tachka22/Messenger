using mauiClient.Services;
using mauiClient.View;
using mauiClient.ViewModel;
using Microsoft.Extensions.Logging;

namespace mauiClient
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("ProtestRiot-Regular.ttf", "ProtestRiotRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<ClientService>();

            builder.Services.AddSingleton<AuthorizationPage>();
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<RegistrationPage>();
            builder.Services.AddSingleton<RegisterViewModel>();

            return builder.Build();
        }
    }
}
