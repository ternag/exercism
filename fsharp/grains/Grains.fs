module Grains

let square (n: int): Result<uint64,string> = 
    match n with
    | x when x > 0 || x <= 64 -> Ok (n * n |> uint64)
    | _ -> Error "Invalid input"

let total: Result<uint64,string> = 
    let c = seq {1UL..64UL}
    let t = Seq.sumBy (fun x -> x * x ) c
    Ok t 