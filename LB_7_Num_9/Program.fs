﻿open System

//1.Дана строка.Необходимо найти общее количество русских символов.

let NumberOfRuschar str = 
    let res1 = String.length(String.filter (fun x -> x>='А' && x<='я') str)
    Console.WriteLine("Количество русских символов в строке: {0}",res1)

//18.Найти в тексте даты формата «день.месяц.год».

//из записи 24.03.2003 удаляем точки и преобразуем в строчку типа 24032003
let Date (str:string)= 
    let day = str.Remove(2,8)
    let month = str.Remove(0,3).Remove(2,5)
    let year = str.Remove(0,6)
    day<="31"&&day>="01" && month>="01"&& month<="12" && year >"0000" && year<"9999"

let FindData (str:string) = 
    let rec finddate (stroka:string) (strNow: string) (strResult: string) = 
        match stroka with
        |"" -> strResult
        |_-> 
            let newStroka = 
                if strNow.Length<10 then
                    strNow + stroka.Remove(1,stroka.Length-1)
                else strNow.Remove(0,1)+(stroka.Remove(1,stroka.Length-1))
            let newResult = 
                if (newStroka.Length = 10 && Date newStroka) then strResult+"\n"+newStroka
                else strResult
            finddate (stroka.Remove(0,1)) newStroka newResult
    if finddate str "" "" = "" then "В тексте дат нет" else finddate str "" ""
    Console.WriteLine("Искомая дата:{0}",finddate str "" "")


let F1 n str  = 
    match n with 
    |1 -> Convert.ToString(NumberOfRuschar str)
    |3 -> Convert.ToString(FindData str)
    
    
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите строку: ")
    let str = Console.ReadLine()
    Console.WriteLine("Введите номер функции:
     1 - поиск общего количество русских символов 
     3 - поиск даты определенного формата в тексте
     ")
    let n = Console.ReadLine() |> Convert.ToInt32
    F1 n str  
    0