# Entity Framework Migration Commands

This document outlines the common Entity Framework Core CLI commands used to manage database migrations in the `Tickify` project.

## 1. Update Database

Applies any pending migrations to the database:

```bash
dotnet ef database update --project Tickify.Database --startup-project Tickify.Api --context TickifyDatabaseContext
```

**Explanation:**
- `--project Tickify.Database`: Specifies the project containing the DbContext and migration files.
- `--startup-project Tickify.Api`: Specifies the startup project containing configuration, typically the API or application layer.
- `--context TickifyDatabaseContext`: Specifies which DbContext to use, useful when multiple contexts exist.

## 2. Add Migration

Generates a new migration based on the changes made to the models:

```bash
dotnet ef migrations add "Initial" --project Tickify.Database --startup-project Tickify.Api
```

**Explanation:**
- `"Initial"`: Name of the migration, typically describing the changes being introduced.
- `--project` and `--startup-project`: Same as described above.

## 3. Remove Last Migration

Removes the last migration if it hasn't been applied yet:

```bash
dotnet ef migrations remove --project Tickify.Database --startup-project Tickify.Api
```

**Explanation:**
- Useful for rolling back uncommitted migration changes.
- `--project` and `--startup-project`: Same as described above.

## Notes

- Always ensure your project builds successfully before running migrations.
- After applying migrations, verify changes by checking your database schema.

