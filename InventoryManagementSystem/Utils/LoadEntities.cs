using IMS_Services.Entities;
using IMS_Services.Services.Implementation;

namespace InventoryManagementSystem.Utils;

public static class LoadEntities
{
    public static void LoadStaffFromListStaff(Control[] controls, ListBox listBox)
    {
        if (listBox.SelectedItem == null) return;
        string? staffData = listBox.SelectedItem.ToString();
        if (staffData == null) return;
        short.TryParse(staffData.Split('.')[0], out short staffId);
        try
        {
            Staff staff = (Staff)StaffServices.GetById(staffId);

            controls[0].Text = staff.StaffId.ToString();
            controls[1].Text = staff.StaffName;
            Casting.CastCombobox(controls[2]).SelectedItem = staff.Gender;
            Casting.CastDateTimePicker(controls[3]).Value = staff.BirthDate;
            Casting.CastCombobox(controls[4]).SelectedItem = staff.StaffPosition;

            controls[5].Text = staff.Address;

            controls[6].Text = staff.WorkNumber;
            controls[7].Text = staff.PersonalNumber;
            Casting.CastDateTimePicker(controls[8]).Value = staff.HiredDate;
            controls[9].Text = staff.Salary.ToString();
            Casting.CastCheckbox(controls[10]).Checked = staff.StoppedWork;
            
        }
        catch(Exception ex) {
            MessageBox.Show(ex.Message);
        }
    } 


    public static void LoadSupplierFromDataGrid(Control[] controls, DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return;
        byte selectedId = (byte)dgv.CurrentRow.Cells[0].Value;

        try
        {
            Supplier supplier = SupplierServices.GetById(selectedId);

            if (supplier == null) return;

            controls[0].Text = supplier.ID.ToString();
            controls[1].Text = supplier.Name;
            controls[2].Text = supplier.Email;
            controls[3].Text = supplier.Address;
            controls[4].Text = supplier.Phone;
            Casting.CastCombobox(controls[5]).SelectedItem = supplier.PaymentMethod;
            controls[6].Text = supplier.PaymentTerm.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }






}
