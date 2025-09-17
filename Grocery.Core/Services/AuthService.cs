using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            // Vraag de klantgegevens [Client] op die je zoekt met het opgegeven emailadres
            var client = _clientService.Get(email);
            if (client == null) return null;

            // Als je een klant gevonden hebt controleer dan of het password matcht 
            bool isPasswordValid = PasswordHelper.VerifyPassword(password, client.Password);

            // Als alles klopt dan klantgegevens teruggeven, anders null
            return isPasswordValid ? client : null;
        }
    }
}
