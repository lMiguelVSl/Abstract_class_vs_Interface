using DemoLibrary.Implementations;

Console.WriteLine("Hello to the Abstract class VS interface project!");
Console.WriteLine("");
Console.WriteLine("IDataAccess interface implementation");
var sqlDa = new SqlDataAccess();
var sqliteDa = new SqliteDataAccess();

sqlDa.LoadData();
sqlDa.SaveData();

Console.WriteLine("IDataAccess interface LoadConnectionString method call from SqlDataAccess");
sqlDa.LoadConnectionString();

sqliteDa.LoadData();
sqliteDa.SaveData();

Console.WriteLine("IDataAccess interface LoadConnectionString method call from SqliteDataAccess");
sqliteDa.LoadConnectionString();

