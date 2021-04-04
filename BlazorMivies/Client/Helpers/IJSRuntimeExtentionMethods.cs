using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMivies.Client.Helpers
{
    public static class IJSRuntimeExtentionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Test message");
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction (this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}
