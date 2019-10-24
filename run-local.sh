#!/bin/bash
#sudo chmod +x ./run-local.sh && ./run-local.sh

gnome-terminal --tab --title="admin" -- bash -c "cd IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin & dotnet build & dotnet run --launch-profile Skoruba.IdentityServer4.Admin /seed " 

gnome-terminal --tab --title="identity" -- bash -c "cd IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity & dotnet build & dotnet run --launch-profile Skoruba.IdentityServer4.AspNetIdentity /seed "
