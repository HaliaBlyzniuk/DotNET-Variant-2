#pragma checksum "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8229826f7717e0b7d83fff899caeaab3a4830e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cities</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "add");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\" aria-hidden=\"true\">Add new city</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 10 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
 if (Cities is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading... !</em></p>");
#nullable restore
#line 12 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Name</th>\r\n                <th>Code</th>\r\n                <th>Rate</th>\r\n                <th>Options</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 25 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
             foreach (var city in Cities)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 28 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
                     city.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
                     city.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 30 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
                     city.Rate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "nav-link");
            __builder.AddAttribute(24, "href", "edit/" + (
#nullable restore
#line 32 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
                                                    city.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<span class=\"oi oi-pencil\" aria-hidden=\"true\">Edit</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "href", "delete/" + (
#nullable restore
#line 35 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
                                                      city.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<span class=\"oi oi-trash\" aria-hidden=\"true\">Delete</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Index.razor"
       
    List<City> Cities { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Cities = await client.GetFromJsonAsync<List<City>>("api/city");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591