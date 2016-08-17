#!/usr/bin/env bash
frameworkVersion=net45
netfx=${frameworkVersion#net}

wget -nc "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe";
mozroots --import --sync
mono nuget.exe install src/ININ.PureCloudApi/packages.config -o packages -NoCache -Verbosity detailed;
mkdir -p bin;

cp packages/Newtonsoft.Json.9.0.1/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.2.3/lib/net45/RestSharp.dll bin/RestSharp.dll;
cp packages/WebSocketSharp.1.0.3-rc11/lib/websocket-sharp.dll bin/websocket-sharp.dll;

mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
bin/websocket-sharp.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/ININ.PureCloudApi.dll \
-recurse:'src/ININ.PureCloudApi/*.cs' \
-doc:bin/ININ.PureCloudApi.xml \
-platform:anycpu
