let n: int = stdin.ReadLine() |> int
let inputA: int64 array = stdin.ReadLine().Split([|' '|]) |> Array.map int64
let inputP: int array = stdin.ReadLine().Split([|' '|]) |> Array.map int

// 1. depth function optimization
let depths = Array.zeroCreate (n - 1)
for i in 0..(n - 2) do
    let mutable j = inputP.[i]
    let mutable d = 1
    while j <> 1 do
        j <- inputP.[j - 2]
        d <- d + 1
    depths.[i] <- d

// 2. sumByDepth function optimization
let sums = Array.zeroCreate<int64> n
for i in 0..(n - 2) do
    let d = depths.[i]
    sums.[d] <- sums.[d] + inputA.[i + 1]

// 3. b array creation
let b = List.ofArray sums

// 4. k calculation
let k =
    let nonZero = b |> List.filter (fun x -> x <> 0L)
    if nonZero.Length = 0 then inputA.[0]
    else nonZero.[nonZero.Length - 1]

if k < 0L then "-"
elif k > 0L then "+"
else "0"
|> printfn "%s"