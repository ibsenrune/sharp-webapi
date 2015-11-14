namespace SharpWebApi

open Owin
open Microsoft.Owin
open System.Web.Http

type Startup() = 
    member this.Configuration (app : IAppBuilder) = 
      let config = new HttpConfiguration()
      config.MapHttpAttributeRoutes() |> ignore
      app.UseWebApi config |> ignore

[<assembly: OwinStartup(typeof<Startup>)>]
do ()