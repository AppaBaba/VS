open System


type H = Alpha | Beta | Gamma | Delta

type R = R1 | R2 | R3 | R4

type Rank = R * H


let cRank rank1 rank2 = 
    if rank1 < rank2 
    then printfn "%A is greater than %A" rank2 rank1 
    else printfn "%A is greater than %A" rank1 rank2 

let r4Delta = Delta, R4
let r2Delta = Delta, R2
let r4Alpha = Alpha, R4

Console.ForegroundColor<-ConsoleColor.Cyan
cRank r4Delta r2Delta
Console.ForegroundColor<-ConsoleColor.Red
cRank r2Delta r4Alpha
Console.ForegroundColor<-ConsoleColor.Green
