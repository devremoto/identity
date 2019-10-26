@echo off
call pre.bat
rem  Build images
docker-compose --file docker-compose-run.yml build ^
--build-arg HOST_IP=%HOST_IP% ^
--build-arg STS_PORT=%STS_PORT% ^
--build-arg USE_SSL=%USE_SSL% ^
--build-arg STS_HTTPS_PORT=%STS_HTTPS_PORT% ^
--build-arg STS_ADMIN_PORT=%STS_ADMIN_PORT% ^
--build-arg STS_ADMIN_HTTPS_PORT=%STS_ADMIN_HTTPS_PORT% ^
--build-arg STS_SERVER=%STS_SERVER% ^
--build-arg STS_ADMIN_SERVER=%STS_ADMIN_SERVER% 

rem  Run the containers
docker-compose --file docker-compose-run.yml up --remove-orphans -d