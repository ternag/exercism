module DifferenceOfSquares

let square x = x * x

let squareOfSum (number: int): int = 
    Seq.sum {1..number} |> square

let sumOfSquares (number: int): int =
    Seq.sumBy square ({1..number})

let differenceOfSquares (number: int): int =
    squareOfSum number - sumOfSquares number