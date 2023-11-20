using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

#region snippet
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
        Console.WriteLine("Hello World");
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine(request.Name + "Hello World");

        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
           
    });
    }
}
#endregion