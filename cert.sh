#!/bin/sh

:'
##Before run this commands on the terminal
##change the file permitions to allow execution

sudo chmod +x ./install.sh
./install.sh
'
#Generation of ssl certificates#####################################
CERT=cert-aspnetcore
openssl req -config https.config -new -out ${CERT}.csr
openssl x509 -req -days 365 -extfile https.config -extensions v3_req -in ${CERT}.csr -signkey ${CERT}.key -out ${CERT}.crt
openssl pkcs12 -export -out ${CERT}.pfx -inkey ${CERT}.key -in ${CERT}.crt -password pass:ufo
sudo chown -R root:root ./${CERT}.key
sudo chown -R root:root ./${CERT}.csr
sudo chmod 600 ./${CERT}.key
sudo chmod 600 ./${CERT}.csr
sudo cp *.pfx /usr/local/share/ca-certificates/
sudo cp *.crt /usr/local/share/ca-certificates/
sudo cp *.pfx *.pem *.crt ./IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin
sudo cp *.pfx *.pem *.crt ./IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity
sudo update-ca-certificates --fresh
sudo update-ca-certificates
#####################################################################
