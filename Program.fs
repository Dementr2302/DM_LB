open System

let rec read n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = read (n-1)
    Head::Tail

let readData = 
    Console.WriteLine("Введите размерность списка:  ")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Введите список: ")
    read n

let rec writeList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.WriteLine(head)
                       writeList tail  


let minind list = 
    let rec indexofminel list min indM indEL=
        match list with
        |[]->indM
        |h::tail -> 
            let newMin = if h<=min then h else min
            let newInd = if h<=min then indEL else indM
            indexofminel tail newMin newInd (indEL+1)
    indexofminel list list.Head 0 0 


let srav list = 
    let indexMin = minind list
    let rec beforemin list indMin indEl ListBefMin ListAfter = 
        match list with 
        |[]-> ListAfter @ ListBefMin
        |h::tail ->
            let newIndEl = indEl+1
            if indEl<indMin then 
                let NewList = ListBefMin @ [h]
                beforemin tail indMin newIndEl NewList ListAfter
            else 
                let NewList = ListAfter @ [list.Head]
                beforemin tail indMin newIndEl ListBefMin NewList
    beforemin list indexMin 0 [] []
    

[<EntryPoint>]
let main argv =
    Console.WriteLine("Новый получившийся список:")
    readData |> srav|>writeList
    0 