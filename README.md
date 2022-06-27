# Todo projektet

## Beskrivelse

TodoWebApp er en ASP.NET Core Razor Pages web applikation, som giver mulighed for at vise en liste af 
Todo items, samt at markere et Todo item som udf�rt ved at klikke p� det. Man kan ogs� oprette et nyt Todo item,
enten via en ny Razor Page form eller via en Modal pop-up. Der er validation alle steder. Desuden kan man klikke
p� Todo navnet og redigere det enkelte item. Det er ogs� muligt at slette det helt.

Default pagen viser alle items, b�de de udf�rte og de ikke-udf�rte. DefaultModal viser kun dem, der mangler at blive udf�rt.

Der er mulighed for at benytte InMemory eller Sqlite databasen.

> ### Oversigt over Branches
> 
> #### 1.TodoWebApp
> 
> Razor Pages, CheckBox, InMemory DB og Sqlite DB
> 
> #### 2.RazorPages_DAL_xUnitTest
> 
> Unit test af TodoService med InMemory database samt af PageModel i RazorPages
> 
> #### 3.WebApp_SeleniumTest
> 
> UI test af WebApp.


&nbsp;

# 1.TodoWebApp_xUnitTest_

https://www.thereformedprogrammer.net/new-features-for-unit-testing-your-entity-framework-core-5-code/

https://github.com/jonpsmith/efcore.testsupport

https://docs.microsoft.com/en-us/ef/core/testing/testing-without-the-database

Tilf�j et **xUnit** test project kaldet `TodoWebApp.UnitTest` til solution, se evt. [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/visual-studio)

Opret reference fra Test projetet til TodoWebApp.

Det foruds�ttes at TodoWebApp projektet er sat op til at benytte InMemory databasen.

Husk at fjerne seeding af data i Contexten.

Ref.: [Razor Pages unit tests in ASP.NET Core](https://docs.microsoft.com/da-dk/aspnet/core/test/razor-pages-tests?view=aspnetcore-5.0)

Opret static `Utillity` klassen, som vha. den statiske metode `TestDbContextOptions()` returnerer et `DbContextOptions` objekt.
Dette sikrer at contexten er ny hver gang en ny test eksekveres.

Der oprettes f�lgende tests:

### TodoServiceUnitTest

`TodoServiceUnitTest` klassen demonstrerer Unit Test af hovedsageligt **ServiceLayer**, eftersom databasen er *InMemory* og derfor
ikke fungerer helt som en "rigtig" SQL server.

### IndexPageTests

`IndexPageTests` klassen demonstrerer Unit Test af hovedsageligt **PageModel** og dens GET/POST metoder. Da disse metoder som regel er meget "tynde", vil 
v�rdien af Page-test v�re begr�nset.