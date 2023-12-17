let n, s, k =
    stdin.ReadLine().Split([| ' ' |])
    |> Array.map int
    |> fun a -> a.[0], a.[1], a.[2]

let mutable ans = 0

for _ in 1..n do
    let p, q =
        stdin.ReadLine().Split([| ' ' |]) |> Array.map int |> (fun a -> a.[0], a.[1])

    ans <- ans + p * q

printf "%d\n" (ans + if ans < s then k else 0)
