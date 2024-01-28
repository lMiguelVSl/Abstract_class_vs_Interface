using DemoLibrary.Interfaces;

namespace DemoLibrary.Implementations;

public class SqliteDataAccess : IDataAccess
{
    public string LoadConnectionString()
    {
        Console.WriteLine("Loading connection string INTERFACE");
        return "SqlDataAccess ABSTRACT connection string loaded";
    }

    public string LoadData()
    {
        Console.WriteLine("Loading data INTERFACE");
        return "SqlDataAccess ABSTRACT LoadData done";
    }

    public string SaveData()
    {
        Console.WriteLine("Saving data INTERFACE");
        return "SqlDataAccess ABSTRACT SaveData done";
    }
}