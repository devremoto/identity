#!/bin/sh
#sudo chmod +x ./install.sh && ./install.sh


#cd IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin

#sudo dotnet ef migrations add AspNetIdentityDbInit -c AdminIdentityDbContext -o Data/Migrations/Identity

#sudo dotnet ef migrations add LoggingDbInit -c AdminLogDbContext -o Data/Migrations/Logging

#sudo dotnet ef migrations add IdentityServerConfigurationDbInit -c IdentityServerConfigurationDbContext -o Data/Migrations/IdentityServerConfiguration

#sudo dotnet ef migrations add IdentityServerPersistedGrantsDbInit -c IdentityServerPersistedGrantDbContext -o Data/Migrations/IdentityServerGrants

#cd ../../../

sudo chmod +x ./cert.sh
./cert.sh

HOST_IP=192.168.0.5

STS_PORT=5000
STS_HTTPS_PORT=5001
STS_ADMIN_PORT=9000
STS_ADMIN_HTTPS_PORT=9001

USE_SSL=false


if ${USE_SSL} 
then
        PROTOCOL=https
        STS_SERVER=${PROTOCOL}://${HOST_IP}:${STS_HTTPS_PORT}
        STS_ADMIN_SERVER=${PROTOCOL}://${HOST_IP}:${STS_ADMIN_HTTPS_PORT}
else    
        PROTOCOL=http        
        STS_SERVER=${PROTOCOL}://${HOST_IP}:${STS_PORT}
        STS_ADMIN_SERVER=${PROTOCOL}://${HOST_IP}:${STS_ADMIN_PORT}
fi


# Build images
sudo STS_PORT=${STS_PORT} \
USE_SSL=${USE_SSL} \
STS_HTTPS_PORT=${STS_HTTPS_PORT} \
STS_ADMIN_PORT=${STS_ADMIN_PORT} \
STS_ADMIN_HTTPS_PORT=${STS_ADMIN_HTTPS_PORT} \
STS_SERVER=${STS_SERVER} \
STS_ADMIN_SERVER=${STS_ADMIN_SERVER} \
docker-compose build

# Run the containers
sudo STS_PORT=${STS_PORT} \
USE_SSL=${USE_SSL} \
STS_HTTPS_PORT=${STS_HTTPS_PORT} \
STS_ADMIN_PORT=${STS_ADMIN_PORT} \
STS_ADMIN_HTTPS_PORT=${STS_ADMIN_HTTPS_PORT} \
STS_SERVER=${STS_SERVER} \
STS_ADMIN_SERVER=${STS_ADMIN_SERVER} \
docker-compose up -d

# Open front/admin and swagger for api
xdg-open "${STS_SERVER}" &
xdg-open "${STS_ADMIN_SERVER}"
exit
