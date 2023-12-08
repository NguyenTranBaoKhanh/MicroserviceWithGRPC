// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GRPCSample;

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:7005");
var client = new Greeter.GreeterClient(channel);
var client2 = new ToDoIt.ToDoItClient(channel);

var response = await client.SayHelloAsync(new HelloRequest { Name = "Bao Khanh" });
var response2 = client2.ListToDo(new GetAllRequest());

Console.WriteLine("From Server: " + response.Message);
Console.WriteLine("From Server: " + response2);
