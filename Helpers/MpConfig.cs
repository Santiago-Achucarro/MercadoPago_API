using System;
using Microsoft.Extensions.Configuration;

namespace MercadoPago_API.Helpers
{
    public class MpConfig
    {
        private readonly IConfiguration _configuration;

        public MpConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ObtenerAccessToken()
        {
            var token = _configuration.GetValue<string>("MercadoPago:AccessToken_Test");
            if (string.IsNullOrEmpty(token))
            {
                throw new Exception("El AccessToken_Test no está configurado correctamente.");
            }
            return token;
        }

        public string ObtenerPublicKey()
        {
            var key = _configuration.GetValue<string>("MercadoPago:PublicKey");
            return key ?? string.Empty;
        }
    }

}
