module Bob

let containsLetter (input: string) = 
    input |> Seq.exists System.Char.IsLetter

let isQuestion (input: string) = 
    input.EndsWith('?')

let isYelling (input: string) = 
    input = input.ToUpper() && input |> containsLetter

let response (input: string): string = 
    match input.Trim() with
    | "" -> "Fine. Be that way!"
    | i when isQuestion i && isYelling i -> "Calm down, I know what I'm doing!"
    | i when isQuestion i -> "Sure."
    | i when isYelling i -> "Whoa, chill out!"
    | _ -> "Whatever."
