namespace FSharp

module Say =
    let hello name =
        printfn "Hello %s" name

    let x = sprintf "This is from F#"