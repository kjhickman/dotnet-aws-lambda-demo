namespace ManagedRuntimeFSharp

open Amazon.Lambda.Core

open System

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[<assembly: LambdaSerializer(typeof<Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer>)>]
()


type Function() =
    member __.FunctionHandler (input: string) (_: ILambdaContext) =
        match input with
        | null -> String.Empty
        | _ -> input.ToUpper()
