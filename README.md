Repo for reperoducing the problem with Grpc compiled with CoreRT/NativeAOT.

# Prerequisites
Net Core 3.1 SDK

# Reproducing the crush
```
git clone https://github.com/RomanoffSoft/grpc_helloworld_native_crush.git
cd grpc_helloworld_native_crush/src/GreeterServer
dotnet publish -c Debug -r win-x64
cd bin/Debug/netcoreapp3.1/win-x64/publish/
GreeterServer.exe
```

Same applies to GreeterClient

