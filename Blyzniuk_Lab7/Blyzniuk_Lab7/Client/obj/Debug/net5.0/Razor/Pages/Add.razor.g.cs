#pragma checksum "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1eb3fff189cba5ec9f89a5a37844948fc9f1a94"
// <auto-generated/>
#pragma warning disable 1591
namespace Blyzniuk_Lab7.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Blyzniuk_Lab7.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Blyzniuk_Lab7.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MVS\Repos\Blyzniuk_Lab7\Client\_Imports.razor"
using Blyzniuk_Lab7.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "form", "Name");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "required");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor"
                                                                city.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.Name = __value, city.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Code\" class=\"control-label\">Code</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "Code");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "required");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor"
                                                                city.Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.Code = __value, city.Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label for=\"Rate\" class=\"control-label\">Rate</label>\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "form", "Rate");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "required");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor"
                                                                city.Rate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.Rate = __value, city.Rate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-4");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor"
                                                                        Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "value", "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Add.razor"
       
    City city = new City();
    protected async void Save()
    {
        await client.PostAsJsonAsync<City>("api/city", city);
        navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
