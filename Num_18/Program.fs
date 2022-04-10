open System


//1


let Sum n = 
    let rec pro n div = 
        if div = 1 then true
        else 
            if n%div=0 then false
            else 
                let newDiv=div-1
                pro n newDiv
    pro n (n-1)

let sum' n = 
    let rec sump n sumInit div = 
        if div = 1 then sumInit
        else 
            let NextSum=
                if n%div=0 && (Sum div = true) then sumInit+div
                else sumInit
            let newDiv=div-1
            sump n NextSum newDiv
    sump n 0 n  



    //2


let num n = 
    let rec Numdel n num = 
        if n = 0 then num
        else 
            let nextNum = 
                if (n%10)%2=1 && (n%10)>3 then (num+1)
                else num
            let NextN = n/10
            Numdel NextN nextNum
    Numdel n 0


let  vod = 
    System.Console.WriteLine("Введите число:")
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let x = sum' n
    Console.WriteLine(x)
    let y =num n
    Console.WriteLine(y)
    0


