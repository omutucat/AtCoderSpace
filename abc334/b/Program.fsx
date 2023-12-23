// 不正答

let a, m, l, r = stdin.ReadLine().Split() |> Array.map int64 |> fun x -> x.[0], x.[1], x.[2], x.[3]

let kijun = a - ((a - l) / m) * m

printfn "%i" kijun

let dif = r - l

let ans = (dif / m) + if kijun = l then 1L else 0L

printfn "%i" ans
