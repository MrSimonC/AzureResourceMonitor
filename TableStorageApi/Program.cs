using Azure.Data.Tables;
using Middleware;
using TableStorageApi.Models;

const string tableName = "ProgramStatus";
const string partitionKey = "StatusUpdate"; 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseApiKeyAuthentication();
app.Urls.Add("http://0.0.0.0:8080");

var tableConnString = Environment.GetEnvironmentVariable("TABLESTORAGECONNECTIONSTRING");
app.Logger.LogInformation($"got conection string {tableConnString}");
var tableClient = new TableClient(tableConnString, tableName);

app.MapGet("/liveness", () => "All OK");
app.MapGet("/", () => Results.Json(tableClient.Query<StatusEntry>()));
app.MapPost("/", (StatusEntry entry) => {
    entry.PartitionKey = partitionKey;
    tableClient.AddEntity(entry);
});

app.Run();
