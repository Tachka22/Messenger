using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mauiClient.Model
{
    public class User
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; } = "Vlad";
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; } = "User294738";
        public string? PhoneNumber { get; set; } = "7(999)-999-99-99";
        public string? Password { get; set; }
        public string? Bio { get; set; }
        public string? PhotoSource { get; set; }
    }
}
