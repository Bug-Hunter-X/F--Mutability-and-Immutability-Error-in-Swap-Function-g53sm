let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

let swap2 x y =
    let temp = x
    x <- y
    y <- temp
    (x,y)

let a = 10
let b = 20
let (c,d) = swap2 a b //This will cause error because a and b are immutable.
printfn "%d %d" c d