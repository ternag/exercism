module Grains

let square n = 
    match n with
    | x when x > 0 && x <= 64 -> Ok (1UL<<<x - 1)
    | _ -> Error "Invalid input"

let total: Result<uint64,string>= 
    let c = seq {1..64}
    let t = c |> Seq.map square |> Seq.sumBy (fun (Ok r) -> r) |> uint64
    Ok t 

// Valid alternative :o)
//let total: Result<uint64,string>= 
//    Ok 18446744073709551615UL
