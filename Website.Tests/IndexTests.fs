namespace Website.Tests

open System
open NUnit.Framework
open FsUnit

open Nancy
open Nancy.Testing

open WebSite


[<TestFixture>]
[<Category("Unit")>]
module ToolsTests  = 

    // F# translation of:
    // https://github.com/NancyFx/Nancy/wiki/Testing-your-application
    [<Test>]
    let ``Index Page StatusCode is OK`` () =
        let bootstrapper = new DefaultNancyBootstrapper()
        let browser = new Browser(bootstrapper)
        let request (x: BrowserContext) = x.HttpRequest()
        let response = browser.Get("/", request);
        let responseBody = response.Body.AsString()

        responseBody.Contains("demo website") |> should equal true
        response.StatusCode |> should equal HttpStatusCode.OK



