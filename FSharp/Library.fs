namespace MauiBlazorApp1.FSharp

module Say =
    let hello name =
        printfn "Hello %s" name

    let x = sprintf "This is from F#"

    let t = System.IO.File.ReadAllText(@"D:\CODE\text.txt")