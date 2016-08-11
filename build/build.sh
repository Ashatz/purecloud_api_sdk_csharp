#!/usr/bin/env bash
frameworkVersion=net45
netfx=${frameworkVersion#net}

wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install src/ININ.PureCloudApi/packages.config -o packages;
mkdir -p bin;

cp packages/Newtonsoft.Json.9.0.1/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.2.3/lib/net45/RestSharp.dll bin/RestSharp.dll;

mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/ININ.PureCloudApi.dll \
-recurse:'src/ININ.PureCloudApi/*.cs' \
-doc:bin/ININ.PureCloudApi.xml \
-platform:anycpu