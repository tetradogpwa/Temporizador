#pragma checksum "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db258793213732d5969215d70b5466fac9b91e37"
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
    public partial class TemporizadorBuilder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-dark btnAddClose offset-1 col-9 ");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<h3 class=\"row\">Nuevo</h3>\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-12");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "text");
            __builder.AddContent(16, "Tiempo ");
            __builder.AddContent(17, 
#nullable restore
#line 8 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                      Time.HoursMinutesString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 10 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
     if (ReferenceTime.IsValid())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-12");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "text");
            __builder.AddContent(25, "  ");
            __builder.AddMarkupContent(26, "<b>Referente</b> ");
            __builder.AddContent(27, 
#nullable restore
#line 13 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                      ReferenceTime.HoursMinutesString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 15 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "btnsIncrements row");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 19 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
     for (int r = 0, i = 0, rF = Rows; r < rF && i < Incrementos.Length; r++)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
         for (int c = 0; c < Columns && i < Incrementos.Length; c++, i++)
        {
            int pos = i;


#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", 
#nullable restore
#line 26 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                            " btn btn-info btnAddTime "+(c==0?"":"offset-1")+" col-3"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                                                                                 ()=> { TotalIncremento += Incrementos[pos];IncrementoAnt = TotalIncremento; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "+");
            __builder.AddContent(40, 
#nullable restore
#line 26 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                                                                                                                                                                  Incrementos[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 27 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
         

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary col-4");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                                        () => { TotalIncremento = 0;IncrementoAnt = 1; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Reset");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-success offset-3 col-4");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
                                                               ()=> {
                                                                   double incremento = TotalIncremento;
                                                                   if(ReferenceTime.IsValid())
                                                                   {
                                                                       incremento += ReferenceTime.TotalMinutes()-DateTime.Now.TotalMinutes();
                                                                   }
                                                                   Created.InvokeAsync((int)incremento);
                                                                   IncrementoAnt = 1;
                                                               }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n        Crear\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\tetra\source\repos\TemporizadorBlazor\Shared\TemporizadorBuilder.razor"
       

        static int IncrementoAnt = 1;
        int[] Incrementos { get; set; } = { 1, 5, 10, 15, 30, 60 };

        int TotalIncremento { get; set; } = IncrementoAnt > 0 ? IncrementoAnt - 1 : 0;

        [Parameter] public int Columns { get; set; } = 3;
        [Parameter] public EventCallback<int> Created { get; set; }
        [Parameter] public EventCallback Close { get; set; }
        [Parameter] public DateTime ReferenceTime { get; set; } = default(DateTime);

        int Rows => Incrementos.Length % Columns == 0 ? Incrementos.Length / Columns : (Incrementos.Length / Columns) + 1;
        int Hours => TotalIncremento / 60;
        int Minutes => TotalIncremento % 60;
        DateTime Time => new DateTime((TimeSpan.FromHours(Hours) + TimeSpan.FromMinutes(Minutes)).Ticks);




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591