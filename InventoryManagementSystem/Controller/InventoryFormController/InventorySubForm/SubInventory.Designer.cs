namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    partial class SubInventory
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            SubInventoryFormTitle = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            btnSubmit = new Button();
            panel5 = new Panel();
            txtId = new TextBox();
            txtUnitCost = new TextBox();
            rtxtNote = new RichTextBox();
            lbProductId = new Label();
            cboProductId = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbNote = new Label();
            nudInitQty = new NumericUpDown();
            lbInitQty = new Label();
            nudCurrentStock = new NumericUpDown();
            lbCurrentStock = new Label();
            lbExpireDate = new Label();
            dtExpireDate = new DateTimePicker();
            lbUnitCost = new Label();
            lbName = new Label();
            txtName = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            dgvInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUnitCost = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colInitQty = new DataGridViewTextBoxColumn();
            colExpireDate = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCurrentStock).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SubInventoryFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 59);
            panel1.TabIndex = 0;
            // 
            // SubInventoryFormTitle
            // 
            SubInventoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubInventoryFormTitle.AutoSize = true;
            SubInventoryFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubInventoryFormTitle.Location = new Point(85, 13);
            SubInventoryFormTitle.Name = "SubInventoryFormTitle";
            SubInventoryFormTitle.Size = new Size(302, 31);
            SubInventoryFormTitle.TabIndex = 3;
            SubInventoryFormTitle.Text = "Add && Update Inventory";
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
            panel5.Controls.Add(txtId);
            panel5.Controls.Add(txtUnitCost);
            panel5.Controls.Add(rtxtNote);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProductId);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(lbNote);
            panel5.Controls.Add(nudInitQty);
            panel5.Controls.Add(lbInitQty);
            panel5.Controls.Add(nudCurrentStock);
            panel5.Controls.Add(lbCurrentStock);
            panel5.Controls.Add(lbExpireDate);
            panel5.Controls.Add(dtExpireDate);
            panel5.Controls.Add(lbUnitCost);
            panel5.Controls.Add(lbName);
            panel5.Controls.Add(txtName);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(666, 544);
            panel5.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(85, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 29);
            txtId.TabIndex = 81;
            txtId.Visible = false;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitCost.Location = new Point(86, 122);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(223, 26);
            txtUnitCost.TabIndex = 75;
            // 
            // rtxtNote
            // 
            rtxtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtNote.BackColor = SystemColors.Control;
            rtxtNote.BorderStyle = BorderStyle.FixedSingle;
            rtxtNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtNote.Location = new Point(372, 55);
            rtxtNote.Name = "rtxtNote";
            rtxtNote.Size = new Size(243, 446);
            rtxtNote.TabIndex = 70;
            rtxtNote.Text = "";
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(86, 450);
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
            cboProductId.Location = new Point(86, 473);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(223, 28);
            cboProductId.TabIndex = 74;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(86, 380);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 72;
            label4.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = " yyyy/MM/dd";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(86, 402);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 26);
            dateTimePicker1.TabIndex = 71;
            // 
            // lbNote
            // 
            lbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNote.AutoSize = true;
            lbNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNote.Location = new Point(372, 32);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(43, 20);
            lbNote.TabIndex = 69;
            lbNote.Text = "Note";
            // 
            // nudInitQty
            // 
            nudInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudInitQty.BackColor = SystemColors.Control;
            nudInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudInitQty.Location = new Point(86, 330);
            nudInitQty.Name = "nudInitQty";
            nudInitQty.Size = new Size(223, 26);
            nudInitQty.TabIndex = 66;
            // 
            // lbInitQty
            // 
            lbInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbInitQty.AutoSize = true;
            lbInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInitQty.ForeColor = Color.Black;
            lbInitQty.Location = new Point(86, 307);
            lbInitQty.Name = "lbInitQty";
            lbInitQty.Size = new Size(74, 20);
            lbInitQty.TabIndex = 65;
            lbInitQty.Text = "Initial Qty";
            // 
            // nudCurrentStock
            // 
            nudCurrentStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCurrentStock.BackColor = SystemColors.Control;
            nudCurrentStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCurrentStock.Location = new Point(86, 260);
            nudCurrentStock.Name = "nudCurrentStock";
            nudCurrentStock.Size = new Size(223, 26);
            nudCurrentStock.TabIndex = 64;
            // 
            // lbCurrentStock
            // 
            lbCurrentStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCurrentStock.AutoSize = true;
            lbCurrentStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCurrentStock.ForeColor = Color.Black;
            lbCurrentStock.Location = new Point(86, 237);
            lbCurrentStock.Name = "lbCurrentStock";
            lbCurrentStock.Size = new Size(107, 20);
            lbCurrentStock.TabIndex = 63;
            lbCurrentStock.Text = "Current Stock";
            // 
            // lbExpireDate
            // 
            lbExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbExpireDate.AutoSize = true;
            lbExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExpireDate.ForeColor = Color.Black;
            lbExpireDate.Location = new Point(86, 163);
            lbExpireDate.Name = "lbExpireDate";
            lbExpireDate.Size = new Size(92, 20);
            lbExpireDate.TabIndex = 62;
            lbExpireDate.Text = "Expire Date";
            // 
            // dtExpireDate
            // 
            dtExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExpireDate.CustomFormat = " yyyy/MM/dd";
            dtExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtExpireDate.Format = DateTimePickerFormat.Custom;
            dtExpireDate.Location = new Point(86, 185);
            dtExpireDate.Margin = new Padding(3, 2, 3, 2);
            dtExpireDate.Name = "dtExpireDate";
            dtExpireDate.Size = new Size(223, 26);
            dtExpireDate.TabIndex = 61;
            // 
            // lbUnitCost
            // 
            lbUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitCost.AutoSize = true;
            lbUnitCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitCost.ForeColor = Color.Black;
            lbUnitCost.Location = new Point(86, 100);
            lbUnitCost.Name = "lbUnitCost";
            lbUnitCost.Size = new Size(75, 20);
            lbUnitCost.TabIndex = 59;
            lbUnitCost.Text = "Unit Cost";
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(86, 32);
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
            txtName.Location = new Point(86, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 29);
            txtName.TabIndex = 3;
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
            panel6.Location = new Point(666, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(36, 544);
            panel6.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvInventory);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(702, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 544);
            panel2.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dgvInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colUnitCost, colCurrentStock, colInitQty, colExpireDate, colProductId });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = SystemColors.Control;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.Size = new Size(441, 544);
            dgvInventory.TabIndex = 1;
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
            // colUnitCost
            // 
            colUnitCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colUnitCost.DefaultCellStyle = dataGridViewCellStyle3;
            colUnitCost.FillWeight = 80F;
            colUnitCost.HeaderText = "Unit Cost";
            colUnitCost.Name = "colUnitCost";
            colUnitCost.ReadOnly = true;
            // 
            // colCurrentStock
            // 
            colCurrentStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCurrentStock.DefaultCellStyle = dataGridViewCellStyle4;
            colCurrentStock.HeaderText = "Current Stock";
            colCurrentStock.Name = "colCurrentStock";
            colCurrentStock.ReadOnly = true;
            // 
            // colInitQty
            // 
            colInitQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInitQty.HeaderText = "Initial Qty";
            colInitQty.Name = "colInitQty";
            colInitQty.ReadOnly = true;
            // 
            // colExpireDate
            // 
            colExpireDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colExpireDate.DefaultCellStyle = dataGridViewCellStyle5;
            colExpireDate.HeaderText = "Expired Date";
            colExpireDate.Name = "colExpireDate";
            colExpireDate.ReadOnly = true;
            // 
            // colProductId
            // 
            colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductId.HeaderText = "Product ID";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(441, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(41, 544);
            panel7.TabIndex = 0;
            // 
            // SubInventory
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
            Name = "SubInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Adding & Updating";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCurrentStock).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private RichTextBox rtxtNote;
        private Label lbNote;
        private NumericUpDown nudInitQty;
        private Label lbInitQty;
        private NumericUpDown nudCurrentStock;
        private Label lbCurrentStock;
        private Label lbExpireDate;
        private DateTimePicker dtExpireDate;
        private Label lbUnitCost;
        private Label lbName;
        private TextBox txtName;
        private Panel panel4;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lbProductId;
        private ComboBox cboProductId;
        private Panel panel6;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUnitCost;
        private DataGridViewTextBoxColumn colCurrentStock;
        private DataGridViewTextBoxColumn colInitQty;
        private DataGridViewTextBoxColumn colExpireDate;
        private DataGridViewTextBoxColumn colProductId;
        private TextBox txtUnitCost;
        private Label SubInventoryFormTitle;
        private Button btnAdd;
        private Button btnSubmit;
        private TextBox txtId;
    }
}