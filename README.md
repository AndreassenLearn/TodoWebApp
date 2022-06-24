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

# 1.TodoWebApp

Best�r af en Razor Pages applikation med tilh�rende service-klasse. Data gemmes enten **InMemory** eller i en **Sqlite** database.

`Index` pagen demonstrerer automatisk check af udf�rt opgave vha. **link med indhold i form af en HTML Entity** for hhv. checked og uncheced option kontrol.

`IndexModal` pagen demonstrerer **Bootstraps Modal komponent** og automatisk updatering og **submit med JavaScript** n�r et Todo item markeres som udf�rt.
