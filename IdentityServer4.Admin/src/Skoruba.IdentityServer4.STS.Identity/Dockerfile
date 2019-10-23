FROM microsoft/dotnet:2.2-sdk AS build

WORKDIR /app
COPY ["Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj", "Skoruba.IdentityServer4.STS.Identity/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts/Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework.Identity/Skoruba.IdentityServer4.Admin.EntityFramework.Identity.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework.Identity/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework/Skoruba.IdentityServer4.Admin.EntityFramework.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework/"]
COPY ["Skoruba.IdentityServer4.STS.Identity/*.pfx","Skoruba.IdentityServer4.STS.Identity/*.crt","Skoruba.IdentityServer4.STS.Identity/*.csr","Skoruba.IdentityServer4.STS.Identity/*.key","Skoruba.IdentityServer4.STS.Identity/*.pem","cert/"]
RUN dotnet restore "Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj"
COPY . ./
RUN dotnet publish "Skoruba.IdentityServer4.STS.Identity/Skoruba.IdentityServer4.STS.Identity.csproj" -c Release -o /app/out

FROM microsoft/dotnet:2.2-aspnetcore-runtime

WORKDIR /app

COPY --from=build /app/out .
COPY --from=build /app/cert/*.* ./
RUN ls
ENTRYPOINT ["dotnet", "Skoruba.IdentityServer4.STS.Identity.dll", "/seed"]
