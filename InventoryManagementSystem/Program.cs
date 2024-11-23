using IMS_Services.Manager;
using IMS_Services.Utils;
using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>


    public static DatabaseConnection connection = DatabaseConnection.Instance;

    [STAThread]
    static void Main()
    {

        //// Initialize Database
        ReadJsonFile.Load("appsetting.json");


        // Application Run
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());

    }


}