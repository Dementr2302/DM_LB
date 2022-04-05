// LB_5_NUM_12
open System

[<EntryPoint>]
let main argv=
    printf "Той любимый ЯП?"
    let f1 (x:string) = printfn "%s" x
    let f2 (x:string) : string = if (x="Prolog") || (x="F#") then "Подлиза" else "Что это?"
    let w = Console.ReadLine()
    (f2>>f1) w
    0