# Razor Pages Ef Core Filter Demo

This is a *simple* demo application to showcase
The Predicate Filter Pattern in use with Razor Pages as the UI and EF Core as the DAL

By simple, I mean that the project is not structured with best practices in mind,
but it is structured to best showcase the filter.

## Requirements

* SQL server installed with a localDB instance ready to go (you can edit the connection string in appsettings.json)
* dotnet cli (for making migrations to localDB)

## To run
Just be sure to apply the migrations to your sql server:

(Run the following inside the RazorPagesEFCoreFilterDemo project directory)

`$ dotnet ef database update`

Then run via `$ dotnet run` or just inside visual studio via the run button

## Project Overview

The project is laid out as a typical Razor Pages Application, with the pages defined in /Pages.

For the sake of demonstration of the filter, we are modelling a Zoo that contains Mammals and Reptiles.

The Animal class hierarchy is defined as follows :
* Animal
    * Mammal
        * Canine
        * Primate
    * Reptile
        * Crocodile
        * Turtle
        
(there are more animals in the world of course, but lets keep it simple)

The application consists of the following routes:
* /Animals
* /Animals/Mammals
* /Animals/Reptiles
* /Animals/Mammals/Canines
* /Animals/Mammals/Primates
* /Animals/Reptiles/Crocodiles
* /Animals/Reptiles/Turtles

All of which lead to the same page (/Pages/AnimalList), it displays an overview of all the animals in the zoo.

There is also a /Animal?id=xxx route that will show specific detailed information about a given animal (/Pages/Animal).

By using a more specific route, more specific filters will be applied (/Animals/Mammals will only list all Mammals).

Besides those hierarchical filters, more filters are available as Post Attributes. (e.g a filter for a minimum age, a filter for sex).




