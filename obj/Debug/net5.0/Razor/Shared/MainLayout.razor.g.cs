#pragma checksum "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac1b0836de5999ee4304fa7b89f8d1c59d8f2481"
// <auto-generated/>
#pragma warning disable 1591
namespace OPdWebApp.Shared
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
#nullable restore
#line 5 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddAttribute(2, "b-ppjar59bcn");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(3);
            __builder.AddAttribute(4, "Position", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 8 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
                              ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Timeout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
                             10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "IconType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 10 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
                              IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(8, "SuccessIcon", "fa fa-thumbs-up");
            __builder.AddAttribute(9, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "logintop-row");
            __builder.AddAttribute(13, "b-ppjar59bcn");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-row");
            __builder.AddAttribute(16, "style", "color:white");
            __builder.AddAttribute(17, "b-ppjar59bcn");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddAttribute(20, "b-ppjar59bcn");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "#");
            __builder.AddAttribute(24, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 20 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                    Home\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddAttribute(30, "b-ppjar59bcn");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "contact");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                    Contact\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddAttribute(39, "b-ppjar59bcn");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "help");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                    Help\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "b-ppjar59bcn");
#nullable restore
#line 46 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
__builder.AddContent(48, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(50);
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(52);
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(54);
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(56);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Shared\MainLayout.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591
