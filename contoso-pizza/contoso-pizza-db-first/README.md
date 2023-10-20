# How I generated the code

I used this command inside "Package Manager Console" in order to generate the Models and DbContext for the application:

```

Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation

```

# Flags explained

- ContextDir flag is used to specify the path where the DbContext will be generated;
- OutputDir flag will be the flag for the path where all the models will be created;
- DataAnnotation flag is used to put annotations to the properties of the models.

# A better way of generating code

Because the business logic can be overwritten by the changes made in the database schema,
we can modify the model classes to become **partial**.

An example of command that will help in our ContosoPizza context will be:

```

Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models/Generated -ContextNamespace contoso_pizza_db_first.Data -Namespace contoso_pizza_db_first.Models -DataAnnotation

```

Warning: The symbol '-' will have to become '_' in the namespace.

So, the equivalent namespace of the folder "contoso-pizza-db-first" will be "contoso_pizza_db_first".

# The namespace flags

The flag ContextNamespace will be used to specify the namespace used by the database context.

The Namespace flag is used to set the namespace for the models.
