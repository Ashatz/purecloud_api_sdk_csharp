# Set up node
echo $REPO
cd $REPO/buildScripts
npm install
cd $REPO

# Execute prebuild script
node buildScripts/prebuild.js

# Get version string
PACKAGE_VERSION=`cat bin/VERSION`
echo $PACKAGE_VERSION

# Clear build directory
rm -rf build
mkdir build

# Configuration
executable="$WORKSPACE/swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar"
JAVA_OPTS="$JAVA_OPTS -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties"
ags="generate -i swagger.json -l purecloudcsharp -o build -c bin/config-csharp.json -t swagger_template"

# Generate SDK source
java $JAVA_OPTS -jar $executable $ags

# Copy extra files in
cp -r $REPO/Extensions $REPO/build/src/ININ.PureCloudApi/Extensions

# Compile module
cd $REPO/build
source $REPO/build/build.sh

# ZIP docs
cp $REPO/README.md $REPO/build/docs/index.md
zip -r ${WORKSPACE}/doc.zip docs/*

# Conditionally commit
cd $REPO
if [ -f "$REPO/newVersion.md" ]
then
	echo "Adding to commit"
	git add .
	git commit -am $PACKAGE_VERSION
else
	echo "No new version, nothing to push"
fi
