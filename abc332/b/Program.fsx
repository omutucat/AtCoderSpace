let k, g, m = 
    stdin.ReadLine().Split([|' '|]) 
    |> Array.map int 
    |> fun a -> a.[0], a.[1], a.[2]

let rec solve k gn mn =
    match k with
    | 0 -> (gn, mn)
    | _ -> 
        if gn = g then
            solve (k - 1) 0 mn
        elif mn = 0 then
            solve (k - 1) gn m
        else
            if mn < (g - gn) then
                solve (k - 1) (gn + mn) 0
            else
                solve (k - 1) g (mn - (g - gn))

let gn, mn = solve k 0 0

printfn "%d %d" gn mn
