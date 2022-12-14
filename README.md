# Table Storage Api Template

A working example template showing:

* [C# .net 7 minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0)
* [Storage using Azure Table Storage SDK](https://learn.microsoft.com/en-us/dotnet/api/overview/azure/data.tables-readme?view=azure-dotnet)

Two examples have been created:

* [Strongly-typed `ITableEntity` model](https://github.com/MrSimonC/CSharp-Minimal-API-Table-Storage-SDK-Template/tree/v1.1-strongly-typed-example) (recommended)
* [Dictionary-style using `TableEntity` class](https://github.com/MrSimonC/CSharp-Minimal-API-Table-Storage-SDK-Template/tree/v1.0-dictionary-example)

## Usage

In `appsettings.json`, update `TableStorageConnectionString` to either the connection string for your *Azure Table Storage* account, or your *Azure Cosmos for Table* (i.e. specially created CosmosDb-Table edition). 

See the differences between the two types of account [here](https://learn.microsoft.com/en-us/azure/cosmos-db/table/support?toc=https%3A%2F%2Flearn.microsoft.com%2Fen-us%2Fazure%2Fstorage%2Ftables%2Ftoc.json&bc=https%3A%2F%2Flearn.microsoft.com%2Fen-us%2Fazure%2Fbread%2Ftoc.json). 

This template code has been successfully tested with both *Azure Table Storage* account and *Azure Cosmos for Table*.