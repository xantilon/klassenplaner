# Klassenplaner

Stundenplan abtippen? Schon wieder?! Jedes Halbjahr der gleiche Mist. 

**Warum kann das nicht EINER aus der Klasse FÜR ALLE übernehmen?** 

**HALT! Das geht mit Klassenplaner!**

 Einer aus der Klasse tippt den Stundenplan ein und alle anderen profitieren von seiner/ihrer Arbeit. Individuelle Einträge (*"Hey, da hab ich doch AG"*) sind natürlich auch möglich.
 
 So erhält jeder mit minimalem Aufwand einen Stundenplan online im Browser oder auf dem Handy und als Ausdruck.


 # Version v0.0.0.0001

``` mermaid
graph TB
    subgraph Client
        Browser["Web Browsers"]:::client
        Desktop["Desktop"]:::client
        Mobile["Mobile"]:::client
        Browser --> Desktop
        Browser --> Mobile
        
        StaticAssets["Static Assets"]:::client
        click StaticAssets "https://github.com/xantilon/klassenplaner/tree/master/Klassenplaner/wwwroot"
        
        ClientLibs["Client Libraries"]:::client
        Bootstrap["Bootstrap"]:::client
        click Bootstrap "https://github.com/xantilon/klassenplaner/tree/master/Klassenplaner/wwwroot/lib/bootstrap"
        jQuery["jQuery"]:::client
        click jQuery "https://github.com/xantilon/klassenplaner/tree/master/Klassenplaner/wwwroot/lib/jquery"
        jQueryVal["jQuery Validation"]:::client
        click jQueryVal "https://github.com/xantilon/klassenplaner/tree/master/Klassenplaner/wwwroot/lib/jquery-validation"
        
        CustomAssets["Custom Assets"]:::client
        CustomCSS["Custom CSS"]:::client
        click CustomCSS "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/wwwroot/css/site.css"
        CustomJS["Custom JavaScript"]:::client
        click CustomJS "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/wwwroot/js/site.js"
        
        ClientLibs --> Bootstrap
        ClientLibs --> jQuery
        ClientLibs --> jQueryVal
        
        CustomAssets --> CustomCSS
        CustomAssets --> CustomJS
        
        StaticAssets --> ClientLibs
        StaticAssets --> CustomAssets
    end
    
    subgraph Application
        CoreComponents["Core Components"]:::app
        Program["Program Entry"]:::app
        click Program "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Program.cs"
        Startup["Application Config"]:::app
        click Startup "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Startup.cs"
        Settings["Settings"]:::app
        click Settings "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/appsettings.json"
        
        CoreComponents --> Program
        CoreComponents --> Startup
        CoreComponents --> Settings
        
        RazorPages["Razor Pages"]:::app
        click RazorPages "https://github.com/xantilon/klassenplaner/tree/master/Klassenplaner/Pages"
        Index["Index Page"]:::app
        click Index "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Index.cshtml"
        About["About Page"]:::app
        click About "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/About.cshtml"
        Contact["Contact Page"]:::app
        click Contact "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Contact.cshtml"
        Privacy["Privacy Page"]:::app
        click Privacy "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Privacy.cshtml"
        
        RazorPages --> Index
        RazorPages --> About
        RazorPages --> Contact
        RazorPages --> Privacy
        
        SharedComponents["Shared Components"]:::app
        Layout["Layout"]:::app
        click Layout "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Shared/_Layout.cshtml"
        LoginPartial["Login Partial"]:::app
        click LoginPartial "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Shared/_LoginPartial.cshtml"
        CookieConsent["Cookie Consent"]:::app
        click CookieConsent "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Pages/Shared/_CookieConsentPartial.cshtml"
        
        SharedComponents --> Layout
        SharedComponents --> LoginPartial
        SharedComponents --> CookieConsent
        
        AppInsights["Application Insights"]:::monitoring
        click AppInsights "https://github.com/xantilon/klassenplaner/blob/master/Klassenplaner/Connected Services/Application Insights/ConnectedService.json"
    end
    
    subgraph Data
        Storage["Data Storage"]:::data
        Schedules["Schedules"]:::data
        UserData["User Data"]:::data
        
        Storage --> Schedules
        Storage --> UserData
    end
    
    Browser --> StaticAssets
    Browser --> RazorPages
    RazorPages --> SharedComponents
    RazorPages --> Storage
    CoreComponents --> AppInsights
    
    classDef client fill:#3498db,stroke:#2980b9,color:#fff
    classDef app fill:#2ecc71,stroke:#27ae60,color:#fff
    classDef data fill:#e67e22,stroke:#d35400,color:#fff
    classDef monitoring fill:#95a5a6,stroke:#7f8c8d,color:#fff
    ```
 
