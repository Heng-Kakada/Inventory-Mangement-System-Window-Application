using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;

namespace InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm
{
    public partial class SubExportDetail : Form
    {

        private static SubExportDetail instance = null!;

        public SubExportDetail()
        {
            InitializeComponent();
        }


        #region SingleTon For Only Show One Form
        public static SubExportDetail GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubExportDetail();
            }
            return instance;
        }
        public new void Show()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = this;
                base.Show();
            }
            else
            {
                // Bring the existing form to the front if already open
                instance.BringToFront();
            }
        }
        #endregion


    }
}
