// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit/{id}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\MVS\Repos\Blyzniuk_Lab7\Client\Pages\Edit.razor"
       
    [Parameter]
    public string id { get; set; }
    City city = new City();
    protected override async Task OnInitializedAsync() {
        city = await client.GetFromJsonAsync<City>($"api/city/{id}");
    }

    protected async void Update() {
        await client.PutAsJsonAsync<City>("api/city", city);
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