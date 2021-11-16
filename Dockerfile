FROM mcr.microsoft.com/dotnet/aspnet:5.0
LABEL version="1.0.2" description="Aplicacao ASP .NET Core MVC e Mysql"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]
