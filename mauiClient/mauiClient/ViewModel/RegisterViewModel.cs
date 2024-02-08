﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppRegAuth.Model;
using mauiClient.Services;

namespace mauiClient.ViewModel
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        public RegisterModel registerModel;

        private readonly ClientService _regService;
        public RegisterViewModel(ClientService clientService)
        {
            _regService = clientService;
            RegisterModel = new();
        }

        [RelayCommand]
        private async Task Register()
        {
            if(RegisterModel.PhoneNumber is null && RegisterModel.Password is null)
            {
                await Shell.Current.DisplayAlert("Error", "Enter your email and password", "Ok");
                return;
            }
            if(CheckPasswordValidate(RegisterModel.Password))
            {
                await GoToHomeChatsPage();
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Check the correctness of the input data", "Ok");
            }
            await _regService.Register(RegisterModel);
        }
        /// <summary>
        /// Валидация пароля.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool CheckPasswordValidate(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
            return isValidated;
        }
        /// <summary>
        /// Переход на главную страницу.
        /// </summary>
        /// <returns></returns>
        private async Task GoToHomeChatsPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(View.HomeChatsPage)}");
        }
    }
}