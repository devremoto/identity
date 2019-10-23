#!/bin/sh
: '
#Before run this commands on the terminal
#change the file permitions to allow execution

sudo chmod +x ./docker-run.sh
./docker-run.sh
'

#docker network create ft-network
HOST_IP_FALLBACK=192.168.0.5
HOST_IP=`ip -4 addr show scope global dev docker0 | grep inet | awk '{print \$2}' | cut -d / -f 1`
FRONT_PORT=4500
GO_PORT=8085
MS_MONGO_PORT=5050
REDIS_PORT=6379
STS_PORT=5000
STS_HTTPS_PORT=5001
STS_ADMIN_PORT=9000
STS_ADMIN_HTTPS_PORT=9001
STS_SERVER=http://$HOST_IP
STS_ADMIN_SERVER=http://$HOST_IP



sudo FRONT_PORT=$FRONT_PORT \
GO_PORT=$GO_PORT \
MS_MONGO_PORT=$MS_MONGO_PORT \
REDIS_PORT=$REDIS_PORT \
STS_PORT=$STS_PORT \
STS_HTTPS_PORT=$STS_HTTPS_PORT \
STS_ADMIN_PORT=$STS_ADMIN_PORT \
STS_ADMIN_HTTPS_PORT=$STS_ADMIN_HTTPS_PORT \
STS_SERVER=$STS_SERVER \
STS_ADMIN_SERVER=$STS_ADMIN_SERVER \
docker-compose -f docker-compose.yml up -d

cd admin/frontend
sleep 2
xdg-open "http://${HOST_IP}:${FRONT_PORT}"
