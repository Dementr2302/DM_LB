open System


let readStrings n = 
   let rec readstrings n list = 
       match n with 
       |0-> list 
       |_->
           let newList = list @ [Console.ReadLine()]
           readstrings(n-1) newList
   readstrings n []

let rec writeList list = 
    List.iter(fun x->printfn "%O" x) list


//1

let sr str = 
    let AveradeNumbersOfVowels=Convert.ToSingle(String.length(String. filter (fun x -> x='а' ||x='о'||x='э'|| x='е'||x='и'||x='ы'||x='у'||x='ё'||x='ю'||x='я') str))/ Convert.ToSingle(String.length str)
    let AveradeNumbersOfСonsonants=Convert.ToSingle(String.length (String. filter (fun x -> not(x='а' ||x='о'||x='э'||x='е'||x='и'||x='ы'||x='у'||x='ё'||x='ю'||x='я')) str)) / Convert.ToSingle(String.length str)
    Math.Abs(AveradeNumbersOfСonsonants-AveradeNumbersOfVowels)

let SortList liststr =  List.sortBy (fun x->sr x) liststr


//6

let FindOfMedian list = 
     List.item ((List.length list)/2) (List.sort list)

let removeAt index list =
    list |> List.indexed |> List.filter (fun (i, _) -> i <> index) |> List.map snd

let srqw list = 
    let rec sortbymedian list sortList =
        match list with
        |[]->sortList
        |_ ->
            let nowMed = FindOfMedian list 
            let indMed =List.findIndex (fun x->x=nowMed) list 
            let newList = removeAt (indMed) list
            sortbymedian newList (sortList @ [nowMed])
    sortbymedian list []
            


let FunctionSelection  = function
    |1 -> SortList 
    |2 -> srqw 

 
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите количество строк,затем сами строки: ")
    let strs = Console.ReadLine() |> Convert.ToInt32 |> readStrings 
    Console.WriteLine("Введите номер функции:
     1 - cортировка по количеству согласных и гласных букв в строке
     2 - cортировка по медианному значению
     ")
    let n = Console.ReadLine() |> Convert.ToInt32 |> FunctionSelection
    strs |> n |>writeList
    0 