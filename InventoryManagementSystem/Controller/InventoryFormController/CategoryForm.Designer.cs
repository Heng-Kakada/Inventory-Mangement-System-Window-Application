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
            panel10 = new Panel();
            lbCatID = new Label();
            txtId = new TextBox();
            rtxtDesc = new RichTextBox();
            panel7 = new Panel();
            lbCatName = new Label();
            panel4 = new Panel();
            categoryFormTitle = new Label();
            lbCatDesc = new Label();
            txtName = new TextBox();
            txtPaymentID = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnClear = new Button();
            panel2 = new Panel();
            dgvCategory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel9 = new Panel();
            panel5 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtPaymentID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 1102);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
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
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 1102);
            panel3.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(144, 889);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(629, 213);
            panel10.TabIndex = 10;
            // 
            // lbCatID
            // 
            lbCatID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCatID.AutoSize = true;
            lbCatID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatID.Location = new Point(190, 323);
            lbCatID.Name = "lbCatID";
            lbCatID.Size = new Size(28, 25);
            lbCatID.TabIndex = 3;
            lbCatID.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(190, 359);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(516, 30);
            txtId.TabIndex = 4;
            // 
            // rtxtDesc
            // 
            rtxtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtDesc.BackColor = SystemColors.Control;
            rtxtDesc.BorderStyle = BorderStyle.FixedSingle;
            rtxtDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtDesc.Location = new Point(190, 521);
            rtxtDesc.Margin = new Padding(3, 4, 3, 4);
            rtxtDesc.Name = "rtxtDesc";
            rtxtDesc.Size = new Size(516, 253);
            rtxtDesc.TabIndex = 8;
            rtxtDesc.Text = "";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 125);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(144, 977);
            panel7.TabIndex = 9;
            // 
            // lbCatName
            // 
            lbCatName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCatName.AutoSize = true;
            lbCatName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatName.Location = new Point(190, 401);
            lbCatName.Name = "lbCatName";
            lbCatName.Size = new Size(64, 25);
            lbCatName.TabIndex = 5;
            lbCatName.Text = "Name";
            // 
            // panel4
            // 
            panel4.Controls.Add(categoryFormTitle);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(773, 125);
            panel4.TabIndex = 0;
            // 
            // categoryFormTitle
            // 
            categoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryFormTitle.AutoSize = true;
            categoryFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryFormTitle.Location = new Point(80, 40);
            categoryFormTitle.Name = "categoryFormTitle";
            categoryFormTitle.Size = new Size(357, 39);
            categoryFormTitle.TabIndex = 3;
            categoryFormTitle.Text = "Category's Information";
            // 
            // lbCatDesc
            // 
            lbCatDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCatDesc.AutoSize = true;
            lbCatDesc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCatDesc.Location = new Point(190, 483);
            lbCatDesc.Name = "lbCatDesc";
            lbCatDesc.Size = new Size(109, 25);
            lbCatDesc.TabIndex = 7;
            lbCatDesc.Text = "Description";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(190, 437);
            txtName.Name = "txtName";
            txtName.Size = new Size(516, 30);
            txtName.TabIndex = 6;
            // 
            // txtPaymentID
            // 
            txtPaymentID.Font = new Font("Times New Roman", 12F);
            txtPaymentID.Location = new Point(277, 223);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.ReadOnly = true;
            txtPaymentID.Size = new Size(235, 30);
            txtPaymentID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(121, 224);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 3;
            label1.Text = "Payment ID";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(77, 562);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 80);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(77, 447);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 80);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(77, 327);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(137, 80);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(77, 683);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 80);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCategory);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1109, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 1102);
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
            dgvCategory.Location = new Point(0, 276);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(705, 681);
            dgvCategory.TabIndex = 49;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 64.93507F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDesc.FillWeight = 135.064941F;
            colDesc.HeaderText = "Description";
            colDesc.MinimumWidth = 6;
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(705, 276);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(128, 681);
            panel6.TabIndex = 52;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 957);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(833, 145);
            panel9.TabIndex = 51;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(lbSearch);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(833, 276);
            panel5.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(0, 208);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(449, 30);
            txtSearch.TabIndex = 6;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(3, 164);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(89, 29);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search";
            // 
            // panel8
            // 
            panel8.Controls.Add(btnDelete);
            panel8.Controls.Add(btnClear);
            panel8.Controls.Add(btnInsert);
            panel8.Controls.Add(btnUpdate);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(773, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(336, 1102);
            panel8.TabIndex = 2;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1942, 1102);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CategoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel8;
        private Panel panel10;
    }
}