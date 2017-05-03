using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStuff
{
    public static class TokenValidator
    {
        public static string GetPayload(string _token, string _discoveryUrl)
        {
            try
            { 
                ConfigurationManager<OpenIdConnectConfiguration> configManager =
                    new ConfigurationManager<OpenIdConnectConfiguration>(_discoveryUrl, new OpenIdConnectConfigurationRetriever());
            
                OpenIdConnectConfiguration config = configManager.GetConfigurationAsync().Result;

                TokenValidationParameters validationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidIssuer = config.Issuer,
                    IssuerSigningKeys = config.SigningKeys,
                    ValidateIssuerSigningKey = false,
                    ValidateIssuer = true,
                    ValidateActor = false,
                    ValidateLifetime = true
                };

                JwtSecurityTokenHandler tokendHandler = new JwtSecurityTokenHandler();

                Microsoft.IdentityModel.Tokens.SecurityToken jwt;

                var result = tokendHandler.ValidateToken(_token, validationParameters, out jwt);

                return ((JwtSecurityToken)jwt).RawPayload;
            }
            catch (Exception e)
            {
                return "Error Parsing Token: " + e.Message;
            }
        }
    }
}
