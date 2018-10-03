module Raindrops

type Raindrop = { 
    divisor:int
    tag:string 
    }

let raindrops = [
    {divisor=3; tag="Pling"};
    {divisor=5; tag="Plang"};
    {divisor=7; tag="Plong"}
    ]

let handleDefault n s = 
    if(s = "")
    then n |> string
    else s

let detectRaindrop raindrop number str =
    if (number % raindrop.divisor = 0)
    then str + raindrop.tag
    else str

let convert number = 
    raindrops |> List.fold (fun acc raindrop -> detectRaindrop raindrop number acc) "" |> handleDefault number
