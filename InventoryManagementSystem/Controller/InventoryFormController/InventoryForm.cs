
using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;

namespace InventoryManagementSystem.Controller.InventoryFormController
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            btnAdd.Click += DoClickAddInventory;


        }

        private void DoClickAddInventory(object? sender, EventArgs e)
        {
            SubInventory subInventory = new SubInventory();
            subInventory.Show();
        }
    }
}
