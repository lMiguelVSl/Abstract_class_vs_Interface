namespace DemoLibrary.Abstract;

public abstract class DataAccessAbstract
{
    public string LoadConnectionString()
    {
        Console.WriteLine("ConnectionString loaded");
        return "";
    }

    public abstract string LoadInformation();
    public abstract string SaveData();

}