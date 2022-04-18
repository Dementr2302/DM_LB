let main arvg=
    Console.ReadLine() |> (fun x -> if (x = "Prolog")||(x = "F#") then "Подлиза" else "Хорош") |> Console.WriteLine