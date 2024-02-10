using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mauiClient.Model;
using Plugin.Media;

namespace mauiClient.ViewModel
{
    public class OldUser()
    {
        public string? Name { get; set; } = "Name";
        public string? Surname { get; set; } = "Surname";
        public string? Email { get; set; } = "Email";
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Bio { get; set; } = "Bio";
        public string? PhotoSource { get; set; }
    }
    public partial class SettingProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private User user;

        [ObservableProperty]
        private OldUser oldUser;

        [ObservableProperty]
        ImageSource myImageSource;
        public SettingProfileViewModel()
        {
            User = new();
            OldUser = new();
        }
        [RelayCommand]
        private async Task GoBack()
        {
            // TODO: Предусмотреть вызод без сохранения изменений.(мб хранить временно данные в другом классе)
            await Shell.Current.GoToAsync($"//{nameof(View.SettingPage)}");
        }
        [RelayCommand]
        private async Task ClickDone()
        {
            if (User.UserName is null || User.PhoneNumber is null)
            {
                await Shell.Current.DisplayAlert("Error", "Enter your UserName and Name", "Ok");
                return;
            }
            else
            {
                // TODO: Реализовать обновление данных.
                await Shell.Current.GoToAsync($"//{nameof(View.SettingPage)}");
            }
        }
        [RelayCommand]
        private async Task SetNewPhoto()
        {
            var photoSource = await LoadPhoto();
            //Загрузить на сервер и получить ссылку -> сохранить ссылку в бд пользователя.???
            User.PhotoSource = photoSource;
            await Shell.Current.DisplayAlert("Error", $"{User.PhotoSource}", "Ok");
            // TODO: Изменять фото доделать!
        }
        private async Task<string> LoadPhoto()
        {
            // TODO: Адаптировать под Android. манифест
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.PickPhotoAsync();
                if (photo != null)
                {
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);
                    await sourceStream.CopyToAsync(localFileStream);

                    return localFilePath;
                }
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "You device isn't supported", "Ok");
            }
            return null;
        }
       
    }
}
