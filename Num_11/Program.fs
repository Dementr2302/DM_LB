// LB_5_NUM_11



open System




let test w =
    match w with
    |"F#"->printf " ТЫ подлиза "
    |"Prolog"->printf " ТЫ подлиза "
    |_->printf"Что это"



[<EntryPoint>]
let main argv =
    printfn "Какой твой любимый язык программирования?"
    let w = System.Console.ReadLine();
    test w
    0