using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;

namespace Skoruba.IdentityServer4.Admin.Configuration.IdentityServer
{
    public class ClientResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource("custom.profile", new[] { JwtClaimTypes.Name, JwtClaimTypes.Email, "location" }),
                new IdentityResource("roles", "Roles", new[] { "role" }),
                new IdentityResource("role", "Role", new[] { "role" })
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource("api1", "Api 1") { ApiSecrets = { new Secret("secret".Sha256()) }},
                new ApiResource("sso", "SSO API") { ApiSecrets = { new Secret("secret".Sha256()) }},
                new ApiResource("feature_toggle_api", "Feature Toggle Api"){ ApiSecrets = { new Secret("secret".Sha256()) }},
             };
        }
    }
}