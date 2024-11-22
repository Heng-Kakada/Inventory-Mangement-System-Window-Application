namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    partial class ImportForm
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
            importFormTitle = new Label();
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
            btnClear = new Button();
            comboBox1 = new ComboBox();
            cboContractID = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            lbDate = new Label();
            dtImportDate = new DateTimePicker();
            textBox1 = new TextBox();
            txtRentalPrice = new TextBox();
            label1 = new Label();
            lbTotalCost = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(importFormTitle);
            pHead.Controls.Add(txtSearch);
            pHead.Controls.Add(lbSearch);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 93);
            pHead.TabIndex = 0;
            // 
            // importFormTitle
            // 
            importFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            importFormTitle.AutoSize = true;
            importFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importFormTitle.Location = new Point(69, 32);
            importFormTitle.Name = "importFormTitle";
            importFormTitle.Size = new Size(273, 33);
            importFormTitle.TabIndex = 12;
            importFormTitle.Text = "Import's Information";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1327, 50);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(393, 26);
            txtSearch.TabIndex = 11;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.None;
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(1377, 18);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(70, 24);
            lbSearch.TabIndex = 10;
            lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
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
            btnAdd.Anchor = AnchorStyles.Left;
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
            btnUpdate.Anchor = AnchorStyles.Left;
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
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(93, 520);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 430);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 28);
            comboBox1.TabIndex = 52;
            // 
            // cboContractID
            // 
            cboContractID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboContractID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContractID.Font = new Font("Microsoft Sans Serif", 12F);
            cboContractID.FormattingEnabled = true;
            cboContractID.Location = new Point(93, 356);
            cboContractID.Margin = new Padding(3, 2, 3, 2);
            cboContractID.Name = "cboContractID";
            cboContractID.Size = new Size(390, 28);
            cboContractID.TabIndex = 51;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(93, 408);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 50;
            label4.Text = "Total Cost";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(93, 334);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 48;
            label3.Text = "Total Cost";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(93, 121);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(44, 20);
            lbDate.TabIndex = 39;
            lbDate.Text = "Date";
            // 
            // dtImportDate
            // 
            dtImportDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtImportDate.CustomFormat = " yyyy/MM/dd";
            dtImportDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtImportDate.Format = DateTimePickerFormat.Custom;
            dtImportDate.Location = new Point(93, 143);
            dtImportDate.Margin = new Padding(3, 2, 3, 2);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(390, 26);
            dtImportDate.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(93, 287);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0.00";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(390, 26);
            textBox1.TabIndex = 37;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRentalPrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtRentalPrice.Location = new Point(93, 215);
            txtRentalPrice.Margin = new Padding(3, 2, 3, 2);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.PlaceholderText = "0.00";
            txtRentalPrice.ReadOnly = true;
            txtRentalPrice.Size = new Size(390, 26);
            txtRentalPrice.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(93, 265);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 12;
            label1.Text = "Total Cost";
            // 
            // lbTotalCost
            // 
            lbTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalCost.AutoSize = true;
            lbTotalCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalCost.ForeColor = Color.Black;
            lbTotalCost.Location = new Point(93, 193);
            lbTotalCost.Name = "lbTotalCost";
            lbTotalCost.Size = new Size(81, 20);
            lbTotalCost.TabIndex = 10;
            lbTotalCost.Text = "Total Cost";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1720, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 725);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbDate);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(lbTotalCost);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cboContractID);
            panel4.Controls.Add(txtRentalPrice);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dtImportDate);
            panel4.Dock = DockStyle.Left;
            panel4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 725);
            panel4.TabIndex = 54;
            // 
            // ImportForm
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
            Name = "ImportForm";
            Text = "ImportForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label importFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colImportDate;
        private DataGridViewTextBoxColumn colTotalCost;
        private DataGridViewTextBoxColumn colTotalItem;
        private DataGridViewTextBoxColumn colHandleBy;
        private DataGridViewTextBoxColumn colSupplierId;
        private Label lbTotalCost;
        private TextBox textBox1;
        private TextBox txtRentalPrice;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cboContractID;
        private Label label4;
        private Label label3;
        private Label lbDate;
        private DateTimePicker dtImportDate;
        private Button btnClear;
        private Panel panel4;
    }
}