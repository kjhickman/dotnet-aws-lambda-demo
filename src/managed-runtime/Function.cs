using System.Text.Json.Serialization;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;
using ManagedRuntime;

[assembly: LambdaSerializer(typeof(SourceGeneratorLambdaJsonSerializer<LambdaJsonSerializerContext>))]

namespace ManagedRuntime;

public class Function
{
    public static string FunctionHandler(string input, ILambdaContext context)
    {
        return input.ToUpper();
    }
}


[JsonSerializable(typeof(string))]
public partial class LambdaJsonSerializerContext : JsonSerializerContext
{
}
