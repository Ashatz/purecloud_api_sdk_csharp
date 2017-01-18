cd $REPO

# Get version string
PACKAGE_VERSION=`cat bin/VERSION`-prerelease
echo $PACKAGE_VERSION

# Make nuspec
node buildScripts/makeNuget.js prerelease

# Pack nuspec
mono nuget.exe pack build/bin/PureCloudApiSdk.nuspec -Verbosity detailed

# --WORKAROUND--
# There is an issue with mono/nuget and the nupkg file. Probably this: https://github.com/NuGet/Home/issues/2833
# This workaround simply unzips the nupkg file and rezips it. I think this makes it use '/' instead of '\'.
mkdir package
unzip PureCloudApiSdk.$PACKAGE_VERSION.nupkg -d package
cd package
zip -r PureCloudApiSdk.$PACKAGE_VERSION.repack.nupkg *
cd $WORKSPACE/repo
cp package/PureCloudApiSdk.$PACKAGE_VERSION.repack.nupkg PureCloudApiSdk.$PACKAGE_VERSION.repack.nupkg

# Publish to nuget
mono nuget.exe push PureCloudApiSdk.$PACKAGE_VERSION.repack.nupkg $NUGET_API_KEY -source "https://www.nuget.org" -Verbosity detailed