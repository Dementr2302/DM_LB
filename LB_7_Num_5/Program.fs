open System

let rec readList n =
    Console.WriteLine("Введите список: ")
    List.init(n) (fun index->Console.ReadLine()|>Convert.ToDouble)

let readData = 
    Console.WriteLine("Введите размерность списка:  ")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writeList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.WriteLine(head)
                       writeList tail



let F1 list = List.average (List.map (fun (x:float)-> Math.Abs(x)) list )
   
[<EntryPoint>]
let main argv =
   Console.WriteLine("Cреднее арифметическое модулей его элементов:")
   readData|> F1 |> Console.WriteLine;
   0 