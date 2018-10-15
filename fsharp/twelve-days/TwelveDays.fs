module TwelveDays

type Day = {
    Ordinal:string
    Text:string
}

let days = [
    { Ordinal="first"; Text="a Partridge in a Pear Tree."}
    { Ordinal="second"; Text="two Turtle Doves"}
    { Ordinal="third"; Text="three French Hens"}
    { Ordinal="fourth"; Text="four Calling Birds"}
    { Ordinal="fifth"; Text="five Gold Rings"}
    { Ordinal="sixth"; Text="six Geese-a-Laying"}
    { Ordinal="seventh"; Text="seven Swans-a-Swimming"}
    { Ordinal="eighth"; Text="eight Maids-a-Milking"}
    { Ordinal="ninth"; Text="nine Ladies Dancing"}
    { Ordinal="tenth"; Text="ten Lords-a-Leaping"}
    { Ordinal="eleventh"; Text="eleven Pipers Piping"}
    { Ordinal="twelfth"; Text="twelve Drummers Drumming"}
]

let reverse list = List.fold (fun acc elem -> elem::acc) [] list

let dayLyric day = 
    let andOrNot = 
        match day with
        | 1 -> ""
        | _ -> " and"

    let dayOne slut start =
        sprintf "%s,%s %s" start andOrNot slut

    let beginning ordinal restOfLyric = 
        sprintf "On the %s day of Christmas my true love gave to me%s" ordinal restOfLyric

    [1 .. (day-1)] 
        |> reverse 
        |> List.fold (fun acc input -> sprintf "%s, %s" acc (days.Item(input).Text)) "" 
        |> dayOne (days.Item(0).Text) 
        |> beginning (days.Item(day - 1).Ordinal)

let recite start stop =
    [start .. stop]
    |> List.map dayLyric