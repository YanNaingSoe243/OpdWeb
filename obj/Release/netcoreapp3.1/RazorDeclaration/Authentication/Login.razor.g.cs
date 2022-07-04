// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OPdWebApp.Authentication
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\Authentication\Login.razor"
       
    SiginModel siginmodel { get; set; }
    // LoginResult User { get; set; }
    protected override async Task OnInitializedAsync()
    {
        siginmodel = new SiginModel();
        //  User = new LoginResult();
    }

    private string error;
    private async void LoginAccount()
    {



        try
        {
            LoginResult User = await AuthenticationService.Login(siginmodel);
            if (User.jwtBearer != null && User.jwtBearer != "")
            {
              
                await Task.Run(() => { UriHelper.NavigateTo("opdpage"); });
            }
            else
            {
                error = "Email and Password are  Not Match....";
                notificationService.Notify(new NotificationMessage { Style = "position: fixed;bottom: 0px; ", Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = error, Duration = 2000 });
            }

        }
        catch (Exception ex)
        {
            error = ex.Message;
            notificationService.Notify(new NotificationMessage { Style = "position: fixed;bottom: 0px; ", Severity = NotificationSeverity.Error, Summary = "Error Summary", Detail =error, Duration = 2000 });

        }
        //StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
