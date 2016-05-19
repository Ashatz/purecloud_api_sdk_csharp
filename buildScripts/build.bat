cd %WORKSPACE%\repo\buildScripts
call npm install
cd %WORKSPACE%\repo

node buildScripts\prebuild.js
set /p PACKAGE_VERSION=<bin\VERSION

rmdir /S /Q build
mkdir build

set executable=%WORKSPACE%\swagger-codegen\modules\swagger-codegen-cli\target\swagger-codegen-cli.jar
set JAVA_OPTS=%JAVA_OPTS% -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties

set ags=generate -i swagger.json -l purecloudcsharp -o build -c bin/config-csharp.json  -t swagger_template

call java %JAVA_OPTS% -jar %executable% %ags%

xcopy %WORKSPACE%\repo\Extensions %WORKSPACE%\repo\build\src\ININ.PureCloudApi\Extensions\ /S

cd %WORKSPACE%\repo\build
call build.bat
cd %WORKSPACE%\repo

cp README.md build/docs/index.md
cd %WORKSPACE%\repo\build


IF EXIST newVersion.md call git add .
IF EXIST newVersion.md call git commit -am %PACKAGE_VERSION%
