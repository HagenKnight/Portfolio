# Portfolio
Clean Architecture example for a Dasaboard Web App


### Migrations

```console
dotnet ef migrations add InitialModel --context PortfolioDbContext --project ../Portfolio.Infrastructure.Persistence/Portfolio.Infrastructure.Persistence.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF

```console
dotnet ef database update --context PortfolioDbContext --project ../Portfolio.Infrastructure.Persistence/Portfolio.Infrastructure.Persistence.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --verbose
```


### Identity Migrations

### Execution for Initial snapshot
```console
dotnet ef migrations add InitialIdenity --context PortfolioIdentityDbContext --project ../Portfolio.Identity/Portfolio.Identity.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF
```console
dotnet ef database update --context PortfolioIdentityDbContext --project ../Portfolio.Identity/Portfolio.Identity.csproj --startup-project ../Portfolio.Api/Portfolio.Api.csproj --verbose
```

