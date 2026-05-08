# MoviesAPI

## Köra projektet

1. Starta PostgreSQL i Docker.
2. Öppna projektet i Visual Studio eller terminal.
3. Kör migrationerna med:

dotnet ef database update

4. Starta projektet med:

dotnet run

eller via Visual Studio.

## Seed av databasen

Seed-data finns definierad i `AppDbContext.cs` med `HasData(...)`.

När databasen skapas eller uppdateras med migrationen via `dotnet ef database update` läggs seed-data in automatiskt.

## Swagger

När projektet startar visas adressen i terminalen.

Swagger nås via `/swagger`, till exempel: https://localhost:7181/swagger