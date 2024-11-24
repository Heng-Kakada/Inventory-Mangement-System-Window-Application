

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

    public static void LoadHandleByCBO(ComboBox comboBox)
    {
        string query = "SELECT StaffID, StaffName FROM tbStaff";
        List<Staff> list = new List<Staff>();
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Staff()
                        {
                            StaffId = reader.GetInt16("StaffID"),
                            StaffName = reader.GetString("StaffName"),
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
        comboBox.ValueMember = "StaffId";
        comboBox.DisplayMember = "StaffName";
        comboBox.SelectedIndex = 0;
    }


    public static void LoadSupplierCBO(ComboBox comboBox)
    {
        string query = "SELECT SupplierID, SupplierName FROM tbSupplier";
        List<Supplier> list = new List<Supplier>();
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Supplier()
                        {
                            ID = reader.GetByte("SupplierID"),
                            Name = reader.GetString("SupplierName"),
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
        comboBox.SelectedIndex = 0;
    }


}
