# Portfolio
Clean Architecture example for a Dasaboard Web App

### Identity Migrations
****
### Execution for Initial snapshot
```console
cd Portfolio.Infrastructure.Identity
```

```console
dotnet ef migrations add InitialIdenity --context PortfolioIdentityDbContext --project Portfolio.Infrastructure.Identity.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF
```console
dotnet ef database update --context PortfolioIdentityDbContext --project Portfolio.Infrastructure.Identity.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --verbose
```




### Migrations

```console 
cd Portfolio.Infrastructure.Persistence
```

```console
dotnet ef migrations add InitialModel --context PortfolioDbContext --project Portfolio.Infrastructure.Persistence.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF

```console
dotnet ef database update --context PortfolioDbContext --project Portfolio.Infrastructure.Persistence.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --verbose
```



