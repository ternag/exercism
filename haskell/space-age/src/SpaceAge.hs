module SpaceAge (Planet(..), ageOn) where

data Planet = Mercury 
            | Venus
            | Earth
            | Mars
            | Jupiter
            | Saturn
            | Uranus
            | Neptune
            
earthYear :: Float
earthYear = 31557600

orbitalPeriod :: Planet -> Float
orbitalPeriod Mercury = earthYear * 0.2408467
orbitalPeriod Venus = earthYear * 0.61519726
orbitalPeriod Earth = earthYear * 1.0
orbitalPeriod Mars = earthYear * 1.8808158
orbitalPeriod Jupiter = earthYear * 11.862615
orbitalPeriod Saturn = earthYear * 29.447498
orbitalPeriod Uranus = earthYear * 84.016846
orbitalPeriod Neptune = earthYear * 164.79132

ageOn :: Planet -> Float -> Float
ageOn planet seconds = seconds / (orbitalPeriod planet)
