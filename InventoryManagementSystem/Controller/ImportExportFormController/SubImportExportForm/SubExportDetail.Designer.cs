namespace InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm
{
    partial class SubExportDetail
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
            panel1 = new Panel();
            subExportDetailFormTitle = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            btnSubmit = new Button();
            panel5 = new Panel();
            txtUnitPrice = new TextBox();
            lbProductId = new Label();
            cboProductId = new ComboBox();
            nudSubTotal = new NumericUpDown();
            lbSubTotal = new Label();
            nudQuantityExport = new NumericUpDown();
            lbUnitPrice = new Label();
            lbQuanityExported = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvExportDetail = new DataGridView();
            lbCategoryId = new Label();
            cboCategoryId = new ComboBox();
            colId = new DataGridViewTextBoxColumn();
            colQtyExport = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colInventoryId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSubTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(subExportDetailFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 59);
            panel1.TabIndex = 0;
            // 
            // subExportDetailFormTitle
            // 
            subExportDetailFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subExportDetailFormTitle.AutoSize = true;
            subExportDetailFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subExportDetailFormTitle.Location = new Point(85, 13);
            subExportDetailFormTitle.Name = "subExportDetailFormTitle";
            subExportDetailFormTitle.Size = new Size(360, 31);
            subExportDetailFormTitle.TabIndex = 3;
            subExportDetailFormTitle.Text = "Add && Update Export History";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 603);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 58);
            panel3.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(86, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 44);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LightGoldenrodYellow;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(226, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(109, 44);
            btnSubmit.TabIndex = 81;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbCategoryId);
            panel5.Controls.Add(cboCategoryId);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProductId);
            panel5.Controls.Add(nudSubTotal);
            panel5.Controls.Add(lbSubTotal);
            panel5.Controls.Add(nudQuantityExport);
            panel5.Controls.Add(lbUnitPrice);
            panel5.Controls.Add(lbQuanityExported);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 544);
            panel5.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitPrice.Location = new Point(51, 173);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "0.00";
            txtUnitPrice.Size = new Size(330, 26);
            txtUnitPrice.TabIndex = 75;
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(50, 275);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(82, 20);
            lbProductId.TabIndex = 73;
            lbProductId.Text = "Product Id";
            // 
            // cboProductId
            // 
            cboProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProductId.BackColor = SystemColors.Control;
            cboProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(50, 298);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(331, 28);
            cboProductId.TabIndex = 74;
            // 
            // nudSubTotal
            // 
            nudSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudSubTotal.BackColor = SystemColors.Control;
            nudSubTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudSubTotal.Location = new Point(50, 237);
            nudSubTotal.Name = "nudSubTotal";
            nudSubTotal.Size = new Size(330, 26);
            nudSubTotal.TabIndex = 66;
            // 
            // lbSubTotal
            // 
            lbSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSubTotal.AutoSize = true;
            lbSubTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTotal.ForeColor = Color.Black;
            lbSubTotal.Location = new Point(50, 214);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(77, 20);
            lbSubTotal.TabIndex = 65;
            lbSubTotal.Text = "Sub Total";
            // 
            // nudQuantityExport
            // 
            nudQuantityExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudQuantityExport.BackColor = SystemColors.Control;
            nudQuantityExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantityExport.Location = new Point(51, 115);
            nudQuantityExport.Name = "nudQuantityExport";
            nudQuantityExport.Size = new Size(330, 26);
            nudQuantityExport.TabIndex = 64;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitPrice.ForeColor = Color.Black;
            lbUnitPrice.Location = new Point(50, 151);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(77, 20);
            lbUnitPrice.TabIndex = 63;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuanityExported
            // 
            lbQuanityExported.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQuanityExported.AutoSize = true;
            lbQuanityExported.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuanityExported.ForeColor = Color.Black;
            lbQuanityExported.Location = new Point(51, 92);
            lbQuanityExported.Name = "lbQuanityExported";
            lbQuanityExported.Size = new Size(131, 20);
            lbQuanityExported.TabIndex = 59;
            lbQuanityExported.Text = "Quanity Exported";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(1184, 544);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(463, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 544);
            panel6.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvExportDetail);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(463, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 544);
            panel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(707, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(14, 544);
            panel7.TabIndex = 0;
            // 
            // dgvExportDetail
            // 
            dgvExportDetail.AllowUserToAddRows = false;
            dgvExportDetail.AllowUserToDeleteRows = false;
            dgvExportDetail.BackgroundColor = SystemColors.Control;
            dgvExportDetail.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExportDetail.Columns.AddRange(new DataGridViewColumn[] { colId, colQtyExport, colUnitPrice, colSubTotal, colProductId, colInventoryId });
            dgvExportDetail.Dock = DockStyle.Fill;
            dgvExportDetail.GridColor = SystemColors.Control;
            dgvExportDetail.Location = new Point(0, 0);
            dgvExportDetail.Name = "dgvExportDetail";
            dgvExportDetail.ReadOnly = true;
            dgvExportDetail.Size = new Size(707, 544);
            dgvExportDetail.TabIndex = 1;
            // 
            // lbCategoryId
            // 
            lbCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategoryId.AutoSize = true;
            lbCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoryId.ForeColor = Color.Black;
            lbCategoryId.Location = new Point(51, 340);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(94, 20);
            lbCategoryId.TabIndex = 76;
            lbCategoryId.Text = "Category ID";
            // 
            // cboCategoryId
            // 
            cboCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboCategoryId.BackColor = SystemColors.Control;
            cboCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoryId.FormattingEnabled = true;
            cboCategoryId.Location = new Point(51, 363);
            cboCategoryId.Name = "cboCategoryId";
            cboCategoryId.Size = new Size(331, 28);
            cboCategoryId.TabIndex = 77;
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
            colId.Width = 51;
            // 
            // colQtyExport
            // 
            colQtyExport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQtyExport.HeaderText = "Qty";
            colQtyExport.Name = "colQtyExport";
            colQtyExport.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colSubTotal
            // 
            colSubTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSubTotal.HeaderText = "Sub Total";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            // 
            // colProductId
            // 
            colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductId.HeaderText = "Product ID";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // colInventoryId
            // 
            colInventoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInventoryId.HeaderText = "Inventory ID";
            colInventoryId.Name = "colInventoryId";
            colInventoryId.ReadOnly = true;
            // 
            // SubExportDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SubExportDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Export Detail Adding & Updating";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSubTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private NumericUpDown nudSubTotal;
        private Label lbSubTotal;
        private NumericUpDown nudQuantityExport;
        private Label lbUnitPrice;
        private Label lbQuanityExported;
        private Panel panel4;
        private Label lbProductId;
        private ComboBox cboProductId;
        private Panel panel6;
        private Panel panel2;
        private Panel panel7;
        private TextBox txtUnitPrice;
        private Label subExportDetailFormTitle;
        private Button btnAdd;
        private Button btnSubmit;
        private DataGridView dgvExportDetail;
        private Label lbCategoryId;
        private ComboBox cboCategoryId;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colQtyExport;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colSubTotal;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colInventoryId;
    }
}