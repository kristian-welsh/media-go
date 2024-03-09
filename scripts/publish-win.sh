# restore is a compilation stage that looks online for build chain tools
# --no-restore is an argument to dotnet commands that disables the restore stage

sourcepath="bin/Release/net8.0/win-x64"
targetpath="/mnt/c/Users/admin/Desktop/hello-dotnet"

cd ../HelloDotnetThree

dotnet publish --no-restore --runtime win-x64 --configuration Release -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true
rm $targetpath/publish/* 2>/dev/null; rm -rf $targetpath/*
cp -r $sourcepath/* $targetpath/; cp $targetpath/glfw3.dll $targetpath/publish/
