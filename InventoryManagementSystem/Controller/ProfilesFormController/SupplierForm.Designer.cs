namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    partial class SupplierForm
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

        #region
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            supplierFormTitle = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            dgvSupplier = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colPaymentTerm = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel4 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            panel3 = new Panel();
            lbPaymentTerm = new Label();
            dtPaymentTerm = new DateTimePicker();
            lbPaymentMethod = new Label();
            cboPaymentMethod = new ComboBox();
            lbPhone = new Label();
            mtxtPhone = new MaskedTextBox();
            textBox2 = new TextBox();
            lbAddress = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            textBox3 = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbContactPerson = new Label();
            btnClear = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // supplierFormTitle
            // 
            supplierFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supplierFormTitle.AutoSize = true;
            supplierFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierFormTitle.Location = new Point(80, 40);
            supplierFormTitle.Name = "supplierFormTitle";
            supplierFormTitle.Size = new Size(345, 39);
            supplierFormTitle.TabIndex = 2;
            supplierFormTitle.Text = "Supplier's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(122, 554);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 80);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(122, 442);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 80);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(122, 328);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(137, 80);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(dgvSupplier);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1084, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 1102);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 997);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(820, 105);
            panel6.TabIndex = 3;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.AllowUserToDeleteRows = false;
            dgvSupplier.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSupplier.ColumnHeadersHeight = 40;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSupplier.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colContact, colPhone, colPaymentMethod, colPaymentTerm });
            dgvSupplier.Dock = DockStyle.Fill;
            dgvSupplier.GridColor = SystemColors.Control;
            dgvSupplier.Location = new Point(0, 133);
            dgvSupplier.Margin = new Padding(3, 4, 3, 4);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(820, 969);
            dgvSupplier.TabIndex = 2;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 55;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colContact.HeaderText = "Contact Person";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentMethod.HeaderText = "Method";
            colPaymentMethod.MinimumWidth = 6;
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            // 
            // colPaymentTerm
            // 
            colPaymentTerm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentTerm.HeaderText = "Term";
            colPaymentTerm.MinimumWidth = 6;
            colPaymentTerm.Name = "colPaymentTerm";
            colPaymentTerm.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(820, 133);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(38, 969);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(lbSearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(858, 133);
            panel4.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(371, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(449, 30);
            txtSearch.TabIndex = 24;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(285, 76);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(89, 29);
            lbSearch.TabIndex = 23;
            lbSearch.Text = "Search";
            // 
            // panel3
            // 
            panel3.Controls.Add(supplierFormTitle);
            panel3.Controls.Add(lbPaymentTerm);
            panel3.Controls.Add(dtPaymentTerm);
            panel3.Controls.Add(lbPaymentMethod);
            panel3.Controls.Add(cboPaymentMethod);
            panel3.Controls.Add(lbPhone);
            panel3.Controls.Add(mtxtPhone);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(lbAddress);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(lbEmail);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lbContactPerson);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(707, 1102);
            panel3.TabIndex = 20;
            // 
            // lbPaymentTerm
            // 
            lbPaymentTerm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPaymentTerm.AutoSize = true;
            lbPaymentTerm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPaymentTerm.ForeColor = Color.Black;
            lbPaymentTerm.Location = new Point(111, 705);
            lbPaymentTerm.Name = "lbPaymentTerm";
            lbPaymentTerm.Size = new Size(140, 25);
            lbPaymentTerm.TabIndex = 48;
            lbPaymentTerm.Text = "Payment Term";
            // 
            // dtPaymentTerm
            // 
            dtPaymentTerm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtPaymentTerm.CalendarFont = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPaymentTerm.CalendarMonthBackground = SystemColors.Control;
            dtPaymentTerm.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPaymentTerm.Location = new Point(111, 736);
            dtPaymentTerm.Margin = new Padding(3, 4, 3, 4);
            dtPaymentTerm.Name = "dtPaymentTerm";
            dtPaymentTerm.Size = new Size(462, 26);
            dtPaymentTerm.TabIndex = 49;
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPaymentMethod.ForeColor = Color.Black;
            lbPaymentMethod.Location = new Point(111, 619);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(160, 25);
            lbPaymentMethod.TabIndex = 46;
            lbPaymentMethod.Text = "Payment Method";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPaymentMethod.BackColor = SystemColors.Control;
            cboPaymentMethod.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(111, 649);
            cboPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(462, 33);
            cboPaymentMethod.TabIndex = 47;
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhone.ForeColor = Color.Black;
            lbPhone.Location = new Point(111, 536);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(69, 25);
            lbPhone.TabIndex = 45;
            lbPhone.Text = "Phone";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtxtPhone.BackColor = SystemColors.Control;
            mtxtPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtPhone.Location = new Point(111, 565);
            mtxtPhone.Mask = "(855) ##-###-####";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(462, 30);
            mtxtPhone.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.Control;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(111, 480);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 34);
            textBox2.TabIndex = 43;
            // 
            // lbAddress
            // 
            lbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.ForeColor = Color.Black;
            lbAddress.Location = new Point(111, 449);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(85, 25);
            lbAddress.TabIndex = 42;
            lbAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(111, 393);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "exmaple@gmail.com";
            txtEmail.Size = new Size(462, 34);
            txtEmail.TabIndex = 41;
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(111, 363);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(60, 25);
            lbEmail.TabIndex = 40;
            lbEmail.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(111, 309);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(462, 34);
            textBox3.TabIndex = 39;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(111, 197);
            lbName.Name = "lbName";
            lbName.Size = new Size(64, 25);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = SystemColors.Control;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(111, 232);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(462, 34);
            txtName.TabIndex = 1;
            // 
            // lbContactPerson
            // 
            lbContactPerson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbContactPerson.AutoSize = true;
            lbContactPerson.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContactPerson.ForeColor = Color.Black;
            lbContactPerson.Location = new Point(111, 279);
            lbContactPerson.Name = "lbContactPerson";
            lbContactPerson.Size = new Size(147, 25);
            lbContactPerson.TabIndex = 2;
            lbContactPerson.Text = "Contact Person";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(122, 666);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 80);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(707, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 1102);
            panel2.TabIndex = 22;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1942, 1102);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SupplierForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label supplierFormTitle;
        private Label lbContactPerson;
        private TextBox txtName;
        private Label lbName;
        private Panel panel1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel3;
        private Button btnClear;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lbAddress;
        private TextBox txtEmail;
        private Label lbEmail;
        private Panel panel2;
        private Label lbPhone;
        private MaskedTextBox mtxtPhone;
        private Label lbPaymentMethod;
        private ComboBox cboPaymentMethod;
        private Label lbPaymentTerm;
        private DateTimePicker dtPaymentTerm;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colPaymentTerm;
        private Panel panel6;
        private TextBox txtSearch;
        private Label lbSearch;
    }
}