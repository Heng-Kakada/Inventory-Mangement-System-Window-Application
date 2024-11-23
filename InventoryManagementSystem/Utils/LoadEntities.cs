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
            controls[0].Text = staff.StaffName;
            Casting.CastCombobox(controls[1]).SelectedItem = staff.Gender;
            Casting.CastDateTimePicker(controls[2]).Value = staff.BirthDate;
            Casting.CastCombobox(controls[3]).SelectedItem = staff.StaffPosition;

            controls[4].Text = staff.Address;

            controls[5].Text = staff.WorkNumber;
            controls[6].Text = staff.PersonalNumber;
            Casting.CastDateTimePicker(controls[7]).Value = staff.HiredDate;
            controls[8].Text = staff.Salary.ToString();
            Casting.CastCheckbox(controls[9]).Checked = staff.StoppedWork;
            controls[10].Text = staff.StaffId.ToString();
        }
        catch(Exception ex) {
            MessageBox.Show(ex.Message);
        }

    } 

}
