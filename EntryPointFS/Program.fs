open Lib

[<EntryPoint>]
let main argv = 
    
    let bar1 = new Bar()
    let bar2 = new Bar()

    let asParams = Test.TestMethod(bar1, bar2)
    let asArray = Test.TestMethod([| bar1; bar2 |])

    0