using System.Collections.Generic;

namespace Skoruba.IdentityServer4.Admin.Configuration.Interfaces
{
    public interface IAdminConfiguration
    {
        string IdentityAdminBaseUrl { get; }
        string IdentityAdminRedirectUri { get; }
        string IdentityServerBaseUrl { get; }
        bool RequireHttpsMetadata { get; set; }
        string ClientId { get; }
        string ClientSecret { get; }
        string OidcResponseType { get; }
        string[] Scopes { get; }
        List<string> AllowedCorsOrigins { get; }
        List<string> RedirectUris { get; }
    }
}