﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FisSst.BlazorComponents.Core.JsInterops
{
    internal class MapJsInterop
    {
        internal static async Task Initialize(IJSRuntime jsRuntime, string mapId)
        {
            await jsRuntime.InvokeVoidAsync("leafletMap.initializeMap", 
                mapId);
        }
    }
}
