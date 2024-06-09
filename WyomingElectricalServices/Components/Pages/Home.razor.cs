using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace WyomingElectricalServices.Components.Pages
{
    public partial class Home
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        int currentCount = 0;
        bool firstRender = true; 
        //protected async override Task OnAfterRenderAsync()
        //{
        //    if (firstRender)
        //    {
        //        await JsRuntime.InvokeAsync<object>("initializeCarousel");
        //        firstRender = false;
        //    }
        //}
    }
}
