//Num_14

open System

let del n f init =
    let rec delnew n w init dev=
       if (dev=0) then init
       else
            let newinit = if (n % dev = 0)
                            then w init dev
                          else init
            let newdev = dev - 1
            delnew n w newinit newdev
    delnew n f init n

    
let vod =
    printf"Введите число : "
    let n = Console.ReadLine()|>Int32.Parse
    del n (fun x y-> x+y) 0 |> Console.WriteLine
    0