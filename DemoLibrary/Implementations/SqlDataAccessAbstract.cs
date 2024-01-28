using DemoLibrary.Abstract;

namespace DemoLibrary.Implementations;

public class SqlDataAccessAbstract : DataAccessAbstract
{
    public override string LoadInformation()
    {
        Console.WriteLine("Loading Information sqlDA abstract");
        return "LoadInformation abstract done";
    }

    public override string SaveData()
    {
        Console.WriteLine("");
        return "SaveData abstract done";
    }
}