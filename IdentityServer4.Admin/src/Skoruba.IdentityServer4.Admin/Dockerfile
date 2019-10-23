FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app
COPY ["Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj", "Skoruba.IdentityServer4.Admin/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts/Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework.Identity/Skoruba.IdentityServer4.Admin.EntityFramework.Identity.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework.Identity/"]
COPY ["Skoruba.IdentityServer4.Admin.EntityFramework/Skoruba.IdentityServer4.Admin.EntityFramework.csproj", "Skoruba.IdentityServer4.Admin.EntityFramework/"]
COPY ["Skoruba.IdentityServer4.Admin.BusinessLogic/Skoruba.IdentityServer4.Admin.BusinessLogic.csproj", "Skoruba.IdentityServer4.Admin.BusinessLogic/"]
COPY ["Skoruba.IdentityServer4.Admin.BusinessLogic.Shared/Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.csproj", "Skoruba.IdentityServer4.Admin.BusinessLogic.Shared/"]
COPY ["Skoruba.IdentityServer4.Admin.BusinessLogic.Identity/Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.csproj", "Skoruba.IdentityServer4.Admin.BusinessLogic.Identity/"]
COPY ["Skoruba.IdentityServer4.Admin/cert-aspnetcore.pfx","cert/"]
RUN dotnet restore "Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj"
COPY . ./

RUN dotnet publish "Skoruba.IdentityServer4.Admin/Skoruba.IdentityServer4.Admin.csproj" -c Release -o /app/out


FROM microsoft/dotnet:2.2-aspnetcore-runtime

WORKDIR /app

COPY --from=build /app/out .
COPY --from=build /app/cert/cert-aspnetcore.pfx .
#RUN apt-get update && apt-get -y install iputils-ping


ENTRYPOINT ["dotnet", "Skoruba.IdentityServer4.Admin.dll", "/seed"]
