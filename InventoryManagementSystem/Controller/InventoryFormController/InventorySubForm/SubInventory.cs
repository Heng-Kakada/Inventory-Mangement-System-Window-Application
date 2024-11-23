using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    public partial class SubInventory : Form
    {

        private static SubInventory instance = null!;

        public SubInventory()
        {
            InitializeComponent();
        }

        #region SingleTon For Only Show One Form
        public static SubInventory GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubInventory();
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
