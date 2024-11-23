

using IMS_Services.Manager;
using IMS_Services.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Utils;

public class LoadComboBoxes
{
    private static DatabaseConnection connection = DatabaseConnection.Instance;
    public static void LoadCategoryCBO(ComboBox comboBox)
    {
        string query = "SELECT CategoryID, CategoryName FROM tbCategory";
        List<Category> list = new List<Category>();
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        //comboBox.Items.Add(new Category()
                        //{ 
                        //    ID = reader.GetByte("CategoryID"),
                        //    Name = reader.GetString("CategoryName"),
                        //});
                        list.Add(new Category()
                        {
                            ID = reader.GetByte("CategoryID"),
                            Name = reader.GetString("CategoryName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }
}
