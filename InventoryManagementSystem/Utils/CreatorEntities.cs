using IMS_Services.Entities;
using InventoryManagementSystem.Convertion;

namespace InventoryManagementSystem.Utils;

public static class CreatorEntities
{
    public static Staff CreateStaff(Control[] controls)
    {

        Staff staff = new Staff()
        {
            StaffName = Convertor.ConvertToString(controls[0]),
            Gender = Convertor.ConvertToEnumGender(controls[1]),
            BirthDate = Convertor.ConvertToDateTime(controls[2]),
            StaffPosition = Convertor.ConvertToStringFromCbo(controls[3]),
            Address = Convertor.ConvertToString(controls[4]),
            WorkNumber = Convertor.ConvertToString(controls[5]),
            PersonalNumber = Convertor.ConvertToString(controls[6]),
            HiredDate = Convertor.ConvertToDateTime(controls[7]),
            Salary = Convertor.ConvertToDecimal(controls[8]),
            StoppedWork = Convertor.ConvertToBooleanFromCheckBox(controls[9]),
        };
        return staff;
    }
}
