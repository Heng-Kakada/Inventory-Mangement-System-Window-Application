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
            supplierFormTitle = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            listStaff = new ListBox();
            picbStaff = new PictureBox();
            btnUpload = new Button();
            panel3 = new Panel();
            lbName = new Label();
            txtName = new TextBox();
            lbContactPerson = new Label();
            btnClear = new Button();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbStaff).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // supplierFormTitle
            // 
            supplierFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supplierFormTitle.AutoSize = true;
            supplierFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierFormTitle.Location = new Point(786, 45);
            supplierFormTitle.Name = "supplierFormTitle";
            supplierFormTitle.Size = new Size(275, 31);
            supplierFormTitle.TabIndex = 2;
            supplierFormTitle.Text = "Supplier's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(877, 620);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(877, 536);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(877, 451);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 60);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lbSearch);
            panel1.Controls.Add(listStaff);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1096, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 900);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(21, 149);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "eg. heng kakada";
            txtSearch.Size = new Size(393, 26);
            txtSearch.TabIndex = 4;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(21, 116);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(60, 20);
            lbSearch.TabIndex = 3;
            lbSearch.Text = "Search";
            // 
            // listStaff
            // 
            listStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listStaff.BackColor = SystemColors.Control;
            listStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listStaff.FormattingEnabled = true;
            listStaff.ItemHeight = 20;
            listStaff.Location = new Point(21, 191);
            listStaff.Margin = new Padding(3, 2, 3, 2);
            listStaff.Name = "listStaff";
            listStaff.Size = new Size(563, 644);
            listStaff.TabIndex = 1;
            // 
            // picbStaff
            // 
            picbStaff.BorderStyle = BorderStyle.FixedSingle;
            picbStaff.Location = new Point(563, 228);
            picbStaff.Margin = new Padding(3, 2, 3, 2);
            picbStaff.Name = "picbStaff";
            picbStaff.Size = new Size(152, 213);
            picbStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            picbStaff.TabIndex = 31;
            picbStaff.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.None;
            btnUpload.Location = new Point(591, 457);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(100, 40);
            btnUpload.TabIndex = 18;
            btnUpload.Text = "Upload Photo";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(picbStaff);
            panel3.Controls.Add(btnUpload);
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lbContactPerson);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 900);
            panel3.TabIndex = 20;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(116, 167);
            lbName.Name = "lbName";
            lbName.Size = new Size(51, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.BackColor = SystemColors.Control;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(116, 193);
            txtName.Name = "txtName";
            txtName.Size = new Size(340, 29);
            txtName.TabIndex = 1;
            // 
            // lbContactPerson
            // 
            lbContactPerson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbContactPerson.AutoSize = true;
            lbContactPerson.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContactPerson.ForeColor = Color.Black;
            lbContactPerson.Location = new Point(116, 228);
            lbContactPerson.Name = "lbContactPerson";
            lbContactPerson.Size = new Size(119, 20);
            lbContactPerson.TabIndex = 2;
            lbContactPerson.Text = "Contact Person";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(877, 704);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(116, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 29);
            textBox3.TabIndex = 39;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(supplierFormTitle);
            Controls.Add(panel3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StaffForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbStaff).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnUpload;
        private Panel panel3;
        private ListBox listStaff;
        private TextBox txtSearch;
        private Label lbSearch;
        private PictureBox picbStaff;
        private Button btnClear;
        private TextBox textBox3;
    }
}