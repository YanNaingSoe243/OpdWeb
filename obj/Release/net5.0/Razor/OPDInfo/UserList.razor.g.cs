#pragma checksum "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff59c81bff6dcf64baec925ae307fcae2a53d11a"
// <auto-generated/>
#pragma warning disable 1591
namespace OPdWebApp.OPDInfo
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(OPDLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "topbar");
            __builder.AddAttribute(2, "b-ide8yuwnqj");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "grid-item1");
            __builder.AddAttribute(5, "b-ide8yuwnqj");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "PageSize");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                            ChangePageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "id", "PageSize");
            __builder.AddAttribute(10, "name", "PageSize");
            __builder.AddAttribute(11, "b-ide8yuwnqj");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", "0");
            __builder.AddAttribute(14, "b-ide8yuwnqj");
            __builder.AddContent(15, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "1");
            __builder.AddAttribute(19, "b-ide8yuwnqj");
            __builder.AddContent(20, "Allow");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", "2");
            __builder.AddAttribute(24, "b-ide8yuwnqj");
            __builder.AddContent(25, "NotAllow");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "grid-item2");
            __builder.AddAttribute(29, "b-ide8yuwnqj");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "placeholder", "Search..");
            __builder.AddAttribute(33, "name", "search");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                                       SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(36, "b-ide8yuwnqj");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddMarkupContent(38, "<button class=\"btn btn-info profile-button\" b-ide8yuwnqj><i class=\"oi oi-magnifying-glass\" b-ide8yuwnqj></i></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "opdbottom");
            __builder.AddAttribute(42, "b-ide8yuwnqj");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "padding:5px");
            __builder.AddAttribute(45, "b-ide8yuwnqj");
#nullable restore
#line 27 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
         if (users == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<div class=\"spinner\" b-ide8yuwnqj></div>");
#nullable restore
#line 30 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"

        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "class", "table border");
            __builder.AddAttribute(49, "style", "font-size:14px");
            __builder.AddAttribute(50, "b-ide8yuwnqj");
            __builder.AddMarkupContent(51, @"<thead b-ide8yuwnqj><tr b-ide8yuwnqj><th b-ide8yuwnqj></th>
                        <th b-ide8yuwnqj>Name</th>
                        <th b-ide8yuwnqj>Email</th>
                        <th b-ide8yuwnqj>Password</th>
                        <th b-ide8yuwnqj>RegisterDate</th>
                        <th b-ide8yuwnqj>Staff Role</th>
                        <th b-ide8yuwnqj>department</th>
                        <th b-ide8yuwnqj>Permition</th>
                        <th b-ide8yuwnqj></th></tr></thead>
                ");
            __builder.OpenElement(52, "tbody");
            __builder.AddAttribute(53, "b-ide8yuwnqj");
#nullable restore
#line 50 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                     if (users.Count() > 0)
                    {
                        account = 1;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                     foreach (var objperson in users.Reverse())
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "tr");
            __builder.AddAttribute(55, "b-ide8yuwnqj");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "b-ide8yuwnqj");
#nullable restore
#line 57 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(58, account);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "b-ide8yuwnqj");
#nullable restore
#line 58 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(62, objperson.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "b-ide8yuwnqj");
#nullable restore
#line 59 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(66, objperson.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "b-ide8yuwnqj");
#nullable restore
#line 60 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(70, objperson.ConfirmPassword);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "td");
            __builder.AddAttribute(73, "b-ide8yuwnqj");
#nullable restore
#line 61 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(74, objperson.RegisterDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "b-ide8yuwnqj");
            __builder.OpenElement(78, "select");
            __builder.AddAttribute(79, "class", "form-control");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                                     objperson.role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objperson.role = __value, objperson.role));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(82, "b-ide8yuwnqj");
