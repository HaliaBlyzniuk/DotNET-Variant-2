// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blyzniuk_Lab6.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Blyzniuk_Lab6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Blyzniuk_Lab6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Blyzniuk_Lab6.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\MVS\Repos\Blyzniuk_Lab6\_Imports.razor"
using Blyzniuk_Lab6.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "E:\MVS\Repos\Blyzniuk_Lab6\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591