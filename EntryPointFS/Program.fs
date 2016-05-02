open Lib

[<EntryPoint>]
let main argv = 
    
    let foo1 = new Foo()
    let foo2 = new Foo()

    let asParams = Test.TestMethod(foo1, foo2)
    let asArray = Test.TestMethod([| foo1; foo2 |])

    0