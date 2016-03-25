open Lib
open System

[<EntryPoint>]
let main argv = 
    
    let bar1 = null
    let bar2 = null

    let lengthAsParam = Test.TestMethod(bar1, bar2)
    let lengthAsArray = Test.TestMethod([| bar1; bar2 |])

    let condition = (lengthAsParam = lengthAsArray);

    assert(condition);

    Console.WriteLine(condition)

    Console.ReadLine() |> ignore

    0