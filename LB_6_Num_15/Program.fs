

open System

let rec rList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = rList (n-1)
    Head::Tail

let rData = 
    Console.WriteLine("Введите размерность:  ")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Введите список: ")
    rList n


let Localmin ind list = 
    let rec lokmin' list ind znachelzadsp ind' =
        match list with
        |[]->true
        |h::tail->
            let result=
                if (ind'+1=ind || ind'=ind) then
                    if (ind'=ind) then lokmin' tail ind h (ind'+1) 
                    else
                        if (h>=tail.Head && ind'+1=ind) then lokmin' tail ind tail.Head (ind'+1)
                        else false
                else               
                    if (ind'-1=ind && h>=znachelzadsp) then true
                        else false
            if (ind'>=ind-1 && ind'<=ind+1) then result
            else
                lokmin' tail ind znachelzadsp (ind'+1)
    lokmin' list ind 0 0 

       
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите индекс: ")
    let ind = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Результат: ")
    rData |> Localmin ind |> Console.WriteLine
    0 