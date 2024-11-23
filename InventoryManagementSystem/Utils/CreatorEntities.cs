using IMS_Services.Entities;
using InventoryManagementSystem.Controller;
using InventoryManagementSystem.Convertion;

namespace InventoryManagementSystem.Utils;

public static class CreatorEntities
{
    public static Staff CreateStaff(Control[] controls)
    {

        Staff staff = new Staff()
        {
            StaffName = Convertor.ConvertToString(controls[1]),
            Gender = Convertor.ConvertToEnumGender(controls[2]),
            BirthDate = Convertor.ConvertToDateTime(controls[3]),
            StaffPosition = Convertor.ConvertToStringFromCbo(controls[4]),
            Address = Convertor.ConvertToString(controls[5]),
            WorkNumber = Convertor.ConvertToString(controls[6]),
            PersonalNumber = Convertor.ConvertToString(controls[7]),
            HiredDate = Convertor.ConvertToDateTime(controls[8]),
            Salary = Convertor.ConvertToDecimal(controls[9]),
            StoppedWork = Convertor.ConvertToBooleanFromCheckBox(controls[10]),
        };
        return staff;
    }


}
