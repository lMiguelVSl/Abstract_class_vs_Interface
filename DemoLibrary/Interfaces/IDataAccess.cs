namespace DemoLibrary.Interfaces;

public interface IDataAccess
{
    public string LoadConnectionString();
    public string LoadData();
    public string SaveData();
}