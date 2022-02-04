FROM mcr.microsoft.com/dotnet/runtime:6.0
COPY bin/Release/net6.0/publish/ App/
WORKDIR /App
EXPOSE 50551 50552
ENTRYPOINT ["dotnet", "proxy.dll"]