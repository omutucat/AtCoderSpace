stdin.ReadLine() |> ignore
let inputA: int64 array = stdin.ReadLine().Split([|' '|]) |> Array.map int64
let inputP: int array = stdin.ReadLine().Split([|' '|]) |> Array.map int

let rec solve (a: int64 array) (p: int array) (index: int) =
    if Array.contains (index + 1) p then
        p
        |> Array.mapi (fun (i: int) (x: int) -> (i, x))
        |> Array.filter (fun (_, x: int) -> x = (index + 1))
        |> Array.map fst
        |> Array.map (fun (i: int) -> solve a p (i + 1))
        |> Array.sum
        |> fun (x: int64) -> if x = 0L then a[index] else x
    else
        a[index]

solve inputA inputP 0
    |> fun (x: int64) ->
        if x < 0 then "-"
        elif x > 0 then "+"
        else "0"
    |> printfn "%s"