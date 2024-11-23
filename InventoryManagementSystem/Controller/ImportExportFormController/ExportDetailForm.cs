using InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;


namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    public partial class ExportDetailForm : Form
    {
        public ExportDetailForm()
        {
            InitializeComponent();



            btnAdd.Click += DoClickAddExportDetail;



        }

        private void DoClickAddExportDetail(object? sender, EventArgs e)
        {
            SubExportDetail subExportDetail = new SubExportDetail();
            subExportDetail.Show();
        }
    }
}
