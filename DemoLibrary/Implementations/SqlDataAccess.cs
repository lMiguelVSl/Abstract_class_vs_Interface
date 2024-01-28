using DemoLibrary.Interfaces;

namespace DemoLibrary.Implementations;

public class SqlDataAccess : IDataAccess
{
    public string LoadConnectionString()
    {
        Console.WriteLine("loading connection string INTERFACE");
        return "SqlDataAccess INTERFACE connection string loaded";
    }

    public string LoadData()
    {
        Console.WriteLine("loading data INTERFACE");
        return "SqlDataAccess INTERFACE LoadData done";
    }

    public string SaveData()
    {
        Console.WriteLine("Saving data INTERFACE");
        return "SqlDataAccess INTERFACE SaveData done";
    }
}