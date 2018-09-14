module Leap

let divisibleBy4 (year: int): bool = year % 4 = 0

let divisibleBy100 (year: int): bool = year % 100 = 0

let divisibleBy400 (year: int): bool = year % 400 = 0

let leapYear (year: int): bool = 
    divisibleBy4 year && not (divisibleBy100 year <> divisibleBy400 year) 
