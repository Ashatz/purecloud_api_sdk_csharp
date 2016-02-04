cd %WORKSPACE%\repo\buildScripts
call npm install
cd %WORKSPACE%\repo

node buildScripts\prebuild.js

rmdir /S /Q build
mkdir build

REM set executable=bin\swagger-codegen-cli.jar
set executable=lib\swagger-codegen-cli.jar
set JAVA_OPTS=%JAVA_OPTS% -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties
set ags=generate -i lib\swagger.json -l csharp -o build -c bin/config-csharp.json

call java %JAVA_OPTS% -jar %executable% %ags%

cd %WORKSPACE%\repo\build
call compile.bat
cd %WORKSPACE%\repo

call git add .
call git commit -am %version%