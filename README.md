# NovaConcept Admin API

**Monorepo** for NovaConcept CMS - Core Domain + Infrastructure + Admin REST API + Shared Packages

---

## 📦 Structure

- **Core.Domain** - Domain entities, value objects
- **Core.Application** - Use cases, DTOs, services
- **Infrastructure.Persistence** - EF Core, migrations
- **Infrastructure.Persistence.Legacy** - Legacy DB scaffold
- **Admin.Api** - ASP.NET Core Web API
- **Shared.Contracts** - NuGet package (interfaces, DTOs)
- **Shared.Data** - NuGet package (PublicDbContext)

---

## 🚀 Quick Start

```bash
dotnet restore
dotnet build
cd src/Admin.Api
dotnet run
```

API: https://localhost:5001
Swagger: https://localhost:5001/swagger

---

**Tech:** ASP.NET Core 8.0, EF Core 8.0, C# 12
