module ReverseString
open System

let reverse input = 
    match input with
    | "" -> ""
    | _ -> input.ToCharArray() |> Array.rev |> String

