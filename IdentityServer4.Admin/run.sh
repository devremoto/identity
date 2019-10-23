#!/bin/bash

dotnet clean src/Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj
dotnet clean src/Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj

dotnet restore src/Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj
dotnet restore src/Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj

dotnet build src/Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj
dotnet build src/Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj


#gnome-terminal -- dotnet run --project src/Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj '/seed'

gnome-terminal -- dotnet run --project src/Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj '/seed'
