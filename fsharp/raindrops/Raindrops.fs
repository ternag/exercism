module Raindrops

let handleDefault (n:int) s = 
    if(s = "")
    then n |> string
    else s

let div3 n s = 
    if (n % 3 = 0)
    then s + "Pling"
    else s

let div5 n s = 
    if (n % 5 = 0)
    then s + "Plang"
    else s

let div7 n s = 
    if (n % 7 = 0)
    then s + "Plong"
    else s

let convert (number: int): string = 
    div3 number "" |> div5 number |> div7 number |> handleDefault number