#pragma checksum "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa6443c06152404f23e1c3486d26facd745ca75"
// <auto-generated/>
#pragma warning disable 1591
namespace Temporizadores.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Temporizadores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Temporizadores.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tetra\source\repos\TemporizadorBlazor\_Imports.razor"
using Temporizadores.Helpers;

#line default
#line hidden
#nullable disable
    public partial class Temporizador : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-4 col-md-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-danger btnOkey temporizador col-11");
            __builder.AddAttribute(5, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor"
                                                                            ()=> { OkeyClick.InvokeAsync(HoraFin); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "oncontextmenu", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor"
                                                                                                                                      ()=>ContextClick.InvokeAsync(HoraFin)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(7, "oncontextmenu", 
#nullable restore
#line 2 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor"
                                                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n           ");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor"
            HoraFin.HoursMinutesString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\Temporizador.razor"
       
    [Parameter] public DateTime HoraFin { get; set; }
    [Parameter] public EventCallback<DateTime> OkeyClick { get; set; }
    [Parameter] public EventCallback<DateTime> ContextClick { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
