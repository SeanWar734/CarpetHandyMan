#pragma checksum "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f48559690736086a3ce6d182df0c4ec6bf154ef"
// <auto-generated/>
#pragma warning disable 1591
namespace CarpetHandyMan.Blazor.Pages.Installer
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
    public partial class OneInstallerModal : OneInstallerModalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
 if (Installer != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border-2 bg-gray-200 border-gray-700 p-2 m-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white text-3xl font-bold");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
                                                                                           Installer.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
                                                                                                                Installer.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mb-1 border-2 border-gray-700 bg-white text-2xl font-semibold");
            __builder.AddContent(10, "Phone Number: ");
            __builder.AddContent(11, 
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
                                                                                                  Installer.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mb-1 border-2 border-gray-700 bg-white");
            __builder.AddContent(15, "Price per Yard: ");
            __builder.AddContent(16, 
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
                                                                             Installer.SquareYardPrice.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "mb-1 border-2 border-gray-700 bg-white");
            __builder.AddContent(20, "Area Installed: ");
            __builder.AddContent(21, 
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
                                                                             Installer.Area

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<span>Loading...</span>");
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Installer\OneInstallerModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591