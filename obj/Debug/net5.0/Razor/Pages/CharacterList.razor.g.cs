#pragma checksum "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828c2ff969c3f8ab64c2f5f19cd4d3b05e21491d"
// <auto-generated/>
#pragma warning disable 1591
namespace AssignmentSampleBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using AssignmentSampleBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\_Imports.razor"
using AssignmentSampleBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CharacterList")]
    public partial class CharacterList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Charaters </h1>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Enter Charater Name");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                                                newName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newName = __value, newName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Enter Charater Age");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                                               age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "placeholder", "Enter Charater Profession");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                                                      profession

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => profession = __value, profession));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "checkbox");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                              isFric

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => isFric = __value, isFric));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Add todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "id", "customers");
            __builder.AddMarkupContent(27, "<tr><th>Name</th>\r\n                <th>Age</th>\r\n                <th>Profession</th>\r\n                <th>Frictional or Real</th></tr>");
#nullable restore
#line 17 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
         foreach (var todo in todos){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 19 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                     todo.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 20 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                     todo.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 21 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                     todo.Profession

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                 if(@todo.IsFictional == false){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<td>Real Charater</td>");
#nullable restore
#line 24 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                }else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<td>Frictional Charater</td>");
#nullable restore
#line 26 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\as5\AssignmentSampleBlazorApp\AssignmentSampleBlazorApp\Pages\CharacterList.razor"
       
    private List<Character> todos = new List<Character>{
        new Character{Name = "Robert", IsFictional = true,Profession="Iron Man",Age=50},
        new Character{Name = "Chris Hemsworth", IsFictional = true,Profession="Captain America",Age=37},
        new Character{Name = "Tom", IsFictional = false,Profession="Actor",Age=52},
        new Character{Name = "Vin Disel", IsFictional = false,Profession="Actor",Age=45},
        new Character{Name = "Paul Walker", IsFictional = false,Profession="Actor",Age=35}
        };
    private string newName;
    private string profession;
    private int age;
    private bool isFric;

    
    
    
    private void AddTodo()
    {   
     
        if (!string.IsNullOrWhiteSpace(newName) &&  !string.IsNullOrWhiteSpace(profession))
        {
            todos.Add(new Character { Name = newName, IsFictional = isFric, Profession = profession, Age = age });
          
            newName = string.Empty;
        }
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
