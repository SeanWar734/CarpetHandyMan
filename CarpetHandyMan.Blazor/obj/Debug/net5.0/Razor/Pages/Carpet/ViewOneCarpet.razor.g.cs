#pragma checksum "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4011c80f6f6c58a78833b85ad8947206873c42fc"
// <auto-generated/>
#pragma warning disable 1591
namespace CarpetHandyMan.Blazor.Pages.Carpet
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using CarpetHandyMan.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using CarpetHandyMan.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class ViewOneCarpet : ViewOneCarpetBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
 if (Carpet != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
              Carpet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
              Carpet.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
              Carpet.Style

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
              Carpet.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
              Carpet.SquareYardPrice.ToString("$#.##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    <br>");
#nullable restore
#line 13 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<span>Loading...</span>");
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Carpet\ViewOneCarpet.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591