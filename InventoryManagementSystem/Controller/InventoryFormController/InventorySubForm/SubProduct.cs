﻿

using InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;

namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    public partial class SubProduct : Form
    {


        private static SubProduct instance = null!;

        public SubProduct()
        {
            InitializeComponent();
        }


        #region SingleTon For Only Show One Form
        public static SubProduct GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubProduct();
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
