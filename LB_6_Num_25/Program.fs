open System

let rec rList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = rList (n-1)
    Head::Tail

let rData = 
    Console.WriteLine("Введите размерность списка:  ")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Введите список: ")
    rList n


let Interval (a,b) list= 
    let rec maxint list (a,b) max = 
        match list with
        |[]->max
        |h::tail-> 
            let newMax = 
                if h>max && h>a && h<b then h
                else max
            maxint tail (a,b) newMax
    maxint list (a,b) a

let vod =
    Console.WriteLine("Введите интервал:")
    let n = (Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()))
    Console.WriteLine("Ответ:")
    rData |> Interval n|> Console.WriteLine
    0