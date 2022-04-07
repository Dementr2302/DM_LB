// LB_5_NUM_13

let rec UmVverh w =
  if w<=1 then 1 else w%10 * UmVverh(w/10)

let UmHvost w =
    let rec Hvost cop w =
        if w <= 1 then cop
        else Hvost (cop * (w % 10)) (w / 10)
    Hvost 1 w

let rec MaxVverh n=
    if n < 10 then n
    else max (n%10) (MaxVverh (n/10))

let MaxHvost n =
    let rec MaxHvost1 n max=
        if n=0 then max
        else
            let cop = n%10
            let newn = n/10
            if cop>max then
                MaxHvost1 newn cop else
                    MaxHvost1 newn max
    MaxHvost1 n 0

let rec MinVverh n=
    if n < 10 then n
    else min (n%10) (MinVverh (n/10))

let MinHvost n =
    let rec HV n min=
        if n=0 then min
        else
            let cop = n%10
            let newn = n/10
            if cop<min then
                HV newn cop else
                    HV newn min
    HV n 0

let vod=
    printfn "ВВедите число :"
    let n=System.Convert.ToInt32(System.Console.ReadLine()) in 
    System.Console.WriteLine(UmVverh n)
    System.Console.WriteLine(UmHvost n)
    System.Console.WriteLine(MaxVverh n)
    System.Console.WriteLine(MaxHvost n)
    System.Console.WriteLine(MinVverh n)
    System.Console.WriteLine(MinHvost n)
    0