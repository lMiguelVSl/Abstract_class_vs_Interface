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

Console.WriteLine("DataAccess abstract class implementation");
var sqlDaAbs = new SqlDataAccessAbstract();
var sqliteDaAbs = new SqliteDataAccessAbstract();

sqlDa.LoadData();
sqlDaAbs.SaveData();
sqlDaAbs.LoadConnectionString();

sqliteDaAbs.LoadConnectionString();
sqliteDaAbs.SaveData();
sqliteDaAbs.LoadInformation();
