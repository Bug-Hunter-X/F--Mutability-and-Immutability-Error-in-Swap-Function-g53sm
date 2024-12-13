The error occurs because in `swap2`, `a` and `b` are declared as immutable values (without the `mutable` keyword), meaning their values cannot be changed after they are initialized.  To fix this, either make `a` and `b` mutable:

```fsharp
let mutable a = 10
let mutable b = 20
let (c,d) = swap2 a b
printfn "%d %d" c d
```

Or, change the swap function to return new values instead of modifying the existing ones. This is generally preferred in F# to maintain functional purity.

```fsharp
let swap3 x y = (y, x)

let a = 10
let b = 20
let (c,d) = swap3 a b
printfn "%d %d" c d
```
The second solution, using `swap3`, is more idiomatic F# as it avoids mutable variables and operates in a purely functional manner.