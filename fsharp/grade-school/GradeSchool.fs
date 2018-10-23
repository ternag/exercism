module GradeSchool

type School = Map<int, string list>

let empty: School = 
    Map.empty

let add (student: string) (grade: int) (school: School): School = 
    match Map.containsKey grade school with
    | true -> Map.add grade (List.sort (student::school.Item grade)) school
    | false -> Map.add grade [student] school

let roster (school: School): (int * string list) list = 
    Map.toList school

let grade (number: int) (school: School): string list = 
    match school with
    | s when s = empty -> []
    | _ -> (school.Item number)
