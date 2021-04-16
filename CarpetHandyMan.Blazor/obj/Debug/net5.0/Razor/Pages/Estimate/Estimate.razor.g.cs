#pragma checksum "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ba0267c6bfd2e29ef6383b19adcf77c1364ea3"
// <auto-generated/>
#pragma warning disable 1591
namespace CarpetHandyMan.Blazor.Pages.Estimate
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/estimate")]
    public partial class Estimate : EstimateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
 if (Carpets != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
                      (() => ShowAddRoomModal(BuildingId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Add New Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    ");
            __builder.OpenElement(4, "div");
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
         if (Rooms.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
             foreach (var Room in Rooms)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "div");
            __builder.AddContent(7, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
                          Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "div");
            __builder.AddContent(10, "Length: ");
            __builder.AddContent(11, 
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
                                  Room.Length

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "dvi");
            __builder.AddContent(14, "Width: ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
                                 Room.Width

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<div>Add More Rooms for Estimate</div>");
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<span>Loading...</span>");
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Estimate\Estimate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591