#nullable restore
#line 66 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                     foreach (StaffRoleEnum obj in Enum.GetValues(typeof(StaffRoleEnum)))
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", 
#nullable restore
#line 68 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                        obj

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(85, "b-ide8yuwnqj");
#nullable restore
#line 68 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(86, obj);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 69 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n                            ");
            __builder.OpenElement(88, "td");
            __builder.AddAttribute(89, "b-ide8yuwnqj");
#nullable restore
#line 76 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                 if (departments.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "select");
            __builder.AddAttribute(91, "class", "form-control");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                                         objperson.department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objperson.department = __value, objperson.department));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(94, "b-ide8yuwnqj");
#nullable restore
#line 80 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                         foreach (Department obj in departments)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "option");
            __builder.AddAttribute(96, "value", 
#nullable restore
#line 82 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                            obj.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(97, "b-ide8yuwnqj");
#nullable restore
#line 82 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(98, obj.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 83 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 86 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(99, objperson.department);

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                         
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "b-ide8yuwnqj");
            __builder.OpenElement(103, "select");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                                     objperson.Permition

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objperson.Permition = __value, objperson.Permition));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(107, "b-ide8yuwnqj");
#nullable restore
#line 95 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                     foreach (PermisionStatus obj in Enum.GetValues(typeof(PermisionStatus)))
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", 
#nullable restore
#line 97 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                        obj

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(110, "b-ide8yuwnqj");
#nullable restore
#line 97 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
__builder.AddContent(111, obj);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 98 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.OpenElement(113, "td");
            __builder.AddAttribute(114, "b-ide8yuwnqj");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "btn-group-sm");
            __builder.AddAttribute(117, "b-ide8yuwnqj");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-warning");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                                                                                e=>EditCharg(objperson)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "b-ide8yuwnqj");
            __builder.AddContent(122, "Allow");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 108 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                        account++;
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 116 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
                   
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "D:\Project\konaymyoag\OPdWebApp\OPdWebApp\OPDInfo\UserList.razor"
       

    [Inject]
    public Blazor.DownloadFileFast.Interfaces.IBlazorDownloadFileService BlazorDownloadFileService { get; set; }
    int account = 1;
    private string error;
    protected IEnumerable<Department> departments { get; set; }
    protected override async Task OnInitializedAsync()
    {

        await load();

    }
    protected async Task ChangePageSize(ChangeEventArgs e)
    {
        int value = Convert.ToInt32(e.Value);
        //await Load();
        if (value == 2)
        {

            users = users.Where(obj => obj.Permition == PermisionStatus.False).ToList();
        }
        else if (value == 1)
        {
            users = users.Where(obj => obj.Permition == PermisionStatus.True).ToList();
        }

        StateHasChanged();

    }

    protected IEnumerable<SiginUp> users { get; set; }
    async Task load()
    {

        // persons = await service.persons.GetAsync(pageindx, pagesize);
        users = await autthenticationservice.UserList();

        departments = await repositoryt.depart.GetAsync();


    }
    private string searchTerm;
    protected string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; Search(); }
    }
    protected async void Search()
    {
        if (searchTerm != "")
        {
            users = users.Where(obj => obj.Email == searchTerm || obj.FullName.Contains(searchTerm)).ToList();
        }
        else
        {
            load();
        }

        StateHasChanged();

    }
    async void EditCharg(SiginUp editdiagnosis)
    {

        try
        {
            error = "";

            var user = await autthenticationservice.Update(editdiagnosis);
            toastService.ShowSuccess("Updated Data ", "Congratulations!");

        }
        catch (Exception ex)
        {
            ;
            error = ex.ToString();
            notificationService.Notify(new NotificationMessage { Style = "position: fixed;bottom: 0px; ", Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = error, Duration = 2000 });
        }

        notificationService.Notify(new NotificationMessage { Style = "position: fixed;bottom: 0px; ", Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = "User Allowed", Duration = 2000 });
        StateHasChanged();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService autthenticationservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositoryT repositoryt { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private QRcode qrcode { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
