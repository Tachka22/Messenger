using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mauiClient.Model;
using mauiClient.Services;

namespace mauiClient.ViewModel
{
    public partial class SettingViewModel:ObservableObject
    {
        [ObservableProperty]
        private User user;

        private readonly ClientService _settingService;
        public SettingViewModel()
        {
            User = new();
        }

        [RelayCommand]
        private async Task LogOut()
        {
            bool answer = await Shell.Current.DisplayAlert("Attention!", "Do you want to log out of your account?", "Yes", "No");
            if (answer)
            {
                // TODO: Написать выход из аккаунта.
            }
        }
        [RelayCommand]
        private async Task GoToChangeProfilePage()
        {
            await Shell.Current.GoToAsync($"//{nameof(View.SettingPages.ChangeProfilePage)}");
        }

        [RelayCommand]
        private async Task GoToAppearancePage()
        {
            await Shell.Current.GoToAsync($"//{nameof(View.SettingPages.Appearance)}");
        }

    }
}
