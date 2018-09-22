module SpaceAge

type Planet = 
   | Earth
   | Mercury
   | Venus
   | Mars
   | Jupiter
   | Saturn
   | Uranus
   | Neptune

let earthYear = 31557600.0

let orbitalPeriod (planet:Planet):float =
    match planet with
    | Earth -> earthYear
    | Mercury -> earthYear * 0.2408467
    | Venus -> earthYear *  0.6151972
    | Mars -> earthYear *  1.8808158
    | Jupiter -> earthYear *  11.862615
    | Saturn -> earthYear *  29.447498
    | Uranus -> earthYear *  84.016846
    | Neptune -> earthYear *  164.79132

let age (planet: Planet) (seconds: int64): float = 
    float seconds / (orbitalPeriod planet)