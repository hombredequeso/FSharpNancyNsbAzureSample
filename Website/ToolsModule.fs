namespace WebSite

open Nancy

type CustomerRowVm = {
    Name: string
}

type MyModel = {
    TestKey:string
    Items: string list
    Customers: CustomerRowVm list
}

type ToolsModule() as m =
    inherit NancyModule()

    do m.Get.["/tools/"] <- fun _ -> 
        let viewModel = {
            TestKey = "ThisIsTheTestKey"
            Items = ["s1"; "s2"]
            Customers = [
                            {Name = "customer1"}
                            {Name = "customer2"}
                            {Name = "customer3"}
            ]
        }
        m.View.["Tools/index", viewModel] :> obj
