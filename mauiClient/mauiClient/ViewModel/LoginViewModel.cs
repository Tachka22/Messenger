﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppRegAuth.Model;
using mauiClient.Model;
using mauiClient.Services;
using mauiClient.View;


namespace mauiClient.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private RegisterModel registerModel;

        [ObservableProperty]
        private LoginParams loginParams;

        [ObservableProperty]
        public bool isAuthenticated;

        private readonly AuthService _authService;

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
            RegisterModel = new();
            LoginParams = new LoginParams();
            IsAuthenticated = false;
        }

        [RelayCommand]
        private async Task Register()
        {
            await _authService.Register(RegisterModel);
        }

        [RelayCommand]
        private async Task Login()
        {
            if (LoginParams.Email is null && LoginParams.Password is null)
            {
                await Shell.Current.DisplayAlert("Error", "Enter your email and password", "Ok");
                return;
            }

            if (IsValidEmail(LoginParams.Email) && LoginParams.Password.Length > 0) 
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