using Grpc.Net.Client;
using GrpcServiceMetanitLearn;

using var channel = GrpcChannel.ForAddress("http://localhost:5291");

var client = new Greeter.GreeterClient(channel);
Console.WriteLine("Введите имя: ");
var name = Console.ReadLine();

var reply = await client.SayHelloAsync(new HelloRequest { Name = name});
Console.WriteLine($"Ответ сервера {reply.Message}");