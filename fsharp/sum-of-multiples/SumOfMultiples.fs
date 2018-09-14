module SumOfMultiples

let rec isMultOf (numbers: int list) (n: int): bool = 
    match numbers with
    | [] -> false
    | head::tail -> (n % head = 0) || isMultOf tail n

let sum (numbers: int list) (upperBound: int): int = 
    let myList = seq { for n in 1..(upperBound-1) do if isMultOf numbers n then yield n }
    Seq.sum myList