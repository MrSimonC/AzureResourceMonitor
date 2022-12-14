using Azure.Data.Tables;
using TableStorageApi.Models;

const string tableName = "ProgramStatus";
const string partitionKey = "StatusUpdate"; 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tableConnString = builder.Configuration["TableStorageConnectionString"];
var tableClient = new TableClient(tableConnString, tableName);

app.MapGet("/", () => Results.Json(tableClient.Query<StatusEntry>()));
app.MapPost("/", (StatusEntry entry) => {
    entry.PartitionKey = partitionKey;
    tableClient.AddEntity(entry);
});

app.Run();
