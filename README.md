Instalacja trzech bibliotek:
--> Microsoft.EntityFrameworkCore 
--> Microsoft.EntityFrameworkCore.SqlServer
--> Microsoft.EntityFrameworkCore.Design

Wykonanie komend (koniecznie w folderze projektu):
--> dotnet new tool-manifest
--> dotnet tool install dotnet-ef
--> dotnet tool list

Tworzenie Migracji
--> dotnet ef migrations add (NAZWA MIGRACJI)
--> dotnet ef database update


"ConnectionStrings": {
    "DbConnString": "Data Source=db-mssql.pjwstk.edu.pl;Initial Catalog=2019SBD;Integrated Security=True;TrustServerCertificate=True"
  }
