namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    partial class SubProduct
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
            panel1 = new Panel();
            SubProductFormTitle = new Label();
            panel3 = new Panel();
            btnSubmit = new Button();
            panel5 = new Panel();
            txtId = new TextBox();
            nudTotalStock = new NumericUpDown();
            lbTotalStock = new Label();
            lbBarCode = new Label();
            txtBarCode = new TextBox();
            txtSalePrice = new TextBox();
            lbCategoryId = new Label();
            cboCategoryId = new ComboBox();
            nudUnitOfMeasure = new NumericUpDown();
            lbUnitOfMeasure = new Label();
            lbSalePrice = new Label();
            lbName = new Label();
            txtName = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitOfMeasure).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SubProductFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 59);
            panel1.TabIndex = 0;
            // 
            // SubProductFormTitle
            // 
            SubProductFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubProductFormTitle.AutoSize = true;
            SubProductFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubProductFormTitle.Location = new Point(80, 12);
            SubProductFormTitle.Name = "SubProductFormTitle";
            SubProductFormTitle.Size = new Size(283, 31);
            SubProductFormTitle.TabIndex = 4;
            SubProductFormTitle.Text = "Add && Update Product";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 541);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 120);
            panel3.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LightGoldenrodYellow;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(438, 38);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 60);
            btnSubmit.TabIndex = 80;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtId);
            panel5.Controls.Add(nudTotalStock);
            panel5.Controls.Add(lbTotalStock);
            panel5.Controls.Add(lbBarCode);
            panel5.Controls.Add(txtBarCode);
            panel5.Controls.Add(txtSalePrice);
            panel5.Controls.Add(lbCategoryId);
            panel5.Controls.Add(cboCategoryId);
            panel5.Controls.Add(nudUnitOfMeasure);
            panel5.Controls.Add(lbUnitOfMeasure);
            panel5.Controls.Add(lbSalePrice);
            panel5.Controls.Add(lbName);
            panel5.Controls.Add(txtName);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(595, 482);
            panel5.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(121, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 29);
            txtId.TabIndex = 80;
            txtId.Visible = false;
            // 
            // nudTotalStock
            // 
            nudTotalStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudTotalStock.BackColor = SystemColors.Control;
            nudTotalStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudTotalStock.Location = new Point(121, 346);
            nudTotalStock.Name = "nudTotalStock";
            nudTotalStock.Size = new Size(290, 26);
            nudTotalStock.TabIndex = 79;
            // 
            // lbTotalStock
            // 
            lbTotalStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTotalStock.AutoSize = true;
            lbTotalStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalStock.ForeColor = Color.Black;
            lbTotalStock.Location = new Point(121, 323);
            lbTotalStock.Name = "lbTotalStock";
            lbTotalStock.Size = new Size(89, 20);
            lbTotalStock.TabIndex = 78;
            lbTotalStock.Text = "Total Stock";
            // 
            // lbBarCode
            // 
            lbBarCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbBarCode.AutoSize = true;
            lbBarCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBarCode.ForeColor = Color.Black;
            lbBarCode.Location = new Point(121, 139);
            lbBarCode.Name = "lbBarCode";
            lbBarCode.Size = new Size(76, 20);
            lbBarCode.TabIndex = 76;
            lbBarCode.Text = "Bar Code";
            // 
            // txtBarCode
            // 
            txtBarCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBarCode.BackColor = SystemColors.Control;
            txtBarCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarCode.Location = new Point(121, 165);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(290, 29);
            txtBarCode.TabIndex = 77;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSalePrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtSalePrice.Location = new Point(121, 224);
            txtSalePrice.Margin = new Padding(3, 2, 3, 2);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PlaceholderText = "0.00";
            txtSalePrice.Size = new Size(290, 26);
            txtSalePrice.TabIndex = 75;
            // 
            // lbCategoryId
            // 
            lbCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategoryId.AutoSize = true;
            lbCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoryId.ForeColor = Color.Black;
            lbCategoryId.Location = new Point(121, 384);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(94, 20);
            lbCategoryId.TabIndex = 73;
            lbCategoryId.Text = "Category ID";
            // 
            // cboCategoryId
            // 
            cboCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboCategoryId.BackColor = SystemColors.Control;
            cboCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoryId.FormattingEnabled = true;
            cboCategoryId.Location = new Point(121, 407);
            cboCategoryId.Name = "cboCategoryId";
            cboCategoryId.Size = new Size(290, 28);
            cboCategoryId.TabIndex = 74;
            // 
            // nudUnitOfMeasure
            // 
            nudUnitOfMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudUnitOfMeasure.BackColor = SystemColors.Control;
            nudUnitOfMeasure.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudUnitOfMeasure.Location = new Point(121, 286);
            nudUnitOfMeasure.Name = "nudUnitOfMeasure";
            nudUnitOfMeasure.Size = new Size(290, 26);
            nudUnitOfMeasure.TabIndex = 64;
            // 
            // lbUnitOfMeasure
            // 
            lbUnitOfMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitOfMeasure.AutoSize = true;
            lbUnitOfMeasure.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitOfMeasure.ForeColor = Color.Black;
            lbUnitOfMeasure.Location = new Point(121, 263);
            lbUnitOfMeasure.Name = "lbUnitOfMeasure";
            lbUnitOfMeasure.Size = new Size(125, 20);
            lbUnitOfMeasure.TabIndex = 63;
            lbUnitOfMeasure.Text = "Unit Of Measure";
            // 
            // lbSalePrice
            // 
            lbSalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSalePrice.AutoSize = true;
            lbSalePrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSalePrice.ForeColor = Color.Black;
            lbSalePrice.Location = new Point(121, 202);
            lbSalePrice.Name = "lbSalePrice";
            lbSalePrice.Size = new Size(80, 20);
            lbSalePrice.TabIndex = 59;
            lbSalePrice.Text = "Sale Price";
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(121, 77);
            lbName.Name = "lbName";
            lbName.Size = new Size(51, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = SystemColors.Control;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(121, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 29);
            txtName.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 482);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(595, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 482);
            panel6.TabIndex = 3;
            // 
            // SubProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(584, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SubProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Adding & Updating";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitOfMeasure).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private NumericUpDown nudUnitOfMeasure;
        private Label lbUnitOfMeasure;
        private Label lbSalePrice;
        private Label lbName;
        private TextBox txtName;
        private Panel panel4;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lbCategoryId;
        private ComboBox cboCategoryId;
        private Panel panel6;
        private TextBox txtSalePrice;
        private Label SubProductFormTitle;
        private Label lbBarCode;
        private TextBox txtBarCode;
        private NumericUpDown nudTotalStock;
        private Label lbTotalStock;
        private Button btnSubmit;
        private TextBox txtId;
    }
}