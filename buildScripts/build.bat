set version=1.0.0.%BUILD_NUMBER%

cd buildScripts
call npm install
cd %WORKSPACE%

node buildScripts/prebuild.js /version=%version%

rmdir /S /Q build
mkdir build

REM set executable=bin/swagger-codegen-cli.jar
set executable=lib/swagger-codegen-cli.jar
set JAVA_OPTS=%JAVA_OPTS% -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties
set ags=generate -i https://public-api.us-east-1.inindca.com/api/v1/docs/swagger -l csharp -o build -c bin/config-csharp.json

call java %JAVA_OPTS% -jar %executable% %ags%

cd build
call compile.bat
cd %WORKSPACE%

call git add .
call git commit -am %version%

node buildScripts/createRelease.js /version=%version% /token=f2d302ca7fd76c0d1c3e18f5b812af2cba029e60 