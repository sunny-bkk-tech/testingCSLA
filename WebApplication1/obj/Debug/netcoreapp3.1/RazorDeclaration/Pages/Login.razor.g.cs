#pragma checksum "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d0f9bfad3a69eca54ef3a9c386c0a5838c614c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/Pages/Login.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/Pages/Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/sunny-dev/Documents/testingCSLA/WebApplication1/Pages/Login.razor"
       
  private UserCredentials Credentials { get; set; } = new UserCredentials();
  private string ErrorText { get; set; }

  private async void LoginUser()
  {
    ErrorText = string.Empty;
    try
    {
      var userinfo = await Http.PostJsonAsync<UserIdentity>("Authentication", Credentials);
      if (userinfo.IsAuthenticated)
      {
        var identity = new ClaimsIdentity(userinfo.AuthenticationType);
        foreach (var item in userinfo.Claims)
          identity.AddClaim(new Claim(item.ClaimType, item.Claim));
        CurrentUserService.CurrentUser = new System.Security.Claims.ClaimsPrincipal(identity);
        StateHasChanged();
        NavigationManager.NavigateTo("/");
      }
      else
      {
        ErrorText = "Invalid credentials";
      }
    }
    catch (Exception ex)
    {
      ErrorText = ex.Message;
    }
    StateHasChanged();
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CurrentUserService CurrentUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
