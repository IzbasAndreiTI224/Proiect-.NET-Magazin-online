# Folosește imaginea oficială ASP.NET Framework 4.8
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8

# Setează directorul de lucru
WORKDIR /inetpub/wwwroot

# Copiază fișierele aplicației în container
COPY . .

# Expune portul 80
EXPOSE 80

# Pornește IIS
CMD ["cmd", "/c", "start", "w3svc"]
