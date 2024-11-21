namespace InventoryManagementSystem.Controller
{
    partial class CategoryForm
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
            panel1 = new Panel();
            panel3 = new Panel();
            lbCatID = new Label();
            txtId = new TextBox();
            rtxtDesc = new RichTextBox();
            panel7 = new Panel();
            lbCatName = new Label();
            panel4 = new Panel();
            lbCatDesc = new Label();
            txtName = new TextBox();
            txtPaymentID = new TextBox();
            label1 = new Label();
            categoryFormTitle = new Label();
            panel2 = new Panel();
            dgvCategory = new DataGridView();
            panel6 = new Panel();
            panel9 = new Panel();
            panel5 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnClear = new Button();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtPaymentID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 900);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbCatID);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(rtxtDesc);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(lbCatName);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lbCatDesc);
            panel3.Controls.Add(txtName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(729, 900);
            panel3.TabIndex = 5;
            // 
            // lbCatID
            // 
            lbCatID.AutoSize = true;
            lbCatID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatID.Location = new Point(169, 270);
            lbCatID.Name = "lbCatID";
            lbCatID.Size = new Size(23, 20);
            lbCatID.TabIndex = 3;
            lbCatID.Text = "Id";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(169, 297);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(505, 26);
            txtId.TabIndex = 4;
            // 
            // rtxtDesc
            // 
            rtxtDesc.BackColor = SystemColors.Control;
            rtxtDesc.BorderStyle = BorderStyle.FixedSingle;
            rtxtDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtDesc.Location = new Point(169, 419);
            rtxtDesc.Name = "rtxtDesc";
            rtxtDesc.Size = new Size(505, 264);
            rtxtDesc.TabIndex = 8;
            rtxtDesc.Text = "";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 123);
            panel7.Name = "panel7";
            panel7.Size = new Size(126, 777);
            panel7.TabIndex = 9;
            // 
            // lbCatName
            // 
            lbCatName.AutoSize = true;
            lbCatName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatName.Location = new Point(169, 329);
            lbCatName.Name = "lbCatName";
            lbCatName.Size = new Size(51, 20);
            lbCatName.TabIndex = 5;
            lbCatName.Text = "Name";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(729, 123);
            panel4.TabIndex = 0;
            // 
            // lbCatDesc
            // 
            lbCatDesc.AutoSize = true;
            lbCatDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatDesc.Location = new Point(169, 390);
            lbCatDesc.Name = "lbCatDesc";
            lbCatDesc.Size = new Size(89, 20);
            lbCatDesc.TabIndex = 7;
            lbCatDesc.Text = "Description";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(169, 356);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(505, 26);
            txtName.TabIndex = 6;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Font = new Font("Times New Roman", 12F);
            txtPaymentID.Location = new Point(242, 167);
            txtPaymentID.Margin = new Padding(3, 2, 3, 2);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.ReadOnly = true;
            txtPaymentID.Size = new Size(206, 26);
            txtPaymentID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(106, 168);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 3;
            label1.Text = "Payment ID";
            // 
            // categoryFormTitle
            // 
            categoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryFormTitle.AutoSize = true;
            categoryFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryFormTitle.Location = new Point(749, 34);
            categoryFormTitle.Name = "categoryFormTitle";
            categoryFormTitle.Size = new Size(287, 31);
            categoryFormTitle.TabIndex = 3;
            categoryFormTitle.Text = "Category's Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCategory);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1071, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 900);
            panel2.TabIndex = 1;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 40;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colDesc });
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Location = new Point(0, 207);
            dgvCategory.Margin = new Padding(3, 2, 3, 2);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new Size(617, 533);
            dgvCategory.TabIndex = 49;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(617, 207);
            panel6.Name = "panel6";
            panel6.Size = new Size(112, 533);
            panel6.TabIndex = 52;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 740);
            panel9.Name = "panel9";
            panel9.Size = new Size(729, 160);
            panel9.TabIndex = 51;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(lbSearch);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(729, 207);
            panel5.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(0, 156);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(393, 26);
            txtSearch.TabIndex = 6;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(3, 123);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(70, 24);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(827, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(827, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(827, 297);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 60);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(827, 564);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 51;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 64.93507F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDesc.FillWeight = 135.064941F;
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(categoryFormTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CategoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtPaymentID;
        private Label label1;
        private TextBox txtId;
        private Label lbCatID;
        private Panel panel5;
        private RichTextBox rtxtDesc;
        private Label lbCatDesc;
        private TextBox txtName;
        private Label lbCatName;
        private Panel panel7;
        private Label categoryFormTitle;
        private Panel panel9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnClear;
        private TextBox txtSearch;
        private Label lbSearch;
        private DataGridView dgvCategory;
        private Panel panel6;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDesc;
    }
}