//Num_15

open System



let rec del a b =
    if a=b then a
    else 
        if a>b then del (a-b) b 
        else del a (b-a) 
 
let OB x F init =
    let rec OB' x F init chislo =
        if chislo=0 then init
        else 
            let new_init = if (del x chislo) =1 then F init chislo else init
            let new_chislo= chislo - 1
            OB' x F new_init new_chislo
    OB' x F init x
 
let vod =
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine(OB x (fun x y -> x+y) 0)
    0
   
