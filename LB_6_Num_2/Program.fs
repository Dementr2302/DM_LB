// min index 
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
    rList n


let MinIndex list = 
    let rec minel list min indM indEL =
        match list with
        |[]->indM
        |h::tail -> 
            let newMin =if h<min then h else min
            let newInd = if h<min then indEL else indM
            minel tail newMin newInd (indEL+1)
    minel list list.Head 0 0

let vod =
    let n = rData
    Console.WriteLine("Индекс минимума: ")
    Console.WriteLine(MinIndex n)
    0