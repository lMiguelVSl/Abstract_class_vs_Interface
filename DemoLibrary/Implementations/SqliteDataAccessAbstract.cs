using DemoLibrary.Abstract;

namespace DemoLibrary.Implementations;

public class SqliteDataAccessAbstract : DataAccessAbstract
{
    public override string LoadInformation()
    {
        Console.WriteLine("Loading Information sqliteDA abstract");
        return "LoadInformation abstract done";
    }

    public override string SaveData()
    {
        Console.WriteLine("Save Data sqliteDA abstract");
        return "SaveData abstract done";
    }
}