namespace SharpWebApi

open System.Web.Http

type HomeController() =
  inherit ApiController()
  [<Route("")>]
  member this.Get() : IHttpActionResult =
    this.Ok() :> IHttpActionResult

