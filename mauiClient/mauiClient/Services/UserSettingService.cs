using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace mauiClient.Services
{
    public class UserSettingService
    {
        public async void SentFile(string filePath)
        {
            using var multipartFormContent = new MultipartFormDataContent();

            byte[] fileToBytes = await File.ReadAllBytesAsync(filePath);

            var content = new ByteArrayContent(fileToBytes);

            content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

            multipartFormContent.Add(content, name: "file", fileName: "forest5.jpg");
        }
        public async Task GetFile() { }
        public async Task UpdateUserInfo() { }
        public async Task UpdatePassword() { }
    }

}
