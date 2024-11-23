namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pHead = new Panel();
            exportFormTitle = new Label();
            txtSearch = new TextBox();
            lbSearch = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colImportDate = new DataGridViewTextBoxColumn();
            colTotalCost = new DataGridViewTextBoxColumn();
            colTotalItem = new DataGridViewTextBoxColumn();
            colHandleBy = new DataGridViewTextBoxColumn();
            colSupplierId = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btnClear = new Button();
            nudTotalItem = new NumericUpDown();
            lbTotalItem = new Label();
            lbDate = new Label();
            cboHandleBy = new ComboBox();
            lbTotalCost = new Label();
            lbHandleBy = new Label();
            txtTotalCost = new TextBox();
            dtExportDate = new DateTimePicker();
            panel1 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalItem).BeginInit();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(exportFormTitle);
            pHead.Controls.Add(txtSearch);
            pHead.Controls.Add(lbSearch);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 93);
            pHead.TabIndex = 0;
            // 
            // exportFormTitle
            // 
            exportFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exportFormTitle.AutoSize = true;
            exportFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportFormTitle.Location = new Point(69, 32);
            exportFormTitle.Name = "exportFormTitle";
            exportFormTitle.Size = new Size(274, 33);
            exportFormTitle.TabIndex = 12;
            exportFormTitle.Text = "Export's Information";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1327, 41);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(393, 26);
            txtSearch.TabIndex = 11;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(1251, 42);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(70, 24);
            lbSearch.TabIndex = 10;
            lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(659, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(659, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(659, 304);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 818);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1800, 82);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(panel3);
            pBody.Controls.Add(panel2);
            pBody.Controls.Add(panel1);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 93);
            pBody.Name = "pBody";
            pBody.Size = new Size(1800, 725);
            pBody.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvInventory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(877, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 725);
            panel3.TabIndex = 3;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeight = 40;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colImportDate, colTotalCost, colTotalItem, colHandleBy, colSupplierId });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = SystemColors.Control;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.Size = new Size(843, 725);
            dgvInventory.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colImportDate
            // 
            colImportDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colImportDate.HeaderText = "Import Date";
            colImportDate.Name = "colImportDate";
            colImportDate.ReadOnly = true;
            // 
            // colTotalCost
            // 
            colTotalCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalCost.HeaderText = "Total Cost";
            colTotalCost.Name = "colTotalCost";
            colTotalCost.ReadOnly = true;
            // 
            // colTotalItem
            // 
            colTotalItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalItem.HeaderText = "Total Item";
            colTotalItem.Name = "colTotalItem";
            colTotalItem.ReadOnly = true;
            // 
            // colHandleBy
            // 
            colHandleBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHandleBy.HeaderText = "Handle By";
            colHandleBy.Name = "colHandleBy";
            colHandleBy.ReadOnly = true;
            // 
            // colSupplierId
            // 
            colSupplierId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSupplierId.HeaderText = "Supplier ID";
            colSupplierId.Name = "colSupplierId";
            colSupplierId.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 725);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(nudTotalItem);
            panel4.Controls.Add(lbTotalItem);
            panel4.Controls.Add(lbDate);
            panel4.Controls.Add(cboHandleBy);
            panel4.Controls.Add(lbTotalCost);
            panel4.Controls.Add(lbHandleBy);
            panel4.Controls.Add(txtTotalCost);
            panel4.Controls.Add(dtExportDate);
            panel4.Dock = DockStyle.Left;
            panel4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 725);
            panel4.TabIndex = 54;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnClear);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(562, 213);
            panel5.TabIndex = 57;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 213);
            panel6.TabIndex = 54;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(93, 34);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // nudTotalItem
            // 
            nudTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudTotalItem.BackColor = SystemColors.Control;
            nudTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudTotalItem.Location = new Point(93, 234);
            nudTotalItem.Name = "nudTotalItem";
            nudTotalItem.Size = new Size(390, 26);
            nudTotalItem.TabIndex = 56;
            // 
            // lbTotalItem
            // 
            lbTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalItem.AutoSize = true;
            lbTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalItem.ForeColor = Color.Black;
            lbTotalItem.Location = new Point(93, 211);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(80, 20);
            lbTotalItem.TabIndex = 54;
            lbTotalItem.Text = "Total Item";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(93, 126);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(44, 20);
            lbDate.TabIndex = 39;
            lbDate.Text = "Date";
            // 
            // cboHandleBy
            // 
            cboHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboHandleBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHandleBy.Font = new Font("Microsoft Sans Serif", 12F);
            cboHandleBy.FormattingEnabled = true;
            cboHandleBy.Location = new Point(93, 395);
            cboHandleBy.Margin = new Padding(3, 2, 3, 2);
            cboHandleBy.Name = "cboHandleBy";
            cboHandleBy.Size = new Size(390, 28);
            cboHandleBy.TabIndex = 52;
            // 
            // lbTotalCost
            // 
            lbTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalCost.AutoSize = true;
            lbTotalCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalCost.ForeColor = Color.Black;
            lbTotalCost.Location = new Point(93, 289);
            lbTotalCost.Name = "lbTotalCost";
            lbTotalCost.Size = new Size(81, 20);
            lbTotalCost.TabIndex = 12;
            lbTotalCost.Text = "Total Cost";
            // 
            // lbHandleBy
            // 
            lbHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbHandleBy.AutoSize = true;
            lbHandleBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHandleBy.ForeColor = Color.Black;
            lbHandleBy.Location = new Point(93, 368);
            lbHandleBy.Name = "lbHandleBy";
            lbHandleBy.Size = new Size(82, 20);
            lbHandleBy.TabIndex = 50;
            lbHandleBy.Text = "Handle By";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtTotalCost.Location = new Point(93, 311);
            txtTotalCost.Margin = new Padding(3, 2, 3, 2);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.PlaceholderText = "0.00";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(390, 26);
            txtTotalCost.TabIndex = 37;
            // 
            // dtExportDate
            // 
            dtExportDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExportDate.CustomFormat = " yyyy/MM/dd";
            dtExportDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtExportDate.Format = DateTimePickerFormat.Custom;
            dtExportDate.Location = new Point(93, 148);
            dtExportDate.Margin = new Padding(3, 2, 3, 2);
            dtExportDate.Name = "dtExportDate";
            dtExportDate.Size = new Size(390, 26);
            dtExportDate.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1720, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 725);
            panel1.TabIndex = 1;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExportForm";
            Text = "ExportForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTotalItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvInventory;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label lbSearch;
        private Label exportFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colImportDate;
        private DataGridViewTextBoxColumn colTotalCost;
        private DataGridViewTextBoxColumn colTotalItem;
        private DataGridViewTextBoxColumn colHandleBy;
        private DataGridViewTextBoxColumn colSupplierId;
        private TextBox txtTotalCost;
        private Label lbTotalCost;
        private ComboBox cboHandleBy;
        private ComboBox cboContractID;
        private Label lbHandleBy;
        private Label label3;
        private Label lbDate;
        private DateTimePicker dtExportDate;
        private Button btnClear;
        private Panel panel4;
        private Label lbTotalItem;
        private NumericUpDown nudTotalItem;
        private TextBox txtName;
        private Panel panel5;
        private Panel panel6;
    }
}