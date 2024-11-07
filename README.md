# PetStoreApi

## Setup

- install ef cli tool `dotnet tool install --global dotnet-ef`
- run `dotnet-ef database update` to apply migrations
- run `dotnet run` to start the app

## Migrations

- create new migrations with `dotnet-ef migrations add <migration name>`

## Services

- register new services/repositories in Program.cs with `builder.Services.AddScoped<IAnimalService, AnimalService>();`