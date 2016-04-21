cd %WORKSPACE%\repo\buildScripts
call npm install
cd %WORKSPACE%\repo

node buildScripts\prebuild.js
set /p PACKAGE_VERSION=<bin\VERSION

rmdir /S /Q build
mkdir build

set executable=%WORKSPACE%\swagger-codegen\modules\swagger-codegen-cli\target\swagger-codegen-cli.jar
set JAVA_OPTS=%JAVA_OPTS% -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties
<<<<<<< HEAD
set ags=generate -i lib\swagger.json -l csharp -o build -c bin/config-csharp.json -t swagger_template
=======
set ags=generate -i swagger.json -l purecloudcsharp -o build -c bin/config-csharp.json
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

call java %JAVA_OPTS% -jar %executable% %ags%

xcopy %WORKSPACE%\repo\Extensions %WORKSPACE%\repo\build\src\main\csharp\ININ\PureCloudApi\Extensions\ /S

cd %WORKSPACE%\repo\build
call compile.bat
cd %WORKSPACE%\repo

cp README.md build/docs/index.md
cd %WORKSPACE%\repo\build


IF EXIST newVersion.md call git add .
IF EXIST newVersion.md call git commit -am %PACKAGE_VERSION%
