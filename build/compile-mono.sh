#!/usr/bin/env bash
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install vendor/packages.config -o vendor;
mkdir -p bin;
mcs -sdk:45 -r:vendor/Newtonsoft.Json.8.0.2/lib/net45/Newtonsoft.Json.dll,\
vendor/RestSharp.105.2.3/lib/net45/RestSharp.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/ININ.PureCloudApi.dll \
-recurse:'src/*.cs' \
-doc:bin/ININ.PureCloudApi.xml \
-platform:anycpu
