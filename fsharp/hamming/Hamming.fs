module Hamming
open Microsoft.FSharp.Core

let distance (strand1: string) (strand2: string): int option = 
    match strand1 with
    | _ when strand1.Length <> strand2.Length -> None
    | _ when strand1 = strand2 -> Some 0
    | _ -> Array.map2 (fun char1 char2 -> if char1 = char2 then 0 else 1) (strand1.ToCharArray()) (strand2.ToCharArray()) 
        |> Array.sum 
        |> Some


let distance2 (a:string) (b:string): int option =
    match a with
    | _ when a.Length <> b.Length -> None
    | _ when a = b -> Some 0
    | _ -> Seq.zip a b
        |> Seq.filter (fun (x, y) -> x <> y)
        |> Seq.length
        |> Some


// let distance a b =
//     Seq.zip a b
//     |> Seq.filter (fun (x, y) -> x <> y)
//     |> Seq.length