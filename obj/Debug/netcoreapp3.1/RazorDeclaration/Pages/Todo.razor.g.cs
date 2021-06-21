// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programiranje tutoriali\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Programiranje tutoriali\BlazorApp\Pages\Todo.razor"
       
private List<TodoItem> todos = new List<TodoItem>();
private string newTodo;
private int currentID = 1;
    private void AddTodo(){
        //Todo : Add the todo
        if(!string.IsNullOrWhiteSpace(newTodo)){
            todos.Add(new TodoItem {Title = newTodo, ID = currentID});
            newTodo = string.Empty;
            incrementID();
        }
    }
    private void incrementID(){
        currentID = currentID +1;
    }
    private void decrementID(){
        currentID = currentID -1;
    }
    private void RemoveTodo(TodoItem selectedItem){
        todos.RemoveAt(todos.ToList<TodoItem>().FindIndex(element => element.ID == selectedItem.ID));
        decrementID();
    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
