1) Create Web.App_Start.NinjectResolver Class and define mappings
2) Define interface in xxxxController to inject
3) In Application_Start  Add DependencyResolver.SetResolver(new App_Start.NinjectResolver());
4) Needs Ninject.MVC package from Nuget