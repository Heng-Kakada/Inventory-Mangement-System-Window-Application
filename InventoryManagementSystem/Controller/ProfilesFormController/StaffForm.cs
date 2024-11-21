
namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

            LoadData();


            cboGender.DataSource = new List<string>() { "Male", "Female" };
            cboGender.SelectedIndex = 0;

            cboPosition.DataSource = new List<string>() { "Sale", "Accountant", "Manager" };
            cboPosition.SelectedIndex = -1;


        }

        #region click event

        #endregion

        #region method
        private void LoadData()
        {
        }
        #endregion


    }
}
