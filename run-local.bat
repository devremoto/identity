@echo off
title=RUN LOCAL
start cmd /c "title=admin & cd %~dp0/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin & dotnet build & dotnet run --launch-profile Skoruba.IdentityServer4.Admin /seed " 

start cmd /c "title=identity & cd IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity & dotnet build & dotnet run --launch-profile Skoruba.IdentityServer4.AspNetIdentity /seed "