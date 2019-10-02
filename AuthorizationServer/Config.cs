using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationServer
{
    public class Config
    {
        public static List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "clientId",
                    ClientName="clientName",
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("clientSecret".Sha256())
                    },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId
                    }
                }
            };
        }

        public static List<ApiResource> GetApiResources()
        {
            return new List<ApiResource>();
        }
    }
}
