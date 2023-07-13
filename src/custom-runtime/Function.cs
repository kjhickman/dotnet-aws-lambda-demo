using System.Text.Json.Serialization;
using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;

namespace CustomRuntime;

public class Function
{
    private static async Task Main()
    {
        var handler = FunctionHandler;
        await LambdaBootstrapBuilder.Create(handler, new SourceGeneratorLambdaJsonSerializer<LambdaJsonSerializerContext>())
            .Build()
            .RunAsync();
    }
    
    public static string FunctionHandler(string input, ILambdaContext context)
    {
        return input.ToUpper();
    }
}


[JsonSerializable(typeof(string))]
public partial class LambdaJsonSerializerContext : JsonSerializerContext
{
}
