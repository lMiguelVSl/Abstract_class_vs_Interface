namespace DemoLibrary.Abstract;

public abstract class DataAccessAbstract
{
    public string LoadConnectionString()
    {
        Console.WriteLine("ConnectionString loaded ABSTRACT");
        return "LoadingConnectionString ABSTRACT done";
    }

    public virtual string LoadConnectionStringVirtual()
    {
        return "VIRTUAL METHOD OVERRIDE";
    }

    public abstract string LoadInformation();
    public abstract string SaveData();

}