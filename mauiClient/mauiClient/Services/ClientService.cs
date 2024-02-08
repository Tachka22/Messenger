using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppRegAuth.Model;
using mauiClient.Model;

namespace mauiClient.Services
{
    public class ClientService
    {
        public async Task<bool> IsLoginAsync()
        {
            await Task.Delay(2000);
            return false;
        }

        public async Task Login(LoginParams loginParams)
        {

        }
        public async Task Register(RegisterModel registerModel)
        {

        }
        public async Task Logout()
        {

        }
    }
}
