namespace WebSite

open Nancy

type SaleLine = {
    Description: string
    Amount: decimal
}

type SaleViewModel = {
    Description: string
    Total: decimal
    Lines: SaleLine list
}


type SalesModule() as m =
    inherit NancyModule()

    do m.Get.["/sales/"] <- fun _ -> 
        let viewModel = [
            {
                Description = "sale1"
                Total = 100.00m
                Lines = [
                            {
                                Description = "line1"
                                Amount = 70m 
                            };
                            {
                                Description = "line2"
                                Amount = 30m 
                            }
                ]
            };
            {
                Description = "sale2"
                Total = 150.00m
                Lines = [
                            {
                                Description = "sale2.line1"
                                Amount = 60m 
                            };
                            {
                                Description = "sale2.line2"
                                Amount = 90m 
                            }
                ]
            }
        ]
        m.View.["sales/index", viewModel] :> obj

