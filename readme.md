# Instalation

Run the commands (docker-compose)  from root folder

## Build the imagens
ex:

```bash
sudo FRONT_PORT=4500 GO_PORT=8085 MS_MONGO_PORT=5050 REDIS_PORT=6379 STS_PORT=5000 STS_ADMIN_PORT=9000 docker-compose build
```

## Run the containers

```bash
sudo FRONT_PORT=4500 GO_PORT=8085 MS_MONGO_PORT=5050 REDIS_PORT=6379 STS_PORT=5000 STS_ADMIN_PORT=9000 docker-compose up -d
```

## install.sh

ALternativelly you can run the install command

```bash
sudo chmod +x ./install.sh

./install.sh
```
# Verificação da instalação

## Admin

http://localhost:4500

Fronend Angular application, responsible to manage the toggles

## Backend (MicroserviceNodeJs - NodeJs)

Microservice responsible to manage crud operations on mongoDB and sync data to redis

### End point to see all toggles on mongoDB

http://localhost:5050/featuretoggle/v1/featuretoggles


## Microservice  (MicroserviceGo - GoLang)
Microservice responsibel to query data on redis

http://localhost:8085/feature

## Identity Server (IdentityServer4.Admin - .net core)
The frontend and back and are protected by [IdentityServer4](https://github.com/IdentityServer/IdentityServer4 "Check this out") and [Skoruba](https://github.com/skoruba/IdentityServer4.Admin "Check this out") to IdentyServer Managment

> **Server** [http://localhost:5000 - Identity Server - Token Issuer ](http://localhost:5000 "Token Issuer")
> **Admin** [http://localhost:9000 - Identity Server - Admin ](http://localhost:9000 "Identity Server - Admin")

### Default credentials for admin
> - **login** "admin";
> - **pass** "Pa$$word123";
> - **email** "admin@example.com";
# Contact


# Contact

## Adilson de Almeida Pedro

[Personal home page - http://adilson.almeidapedro.com.br](http://adilson.almeidapedro.com.br)

[email: adilson@almeidapedro.com.br](mailto:adilson@almeidapedro.com.br)

[LinkeIn https://www.linkedin.com/in/adilsonpedro/](ttps://www.linkedin.com/in/adilsonpedro/)

[Github https://github.com/devremoto](https://github.com/devremoto/featuretoggle)

(11) 9 9353-6732
