# SuperHero Web Site

SuperHero is a web application created to give information about Heroes or Villains from different Comics Universes such as Marvel or DC.

## Prerequisites to Run 
- Visual Studio 
- .Net Framework 4.8

## Installation

Use the package manager Nuget(https://www.nuget.org/packages) to install all dependencies.

```bash
Install-Package Newtonsoft.Json -Version 12.0.2 -ProjectName SuperHero.DataAccess
Install-Package Antlr -Version 3.5.0.2 -ProjectName SuperHero.Web
Install-Package bootstrap -Version 3.4.1 -ProjectName SuperHero.Web
Install-Package jQuery -Version 3.6.0 -ProjectName SuperHero.Web
Install-Package jQuery.Validation -Version 1.19.3 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Mvc -Version 5.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Mvc.es -Version 5.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Razor -Version 3.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Razor.es -Version 3.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Web.Optimization -Version 1.1.3 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.Web.Optimization.es -Version 1.1.3 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.WebPages -Version 3.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.AspNet.WebPages.es -Version 3.2.7 -ProjectName SuperHero.Web
Install-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -Version 2.0.1 -ProjectName SuperHero.Web
Install-Package Microsoft.jQuery.Unobtrusive.Validation -Version 3.2.11 -ProjectName SuperHero.Web
Install-Package Microsoft.Web.Infrastructure -Version 1.0.0.0 -ProjectName SuperHero.Web
Install-Package Modernizr -Version 2.8.3 -ProjectName SuperHero.Web
Install-Package Newtonsoft.Json -Version 12.0.2 -ProjectName SuperHero.Web
Install-Package WebGrease -Version 1.6.0 -ProjectName SuperHero.Web
```

## Usage
Run Project in Visual Studio. 

If the token or connection to the API fails, please access to [API Documentation](https://superheroapi.com/) and generate a new token. 

Values can be changed at .config file inside the settings keys

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.