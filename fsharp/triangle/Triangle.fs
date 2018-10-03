module Triangle

let validateNoZeroSide triangle =
    let listOfZeroElements = List.filter (fun elem -> elem = 0.0) triangle
    if (List.isEmpty listOfZeroElements)
    then Ok triangle
    else Error "triangle has one or more 0 element(s). "

let validateNotInequal (triangle:Result<float list, string>) = 
    match triangle with
    | Ok t -> if (t.Item(0) + t.Item(1) > t.Item(2) && t.Item(0) + t.Item(2) > t.Item(1) && t.Item(1) + t.Item(2) > t.Item(0))
              then Ok t
              else Error "Triangle is Inequal"
    | Error msg -> Error msg

let testForEquilateral (triangle:Result<float list, string>) = 
    match triangle with
    | Ok t -> Ok (t.Item(0) = t.Item(1) && t.Item(1) = t.Item(2))
    | Error msg -> Error msg

let testForIsosceles (triangle:Result<float list, string>) = 
    match triangle with
    | Ok t -> Ok (t.Item(0) = t.Item(1) || t.Item(1) = t.Item(2) || t.Item(0) = t.Item(2))
    | Error msg -> Error msg

let testForScalene (triangle:Result<float list, string>) =
    match triangle with
    | Ok t -> Ok (t.Item(0) <> t.Item(1) && t.Item(1) <> t.Item(2) && t.Item(0) <> t.Item(2))
    | Error msg -> Error msg


let getResult r = 
    match r with
    | Ok b -> b
    | Error _ -> false

let equilateral triangle = 
    triangle |> validateNoZeroSide |> validateNotInequal |> testForEquilateral |> getResult

let isosceles triangle = 
    triangle |> validateNoZeroSide |> validateNotInequal |> testForIsosceles |> getResult

let scalene triangle = 
    triangle |> validateNoZeroSide |> validateNotInequal |> testForScalene |> getResult