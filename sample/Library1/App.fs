﻿namespace BlazorApp1

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Net.Http
open Microsoft.AspNetCore.Blazor
open Microsoft.AspNetCore.Blazor.Browser.Rendering
open Microsoft.AspNetCore.Blazor.Browser.Services
open Microsoft.AspNetCore.Blazor.Components
open Microsoft.AspNetCore.Blazor.Layouts
open Microsoft.AspNetCore.Blazor.Routing
open BlazorApp1
open BlazorApp1.Shared
open Trail

type Marker = class end

type App() =
    inherit Trail.Component()

    override __.Render() =
        Dom.comp<Router> [Dom.BlazorObjAttribute("AppAssembly", box typeof<Marker>.Assembly)] []

(*
// TODO: can we go ALL the way?
module Program =
    [<EntryPoint>]
    let main _ =
        let serviceProvider = new BrowserServiceProvider(fun configure ->
            // Add any custom services here
            ()
        )

        (new BrowserRenderer(serviceProvider)).AddComponent<App>("app")
        0
*)
