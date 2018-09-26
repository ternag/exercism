module Hamming
open Microsoft.FSharp.Core

let distance a b = 
    match a with
    | _ when Seq.length a <> Seq.length b -> None
    | _ -> Seq.map2 (fun n m -> if n = m then 0 else 1) a b 
        |> Seq.sum 
        |> Some

let distance3 a b = 
    if (Seq.length a <> Seq.length b) 
    then None
    else Seq.map2 (fun n m -> if n = m then 0 else 1) a b 
      |> Seq.sum 
      |> Some

let distance2 a b =
    match a with
    | _ when Seq.length a <> Seq.length b -> None
    | _ -> Seq.zip a b 
        |> Seq.filter (fun (x, y) -> x <> y) 
        |> Seq.length 
        |> Some


// let distance a b =
//     Seq.zip a b
//     |> Seq.filter (fun (x, y) -> x <> y)
//     |> Seq.length