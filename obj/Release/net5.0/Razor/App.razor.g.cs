#pragma checksum "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "289b007a6d8b0966df20fac2ba0bb446ee06673f"
// <auto-generated/>
#pragma warning disable 1591
namespace OPdWebApp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp.OPDInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp.ExprotService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using OPdWebApp.BarCodeReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 13 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 15 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 15 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 18 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\App.razor"
          
            // redirect to home page if not found
            NavigationManager.NavigateTo("");
        

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
