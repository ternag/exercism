module Pangram

open System

let addToListDistinct chr lst =
    match Char.ToLowerInvariant chr with
    | c when not (Char.IsLetter c) -> lst
    | c when List.contains c lst -> lst
    | c -> c::lst

let isPangram input =
    let numberOfChars = List.fold (fun acc element -> addToListDistinct element acc ) List.empty (Seq.toList input)
    numberOfChars.Length = 26
