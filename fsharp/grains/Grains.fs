module Grains

let square n = 
    match n with
    | x when x > 0 && x <= 64 -> Ok (1UL<<<x - 1)
    | _ -> Error "Invalid input"

let total: Result<uint64,string>=  
        [1..64] 
        |> List.map square 
        |> List.sumBy (function | Ok n -> n | Error _ -> 0UL) 
        |> uint64
        |> Ok 

// let qw str = 
//     str |> List.filter (fun c -> (not (System.Char.IsDigit c)))

// Valid alternative :o)
//let total: Result<uint64,string>= 
//    Ok 18446744073709551615UL
