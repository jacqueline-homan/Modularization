// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open Jacque.Demo.Calculator

printfn "27 divide by 9 is %d" (Divider.div 27 9)

[<EntryPoint>] // this is a standard .NET attribute
let main argv = 
    printfn "add 5 and 3 is %d" (Adder.add 5 3)
    printfn "The square of 12 is %d" (Multiplier.square 12)
    printfn " 6 times 7 is %d" (Multiplier.mult 6 7)
    0 // return an integer exit code

