let b, g = stdin.ReadLine().Split() |> Array.map int |> (fun a -> a.[0], a.[1])

printfn "%s" (if b > g then "Bat" else "Glove")
