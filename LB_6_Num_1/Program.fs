

open System 
let rec readList n =
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail

let readSizeList =
    printfn "Задайте размер листа, затем вводите последовательно числа"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let ferstmax list = 
    let rec IndMax list max indM indEL=
        match list with
        |[]->indM
        |h::tail -> 
            let newMax = if h>=max then h else max
            let newInd = if h>=max then indEL else indM
            IndMax tail newMax newInd (indEL+1)
    IndMax list list.Head 0 0 

//длина списка
let ListLenght list = 
    let rec listlenght list count =
        match list with 
        |[]->count
        |h::tail->
            let newCount = count+1
            listlenght tail newCount
    listlenght list 0

//поиск кол ва 
let col list = 
    let indexMax = ferstmax list 
    let result = ListLenght list-indexMax-1
    result


let vod = 
    Console.WriteLine("Количество элементов :")
    readSizeList|>col|>Console.WriteLine
    0
