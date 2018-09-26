module RnaTranscription
open System

let translate dna =
    match dna with
    | 'G' -> "C"
    | 'C' -> "G"
    | 'T' -> "A"
    | 'A' -> "U"
    | _ -> "?"

let toRna (dna: string): string = 
    String.collect translate dna
