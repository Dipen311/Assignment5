// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
