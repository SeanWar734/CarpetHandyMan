#pragma checksum "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c42a96391835f6a522ce2669192f2ca35c1a835"
// <auto-generated/>
#pragma warning disable 1591
namespace CarpetHandyMan.Blazor.Pages.Retailer
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
    public partial class AddRetailerModal : AddRetailerModalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
 if (Retailer != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                     Retailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                              (() => AddNewRetailerAsync(Retailer))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "rounded-md border-2 border-gray-700 bg-gray-200 p-2");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(10, "<div>Comapany Name</div>\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "style", "width: 100%");
                __builder2.AddAttribute(15, "placeholder", "Enter Company Name...");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                    Retailer.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.CompanyName = __value, Retailer.CompanyName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.CompanyName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(22, "<div>Description</div>\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "style", "width: 100%");
                __builder2.AddAttribute(27, "placeholder", "Enter Company Description...");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                           Retailer.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.Description = __value, Retailer.Description))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(34, "<div>Phone Number</div>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "style", "width: 100%");
                __builder2.AddAttribute(39, "placeholder", "Enter Company Phone Number...");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                            Retailer.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.PhoneNumber = __value, Retailer.PhoneNumber))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(46, "<div>Address Line 1</div>\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "style", "width: 100%");
                __builder2.AddAttribute(51, "placeholder", "Enter Company Address...");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                       Retailer.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.Address = __value, Retailer.Address))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.Address));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(58, "<div>City</div>\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "style", "width: 100%");
                __builder2.AddAttribute(63, "placeholder", "Enter Company City...");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                    Retailer.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.City = __value, Retailer.City))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "mb-1 rounded-md border-2 border-gray-700 bg-white p-2");
                __builder2.AddMarkupContent(70, "<div>State</div>\r\n                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "border-black border-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "style", "width: 100%");
                __builder2.AddAttribute(75, "placeholder", "Enter Company State...");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
                                                                                                     Retailer.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Retailer.State = __value, Retailer.State))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Retailer.State));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.AddMarkupContent(80, "<button type=\"submit\">Add</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<span>Loading...</span>");
#nullable restore
#line 52 "C:\Users\swarchuck\source\repos\CarpetHandyMan\CarpetHandyMan.Blazor\Pages\Retailer\AddRetailerModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
