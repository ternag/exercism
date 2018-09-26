module Hamming
open Microsoft.FSharp.Core

let distance (strand1: string) (strand2: string): int option = 
    match strand1 with
    | _ when strand1.Length <> strand2.Length -> None
    | _ when strand1 = strand2 -> Some 0
    | _ -> Array.map2 (fun char1 char2 -> if char1 = char2 then 0 else 1) (strand1.ToCharArray()) (strand2.ToCharArray()) 
        |> Array.sum 
        |> Some


