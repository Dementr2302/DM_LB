
open System

let Pro n = 
    let rec Pro1 n div = 
        if div = 1 then true
        else 
            if n%div=0 then false
            else 
                let newDiv=div-1
                Pro1 n newDiv
    Pro1 n (n-1)

let Sum n = 
    let rec Sum1 n sumInit div = 
        if div = 1 then sumInit
        else 
            let NextSum=
                if n%div=0 && (Pro div = true) then sumInit+div
                else sumInit
            let newDiv=div-1
            Sum1 n NextSum newDiv
    Sum1 n 0 n  


let col_vo n = 
    let rec Num n num = 
        if n = 0 then num
        else 
            let nextNum = 
                if (n%10)%2=1 && (n%10)>3 then (num+1)
                else num
            let NextN = n/10
            Num NextN nextNum
    Num n 0


let Sumn n = 
    let rec Sum1 n init = 
        if n = 0 then init
        else 
            let nextInit = init+(n%10)
            let nextN=n/10
            Sum1 nextN nextInit
    Sum1 n 0

let Div n = 
    let rec ProductDiv n result div = 
        if div = 1 then result
        else 
            let nextRes= 
                if n%div=0 && (Sumn div < Sumn n) then result*div
                else result
            let nextDiv = div-1
            ProductDiv n nextRes nextDiv
    ProductDiv n 1 n

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число:")
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let res1 = Sum n
    Console.WriteLine("Сумма простых делителей числа = {0}",res1)
    let res2=col_vo n
    Console.WriteLine("Количество нечетных цифр числа, которые больше 3  = {0}",res2)
    let res3=Div n
    Console.WriteLine("Произведение делителей числа, сумма цифр которых меньше суммы цифр исходного числа = {0}",res3)
    0 
