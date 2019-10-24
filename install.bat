rem cd IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin

rem dotnet ef migrations add AspNetIdentityDbInit -c AdminIdentityDbContext -o Data/Migrations/Identity

rem dotnet ef migrations add LoggingDbInit -c AdminLogDbContext -o Data/Migrations/Logging

rem dotnet ef migrations add IdentityServerConfigurationDbInit -c IdentityServerConfigurationDbContext -o Data/Migrations/IdentityServerConfiguration

rem dotnet ef migrations add IdentityServerPersistedGrantsDbInit -c IdentityServerPersistedGrantDbContext -o Data/Migrations/IdentityServerGrants

rem cd ../../../

REM sudo chmod +x ./cert.sh
REM ./cert.sh

SET HOST_IP=192.168.0.5
SET STS_PORT=5000
SET STS_HTTPS_PORT=5001
SET STS_ADMIN_PORT=9000
SET STS_ADMIN_HTTPS_PORT=9001

SET USE_SSL=false

SET PROTOCOL=http
SET STS_SERVER=%PROTOCOL%://%HOST_IP%:%STS_PORT%
SET STS_ADMIN_SERVER=%PROTOCOL%://%HOST_IP%:%STS_ADMIN_PORT%

if %USE_SSL% == true (

        SET PROTOCOL=https
        SET STS_SERVER=%PROTOCOL%://%HOST_IP%:%STS_HTTPS_PORT%
        SET STS_ADMIN_SERVER=%PROTOCOL%://%HOST_IP%:%STS_ADMIN_HTTPS_PORT%
)

echo %STS_SERVER%
echo %STS_ADMIN_SERVER%
docker-compose down
docker rm devremoto-identity-admin -f
docker rm devremoto-identity -f

rem  Build images
docker-compose build ^
--build-arg HOST_IP=%HOST_IP%
--build-arg STS_PORT=%STS_PORT% ^
--build-arg USE_SSL=%USE_SSL% ^
--build-arg STS_HTTPS_PORT=%STS_HTTPS_PORT% ^
--build-arg STS_ADMIN_PORT=%STS_ADMIN_PORT% ^
--build-arg STS_ADMIN_HTTPS_PORT=%STS_ADMIN_HTTPS_PORT% ^
--build-arg STS_SERVER=%STS_SERVER% ^
--build-arg STS_ADMIN_SERVER=%STS_ADMIN_SERVER%

rem  Run the containers
rem docker-compose down
docker-compose up -d


rem  Open front/admin and swagger for api
rem start %STS_SERVER%
rem start %STS_ADMIN_SERVER%
