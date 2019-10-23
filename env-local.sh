#!/bin/sh
export PORT=4200
export AppModelConfiguration_ApiName="api1"
export AppModelConfiguration_ImgFolder="images"
export AppModelConfiguration_Authority="http://192.168.0.5:5000"
export AppModelConfiguration_UseAuthority=true
export AppModelConfiguration_CorsOrigins_0=http://localhost:${PORT}
# Set url for api CORS
# export AppModelConfiguration_CorsOrigins_1=http://localhost:8100
# export AppModelConfiguration_CorsOrigins_2=http://localhost:${PORT}
# export AppModelConfiguration_CorsOrigins_3=http://127.0.0.1
# export AppModelConfiguration_CorsOrigins_4=http://192.168.0.5
# export AppModelConfiguration_CorsOrigins_5=http://localhost:4200
# export AppModelConfiguration_CorsOrigins_6=http://localhost:4300

export AppModelConfiguration_RequireHttpsMetadata=false
export AppModelConfiguration_ApiUrl=http://localhost:52050/api/
export AppModelConfiguration_MapKey="your_key"
export AppModelConfiguration_ClientId="tgappmodel"
export AppModelConfiguration_HostServer=http://localhost
export AppModelConfiguration_HostPort=${PORT}

export SmtpConfiguration_DisplayName="Adilson"
export SmtpConfiguration_EnableSsl=false
export SmtpConfiguration_MailAddress="your@mail.addr"
export SmtpConfiguration_Password="your_pass"
export SmtpConfiguration_Port=587
export SmtpConfiguration_Server="your.smtp.server"
export SmtpConfiguration_User="user@smtp.server"

export BingTranslateConfiguration_Key="your_key"
