namespace DemoLibrary.Abstract;

public abstract class DataAccessAbstract
{
    public string LoadConnectionString()
    {
        Console.WriteLine("ConnectionString loaded ABSTRACT");
        return "LoadingConnectionString ABSTRACT done";
    }

    public abstract string LoadInformation();
    public abstract string SaveData();

}