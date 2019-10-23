using System.Linq;
using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using Skoruba.IdentityServer4.Admin.Configuration.Constants;
using Skoruba.IdentityServer4.Admin.Configuration.Interfaces;

namespace Skoruba.IdentityServer4.Admin.Configuration.IdentityServer

{
    public class Clients
    {
        public static IEnumerable<Client> GetAdminClient(IAdminConfiguration adminConfiguration)
        {
            var allowedCorsOrigens = adminConfiguration.AllowedCorsOrigins;
            allowedCorsOrigens.Add(adminConfiguration.IdentityAdminBaseUrl);

            var redirectUris = adminConfiguration.RedirectUris;
            redirectUris.AddRange(new List<string>{
                                $"{adminConfiguration.IdentityAdminBaseUrl}/signin-oidc",
                                $"{adminConfiguration.IdentityAdminBaseUrl}"
                        });

            return new List<Client>
            {
            new Client
                {

                        ClientId =adminConfiguration.ClientId,
                        ClientName =adminConfiguration.ClientId,
                        ClientUri = adminConfiguration.IdentityAdminBaseUrl,

                        AllowedGrantTypes = GrantTypes.Hybrid,

                        ClientSecrets = new List<Secret>
                        {
                                new Secret(adminConfiguration.ClientSecret.ToSha256())
                        },
                        RedirectUris = redirectUris,
                        FrontChannelLogoutUri = $"{adminConfiguration.IdentityAdminBaseUrl}/signout-oidc",
                        PostLogoutRedirectUris = { $"{adminConfiguration.IdentityAdminBaseUrl}/signout-callback-oidc"},
                        AllowedCorsOrigins = allowedCorsOrigens,

                        AllowedScopes = {
                                IdentityServerConstants.StandardScopes.OpenId,
                                IdentityServerConstants.StandardScopes.Profile,
                                IdentityServerConstants.StandardScopes.Email,
                                "roles"
                        }
                },
                new Client
                {
                        ClientId ="feature_toggle_admin",
                        ClientName ="Feature Toggle Admin",
                        ClientUri = $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500")}",

                        AllowedGrantTypes = GrantTypes.Implicit,
                        ClientSecrets = new List<Secret>
                        {
                                new Secret(adminConfiguration.ClientSecret.ToSha256())
                        },
                        LogoUri = $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500")}/assets/admin/img/logo.jpg",
                        RedirectUris = {
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500")}/callback",
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500")}/admin",
                                "http://localhost:4500/callback", "http://localhost:4500/admin",
                                "http://localhost:4300/callback", "http://localhost:4300/admin" ,
                                "http://localhost:4200/callback", "http://localhost:4200/admin"
                        },
                        FrontChannelLogoutUri = "http://localhost:4500/callback",
                        PostLogoutRedirectUris = {
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500")}/callback",
                                "http://localhost:4500/callback",
                                "http://localhost:4300/callback",
                                "http://localhost:4200/callback"
                        },
                        AllowedCorsOrigins = {
                                adminConfiguration.IdentityServerBaseUrl.Replace("5000","4500"),
                                "http://localhost:4500",
                                "http://localhost:4300",
                                "http://localhost:4200"
                        },
                        AllowOfflineAccess = true,
                        AllowAccessTokensViaBrowser = true,
                        RequireConsent = false,
                        RequireClientSecret = false,
                        AllowedScopes =
                        {
                                IdentityServerConstants.StandardScopes.OpenId,
                                IdentityServerConstants.StandardScopes.Profile,
                                IdentityServerConstants.StandardScopes.Email,
                                "roles",
                                "feature_toggle_api"
                        }
                }
                ,
                new Client
                {

                        ClientId ="tgappmodel",
                        ClientName ="Tugon App Model",
                        ClientUri = $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200")}",

                        AllowedGrantTypes = GrantTypes.Implicit,

                        ClientSecrets = new List<Secret>
                        {
                                new Secret("secret".ToSha256())
                        },
                        LogoUri = $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200")}/assets/admin/img/logo.jpg",
                        RedirectUris = {
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200")}/callback",
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200")}/admin",
                                "http://localhost:4200/callback",
                                "http://localhost:4200/admin",
                                "http://192.168.0.5:52050/swagger/oauth2-redirect.html",
                                "http://localhost:52050/swagger/oauth2-redirect.html"
                        },
                        FrontChannelLogoutUri = "http://localhost:4200/callback",
                        PostLogoutRedirectUris = {
                                $"{adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200")}/callback",
                                "http://localhost:4200/callback",
                                "http://localhost:4200/callback"
                        },
                        AllowedCorsOrigins = {
                                adminConfiguration.IdentityServerBaseUrl.Replace("5000","4200"),
                                "http://localhost:52050",
                                "http://192.168.0.5:52050"
                        },
                        AllowOfflineAccess = true,
                        AllowAccessTokensViaBrowser = true,
                        RequireConsent = false,
                        RequireClientSecret = false,
                        FrontChannelLogoutSessionRequired = false,
                        BackChannelLogoutSessionRequired = false,
                        AllowedScopes =
                        {
                                IdentityServerConstants.StandardScopes.OpenId,
                                IdentityServerConstants.StandardScopes.Profile,
                                IdentityServerConstants.StandardScopes.Email,
                                "roles",
                                "role",
                                "sso",
                                "api1"
                        }
                },


            };

        }


        public static IEnumerable<Client> Get()
        {
            return new List<Client>
                        {
                ///////////////////////////////////////////
                // Console Client Credentials Flow Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "client",
                                        ClientSecrets =
                                        {
                                                new Secret("secret".Sha256())
                                        },

                                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                                        AllowedScopes = { "api1", "api2.read_only" }
                                },

                ///////////////////////////////////////////
                // Console Client Credentials Flow with client JWT assertion
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "client.jwt",
                                        ClientSecrets =
                                        {
                                                new Secret
                                                {
                                                        Type = IdentityServerConstants.SecretTypes.X509CertificateBase64,
                                                        Value = "MIIDATCCAe2gAwIBAgIQoHUYAquk9rBJcq8W+F0FAzAJBgUrDgMCHQUAMBIxEDAOBgNVBAMTB0RldlJvb3QwHhcNMTAwMTIwMjMwMDAwWhcNMjAwMTIwMjMwMDAwWjARMQ8wDQYDVQQDEwZDbGllbnQwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDSaY4x1eXqjHF1iXQcF3pbFrIbmNw19w/IdOQxbavmuPbhY7jX0IORu/GQiHjmhqWt8F4G7KGLhXLC1j7rXdDmxXRyVJBZBTEaSYukuX7zGeUXscdpgODLQVay/0hUGz54aDZPAhtBHaYbog+yH10sCXgV1Mxtzx3dGelA6pPwiAmXwFxjJ1HGsS/hdbt+vgXhdlzud3ZSfyI/TJAnFeKxsmbJUyqMfoBl1zFKG4MOvgHhBjekp+r8gYNGknMYu9JDFr1ue0wylaw9UwG8ZXAkYmYbn2wN/CpJl3gJgX42/9g87uLvtVAmz5L+rZQTlS1ibv54ScR2lcRpGQiQav/LAgMBAAGjXDBaMBMGA1UdJQQMMAoGCCsGAQUFBwMCMEMGA1UdAQQ8MDqAENIWANpX5DZ3bX3WvoDfy0GhFDASMRAwDgYDVQQDEwdEZXZSb290ghAsWTt7E82DjU1E1p427Qj2MAkGBSsOAwIdBQADggEBADLje0qbqGVPaZHINLn+WSM2czZk0b5NG80btp7arjgDYoWBIe2TSOkkApTRhLPfmZTsaiI3Ro/64q+Dk3z3Kt7w+grHqu5nYhsn7xQFAQUf3y2KcJnRdIEk0jrLM4vgIzYdXsoC6YO+9QnlkNqcN36Y8IpSVSTda6gRKvGXiAhu42e2Qey/WNMFOL+YzMXGt/nDHL/qRKsuXBOarIb++43DV3YnxGTx22llhOnPpuZ9/gnNY7KLjODaiEciKhaKqt/b57mTEz4jTF4kIg6BP03MUfDXeVlM1Qf1jB43G2QQ19n5lUiqTpmQkcfLfyci2uBZ8BkOhXr3Vk9HIk/xBXQ="
                                                }
                                        },

                                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                                        AllowedScopes = { "api1", "api2.read_only" }
                                },

                ///////////////////////////////////////////
                // Custom Grant Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "client.custom",
                                        ClientSecrets =
                                        {
                                                new Secret("secret".Sha256())
                                        },

                                        AllowedScopes = { "api1", "api2.read_only" }
                                },

                ///////////////////////////////////////////
                // Console Resource Owner Flow Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "roclient",
                                        ClientSecrets =
                                        {
                                                new Secret("secret".Sha256())
                                        },

                                        AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                                        AllowOfflineAccess = true,
                                        AllowedScopes =
                                        {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                "custom.profile",
                                                "api1", "api2.read_only"
                                        }
                                },

                ///////////////////////////////////////////
                // Console Public Resource Owner Flow Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "roclient.public",
                                        RequireClientSecret = false,

                                        AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                                        AllowOfflineAccess = true,
                                        AllowedScopes =
                                        {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "api1", "api2.read_only"
                                        }
                                },

                ///////////////////////////////////////////
                // Console Hybrid with PKCE Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "console.hybrid.pkce",
                                        ClientName = "Console Hybrid with PKCE Sample",
                                        RequireClientSecret = false,

                                        AllowedGrantTypes = GrantTypes.Hybrid,
                                        RequirePkce = true,

                                        RedirectUris = { "http://127.0.0.1:7890/" },

                                        AllowOfflineAccess = true,

                                        AllowedScopes =
                                        {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Profile,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "api1", "api2.read_only",
                                        },
                                },

                ///////////////////////////////////////////
                // Introspection Client Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "roclient.reference",
                                        ClientSecrets =
                                        {
                                                new Secret("secret".Sha256())
                                        },

                                        AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                                        AllowedScopes = { "api1", "api2.read_only" },

                                        AccessTokenType = AccessTokenType.Reference
                                },

                ///////////////////////////////////////////
                // MVC Implicit Flow Samples
                //////////////////////////////////////////
                new Client
                                {

                                        ClientId = "mvc.implicit",
                                        ClientName = "MVC Implicit",
                                        ClientUri = "http://identityserver.io",

                                        AllowedGrantTypes = GrantTypes.Implicit,
                                        AllowAccessTokensViaBrowser = true,

                                        RedirectUris =  { "http://localhost:44077/signin-oidc" },
                                        FrontChannelLogoutUri = "http://localhost:44077/signout-oidc",
                                        PostLogoutRedirectUris = { "http://localhost:44077/signout-callback-oidc" },

                                        AllowedScopes =
                                        {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Profile,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "api1", "api2.read_only"
                                        },
                                },

                ///////////////////////////////////////////
                // MVC Manual Implicit Flow Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "mvc.manual",
                                        ClientName = "MVC Manual",
                                        ClientUri = "http://identityserver.io",

                                        AllowedGrantTypes = GrantTypes.Implicit,
                                        RedirectUris = { "http://localhost:44077/home/callback" },
                                        FrontChannelLogoutUri = "http://localhost:44077/signout-oidc",
                                        PostLogoutRedirectUris = { "http://localhost:44077/" },

                                        AllowedScopes = { IdentityServerConstants.StandardScopes.OpenId },
                                },

                ///////////////////////////////////////////
                // MVC Hybrid Flow Samples
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "mvc.hybrid",
                                        ClientName = "MVC Hybrid",
                                        ClientUri = "http://identityserver.io",

                                        ClientSecrets =
                                        {
                                                new Secret("secret".Sha256())
                                        },

                                        AllowedGrantTypes = GrantTypes.Hybrid,
                                        AllowAccessTokensViaBrowser = false,

                                        RedirectUris = { "http://localhost:21402/signin-oidc" },
                                        FrontChannelLogoutUri = "http://localhost:21402/signout-oidc",
                                        PostLogoutRedirectUris = { "http://localhost:21402/signout-callback-oidc" },

                                        AllowOfflineAccess = true,

                                        AllowedScopes =
                                        {
                                                IdentityServerConstants.StandardScopes.OpenId,
                                                IdentityServerConstants.StandardScopes.Profile,
                                                IdentityServerConstants.StandardScopes.Email,
                                                "api1", "api2.read_only",
                                        },
                                },

                ///////////////////////////////////////////
                // JS OAuth 2.0 Sample
                //////////////////////////////////////////
                new Client
                                {
                                        ClientId = "js_oauth",
                                        ClientName = "JavaScript OAuth 2.0 Client",
                                        ClientUri = "http://identityserver.io",

                                        AllowedGrantTypes = GrantTypes.Implicit,
                                        AllowAccessTokensViaBrowser = true,

                                        RedirectUris = { "http://localhost:28895/index.html" },
                                        AllowedScopes = { "api1", "api2.read_only" },
                                },
                
                ///////////////////////////////////////////
                // JS OIDC Sample
                //////////////////////////////////////////
                new Client                    {
                            ClientId = "js_oidc",
                            ClientName = "JavaScript OIDC Client",
                            ClientUri = "http://identityserver.io",

                            AllowedGrantTypes = GrantTypes.Implicit,
                            AllowAccessTokensViaBrowser = true,
                            RequireClientSecret = false,
                            AccessTokenType = AccessTokenType.Reference,

                            RedirectUris =
                            {
                                    "http://localhost:7017/index.html",
                                    "http://localhost:7017/callback.html",
                                    "http://localhost:7017/silent.html",
                                    "http://localhost:7017/popup.html",
                            },

                            PostLogoutRedirectUris = { "http://localhost:7017/index.html" },
                            AllowedCorsOrigins = { "http://localhost:7017" },

                            AllowedScopes =
                            {
                                    IdentityServerConstants.StandardScopes.OpenId,
                                    IdentityServerConstants.StandardScopes.Profile,
                                    IdentityServerConstants.StandardScopes.Email,
                                    "api1", "api2.read_only"
                            },
                    },
            };
        }
    }
}
