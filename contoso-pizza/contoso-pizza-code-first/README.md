# How I generated the database

I used those commands inside "Package Manager Console" in order to generate the Tables inside the database:

```

Add-Migration InitialCreate
Update-Database

```

# Commands explained

- Add-Migration command generates the code that will add the changes to the database;
- Update-Database will execute the code from the migration in order to create or modify the database.
