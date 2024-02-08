using mauiClient.View;

namespace mauiClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); 
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            const int newWidth = 1200;
            const int newHeight = 850;
            window.Width = newWidth;
            window.Height = newHeight;
            return window;
        }
    }
}
