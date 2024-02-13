using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mauiClient.Model;
using mauiClient.Services;



namespace mauiClient.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {

        [ObservableProperty]
        private LoginParams loginParams;

        [ObservableProperty]
        public bool isAuthenticated;

        private readonly ClientService _authService;

        public LoginViewModel(ClientService authService)
        {
            _authService = authService;
            LoginParams = new LoginParams();
            IsAuthenticated = false;
        }

        [RelayCommand]
        private async Task Login()
        {
            if (LoginParams.PhoneNumber is null && LoginParams.Password is null)
            {
                await Shell.Current.DisplayAlert("Error", "Enter your phone number and password", "Ok");
                return;
            }

            if (LoginParams.PhoneNumber.Length > 5  && LoginParams.Password.Length > 0) 
                await GoToHomeChatsPage();
            else
                await Shell.Current.DisplayAlert("Error", "Check the correctness of the input data", "Ok");
        }


        [RelayCommand]
        private async Task GoToRegisterPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(View.RegistrationPage)}");
        }

        private async Task GoToHomeChatsPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(View.HomeChatsPage)}");
        }
        /// <summary>
        /// Проверка валидности почты
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
